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
    public partial class FrmMtoSucursal : Form
    {
        public FrmMtoSucursal()
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
            spd4.Available = configura;
            btnSalir.Available = configura;
            pnl4.Visible = configura;
        }

        private void FrmMtoSucursal_Load(object sender, EventArgs e)
        {
            taPais.Fill(dsNeo.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtNombre.Focus();
            cboPais.SelectedIndex = -1;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblGrabada.Text = DateTime.Today.ToShortDateString();
            lblEquipo.Text = Environment.MachineName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                txtDireccion.Focus();
                ep.SetError(txtDireccion, Utilidad.campoVacio);
                return;
            }

            if (cboPais.SelectedIndex == -1)
            {
                cboPais.Focus();
                ep.SetError(cboPais, Utilidad.listaVacia);
                return;
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                cboProvincia.Focus();
                ep.SetError(cboProvincia, Utilidad.listaVacia);
                return;
            }

            try
            {
                this.Validate();
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.consultasProgramadas cp = new DsNeoTableAdapters.consultasProgramadas();
                    int codigo = cp.fnSiguienteNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "sucursal").Value;
                    lblCodigo.Text = codigo.ToString();
                }

                this.bsMto.EndEdit();
                
                if (!btnNuevo.Available)
                {
                    taSucursal.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text), cboPais.Text.Trim(), cboProvincia.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtCodigoPostal.Text.Trim(), lblUsuario.Text, lblGrabada.Text, lblEquipo.Text, chkActivo.Checked);
                    ConfiguraBoton(true);                    
                }
                else
                {
                    taSucursal.Edita(cboPais.Text.Trim(), cboProvincia.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtCodigoPostal.Text.Trim(), chkActivo.Checked, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text));
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
                        taSucursal.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text));
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

        private void grabadaLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrmMtoSucursal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoSucursal = null;
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            taProvincia.FillByPais(dsNeo.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, cboPais.Text.Trim());
            cboProvincia.SelectedIndex = -1;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null && cboProvincia.SelectedIndex == -1)
                cboProvincia.Text = grdMto.CurrentRow.Cells["sProvincia"].Value.ToString();
        }
    }
}
