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
        int codigoMascota = 0;

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
            //taEmpleado.FillByPuesto(dataSet.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinaria");
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
            dr["CodigoEmpleado"] = 0;
            dr["Veterinario"] = "Ha";
            dr["CodigoArticulo"] = 0;
            dr["Descripcion"] = "sfs";
            dr["Pendiente"] = true;
            dr["Costo"] = 0.00M;
            dr["Venta"] = 0.00;
            dr["Activa"] = true;
            dr["Nota"] = null;
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
                if (dsNeo.tbArticuloProveedor.Rows.Count > 0)
                {
                    decimal costo = decimal.Parse(dsNeo.tbArticuloProveedor.Rows[0]["Costo"].ToString());
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = codigo;
                }
                else
                {
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = 0.00M;
                }
                pnlServicio.Visible = false;
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
                    grdMascota.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtServicio.Focus();
                txtServicio.SelectAll();
                pnlServicio.Visible = false;
            }
        }

        private void grdArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            int numero = !string.IsNullOrEmpty(lblNumero.Text) ? int.Parse(lblNumero.Text) : 0;
            if (numero == 0)
            {
                DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                numero = cp.fnSiguienteNumero("cita", Utilidad.codigoSucursal, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value;
                taCita.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigoMascota, null, "Cliente", Utilidad.nombreUsuario, DateTime.Today.ToShortDateString(), dtpFecha.Value.ToShortDateString(), null, cboTipo.Text);
                foreach (DataRow dr in dsNeo.tbCitaDetalle.Rows)
                {
                    int codigo = int.Parse(dr["CodigoArticulo"].ToString());
                    short empleado = short.Parse(dr["CodigoVeterinario"].ToString());
                    bool pendiente = bool.Parse(dr["Pendiente"].ToString());
                    decimal costo = decimal.Parse(dr["Costo"].ToString());
                    decimal venta = decimal.Parse(dr["Venta"].ToString());
                    bool activa = bool.Parse(dr["Activa"].ToString());
                    string nota = dr["Nota"].ToString();
                    taCitaDetalle.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, codigo, empleado, pendiente, costo, venta, activa, nota);
                }
            }
            else
            {
                
            }
        }
    }
}
