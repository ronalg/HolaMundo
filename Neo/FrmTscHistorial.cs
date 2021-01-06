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
    public partial class FrmTscHistorial : Form
    {
        public FrmTscHistorial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscHistorial = null;
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
                taMascota.Fill(ds.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, txtBuscaMascota.Text.Trim());
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
            taMascota.Fill(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null);
            grdMascota.Visible = false;
            bnDetalle.Focus();
            btnNew.Select();
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
                        taHistorialDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, sucursal, numero);
                        taHistorial.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, sucursal, numero);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscaMascota.Focus();
            txtBuscaMascota.Clear();
            dsNeo.tbMascota.Rows.Clear();
            dsNeo.tbHistorialDetalle.Rows.Clear();
            lblNumero.Text = null;
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            dtpFecha.Value = DateTime.Today.Date;
            pnlServicio.Visible = false;
            pnlVeterinario.Visible = false;
            grdMascota.Visible = false;
            txtBuscaMascota.Focus();
        }

        private void btnCancelaVeterinario_Click(object sender, EventArgs e)
        {
            pnlVeterinario.Visible = false;
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

        private void btnCancelaServicio_Click(object sender, EventArgs e)
        {
            pnlServicio.Visible = false;
        }

        private void btnAceptaServicio_Click(object sender, EventArgs e)
        {
            if (grdServicio.CurrentRow.Cells["sCodigo"].Value != DBNull.Value)
            {
                this.Cursor = Cursors.WaitCursor;
                int codigo = int.Parse(grdServicio.CurrentRow.Cells["sCodigo"].Value.ToString());
                grdArticulo.CurrentRow.Cells["aCodigo"].Value = codigo;
                grdArticulo.CurrentRow.Cells["aDescripcion"].Value = grdServicio.CurrentRow.Cells["sDescripcion"].Value.ToString();
                codigo = int.Parse(lblCodigo.Text);
                taMascota.Fill(ds.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null);
                short codigoEmpleado = short.Parse(ds.tbMascota.Rows[0]["CodigoEmpleado"].ToString());
                grdArticulo.CurrentRow.Cells["aCodigoVeterinario"].Value = codigoEmpleado;
                string nombre = ds.tbMascota.Rows[0]["nombreVeterinario"].ToString();
                grdArticulo.CurrentRow.Cells["aVeterinario"].Value = nombre;
                pnlServicio.Visible = false;
                bnDetalle.Focus();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnServicioAceptarNuevo_Click(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
            btnNew_Click(sender, EventArgs.Empty);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                DataRow dr = dsNeo.tbHistorialDetalle.NewtbHistorialDetalleRow();
                dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
                dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
                dr["CodigoSucursal"] = Utilidad.codigoSucursal;
                dr["NumeroHistorial"] = 0;
                dr["CodigoEmpleado"] = DBNull.Value;
                dr["Veterinario"] = DBNull.Value;
                dr["CodigoArticulo"] = DBNull.Value;
                dr["Descripcion"] = DBNull.Value;
                dr["Nota"] = DBNull.Value;
                dsNeo.tbCitaDetalle.Rows.Add(dr);
                pnlServicio.Visible = true;
                txtServicio.Clear();
                txtServicio.Focus();
                grdArticulo.Rows[grdArticulo.RowCount - 1].Cells["aCodigo"].Selected = true;
            }
            else
            {
                MessageBox.Show("Seleccione mascota", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                        if (grdArticulo.CurrentRow.Cells["aCodigo"].Value != DBNull.Value)
                        {
                            int codigo = int.Parse(grdArticulo.CurrentRow.Cells["aCodigo"].Value.ToString());
                            if (!string.IsNullOrEmpty(lblNumero.Text))
                            {
                                int numero = int.Parse(lblNumero.Text);
                                taHistorialDetalle.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigo);
                            }
                        }
                        grdArticulo.Rows.Remove(grdArticulo.CurrentRow);
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

        private void grdServicio_DoubleClick(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
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
                    numero = cp.fnSiguienteNumero("historial", Utilidad.codigoSucursal, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value;
                    taHistorial.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigoMascota, null, Utilidad.nombreUsuario, DateTime.Today.ToShortDateString(), dtpFecha.Value.ToShortDateString(), null, null);
                    lblNumero.Text = numero.ToString();
                }
                else
                {
                    taHistorial.Edita(codigoMascota, null, dtpFecha.Value.ToShortDateString(), null, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                }

                taHistorialDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                foreach (DataRow dr in dsNeo.tbCitaDetalle.Rows)
                {
                    int codigo = int.Parse(dr["CodigoArticulo"].ToString());
                    short empleado = short.Parse(dr["CodigoEmpleado"].ToString());
                    bool pendiente = bool.Parse(dr["Pendiente"].ToString());
                    decimal costo = decimal.Parse(dr["Costo"].ToString());
                    decimal venta = decimal.Parse(dr["Venta"].ToString());
                    bool activa = bool.Parse(dr["Activa"].ToString());
                    string nota = dr["Nota"].ToString();

                    taHistorialDetalle.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigo, empleado, nota);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidad.bscHistorial == null)
                Utilidad.bscHistorial = new FrmBscHistorial();
            Utilidad.bscHistorial.BringToFront();
            Utilidad.bscHistorial.Show();
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

        private void FrmTscHistorial_Load(object sender, EventArgs e)
        {
            taArticulo.FillByVeterinaria(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, null);
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinario");
        }
    }
}
