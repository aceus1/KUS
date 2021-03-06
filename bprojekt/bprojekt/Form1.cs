﻿using System;
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
    public partial class Form1 : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        Dictionary<string, User> DUser = new Dictionary<string, User>();
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DUser.Clear();
            OleDbDataReader reader;
            conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Login", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string xy = reader["User"].ToString();
                DUser.Add(reader["User"].ToString(),
                new User(reader["User"].ToString(), reader["Password"].ToString(), int.Parse(reader["Rang"].ToString()))
                );
            }
            reader.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            DUser.Clear();
            OleDbDataReader reader;
            conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Login", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string xy = reader["User"].ToString();
                DUser.Add(reader["User"].ToString(),
                new User(reader["User"].ToString(), reader["Password"].ToString(), int.Parse(reader["Rang"].ToString()))
                );
            }
            reader.Close();
            bool check = false;
            foreach (KeyValuePair<string, User> u in DUser)
            {
                if (username.Text == u.Value.Uname&&password.Text==u.Value.Upass)
                {
                    check = true;
                    this.Hide();
                    Rang r = new Rang(u.Value.Urang);
                    Menue menue = new Menue(r);
                    menue.ShowDialog();
                    this.Close();
                }
            }
            if (!check)
            {
                MessageBox.Show("Der Benutzername oder das Passwort ist falsch ! ");
                
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.ShowDialog();
        }
    }
}
