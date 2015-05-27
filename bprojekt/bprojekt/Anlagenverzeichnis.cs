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
    internal partial class Anlagenverzeichnis : Form
    {
        Rang r;
        public Anlagenverzeichnis(Rang a)
        {
            r = a;
            InitializeComponent();
        }
        public Anlagenverzeichnis()
        {
            InitializeComponent();
        }

        private void Anlagenverzeichnis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSDataSet1.Anlagenverzeichnis' table. You can move, or remove it, as needed.
            this.anlagenverzeichnisTableAdapter.Fill(this.dBSDataSet1.Anlagenverzeichnis);
            gegenstandbox.BackColor = Color.Red;
            anschaffdatumbox.BackColor = Color.Red;
            anschaffwertbox.BackColor = Color.Red;
            Zugangbox.BackColor = Color.Red;
            dauerbox.BackColor = Color.Red;
            AbgangBox.BackColor = Color.Red;
            Prozentbox.BackColor = Color.Red;

        }
        #region Save&Delete Button
        private void savebuttonanlage_Click(object sender, EventArgs e)
        {

        }

        private void deletebuttonanlage_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //TODO: Datenbank einlesen / auslesen / speichern / löschen
        #region Textboxenrichtig Variablen
        private bool gegenstandboxr = false;
        private bool anschaffdatumboxr = false;
        private bool anschaffwertboxr = false;
        private bool zugangboxr = false;
        private bool dauerboxr = false;
        private bool abgangboxr = false;
        private bool prozentboxr = false;
        private bool textboxentrue()
        {
            if (gegenstandboxr == true && anschaffdatumboxr == true && anschaffdatumboxr == true && zugangboxr == true && dauerboxr == true && abgangboxr == true && prozentboxr == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region TextChanged Events
        private void gegenstandbox_TextChanged(object sender, EventArgs e)
        {
            if (gegenstandbox.Text == "")
            {
                gegenstandbox.BackColor = Color.Red;
                gegenstandboxr = false;
            }
            else
            {
                gegenstandbox.BackColor = Color.Green;
                gegenstandboxr = true;
            }
            
        }

        private void anschaffdatumbox_TextChanged(object sender, EventArgs e)
        {
            if (anschaffdatumbox.Text.Length == 10) //Überprüft ob in der Textbox der Text genau 10 Zeichen lang ist
            {
                if (anschaffdatumbox.Text.Contains(".") == true)
                /*Überprüft ob das Datum überhaupt einen Punkt enthält*/
                {
                    try
                    {
                        DateTime.Parse(anschaffdatumbox.Text);
                        anschaffdatumbox.BackColor = Color.Green;
                        anschaffdatumboxr = true;
                    }
                    catch (Exception)
                    {
                        anschaffdatumbox.BackColor = Color.Red;
                        anschaffdatumboxr = false;
                    }
                }
                else
                {
                    anschaffdatumbox.BackColor = Color.Red;
                    anschaffdatumboxr = false;
                }
            }
            else
            {
                anschaffdatumbox.BackColor = Color.Red;
                anschaffdatumboxr = false;
            }
        }

        private void anschaffwertbox_TextChanged(object sender, EventArgs e)
        {
            if (checkiftextisdouble(anschaffwertbox.Text))
            {
                anschaffwertboxr = true;
                anschaffwertbox.BackColor = Color.Green;
            }
            else
            {
                anschaffwertboxr = false;
                anschaffwertbox.BackColor = Color.Red;
            }
        }

        private void Zugangbox_TextChanged(object sender, EventArgs e)
        {
            if (checkiftextisdouble(Zugangbox.Text))
            {
                zugangboxr = true;
                Zugangbox.BackColor = Color.Green;
            }
            else
            {
                zugangboxr = false;
                Zugangbox.BackColor = Color.Red;
            }
        }

        private void dauerbox_TextChanged(object sender, EventArgs e)
        {
            if (checkiftextisdouble(dauerbox.Text))
            {
                dauerbox.BackColor = Color.Green;
                dauerboxr = true;
            }
            else
            {
                dauerbox.BackColor = Color.Red;
                dauerboxr = false;
            }
        }

        private void Prozentbox_TextChanged(object sender, EventArgs e)
        {
            if (checkiftextisdouble(Prozentbox.Text))
            {
                Prozentbox.BackColor = Color.Green;
                prozentboxr = true;
            }
            else
            {
                prozentboxr = false;
                Prozentbox.BackColor = Color.Red;
            }
        }

        private void AbangangBox_TextChanged(object sender, EventArgs e)
        {
            if (checkiftextisdouble(AbgangBox.Text))
            {
                AbgangBox.BackColor = Color.Green;
                abgangboxr = true;
            }
            else
            {
                abgangboxr = false;
                AbgangBox.BackColor = Color.Red;
            }
        }
        private bool checkiftextisdouble(string text)
        {
            try
            {
                double.Parse(text);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        #endregion
        //TODO: Überprüfen ob etwas in den Boxen steht
    }
}
