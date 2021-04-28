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
    public partial class FrmRptFacturaResumen : Form
    {
        short? codigoCliente = null;
        public FrmRptFacturaResumen()
        {
            InitializeComponent();
        }

        private void FrmRptFacturaResumen_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taFactura.Fill(dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, null, dtpDesde.Value.Date, dtpHasta.Value.Date, null, codigoCliente);
            if (dsNeo.tbFactura.Rows.Count > 0)
            {
                decimal totalVenta = decimal.Parse(dsNeo.tbFactura.Compute("SUM(TotalVenta)", null).ToString());
                lblVenta.Text = totalVenta.ToString("N2");
            }
            else
            {
                lblVenta.Text = null;
            }
            this.Cursor = Cursors.Default;
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbFactura.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                if (Utilidad.tscFactura == null)
                    Utilidad.tscFactura = new FrmTscFactura();
                Utilidad.tscFactura.FrmTscFactura_Load(sender, EventArgs.Empty);
                int numero = int.Parse(grdFactura.CurrentRow.Cells["fNumero"].Value.ToString());
                Utilidad.tscFactura.taFactura.Fill(Utilidad.tscFactura.dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, null, null, null, null);
                short? codigoCliente = null;
                string codigo = Utilidad.tscFactura.dsNeo.tbFactura.Rows[0]["CodigoCliente"].ToString();
                if (!string.IsNullOrEmpty(codigo))
                    codigoCliente = short.Parse(codigo);
                Utilidad.tscFactura.taCliente.FillByCodigo(Utilidad.tscFactura.dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
                Utilidad.tscFactura.taFacturaDetalle.Fill(Utilidad.tscFactura.dsNeo.tbFacturaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscFactura.taFacturaCobro.Fill(Utilidad.tscFactura.dsNeo.tbFacturaCobro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);                
                Utilidad.tscFactura.btnLimpiar.Available = false;
                Utilidad.tscFactura.total();
                if (!string.IsNullOrEmpty(Utilidad.tscFactura.txtRecibido.Text))
                {
                    decimal r = decimal.Parse(Utilidad.tscFactura.txtRecibido.Text);
                    Utilidad.tscFactura.txtRecibido.Text = r.ToString("N2");
                    Utilidad.tscFactura.lblDevuelta.Text = Utilidad.tscFactura.devuelta().ToString("N2");
                }
                Utilidad.tscFactura.Show();
                Utilidad.tscFactura.cboVendedor.Text = grdFactura.CurrentRow.Cells["fVendedor"].Value.ToString();
                Utilidad.tscFactura.cboCondicion.Text = grdFactura.CurrentRow.Cells["fCondicion"].Value.ToString();
                Utilidad.tscFactura.cboCaja.Text = grdFactura.CurrentRow.Cells["fCaja"].Value.ToString();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRptFacturaResumen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.rptFacturaResumen = null;
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            txtCliente.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            grdCliente.Visible = false;
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtCliente.Focus();
                txtCliente.SelectAll();
                grdCliente.Visible = false;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                grdCliente.Visible = false;
                codigoCliente = null;
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtCliente.Text);
                grdCliente.Visible = true;
                if (dsNeo.tbCliente.Rows.Count == 1)
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                else if (dsNeo.tbCliente.Rows.Count > 1)
                    grdCliente.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtCliente.SelectAll();
                txtCliente.Focus();
            }
        }

        private void grdFactura_DoubleClick(object sender, EventArgs e)
        {
            btnVerFactura_Click(sender, EventArgs.Empty);
        }
    }
}
