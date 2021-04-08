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
    public partial class FrmBscFactura : Form
    {
        public FrmBscFactura()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnBuscar_Click(object sender, EventArgs e)
        {         
            this.Cursor = Cursors.WaitCursor;
            string nombre = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text.Trim();
            taFactura.Fill(dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, null, dtpDesde.Value.Date, dtpHasta.Value.Date, nombre);
            this.Cursor = Cursors.Default;
        }

        private void FrmBscFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
            btnBuscar_Click(sender, EventArgs.Empty);
        }

=======
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscFactura = null;
        }

<<<<<<< HEAD
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, EventArgs.Empty);
=======
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //taFactura.Fill();
            this.Cursor = Cursors.Default;
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (grdFactura.CurrentRow != null)
            {
                this.Cursor = Cursors.WaitCursor;
                int? numero = int.Parse(grdFactura.CurrentRow.Cells["fNumero"].Value.ToString());
                Utilidad.tscFactura.taFactura.Fill(Utilidad.tscFactura.dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, null, null, null);
                short codigoCliente = short.Parse(grdFactura.CurrentRow.Cells["fCodigoCliente"].Value.ToString());
                Utilidad.tscFactura.taCliente.FillByCodigo(Utilidad.tscFactura.dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
                Utilidad.tscFactura.taFacturaDetalle.Fill(Utilidad.tscFactura.dsNeo.tbFacturaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                string vendedor = grdFactura.CurrentRow.Cells["fVendedor"].Value.ToString();
                Utilidad.tscFactura.cboVendedor.Text = vendedor;
                Utilidad.tscFactura.taFacturaCobro.Fill(Utilidad.tscFactura.dsNeo.tbFacturaCobro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscFactura.total();
                Utilidad.tscFactura.lblDevuelta.Text = Utilidad.tscFactura.devuelta().ToString("N2");
                this.Close();
                this.Cursor = Cursors.Default;
            }
        }

        private void grdFactura_DoubleClick(object sender, EventArgs e)
        {
            btnVer_Click(sender, EventArgs.Empty);
=======

        }

        private void FrmBscFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        }
    }
}
