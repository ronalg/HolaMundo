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
    public partial class FrmMtoEmpleado : Form
    {
        public FrmMtoEmpleado()
        {
            InitializeComponent();
        }

        string nombre = null;

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
            spd4.Available = configura;
            btnSalir.Available = configura;
            pnl4.Visible = configura;
        }

        private void FrmMtoEmpleado_Load(object sender, EventArgs e)
        {
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taPuesto.FillByVeterinaria(dsNeo.tbPuesto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true);
            taEmpleado.Fill(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtNombre.Focus();
            dtpApertura.Value = DateTime.Today.Date.AddDays(-1);
            dtpFecha.Value = DateTime.Today.Date.AddDays(-1);
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            cboPuesto.SelectedIndex = -1;
            dsNeo.tbSucursal.Rows.Clear();
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            dtpFecha.Value = DateTime.Today.Date;
            dtpApertura.Value = DateTime.Today.Date;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (cboPuesto.SelectedIndex == - 1)
            {
                cboPuesto.Focus();
                ep.SetError(cboPuesto, Utilidad.campoVacio);
                return;
            }

            try
            {
                lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
                lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
                short codigo;
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    codigo = Convert.ToInt16(cp.fnSiguienteNumero("empleado", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null).Value.ToString());
                    lblCodigo.Text = codigo.ToString();
                }
                else
                {
                    codigo = Convert.ToInt16(lblCodigo.Text);
                }
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taEmpleado.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, short.Parse(txtSucursal.Text), cboPuesto.Text, txtNombre.Text.Trim(), dtpFecha.Value.ToString(), dtpApertura.Value.ToShortDateString(), chkActivo.Checked, txtNota.Text.Trim());
                    ConfiguraBoton(true);
                    nombre = txtNombre.Text.Trim();
                }
                else
                {
                    taEmpleado.Edita(short.Parse(txtSucursal.Text), txtNombre.Text.Trim(), cboPuesto.Text, dtpApertura.Value.ToShortDateString(), chkActivo.Checked, txtNota.Text.Trim(), Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                }
            }
            catch (NoNullAllowedException nullEx)
            {
                MessageBox.Show(nullEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnNuevo.Available && grdMto.CurrentRow != null)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.textoCuadroMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        short codigo = short.Parse(lblCodigo.Text);
                        taEmpleado.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                        grdMto.Rows.Remove(grdMto.CurrentRow);
                    }
                }
                else if (grdMto.CurrentRow != null)
                {
                    grdMto.Rows.Remove(grdMto.CurrentRow);
                    ConfiguraBoton(true);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMtoEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoEmpleado = null;
        }

        private void bsMto_AddingNew(object sender, AddingNewEventArgs e)
        {
            
        }
    }
}
