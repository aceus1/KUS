﻿using System;
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
        public Menue()
        {
            InitializeComponent();
        }

        private void Fahrtenbuch_Click(object sender, EventArgs e)
        {
            Fahrtbuch fahrtenbuch = new Fahrtbuch();
            fahrtenbuch.Show();
        }
    }
}
