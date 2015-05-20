using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace bprojekt
{
    public partial class Register : Form
    {
        /*Funktion Register: 
         *Beim Regestrieren hat man Recht "0" und ist sozusagen Gast
         *Admin kann das Recht Später hoch setzten
         */
        Dictionary<string, User> DUser = new Dictionary<string, User>();
        OleDbCommand cmd;
        OleDbConnection conn;
        public Register()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            Password2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
           
            OleDbDataReader reader;
            conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Login", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string xy = reader["User"].ToString();
                DUser.Add(reader["User"].ToString(),
                new User(reader["User"].ToString(),reader["Password"].ToString(),int.Parse(reader["Rang"].ToString()))
                );
            }
            reader.Close();

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            bool check = true,check2=true;
            if (Password.Text.Length < 6 || Password.Text.Length > 20 )
            {
                MessageBox.Show("Das Passwort muss zwischen 6 und 20 Zeichen lang sein ");
                check = false;
            }
            if (Password.Text != Password2.Text)
                {
                    MessageBox.Show("Die Passwörter stimmen nicht überein");
                    check = false;
                }
            foreach (KeyValuePair<string ,User> u in DUser)
            {
                if (Username.Text==u.Value.Uname)
                {
                    MessageBox.Show("Der Benutzername ist bereits vergeben");
                    check = false;
                }
            }
            if (check)
            {
                cmd = new OleDbCommand("INSERT INTO Login VALUES ('" + Username.Text + "','" + Password.Text + "',0)", conn);
                try
                {

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("unbekannter Fehler!" + "\r" + ex.ToString());
                    check2 = false;
                }
                if (check2)
                {
                   MessageBox.Show("Die Registration wurde erfolgreich abgeschlossen!");
                }
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
