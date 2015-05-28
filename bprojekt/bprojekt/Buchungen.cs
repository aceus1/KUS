using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bprojekt
{
    internal partial class Buchungen : Form
    {
        Rang r;
        bool combcheck1 = false;
        bool combcheck2 = false;
        bool ustcheck = false;
        bool wertcheck = false;
        bool combcheck1 = false;
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
            comboBox1.Items.Add("Eing.-Re");
            comboBox1.Items.Add("Ausg.-Re");
            comboBox2.Items.Add("0");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("20");
            comboBox2.Text = "Ust";
            if (!r.rangcheck())
            {
                
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

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wert.ReadOnly = false;
        }
        private bool eadatum = false;
        private bool redatum = false; 


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
                        if (comboBox2.Text == "0")
                        {
                            Ust_Summe.Text = Wert.Text;
                        }
                        else
                        {
                            Ust_Summe.Text = Convert.ToString(Convert.ToDouble(Wert.Text) * ((Convert.ToDouble(comboBox2.Text) / 100)));

                        }

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
         }

    }
}
