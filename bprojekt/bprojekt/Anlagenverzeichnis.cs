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

        }
    }
}
