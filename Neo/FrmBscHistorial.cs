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

        private void FrmBscHistorial_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string nombre = string.IsNullOrEmpty(txtMascota.Text) ? null : txtMascota.Text;
            taHistorialMascota.Fill(dsNeo.tbHistorialMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, dtpDesde.Value, dtpHasta.Value.Date, null, null, null, null, null, nombre);
            this.Cursor = Cursors.Default;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbHistorialMascota.Rows.Count > 0)
            {
                int numero = int.Parse(grdHistorial.CurrentRow.Cells["hNumero"].Value.ToString());
                Utilidad.tscHistorial.taHistorial.Fill(Utilidad.tscHistorial.dsNeo.tbHistorial, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                int codigo = int.Parse(grdHistorial.CurrentRow.Cells["hCodigo"].Value.ToString());
                Utilidad.tscHistorial.taMascota.Fill(Utilidad.tscHistorial.dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null);
                Utilidad.tscHistorial.taHistorialDetalle.Fill(Utilidad.tscHistorial.dsNeo.tbHistorialDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                this.Close();
            }
        }
    }
}
