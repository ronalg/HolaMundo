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
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.AddDays(30);
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
            taCitaMascota.Fill(dsNeo.tbCitaMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, dtpDesde.Value.Date, dtpHasta.Value.Date, pendiente, activa, nombre, null, null, null);
            this.Cursor = Cursors.Default;
        }

        private void cboActiva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCitaMascota.Rows.Count > 0)
            {
                int numero = int.Parse(grdCita.CurrentRow.Cells["cNumero"].Value.ToString());
                Utilidad.tscCita.taCita.FillByNumero(Utilidad.tscCita.dsNeo.tbCita, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal,  numero);
                int codigo = int.Parse(Utilidad.tscCita.dsNeo.tbCita.Rows[0]["CodigoMascota"].ToString());
                Utilidad.tscCita.taMascota.Fill(Utilidad.tscCita.dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null); 
                Utilidad.tscCita.taCitaDetalle.FillByNumero(Utilidad.tscCita.dsNeo.tbCitaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                this.Close();
            }
        }

        private void grdCita_DoubleClick(object sender, EventArgs e)
        {
            btnVer_Click(sender, EventArgs.Empty);
        }
    }
}
