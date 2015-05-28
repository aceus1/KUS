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
    internal partial class Buchungen : Form
    {
        Rang r;
        bool combcheck1 = false;
        bool combcheck2 = false;
        bool wertcheck = false;
        bool eadatum = false;
        bool redatum = false; 
        //bool combcheck1 = false;
        public Buchungen(Rang a)
        {
            r = a;
            InitializeComponent();
        }
        public Buchungen()
        {
            InitializeComponent();
        }

        private void Buchungen_Load(object sender, EventArgs e)
        {
            Wert.BackColor = Color.Red;
            Ust_Summe.BackColor = Color.Red;
            EA_Datum.BackColor = Color.Red;
            Re_Datum.BackColor = Color.Red;
            // TODO: This line of code loads data into the 'dBSDataSet1.Buchungen' table. You can move, or remove it, as needed.
            this.buchungenTableAdapter.Fill(this.dBSDataSet1.Buchungen);
            Art_cbx.Items.Add("ER");
            Art_cbx.Items.Add("AR");
            Ust_cbx.Items.Add("0");
            Ust_cbx.Items.Add("10");
            Ust_cbx.Items.Add("20");
            Ust_cbx.Text = "Ust";
            if (!r.rangcheck())
            {
                label1.Visible = false;
                Löschenbutton.Visible = false;
                Löschen.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ust_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combcheck1 = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wert.ReadOnly = false;
            combcheck2 = true;
        }


        private void EA_Datum_TextChanged(object sender, EventArgs e)
        {
            #region DatumTesten
            if (EA_Datum.Text.Length == 10) //Überprüft ob in der Textbox der Text genau 10 Zeichen lang ist
            {
                if (EA_Datum.Text.Contains(".") == true)
                /*Überprüft ob das Datum überhaupt einen Punkt enthält*/
                {
                    try
                    {
                        DateTime.Parse(EA_Datum.Text);
                        EA_Datum.BackColor = Color.Green;
                        eadatum = true;
                    }
                    catch (Exception)
                    {
                        EA_Datum.BackColor = Color.Red;
                        eadatum = false;
                    }
                }
                else
                {
                    EA_Datum.BackColor = Color.Red;
                    eadatum = false;
                }
            }
            else
            {
                EA_Datum.BackColor = Color.Red;
                eadatum = false;
            }

            #endregion
        }
        
        private void Re_Datum_TextChanged(object sender, EventArgs e)
        {
            #region DatumTesten
            if (Re_Datum.Text.Length == 10) //Überprüft ob in der Textbox der Text genau 10 Zeichen lang ist
            {
                if (Re_Datum.Text.Contains(".") == true)
                /*Überprüft ob das Datum überhaupt einen Punkt enthält*/
                {
                    try
                    {
                        DateTime.Parse(Re_Datum.Text);
                        Re_Datum.BackColor = Color.Green;
                        redatum = true;
                    }
                    catch (Exception)
                    {
                        Re_Datum.BackColor = Color.Red;
                        redatum = false;
                    }
                }
                else
                {
                    Re_Datum.BackColor = Color.Red;
                    redatum = false;
                }
            }
            else
            {
                Re_Datum.BackColor = Color.Red;
                redatum = false;
            }

            #endregion
            
        }

        private void Wert_TextChanged(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(Wert.Text))
                {
                    if (Check(Wert.Text))
                    {
                        Wert.BackColor = Color.Green;
                        Ust_Summe.BackColor = Color.Green;
                        if (Ust_cbx.Text == "0")
                        {
                            Ust_Summe.Text = Wert.Text;
                        }
                        else
                        {
                            Ust_Summe.Text = Convert.ToString(Convert.ToDouble(Wert.Text) * ((Convert.ToDouble(Ust_cbx.Text) / 100)));

                        }
                        wertcheck = true;

                    }
                    else
                    {
                        Wert.BackColor = Color.Red;
                        Ust_Summe.BackColor = Color.Red;
                    }
                }
            
        }
         bool Check(string t)
        {
            try
            {
                double Zahl = double.Parse(t);
                // keine Exception, Eingabe ist eine Zahl
                return true;
            }
            catch (FormatException)
            {
                //kein Zahl
                return false;
            }
        }

         private void Löschen_TextChanged(object sender, EventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
             try
             {

                 OleDbCommand cmd;
                 OleDbConnection conn;
                 string cmdstr;
                 conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
                 if (combcheck1 && combcheck2 && wertcheck && eadatum && redatum)
                 {

                     conn.Open();
                     //cmdstr = "INSERT INTO Buchungen ([Art], [Ust], [Wert], [Ust-Summe], [Re-Datum], [EA-Datum]) VALUES ('" + Art_cbx.Text + "'," + Ust_cbx.Text + "," + Wert.Text + "," + Ust_Summe.Text + ",'" + Re_Datum.Text + "','" + EA_Datum.Text + "');";
                     cmd = new OleDbCommand();
                     cmd.CommandType = CommandType.Text;
                     cmd.CommandText = "INSERT INTO Buchungen ([Art], [Ust], [Wert], [Ust-Summe], [Re-Datum], [EA-Datum]) VALUES (?,?,?,?,?,?);";
                     cmd.Parameters.AddWithValue("@Art", Art_cbx.Text);
                     cmd.Parameters.AddWithValue("@Ust", Ust_cbx.Text);
                     cmd.Parameters.AddWithValue("@Wert", Wert.Text);
                     cmd.Parameters.AddWithValue("@Ust-Summe", Ust_Summe.Text);
                     cmd.Parameters.AddWithValue("@Re-Datum", Re_Datum.Text);
                     cmd.Parameters.AddWithValue("@EA-Datum", EA_Datum.Text);
                     cmd.Connection = conn;
                     //cmd = new OleDbCommand(cmdstr, conn);
                     cmd.ExecuteNonQuery();
                     conn.Close();
                     Buchungen a = new Buchungen(r);
                     this.Close();
                     a.Show();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void Löschenbutton_Click(object sender, EventArgs e)
         {
             try
             {
                 if (Löschen.Text != "")
                 {
                     string cmdstr = "DELETE FROM Buchungen WHERE Belegnummer = " + Löschen.Text;
                     OleDbCommand cmd;
                     OleDbConnection conn;
                     conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
                     conn.Open();
                     cmd = new OleDbCommand(cmdstr, conn);
                     cmd.ExecuteNonQuery();
                     conn.Close();
                     dataGridView1.Update();
                     Buchungen a = new Buchungen(r);
                     this.Close();
                     a.Show();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }

         }

         private void buchungenBindingSource_CurrentChanged(object sender, EventArgs e)
         {

         }

    }
}
