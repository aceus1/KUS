using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            OleDbCommand cmd;
            OleDbConnection conn;
            string cmdstr;
            conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
            
            fahrtidlesen();
            if (datumbr == true && abfahrtortr == true && zielortr == true && akmstr == true && ekmstr == true)//Wenn alle Felder Grün sind speichert er erst in die Datenbank
            {
                conn.Open();
                cmdstr = "INSERT INTO Fahrtenbuch (FahrtID, Datum, Abfahrtsort, Zielort, Anfangskmst, Endkmst) VALUES ('" + (fahrtidlesen() + 1) + "','" + Datumtb.Text + "','" + Abfahrtsorttb.Text +"','"+ Zielorttb.Text +"','"+ ankmtb.Text +"','" + endkmtb +"'";
                //TODO: cmdstr absenden an die Datenbank
            }
        }

        private int fahrtidlesen()
        {
            OleDbCommand cmd;
            OleDbConnection conn;
            OleDbDataReader reader;
            int biggest = 0;
            conn = new OleDbConnection(Properties.Settings.Default.DBSConnectionString1);
            conn.Open();
            cmd = new OleDbCommand("SELECT FahrtID FROM Fahrtenbuch ORDER BY FahrtID DESC", conn);
            reader = cmd.ExecuteReader();
            reader.Read ();
            //MessageBox.Show(reader["FahrtID"].ToString());
            biggest = int.Parse(reader["FahrtID"].ToString());
            reader.Close();
            conn.Close();
            return biggest;


        }
        private bool datumbr = false;
        private bool abfahrtortr = false;
        private bool zielortr = false;
        private bool akmstr = false;
        private bool ekmstr = false;

        private void Datumtb_TextChanged(object sender, EventArgs e)
        {
            #region DatumTesten
            if (Datumtb.Text.Length == 10) //Überprüft ob in der Textbox der Text genau 10 Zeichen lang ist
            {
                if (Datumtb.Text.Contains(".") == true)
                    /*Überprüft ob das Datum überhaupt einen Punkt enthält*/
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
        private void endkcheck()
        {
            try
            {
                if (double.Parse(endkmtb.Text)<double.Parse(ankmtb.Text))
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
            catch (Exception)
            {
                endkmtb.BackColor = Color.Red;
                ekmstr = false;
            }
            
        }
        private void ankcheck()
        {
            try
            {
                if (double.Parse(endkmtb.Text) < double.Parse(ankmtb.Text))
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
            catch (Exception)
            {
                ankmtb.BackColor = Color.Red;
                akmstr = false;
            }
        }
        private void ankmtb_TextChanged(object sender, EventArgs e)
        {
            ankcheck();
            endkcheck();
        }
        //private bool zahl(string z, int laenge) chens arbeit
        //{
        //    bool check = false;
        //    for (int i = 0; i < laenge; i++)
        //    {
        //        for (char j = '0'; j < '9'; j++)
        //        {
        //            if (z[i] == j)
        //            {
        //                check = true;
        //            }
        //        }
        //        if (!check)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            check = false;
        //        }

        //    }
        //    return true;
        //}
        private void endkmtb_TextChanged(object sender, EventArgs e)
        {
            ankcheck();
            endkcheck();
        }

    }
}
