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
            cmd = new OleDbCommand("SELECT * FROM Lager", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

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
