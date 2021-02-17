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
    public partial class FrmTscFactura : Form
    {
        public FrmTscFactura()
        {
            InitializeComponent();
        }

        private void txtBuscaMascota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusca.Text.Trim()))            
                grdCliente.Visible = false;
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taCliente.FillByNombre(dataSet.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtBusca.Text.Trim());
                if (grdCliente.RowCount == 1)
                {
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdCliente.Visible = true;
                    grdCliente.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBusca.Focus();
                txtBusca.SelectAll();
                grdCliente.Visible = false;
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            lblRazonSocial.Text = grdCliente.CurrentRow.Cells["cRazonSocial"].Value.ToString();
            lblLimite.Text = grdCliente.CurrentRow.Cells["cLimite"].Value.ToString();
            short codigo = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            lblCodigo.Text = codigo.ToString();
            taSucursalContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
            grdCliente.Visible = false;
            if (string.IsNullOrEmpty(lblNumero.Text))
            {
                if (cboVendedor.Items.Count == 1)
                {
                    cboVendedor.SelectedIndex = 0;
                }
                else
                {
                    cboVendedor.Text = grdCliente.CurrentRow.Cells[""].Value.ToString();
                }
                bnDetalle.Focus();
                btnNuevoServicio.Select();
            }
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtBusca.Focus();
                txtBusca.SelectAll();
            }
        }

        private void FrmTscFactura_Load(object sender, EventArgs e)
        {
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Vendedor");
            taFrecuencia.Fill(dsNeo.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            btnNuevo_Click(sender, EventArgs.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscFactura = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblNumero.Text = null;
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            dtpFecha.Value = DateTime.Today.Date;
            cboCondicion.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            txtBusca.Clear();
            txtNombre.Clear();
            lblRazonSocial.Text = null;
            lblLimite.Text = null;
            lblCodigo.Text = null;
            grdCliente.Visible = false;
            dsNeo.tbSucursalContacto.Rows.Clear();
            dsNeo.tbFacturaDetalle.Rows.Clear();
            txtNota.Clear();
            lblSubTotal.Text = "0.00";
            txtDescuento.Text = "0.00";
            lblTotal.Text = "0.00";
            cboCondicion.Text = "Contado";
        }

        private void tbSucursalContactoKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelaServicio_Click(object sender, EventArgs e)
        {
            pnlServicio.Visible = false;
        }

        private void txtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taFnArticuloPrecioVenta.Fill(dataSet.fnArticuloPrecioVenta, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtServicio.Text);
                if (dataSet.fnArticuloPrecioVenta.Rows.Count == 1)
                    btnAceptaServicio_Click(sender, EventArgs.Empty);
                else
                    grdServicio.Focus();
            }
        }

        private void btnAceptaServicio_Click(object sender, EventArgs e)
        {
            if (grdServicio.CurrentRow.Cells["sCodigo"].Value != DBNull.Value)
            {
                string codigo = grdServicio.CurrentRow.Cells["sCodigo"].Value.ToString();
                string descripcion = grdServicio.CurrentRow.Cells["sDescripcion"].Value.ToString();
                string codigoPrecio = grdServicio.CurrentRow.Cells["sCodigoPrecio"].Value.ToString();
                string precio = grdServicio.CurrentRow.Cells["sPrecio"].Value.ToString();
                string costo = grdServicio.CurrentRow.Cells["sCosto"].Value.ToString();
                grdDetalle.CurrentRow.Cells["dCodigo"].Value = codigo;
                grdDetalle.CurrentRow.Cells["dDescripcion"].Value = descripcion;
                grdDetalle.CurrentRow.Cells["dCodigoPrecio"].Value = codigoPrecio;
                grdDetalle.CurrentRow.Cells["dVenta"].Value = precio;
                grdDetalle.CurrentRow.Cells["dCosto"].Value = costo;
                pnlServicio.Visible = false;
                grdDetalle.CurrentRow.Cells["dCantidad"].Selected = true;
                grdDetalle.BeginEdit(true);
            }
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {   
            DataRow dr = dsNeo.tbFacturaDetalle.NewtbFacturaDetalleRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["CodigoSucursal"] = Utilidad.codigoSucursal;
            dr["NumeroFactura"] = DBNull.Value;
            dr["Secuencia"] = DBNull.Value;
            dr["CodigoArticulo"] = DBNull.Value;
            dr["CodigoPrecioVenta"] = DBNull.Value;
            dr["Descripcion"] = DBNull.Value;
            dr["Cantidad"] = 1;
            dr["Costo"] = DBNull.Value;
            dr["Venta"] = DBNull.Value;
            dr["DescuentoArticulo"] = 0.00M;
            dsNeo.tbFacturaDetalle.Rows.Add(dr);
            pnlServicio.Visible = true;
            txtServicio.Clear();
            txtServicio.Focus();
            grdDetalle.Rows[grdDetalle.RowCount - 1].Cells["dSecuencia"].Selected = true;
        }

        private void grdServicio_DoubleClick(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
        }

        private void grdServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAceptaServicio_Click(sender, EventArgs.Empty);            
            else if (e.KeyCode == Keys.Escape)
                btnCancelaServicio_Click(sender, EventArgs.Empty);            
        }
    }
}
