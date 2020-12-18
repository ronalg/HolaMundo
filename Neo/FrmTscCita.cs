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
    public partial class FrmTscCita : Form
    {
        public FrmTscCita()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void tbCitaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numeroCitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroCitaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            

        }

        private void txtBuscaMascota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscaMascota.Text.Trim()))
                grdMascota.Visible = false;
        }

        private void txtBuscaMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taMascota.Fill(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtBuscaMascota.Text.Trim());
                if (grdMascota.RowCount == 1)
                {
                    grdMascota_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdMascota.Visible = true;
                    grdMascota.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBuscaMascota.Focus();
                txtBuscaMascota.SelectAll();
                grdMascota.Visible = false;
            }
        }

        private void grdMascota_DoubleClick(object sender, EventArgs e)
        {
            int codigo = int.Parse(grdMascota.CurrentRow.Cells["mCodigo"].Value.ToString());
            taMascota.FillByCodigo(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, codigo);
            grdMascota.Visible = false;
            cboTipo.Focus();
        }

        private void grdMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdMascota_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdMascota.Visible = false;
                txtBuscaMascota.Focus();
                txtBuscaMascota.SelectAll();
            }
        }

        private void btnCancelaServicio_Click(object sender, EventArgs e)
        {
            pnlServicio.Visible = false;
        }

        private void btnCancelaVeterinario_Click(object sender, EventArgs e)
        {
            pnlVeterinario.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscCita = null;
        }

        private void FrmTscCita_Load(object sender, EventArgs e)
        {
            taArticulo.FillByVeterinaria(dataSet.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, null);
            taEmpleado.FillByPuesto(dataSet.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinario");
            btnNuevo_Click(sender, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidad.bscCita == null)
                Utilidad.bscCita = new FrmBscCita();
            Utilidad.bscCita.BringToFront();
            Utilidad.bscCita.Show();
        }

        private void grdServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServicio.Text))
                taArticulo.FillByVeterinaria(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, null);
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNeo.tbCitaDetalle.NewtbCitaDetalleRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["CodigoSucursal"] = Utilidad.codigoSucursal;
            dr["NumeroCita"] = 0;
            dr["CodigoEmpleado"] = DBNull.Value;
            dr["Veterinario"] = DBNull.Value;
            dr["CodigoArticulo"] = DBNull.Value;
            dr["Descripcion"] = DBNull.Value;
            dr["Pendiente"] = true;
            dr["Costo"] = DBNull.Value;
            dr["Venta"] = DBNull.Value;
            dr["Activa"] = true;
            dr["Nota"] = DBNull.Value;
            dsNeo.tbCitaDetalle.Rows.Add(dr);
            pnlServicio.Visible = true;
            txtServicio.Clear();
            txtServicio.Focus();
            grdArticulo.Rows[grdArticulo.RowCount - 1].Cells["aCodigo"].Selected = true;
        }

        private void btnAceptaServicio_Click(object sender, EventArgs e)
        {
            if (grdServicio.CurrentRow.Cells["sCodigo"].Value != DBNull.Value)
            {
                int codigo = int.Parse(grdServicio.CurrentRow.Cells["sCodigo"].Value.ToString());
                grdArticulo.CurrentRow.Cells["aCodigo"].Value = codigo;
                grdArticulo.CurrentRow.Cells["aDescripcion"].Value = grdServicio.CurrentRow.Cells["sDescripcion"].Value.ToString();
                taArticuloProveedor.FillByActual(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, true);
                //coste
                if (dsNeo.tbArticuloProveedor.Rows.Count > 0)
                {
                    decimal costo = decimal.Parse(dsNeo.tbArticuloProveedor.Rows[0]["Costo"].ToString());
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = costo;
                }
                else
                {
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = 0.00M;
                }
                //venta
                taArticuloPrecioVenta.FillByCodigoPrecioVenta(dsNeo.tbArticuloPrecioVenta, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Venta 1");
                if (dsNeo.tbArticuloPrecioVenta.Rows.Count > 0)
                {
                    decimal venta = decimal.Parse(dsNeo.tbArticuloPrecioVenta.Rows[0]["Precio"].ToString());
                    grdArticulo.CurrentRow.Cells["aVenta"].Value = venta;
                }
                else
                {
                    grdArticulo.CurrentRow.Cells["aVenta"].Value = 0.00M;
                }
                codigo = int.Parse(lblCodigo.Text);
                taMascota.FillByCodigo(dataSet.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, codigo);
                short codigoEmpleado = short.Parse(dataSet.tbMascota.Rows[0]["CodigoEmpleado"].ToString());
                grdArticulo.CurrentRow.Cells["aCodigoVeterinario"].Value = codigoEmpleado;
                string nombre = dataSet.tbMascota.Rows[0]["nombreVeterinario"].ToString();
                grdArticulo.CurrentRow.Cells["aVeterinario"].Value = nombre;
                pnlServicio.Visible = false;
                lblTotal.Text = total().ToString("N2");
                bnDetalle.Focus();
            }
        }

        private void txtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taArticulo.FillByVeterinaria(dataSet.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, txtServicio.Text);
                if (dataSet.tbArticulo.Rows.Count == 1)
                    btnAceptaServicio_Click(sender, EventArgs.Empty);
                else
                    grdServicio.Focus();
            }
        }

        private void grdServicio_DoubleClick(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
        }

        private void lblDueno_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscaMascota.Focus();
            dsNeo.tbMascota.Rows.Clear();
            dsNeo.tbCitaDetalle.Rows.Clear();
            lblNumero.Text = null;
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            dtpFecha.Value = DateTime.Today.Date;
            lblTotal.Text = "0.00";
            pnlServicio.Visible = false;
            pnlVeterinario.Visible = false;
            grdMascota.Visible = false;
            cboTipo.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnNuevo.Available)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.textoCuadroMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        int numero = int.Parse(lblNumero.Text);
                        short sucursal = short.Parse(lblSucursal.Text);
                        taCitaDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, sucursal, numero);
                        taCita.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, sucursal, numero);
                        btnNuevo_Click(sender, EventArgs.Empty);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCodigo.Text))
            {
                ep.SetError(txtBuscaMascota, Utilidad.campoVacio);
                txtBuscaMascota.Focus();
                return;
            }

            if (grdArticulo.RowCount == 0)
            {
                MessageBox.Show("Ingrese servicio", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            foreach (DataRow dr in dsNeo.tbCitaDetalle)
            {
                string codigo = dr["CodigoArticulo"].ToString();
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Ingrese valor en el listado de servicio valido", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                int numero = !string.IsNullOrEmpty(lblNumero.Text) ? int.Parse(lblNumero.Text) : 0;
                int codigoMascota = int.Parse(lblCodigo.Text);
                if (numero == 0)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    numero = cp.fnSiguienteNumero("cita", Utilidad.codigoSucursal, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value;
                    taCita.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigoMascota, null, "Cliente", Utilidad.nombreUsuario, DateTime.Today.ToShortDateString(), dtpFecha.Value.ToShortDateString(), null, cboTipo.Text);
                    lblNumero.Text = numero.ToString();
                }
                else
                {
                    taCita.Edita(codigoMascota, null, dtpFecha.Value.ToShortDateString(), null, cboTipo.Text, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                }

                taCitaDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                foreach (DataRow dr in dsNeo.tbCitaDetalle.Rows)
                {
                    int codigo = int.Parse(dr["CodigoArticulo"].ToString());
                    short empleado = short.Parse(dr["CodigoEmpleado"].ToString());
                    bool pendiente = bool.Parse(dr["Pendiente"].ToString());
                    decimal costo = decimal.Parse(dr["Costo"].ToString());
                    decimal venta = decimal.Parse(dr["Venta"].ToString());
                    bool activa = bool.Parse(dr["Activa"].ToString());
                    string nota = dr["Nota"].ToString();

                    taCitaDetalle.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigo, empleado, pendiente, costo, venta, activa, nota);
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
            }
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void grdMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private decimal total ()
        {
            decimal valor = decimal.Parse(dsNeo.tbCitaDetalle.Compute("SUM(Venta)", null).ToString());
            return valor;
        }

        private void cboTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNuevoServicio_Click(sender, EventArgs.Empty);
        }

        private void btnServicioAceptarNuevo_Click(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
            btnNuevoServicio_Click(sender, EventArgs.Empty);
        }

        private void btnEliminaServicio_Click(object sender, EventArgs e)
        {
            if (grdArticulo.CurrentRow != null)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.textoCuadroMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        int codigo = int.Parse(grdArticulo.CurrentRow.Cells["aCodigo"].Value.ToString());
                        if (!string.IsNullOrEmpty(lblNumero.Text))
                        {
                            int numero = int.Parse(lblNumero.Text);
                            taCitaDetalle.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigo);
                        }
                        grdArticulo.Rows.Remove(grdArticulo.CurrentRow);
                        lblTotal.Text = total().ToString("N2");
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void grdServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAceptaServicio_Click(sender, EventArgs.Empty);
        }

        private void grdArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna = grdArticulo.CurrentRow.Cells[e.ColumnIndex].OwningColumn.Name;
            if (columna == "aCodigo" || columna == "aDescripcion")
            {
                pnlServicio.Visible = true;
                txtServicio.Focus();
                txtServicio.Clear();
            }
            else if (columna == "aVeterinario")
            {
                pnlVeterinario.Visible = true;
                grdVeterinario.Focus();
            }
        }

        private void btnAceptaVeterinario_Click(object sender, EventArgs e)
        {
            if (grdVeterinario.CurrentRow.Cells["vNombre"].Value != DBNull.Value)
            {
                string codigo = grdVeterinario.CurrentRow.Cells["vCodigo"].Value.ToString();
                string nombre = grdVeterinario.CurrentRow.Cells["vNombre"].Value.ToString();
                grdArticulo.CurrentRow.Cells["aCodigoVeterinario"].Value = codigo;
                grdArticulo.CurrentRow.Cells["aVeterinario"].Value = nombre;
                pnlVeterinario.Visible = false;
                grdArticulo.CurrentRow.Cells["aVeterinario"].Selected = true;
            }
        }

        private void grdVeterinario_DoubleClick(object sender, EventArgs e)
        {
            btnAceptaVeterinario_Click(sender, EventArgs.Empty);
        }

        private void grdVeterinario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAceptaVeterinario_Click(sender, EventArgs.Empty);
            else if (e.KeyCode == Keys.Escape)
                btnCancelaServicio_Click(sender, EventArgs.Empty);
        }
    }
}
