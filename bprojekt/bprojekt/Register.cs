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
        Dictionary<string, User> DUser;
        OleDbCommand cmd;
        OleDbConnection conn;
        public Register()
        {
            InitializeComponent();
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
                DUser.Add(reader["ID"].ToString(),
                new User(reader["ID"].ToString(),reader["Password"].ToString(),int.Parse(reader["Rang"].ToString()))
                );
            }
            reader.Close();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (Password.Text != Password2.Text)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein");
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
