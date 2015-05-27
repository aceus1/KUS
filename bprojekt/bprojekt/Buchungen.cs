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
<<<<<<< HEAD
        
=======
        public Buchungen(Rang a)
        {
            r = a;
            InitializeComponent();
        }
>>>>>>> origin/master
        public Buchungen()
        {
            InitializeComponent();
        }

        private void Buchungen_Load(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Red;
            comboBox2.BackColor = Color.Red;
            Wert.BackColor = Color.Red;
            Ust_Summe.BackColor = Color.Red;
            EA_Datum.BackColor = Color.Red;
            Re_Datum.BackColor = Color.Red;
            // TODO: This line of code loads data into the 'dBSDataSet1.Buchungen' table. You can move, or remove it, as needed.
            this.buchungenTableAdapter.Fill(this.dBSDataSet1.Buchungen);
            comboBox1.Items.Add("Eingangsrechnung");
            comboBox1.Items.Add("Ausgangsrechnung");
            comboBox2.Items.Add("0%");
            comboBox2.Items.Add("10%");
            comboBox2.Items.Add("20%");
            if (!r.rangcheck())
            {
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double a=double.Parse(Wert.Text)/double.Parse(comboBox2.Text);
            Ust_Summe.Text =Convert.ToString(a * 100);
        }

        private void Ust_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
