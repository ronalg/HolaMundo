using System;
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
    public partial class FrmBscCita : Form
    {
        //string codigo = null;
        public FrmBscCita()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscCita_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.Date;
            dtpHasta.Value = DateTime.Today.AddDays(30);
        }

        private void FrmBscCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscCita = null;
        }
    }
}
