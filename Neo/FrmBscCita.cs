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
            dtpDesde.Value.AddDays(-30);
            dtpHasta.Value.AddDays(30);
            cboPendiente.SelectedIndex = 0;
            cboActiva.SelectedIndex = 0;
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void FrmBscCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscCita = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string nombre = string.IsNullOrEmpty(txtMascota.Text) ? null : txtMascota.Text;
            bool? pendiente = null;
            if (cboPendiente.SelectedIndex == 1)
                pendiente = true;
            else if (cboPendiente.SelectedIndex == 2)
                pendiente = false;
            bool? activa = null;
            if (cboActiva.SelectedIndex == 1)
                activa = true;
            else if (cboActiva.SelectedIndex == 2)
                activa = false;
            taCitaMascota.FillByNombre(dsNeo.tbCitaMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, dtpDesde.Value.ToLongDateString(), dtpHasta.Value.ToShortTimeString(), nombre, pendiente, activa);
            this.Cursor = Cursors.Default;
        }

        private void cboActiva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
