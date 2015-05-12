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
    public partial class Fahrtbuch : Form
    {
        public Fahrtbuch()
        {
            InitializeComponent();
        }

        private void Fahrtbuch_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dbsDataSet11.Fahrtenbuch". Sie können sie bei Bedarf verschieben oder entfernen.
            this.fahrtenbuchTableAdapter.Fill(this.dbsDataSet11.Fahrtenbuch);
            Datumtb.BackColor = Color.Red;
            Zielorttb.BackColor = Color.Red;
            Abfahrtsorttb.BackColor = Color.Red;
            ankmtb.BackColor = Color.Red;
            endkmtb.BackColor = Color.Red;
            datumbr = false;
            abfahrtortr = false;
            zielortr = false;
            akmstr = false;
            ekmstr = false;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (datumbr == true && abfahrtortr == true && zielortr == true && akmstr == true && ekmstr == true)//Wenn alle Felder Grün sind speichert er erst in die Datenbank
            {
                
            }
        }
        private bool datumbr = false;
        private bool abfahrtortr = false;
        private bool zielortr = false;
        private bool akmstr = false;
        private bool ekmstr = false;

        private void Datumtb_TextChanged(object sender, EventArgs e)
        {
            #region DatumTesten
            if (Datumtb.Text.Length == 10)
            {
                try
                {
                    DateTime.Parse(Datumtb.Text);
                    Datumtb.BackColor = Color.Green;
                    datumbr = true;
                }
                catch (Exception)
                {
                    Datumtb.BackColor = Color.Red;
                    datumbr = false;
                }   
            }
            else
            {
                Datumtb.BackColor = Color.Red;
                datumbr = false;
            }
            #endregion
        }

        private void Abfahrtsorttb_TextChanged(object sender, EventArgs e)
        {
            if (Abfahrtsorttb.Text.Length < 2 )
            {
                Abfahrtsorttb.BackColor = Color.Red;
                abfahrtortr = false;

                
            }
            else
            {
                Abfahrtsorttb.BackColor = Color.Green;
                abfahrtortr = true;
            }
        }

        private void Zielorttb_TextChanged(object sender, EventArgs e)
        {
            if (Zielorttb.Text.Length < 2)
            {
                Zielorttb.BackColor = Color.Red;
                zielortr = false;

            }
            else
            {
                Zielorttb.BackColor = Color.Green;
                zielortr = true;
            }
        }

        private void ankmtb_TextChanged(object sender, EventArgs e)
        {
            if (!zahl(ankmtb.Text,ankmtb.Text.Length))
            {
                ankmtb.BackColor = Color.Red;
                akmstr = false;
            }
            else
            {
                ankmtb.BackColor = Color.Green;
                akmstr = true;
            }
        }
        private bool zahl(string z, int laenge)
        {
            bool check = false;
            for (int i = 0; i < laenge; i++)
            {
                for (char j = '0'; j < '9'; j++)
                {
                    if (z[i] == j)
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    return false;
                }
                else
                {
                    check = false;
                }

            }
            return true;
        }
        private void endkmtb_TextChanged(object sender, EventArgs e)
        {
            if (!zahl(endkmtb.Text, endkmtb.Text.Length))
            {
                endkmtb.BackColor = Color.Red;
                ekmstr = false;

            }
            else
            {
                endkmtb.BackColor = Color.Green;
                ekmstr = true;
            }
        }

    }
}
