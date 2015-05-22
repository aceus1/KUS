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
    public partial class Buchungen : Form
    {
        public Buchungen()
        {
            InitializeComponent();
        }

        private void Buchungen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSDataSet1.Buchungen' table. You can move, or remove it, as needed.
            this.buchungenTableAdapter.Fill(this.dBSDataSet1.Buchungen);
            comboBox1.Items.Add("Eingangsrechnung");
        }
    }
}
