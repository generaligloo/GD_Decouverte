﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace GD_Decouverte
{
    public partial class EcranCarte : Form
    {
        
        public EcranCarte()
        {
            InitializeComponent();
        }
        public EcranCarte(string sLat, string sLon)
         : this()
        {
           CWBcarte.Load("https://www.google.com/maps/dir//" + sLat + "," + sLon);
        }
        private void EcranCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
