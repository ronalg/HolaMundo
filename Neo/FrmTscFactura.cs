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
    public partial class FrmTscFactura : Form
    {
        public FrmTscFactura()
        {
            InitializeComponent();
        }

        private void ConfiguraBoton(bool configura)
        {
            btnPrimero.Available = configura;
            btnAnterior.Available = configura;
            spd1.Available = configura;
            txtPosicion.Available = configura;
            lblRegistro.Available = configura;
            spd2.Available = configura;
            btnSiguiente.Available = configura;
            btnUltimo.Available = configura;
            spd3.Available = configura;
            btnNuevo.Available = configura;
            btnBuscar.Available = configura;
            spd4.Available = configura;
            btnImprimir.Available = configura;
            btnLimpiar.Available = configura;
            spd5.Available = configura;
            btnSalir.Available = configura;
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
            taCaja.Fill(dsNeo.tbCaja, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
            taFormaPago.Fill(dsNeo.tbFormaPago, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Vendedor");
            taFrecuencia.Fill(dsNeo.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboCaja.SelectedIndex = -1;
            cboCondicion.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;            
            //btnNuevo_Click(sender, EventArgs.Empty);
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
            cboCondicion.SelectedIndex = cboCondicion.Items.Count == 0 ? -1 : 0;
            cboVendedor.SelectedIndex = cboVendedor.Items.Count == 0 ? -1 : 0;
            cboCaja.SelectedIndex = cboCaja.Items.Count == 0 ? -1 : 0;
            cboCondicion.SelectedIndex = -1;
            ConfiguraBoton(false);
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
                else if (dataSet.fnArticuloPrecioVenta.Rows.Count > 1)
                    grdServicio.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                dataSet.fnArticuloPrecioVenta.Rows.Clear();
                btnCancelaServicio_Click(sender, EventArgs.Empty);
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
                grdDetalle.CurrentRow.Cells["dSubTotal"].Value = precio;
                grdDetalle.CurrentRow.Cells["dImporte"].Value = precio;
                pnlServicio.Visible = false;

                grdServicio.Rows[grdDetalle.RowCount - 1].Selected = true;
                grdDetalle.Rows[grdDetalle.RowCount - 1].Cells["dCantidad"].Selected = true;
                grdDetalle.BeginEdit(true);
                total();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCondicion.Text))
            {
                ep.SetError(cboCondicion, Utilidad.campoVacio);
                cboCondicion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cboVendedor.Text))
            {
                ep.SetError(cboVendedor, Utilidad.campoVacio);
                cboVendedor.Focus();
                return;
            }

            if (grdDetalle.RowCount == 0)
            {
                MessageBox.Show("Ingrese servicio", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            foreach (DataRow dr in dsNeo.tbFacturaDetalle)
            {
                string codigo = dr["CodigoArticulo"].ToString();
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Ingrese valor en el listado de servicio valido", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            taFrecuencia.FillByNombre(dataSet.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, cboCondicion.Text);
            short cantidadDias = short.Parse(dataSet.tbFrecuencia.Rows[0]["Cantidad"].ToString());
            decimal totalCobro = dsNeo.tbFacturaCobro.Rows.Count == 0 ? 0.00M : decimal.Parse(dsNeo.tbFacturaCobro.Rows[0]["Monto"].ToString());

            if (cantidadDias == 0.00M)
            {
                if (totalCobro == 0.00M)
                {
                    MessageBox.Show("Ingrese cobro", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnNuevoCobro_Click(sender, EventArgs.Empty);
                    return;
                }

                if (string.IsNullOrEmpty(txtRecibido.Text))
                {
                    MessageBox.Show("Ingrese cantidad recibida", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnNuevoCobro_Click(sender, EventArgs.Empty);
                    return;
                }
            }          

            try
            {
                this.Cursor = Cursors.WaitCursor;
                int numero = !string.IsNullOrEmpty(lblNumero.Text) ? int.Parse(lblNumero.Text) : 0;
                short? codigoCliente = null;
                if (!string.IsNullOrEmpty(lblCodigo.Text))
                    codigoCliente = short.Parse(lblCodigo.Text);
                short codigoEmpleado = short.Parse(cboVendedor.SelectedValue.ToString());
                string nombre = !string.IsNullOrEmpty(txtNombre.Text) ? txtNombre.Text.Trim() : null;
                decimal descuento = decimal.Parse(txtDescuento.Text);
                string nota = !string.IsNullOrEmpty(txtNota.Text) ? txtNota.Text : null;
                decimal? recibido = null;
                if (!string.IsNullOrWhiteSpace(txtRecibido.Text))
                    recibido = decimal.Parse(txtRecibido.Text);

                if (numero == 0)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    numero = cp.fnSiguienteNumero("factura", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value;
                    taFactura.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigoCliente, "Cliente", codigoEmpleado, cboCondicion.Text, null, null, Utilidad.nombreUsuario, null, null, DateTime.Today.ToShortDateString(), nombre, dtpFecha.Value.ToShortDateString(), null, descuento, nota, cboCaja.Text, recibido); 
                    lblNumero.Text = numero.ToString();
                }
                else
                {
                    taFactura.Edita(codigoCliente, codigoEmpleado, cboCondicion.Text, nombre, dtpFecha.Value.ToShortDateString(), descuento, nota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                    taFacturaDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                    taFacturaCobro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                }

                short i = 0;
                foreach (DataRow dr in dsNeo.tbFacturaDetalle.Rows)
                {
                    i++;
                    short secuencia = i;
                    int codigo = int.Parse(dr["CodigoArticulo"].ToString());
                    string codigoPrecio = dr["CodigoPrecioVenta"].ToString();
                    string descripcion = dr["Descripcion"].ToString();
                    short cantidad = short.Parse(dr["Cantidad"].ToString());
                    decimal costo = decimal.Parse(dr["Costo"].ToString());
                    decimal venta = decimal.Parse(dr["Venta"].ToString());
                    descuento = decimal.Parse(dr["DescuentoArticulo"].ToString());
                   
                    taFacturaDetalle.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, secuencia, codigo, codigoPrecio, descripcion, cantidad, costo, venta, descuento);
                }

                i = 0;
                foreach (DataRow dr in dsNeo.tbFacturaCobro)
                {
                    i++;
                    string nombreFormaPago = dr["NombreFormaPago"].ToString();
                    decimal monto = decimal.Parse(dr["Monto"].ToString());
                    string fecha = dtpFecha.Value.ToShortDateString();
                    string concepto = string.Concat("Cobro ", txtNombre.Text.Trim());
                    taFacturaCobro.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, i, nombreFormaPago, Utilidad.nombreUsuario,fecha, concepto, monto);
                }

                ConfiguraBoton(true);
                MessageBox.Show("Factura guardada", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            }
        }

        private void btnCancelarFp_Click(object sender, EventArgs e)
        {
            pnlFormaPago.Visible = false;
        }

        private void grdCobroFactura_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnAceptarFg_Click(object sender, EventArgs e)
        {
            object numero = DBNull.Value;
            if (!string.IsNullOrEmpty(lblNumero.Text))
                numero = lblNumero.Text;
            DataRow dr = dsNeo.tbFacturaCobro.NewtbFacturaCobroRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["CodigoSucursal"] = Utilidad.codigoSucursal;
            dr["NumeroFactura"] = numero;
            dr["SecuenciaCobro"] = 1;
            dr["NombreFormaPago"] = grdFormaPago.CurrentRow.Cells["fpNombre"].Value.ToString();           
            dr["FechaCobro"] = DateTime.Today.ToShortDateString();
            dr["Concepto"] = "Cobro";
            dr["UsuarioCobro"] = Utilidad.nombreUsuario;          

            decimal monto = 0.00M;
            if (cboCondicion.SelectedIndex > -1 && dsNeo.tbFacturaCobro.Rows.Count == 0)
            {    
                string nombre = cboCondicion.Text;
                taFrecuencia.FillByNombre(dataSet.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                short cantidad = short.Parse(dataSet.tbFrecuencia.Rows[0]["cantidad"].ToString());
                if (cantidad == 0)
                    monto = decimal.Parse(lblTotal.Text);      
            }
            dr["Monto"] = monto;
            dsNeo.tbFacturaCobro.Rows.Add(dr);

            if (dsNeo.tbFacturaCobro.Rows.Count == 1)
            {
                txtRecibido.Focus();
            }
            else
            {
                grdFacturaCobro.Rows[grdFacturaCobro.RowCount - 1].Selected = true;
                grdFacturaCobro.Rows[grdFacturaCobro.RowCount - 1].Cells["cMonto"].Selected = true;
                grdFacturaCobro.BeginEdit(true);
            }

            btnCancelarFp_Click(sender, EventArgs.Empty);
<<<<<<< HEAD
            if (!string.IsNullOrEmpty(txtRecibido.Text))
                lblDevuelta.Text = devuelta().ToString("N2");
=======
            lblDevuelta.Text = devuelta().ToString("N2");
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            pnlFormaPago.Visible = true;
            grdFormaPago.Focus();
        }

        private void btnAceptarNuevoFp_Click(object sender, EventArgs e)
        {
            btnAceptarFg_Click(sender, EventArgs.Empty);
            btnNuevoCobro_Click(sender, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Available)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombrePrograma, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    int numero = int.Parse(lblNumero.Text);
                    taFacturaCobro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                    taFacturaDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                    taFactura.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                ConfiguraBoton(true);
            }
        }

        public void total()
        {
            decimal subTotal = decimal.Parse(dsNeo.tbFacturaDetalle.Compute("SUM(SubTotal)", null).ToString());
            lblSubTotal.Text = subTotal.ToString("N2");
            decimal importe = decimal.Parse(dsNeo.tbFacturaDetalle.Compute("SUM(Importe)", null).ToString());
            lblTotal.Text = importe.ToString("N2");
        }

        private void grdDetalle_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            string columna = grdDetalle.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;
            if (columna == "dCantidad" || columna == "dVenta" || columna == "dDescuento")
            {
                decimal cantidad = decimal.Parse(grdDetalle.CurrentRow.Cells["dCantidad"].Value.ToString());
                decimal precio = decimal.Parse(grdDetalle.CurrentRow.Cells["dVenta"].Value.ToString());
                decimal descuento = decimal.Parse(grdDetalle.CurrentRow.Cells["dDescuento"].Value.ToString());
                decimal subTotal = cantidad * precio - descuento;
                grdDetalle.CurrentRow.Cells["dSubTotal"].Value = subTotal;
                decimal importe = cantidad * precio - descuento;
                grdDetalle.CurrentRow.Cells["dImporte"].Value = importe;
                total();
            }               
        }

<<<<<<< HEAD
        private void grdFormaPago_DoubleClick(object sender, EventArgs e)
        {
            btnAceptarFg_Click(sender, EventArgs.Empty);
        }

        public decimal devuelta()
        {
            decimal venta = decimal.Parse(lblTotal.Text);
            decimal recibido = decimal.Parse(txtRecibido.Text);
            decimal total = venta - recibido;

            return total;
        }

        private void txtRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtRecibido.Text))
                lblDevuelta.Text = devuelta().ToString("N2");            
        }

        private void cboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRecibido_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecibido.Text))
                lblDevuelta.Text = devuelta().ToString("N2");
        }

=======
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidad.bscFactura == null)
                Utilidad.bscFactura = new FrmBscFactura();
            Utilidad.bscFactura.BringToFront();
            Utilidad.bscFactura.Show();
        }

<<<<<<< HEAD
        private void grdFacturaCobro_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnEliminaCobro_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombrePrograma, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                int numero = string.IsNullOrEmpty(lblNumero.Text) ? 0 : int.Parse(lblNumero.Text);
                short secuencia = short.Parse(grdFacturaCobro.CurrentRow.Cells["cSecuencia"].Value.ToString());
                taFacturaCobro.EliminaSecuencia(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, secuencia);
                grdFacturaCobro.Rows.Remove(grdFacturaCobro.CurrentRow);
            }
        }

        private void bsFacturaDetalle_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }

        private void grdDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal cantidad = decimal.Parse(grdDetalle.Rows[e.RowIndex].Cells["dCantidad"].Value.ToString());
            decimal precio = decimal.Parse(grdDetalle.Rows[e.RowIndex].Cells["dVenta"].Value.ToString());
            decimal descuento = decimal.Parse(grdDetalle.Rows[e.RowIndex].Cells["dDescuento"].Value.ToString());
            grdDetalle.Rows[e.RowIndex].Cells["dSubTotal"].Value = cantidad * precio;
            grdDetalle.Rows[e.RowIndex].Cells["dImporte"].Value = cantidad * precio - descuento;
=======
        private void cboCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCondicion.SelectedIndex > -1)
            {
                taFrecuencia.FillByNombre(dataSet.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, cboCondicion.Text);
                short i = short.Parse(dataSet.tbFrecuencia.Rows[0]["cantidad"].ToString());
                if (i == 0)
                {
                    btnNuevoCobro.Available = true;
                    txtRecibido.ReadOnly = false;
                }
                else
                {
                    btnNuevoCobro.Available = false;
                    txtRecibido.ReadOnly = true;
                }
            }
        }

        private decimal devuelta ()
        {
            decimal resultado = 0.00M;
            decimal total = decimal.Parse(lblTotal.Text);
            decimal cobro = decimal.Parse(dsNeo.tbFacturaCobro.Compute("SUM(Monto)", null).ToString());

            return resultado;
        }

        private void btnEliminaCobro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNumero.Text))
            {
                grdFacturaCobro.Rows.Remove(grdFacturaCobro.CurrentRow);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombrePrograma, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    DsNeoTableAdapters.taFacturaCobro ta = new DsNeoTableAdapters.taFacturaCobro();
                    
                    this.Cursor = Cursors.Default;
                }
            }
>>>>>>> d10643eaa9b8906793189f9d0b1f17a5b1617753
        }
    }
}
