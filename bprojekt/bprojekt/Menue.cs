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
    public partial class Menue : Form
    {
        Rang r;
        public Menue(Rang a)
        {
            r = a;
        
        }
        public Menue()
        {
            InitializeComponent();
        }

        private void Fahrtenbuch_Click(object sender, EventArgs e)
        {
            Fahrtbuch fahrtenbuch = new Fahrtbuch( r);
            fahrtenbuch.Show();
        }

        private void Buchungen_Click(object sender, EventArgs e)
        {
            Buchungen a = new Buchungen(r);
            a.Show();
        }

        private void Menue_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
            
            

        }
    }
}
