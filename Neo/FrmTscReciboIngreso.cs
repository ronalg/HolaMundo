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
    public partial class FrmTscReciboIngreso : Form
    {
        short? codigoCliente = null;

        public FrmTscReciboIngreso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taCuentaCobrar.Fill(dsNeo.tbCuentaCobrar, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, dtpDesde.Value.Date, dtpHasta.Value.Date, codigoCliente);
            if (dsNeo.tbCuentaCobrar.Rows.Count > 0)
            {
                decimal venta = decimal.Parse(dsNeo.tbCuentaCobrar.Compute("SUM(TotalVenta)", null).ToString());
                lblVenta.Text = venta.ToString("N2");
                decimal cobro = decimal.Parse(dsNeo.tbCuentaCobrar.Compute("SUM(TotalCobro)", null).ToString());
                lblCobro.Text = cobro.ToString("N2");
                decimal balance = decimal.Parse(dsNeo.tbCuentaCobrar.Compute("SUM(Balance)", null).ToString());
                lblBalance.Text = balance.ToString("N2");
            }
            else
            {
                lblVenta.Text = "0.00";
                lblCobro.Text = "0.00";
                lblBalance.Text = "0.00";
            }
            this.Cursor = Cursors.Default;
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCuentaCobrar.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                if (Utilidad.tscFactura == null)
                    Utilidad.tscFactura = new FrmTscFactura();
                Utilidad.tscFactura.FrmTscFactura_Load(sender, EventArgs.Empty);
                int numero = int.Parse(grdFactura.CurrentRow.Cells["rNumero"].Value.ToString());
                Utilidad.tscFactura.taFactura.Fill(Utilidad.tscFactura.dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, null, null, null, null, null);
                short? codigoCliente = null;
                string codigo = Utilidad.tscFactura.dsNeo.tbFactura.Rows[0]["CodigoCliente"].ToString();
                if (!string.IsNullOrEmpty(codigo))
                    codigoCliente = short.Parse(codigo);
                Utilidad.tscFactura.taCliente.FillByCodigo(Utilidad.tscFactura.dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
                Utilidad.tscFactura.taFacturaDetalle.Fill(Utilidad.tscFactura.dsNeo.tbFacturaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                string frecuencia = Utilidad.tscFactura.dsNeo.tbFactura.Rows[0]["Condicion"].ToString();
                taFrecuencia.FillByNombre(dsNeo.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, frecuencia);
                short cantidad = short.Parse(dsNeo.tbFrecuencia.Rows[0]["Cantidad"].ToString());
                if (cantidad == 0)
                    Utilidad.tscFactura.taFacturaCobro.Fill(Utilidad.tscFactura.dsNeo.tbFacturaCobro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                else
                    Utilidad.tscFactura.dsNeo.tbFacturaCobro.Rows.Clear();
                Utilidad.tscFactura.btnLimpiar.Available = false;
                Utilidad.tscFactura.total();
                if (!string.IsNullOrEmpty(Utilidad.tscFactura.txtRecibido.Text))
                {
                    decimal r = decimal.Parse(Utilidad.tscFactura.txtRecibido.Text);
                    Utilidad.tscFactura.txtRecibido.Text = r.ToString("N2");
                    Utilidad.tscFactura.lblDevuelta.Text = Utilidad.tscFactura.devuelta().ToString("N2");
                }
                Utilidad.tscFactura.Show();
                Utilidad.tscFactura.cboVendedor.Text = grdFactura.CurrentRow.Cells["rVendedor"].Value.ToString();
                Utilidad.tscFactura.cboCondicion.Text = grdFactura.CurrentRow.Cells["rCondicion"].Value.ToString();
                Utilidad.tscFactura.cboCaja.Text = grdFactura.CurrentRow.Cells["rCaja"].Value.ToString();
                this.Cursor = Cursors.Default;

            }
        }

        private void btnSalr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscReciboIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscReciboIngreso = null;
        }

        private void FrmTscReciboIngreso_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                grdCliente.Visible = false;
                codigoCliente = null;
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            txtCliente.Text = grdCliente.CurrentRow.Cells["ccNombre"].Value.ToString();
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

        private void grdFactura_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string columna = "rVenta";
            decimal valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "rCobro";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "rCosto";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "rBalance";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "rVence";
            DateTime vence = DateTime.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = DateTime.Today.Date >= vence ? Color.Black : Color.Red;
        }

        private void mnuPantalla_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taEmpresa.FillByCodigo(dsNeo.tbEmpresa, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taSucursal.FillByCodigo(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);

            RptCstCuentaCobrar rpt = new RptCstCuentaCobrar();
            rpt.SetDataSource(dsNeo);
            FrmRpt frm = new FrmRpt();
            frm.crv.ReportSource = rpt;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void grdFactura_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string columna = grdFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;
            if (columna == "rSaldar")
            {
                bool saldar = bool.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
                if (saldar)
                {
                    decimal balance = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells["rBalance"].Value.ToString());
                    grdFactura.Rows[e.RowIndex].Cells["rAplicar"].Value = balance;
                }
                else
                {
                    grdFactura.Rows[e.RowIndex].Cells["rAplicar"].Value = 0.00M;
                }
            }
        }
    }
}
