using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    public partial class FrmTscOrdenPedido : Form
    {
        short codigoArticulo = 0;
        public short codigoCliente = 0;
        string codigoUnidad = null;
        decimal coste = 0.00M;

        public FrmTscOrdenPedido()
        {
            InitializeComponent();
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && grdCliente.Rows.Count > 0)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = Convert.ToInt16(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            string nombre = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            txtNombre.Text = nombre;
            taCliente.FillByCodigo(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
            lblId.Text = dsNeo.tbCliente.Rows[0]["IdCliente"].ToString();
            lblNombre.Text = dsNeo.tbCliente.Rows[0]["Nombre"].ToString();
            lblRazonSocial.Text = dsNeo.tbCliente.Rows[0]["RazonSocial"].ToString();
            lblLimiteCredito.Text = dsNeo.tbCliente.Rows[0]["LimiteCredito"].ToString();
            grdCliente.Visible = false;

            taClienteDomicilio.Fill(dsNeo.tbClienteDomicilio, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nombre = txtNombre.Text.Trim();
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (dsNeo.tbCliente.Rows.Count == 1)
                {
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdCliente.Visible = true;
                    grdCliente.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscOrdenPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscOrdenPedido = null;
        }    

        private void FrmTscOrdenPedido_Load(object sender, EventArgs e)
        {
            taEstado.FillByTipo(dsNeo.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Orden Pedido");
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboSucursal.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string descripcion = txtDescripcion.Text.Trim();
                taBuscaArticulo.Fill(dsNeo.tbBuscaArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, descripcion);
                if (dsNeo.tbBuscaArticulo.Rows.Count == 1)
                {
                    grdArticulo_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdArticulo.Visible = true;
                    grdArticulo.Focus();
                }
            }
        }

        private void grdArticulo_DoubleClick(object sender, EventArgs e)
        {
            codigoArticulo = Convert.ToInt16(grdArticulo.CurrentRow.Cells["aCodigo"].Value.ToString());
            string descripcion = grdArticulo.CurrentRow.Cells["aDescripcion"].Value.ToString();
            txtDescripcion.Text = descripcion;
            decimal precio = Convert.ToDecimal(grdArticulo.CurrentRow.Cells["aPrecio"].Value.ToString());
            txtPrecio.Text = precio.ToString("N2");
            grdArticulo.Visible = false;

            decimal importe = calculaImporte();
            lblSubTotalArticulo.Text = importe.ToString("N2");
            lblTotalArticulo.Text = importe.ToString("N2");
        }

        private void grdArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && grdArticulo.Rows.Count > 0)
            {
                grdArticulo_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdArticulo.Visible = false;
                txtDescripcion.Focus();
                txtDescripcion.SelectAll();
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
                grdArticulo.Visible = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                grdCliente.Visible = false;
        }

        private decimal calculaImporte()
        {
            decimal importe = 0.00M;
            decimal cantidad = Convert.ToDecimal(txtCantidad.Text.Trim());
            decimal precio = Convert.ToDecimal(txtPrecio.Text.Trim());
            decimal descuento = Convert.ToDecimal(txtDescuento.Text.Trim());

            importe = cantidad * precio - descuento;
            return importe;
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
                txtCantidad.Text = "1.00";
            decimal importe = calculaImporte();
            lblSubTotalArticulo.Text = importe.ToString("N2");
            lblTotalArticulo.Text = importe.ToString("N2");
        }

        private void txtDescuento_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text))
                txtDescuento.Text = "1.00";
            decimal importe = calculaImporte();
            lblSubTotalArticulo.Text = importe.ToString("N2");
            lblTotalArticulo.Text = importe.ToString("N2");
        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
                txtPrecio.Text = "1.00";
            decimal importe = calculaImporte();
            lblSubTotalArticulo.Text = importe.ToString("N2");
            lblTotalArticulo.Text = importe.ToString("N2");
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                codigoArticulo = 0;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (cboSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione sucursal", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cboSucursal.Focus();
                return;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione estado", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cboEstado.Focus();
                return;
            }

            if (codigoArticulo == 0)
            {
                MessageBox.Show("Seleccione artículo", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtDescripcion.Focus();
                return;
            }

            taArticulo.FillByCodigo(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo);
            string codigoUnidad = dsNeo.tbArticulo.Rows[0]["CodigoUnidad"].ToString();
            taArticuloProveedor.FillByActual(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, true);
            if (dsNeo.tbArticuloProveedor.Rows.Count > 0)
            {
                coste = Convert.ToDecimal(dsNeo.tbArticuloProveedor.Rows[0]["Costo"].ToString());

                if (pnl7.BackColor == Color.White)
                {
                    DataRow dr = dsNeo.tbOrdenPedidoArticulo.NewRow();
                    dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
                    dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
                    dr["CodigoSucursal"] = cboSucursal.SelectedValue.ToString();
                    dr["NumeroOrdenPedido"] = string.IsNullOrEmpty(lblNumero.Text) ? "0" : lblNumero.Text;
                    dr["CodigoArticulo"] = codigoArticulo;
                    dr["Descripcion"] = txtDescripcion.Text.Trim();
                    dr["Coste"] = 0;
                    dr["Cantidad"] = txtCantidad.Text.Trim();
                    dr["Precio"] = txtPrecio.Text.Trim();
                    dr["Descuento"] = txtDescuento.Text.Trim();
                    dr["CodigoUnidad"] = codigoUnidad;
                    dr["Coste"] = coste;
                    dsNeo.tbOrdenPedidoArticulo.Rows.Add(dr);
                }
                else
                {
                    grdDetalle.CurrentRow.Cells["dCodigoArticulo"].Value = codigoArticulo;
                    grdDetalle.CurrentRow.Cells["dCantidad"].Value = txtCantidad.Text.Trim();
                    grdDetalle.CurrentRow.Cells["dCodigoUnidad"].Value = "UNI";
                    grdDetalle.CurrentRow.Cells["dDescripcion"].Value = txtDescripcion.Text.Trim();
                    grdDetalle.CurrentRow.Cells["dPrecio"].Value = txtPrecio.Text.Trim();
                    grdDetalle.CurrentRow.Cells["dDescuento"].Value = txtDescuento.Text.Trim();
                    pnl7.BackColor = Color.White;
                }

                limpiaArticulo();
                lblSubTotal.Text = total().ToString("N2");
                lblTotal.Text = total().ToString("N2");
            }
            else
            {
                MessageBox.Show("Artículo no tiene proveedor actual", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombrePrograma, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(lblNumero.Text)) 
                {
                    short codigoSucursal = Convert.ToInt16(cboSucursal.SelectedValue.ToString());
                    string numero = lblNumero.Text;
                    int codArt = Convert.ToInt32(grdDetalle.CurrentRow.Cells["aCodigoArticulo"].Value.ToString());
                    taOrdenPedidoArticulo.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero, codArt);
                }
                grdDetalle.Rows.Remove(grdDetalle.CurrentRow);
            }
        }

        public decimal total() 
        {
            decimal total = Convert.ToDecimal(dsNeo.tbOrdenPedidoArticulo.Compute("SUM(importe)", null));
            decimal descuento = Convert.ToDecimal(txtDesc.Text.Trim());
            total -= descuento;
            return total;
        }

        private decimal subTotal()
        {
            decimal subTotal = Convert.ToDecimal(dsNeo.tbOrdenPedidoArticulo.Compute("SUM(SubTotal)", null));
            return subTotal;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = -1;
            txtNombre.Clear();
            dsNeo.tbCliente.Rows.Clear();
            dsNeo.tbOrdenPedido.Rows.Clear();
            dsNeo.tbClienteDomicilio.Rows.Clear();
            lblNumero.Text = null;
            cboEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today.Date;
            limpiaArticulo();
            dsNeo.tbOrdenPedidoArticulo.Rows.Clear();
            txtNota.Clear();
            txtDesc.Text = "0.00";                
            lblSubTotal.Text = null;
            lblTotal.Text = null;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            DsNeo ds = new DsNeo();
            taSucursal.FillByCodigo(ds.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
            string nombre = ds.tbSucursal.Rows[0]["Nombre"].ToString();
            cboSucursal.Text = nombre;
            taEstado.FillByTipoInicio(ds.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Orden Pedido", true);
            if (ds.tbEstado.Rows.Count > 0)
            {
                nombre = ds.tbEstado.Rows[0]["NombreEstado"].ToString();
                cboEstado.Text = nombre;
            }
            else
            {
                cboEstado.SelectedIndex = -1;
            }
            txtNombre.Focus();
        }

        private void limpiaArticulo()
        {
            codigoArticulo = 0;
            codigoUnidad = null;
            coste = 0.00M;
            txtCantidad.Text = "1.00";
            txtDescripcion.Clear();
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";
            lblSubTotalArticulo.Text = null;
            lblTotalArticulo.Text = null;
            pnl7.BackColor = Color.White;
        }

        private void grdDetalle_DoubleClick(object sender, EventArgs e)
        {
            codigoArticulo = Convert.ToInt16(grdDetalle.CurrentRow.Cells["dCodigoArticulo"].Value.ToString());

            string cantidad = grdDetalle.CurrentRow.Cells["dCantidad"].Value.ToString();
            string descripcion = grdDetalle.CurrentRow.Cells["dDescripcion"].Value.ToString();
            string precio = grdDetalle.CurrentRow.Cells["dPrecio"].Value.ToString();
            string descuento = grdDetalle.CurrentRow.Cells["dDescuento"].Value.ToString();
            string subTotal = grdDetalle.CurrentRow.Cells["dImporte"].Value.ToString();
            string total = grdDetalle.CurrentRow.Cells["dImporte"].Value.ToString();

            txtCantidad.Text = cantidad;
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = precio;
            txtDescuento.Text = descuento;
            lblSubTotalArticulo.Text = subTotal;
            lblTotalArticulo.Text = total;

            pnl7.BackColor = Color.LightYellow;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Ingrese cliente", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtNombre.Focus();
                return;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione estado", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cboEstado.Focus();
                return;
            }

            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese artículo", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtCantidad.Focus();
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                string numero = null;
                DsNeo ds = new DsNeo();
                taCliente.FillById(ds.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, lblId.Text);
                short codigoCliente = Convert.ToInt16(ds.tbCliente.Rows[0]["CodigoCliente"].ToString());
                decimal descuento = Convert.ToDecimal(txtDescuento.Text);
                short codigoSucursal = Convert.ToInt16(cboSucursal.SelectedValue.ToString());

                if (string.IsNullOrEmpty(lblNumero.Text))
                {
                    
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    int number = cp.fnSiguienteNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "ordenPedido", codigoSucursal).Value;
                    numero = Utilidad.Ceros(number.ToString());
                    lblNumero.Text = numero;
                    taOrdenPedido.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero, codigoCliente, "DOP", Utilidad.nombreUsuario, DateTime.Today.ToShortDateString(), dtpFecha.Value.ToShortDateString(), "05:30", Environment.MachineName, descuento, txtNota.Text.Trim());
                    
                    foreach (DataRow dr in dsNeo.tbOrdenPedidoArticulo.Rows)
                    {
                        int codArt = Convert.ToInt32(dr["CodigoArticulo"].ToString());
                        decimal coste = Convert.ToDecimal(dr["Coste"].ToString());
                        decimal cantidad = Convert.ToDecimal(dr["Cantidad"].ToString());
                        decimal precio = Convert.ToDecimal(dr["Precio"].ToString());
                        descuento = Convert.ToDecimal(dr["Descuento"].ToString());
                        taOrdenPedidoArticulo.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero, codArt, dr["Descripcion"].ToString(), coste, cantidad, precio, descuento);
                    }
                    taEstado.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, cboEstado.Text, "Orden Pedido", true);
                }
                else
                {
                    numero = lblNumero.Text;
                    taOrdenPedido.Edita(codigoCliente, "DOP", dtpFecha.Value.ToShortDateString(), descuento, txtNota.Text.Trim(), Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero);
                    foreach (DataRow dr in dsNeo.tbOrdenPedidoArticulo.Rows)
                    {
                        int codArticulo = Convert.ToInt32(dr["CodigoArticulo"].ToString());                        
                        decimal cantidad = Convert.ToDecimal(dr["Cantidad"].ToString());
                        decimal precio = Convert.ToDecimal(dr["Precio"].ToString());
                        decimal coste = Convert.ToDecimal(dr["Coste"].ToString()) * cantidad;
                        descuento = Convert.ToDecimal(dr["Descuento"].ToString());
                        taOrdenPedidoArticulo.Edita(dr["Descripcion"].ToString(), coste, cantidad, precio, descuento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero.ToString(), codigoArticulo);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(Utilidad.mensajeGuardado, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtDesc_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
                txtDesc.Text = "0.00";
            lblSubTotal.Text = total().ToString("N2");
            lblTotal.Text = total().ToString("N2");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidad.bscOrdenPedido == null)
            {
                Utilidad.bscOrdenPedido = new FrmBscOrdenPedido();
                Utilidad.bscOrdenPedido.StartPosition = FormStartPosition.CenterScreen;
            }
            Utilidad.bscOrdenPedido.BringToFront();
            Utilidad.bscOrdenPedido.Show();
        }
    }
}
