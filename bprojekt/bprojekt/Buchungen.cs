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

        private void EA_Datum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
