﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    public partial class FrmBscHistorial : Form
    {
        public FrmBscHistorial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscHistorial = null;
        }
    }
}