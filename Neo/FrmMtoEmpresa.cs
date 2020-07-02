using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    public partial class FrmMtoEmpresa : Form
    {
        public FrmMtoEmpresa()
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
            int codigo = cp.fnSiguienteNumero(Utilidad.codigoTrabajo, 0, "empresa").Value;            
            lblCodigo.Text = codigo.ToString();
            cboIdentificacion.SelectedIndex = -1;
            txtNombre.Focus();
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblGrabada.Text = DateTime.Today.ToShortDateString();
            lblEquipo.Text = Environment.MachineName;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
            {
                txtRazonSocial.Focus();
                ep.SetError(txtRazonSocial, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtAbreviatura.Text.Trim()))
            {
                txtAbreviatura.Focus();
                ep.SetError(txtAbreviatura, Utilidad.campoVacio);
                return;
            }

            if (cboIdentificacion.SelectedIndex == -1)
            {
                cboIdentificacion.Focus();
                ep.SetError(cboIdentificacion, Utilidad.listaVacia);
                return;
            }

            if (string.IsNullOrEmpty(txtIdentificacion.Text.Trim()))
            {
                txtIdentificacion.Focus();
                ep.SetError(txtIdentificacion, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                txtDescripcion.Focus();
                ep.SetError(txtDescripcion, Utilidad.campoVacio);
                return;
            }

            try
            {                
                this.Validate();
                this.bsMto.EndEdit();
                byte[] logo = pbLogo.Image != null ? imagenByte(pbLogo.Image) : null;
                if (!btnNuevo.Available)
                {
                    taEmpresa.Inserta(short.Parse(lblTrabajo.Text), short.Parse(lblCodigo.Text), cboIdentificacion.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), txtAbreviatura.Text.Trim(), txtIdentificacion.Text.Trim(), txtDescripcion.Text.Trim(), txtLemaPublicitario.Text.Trim(), txtSitioWeb.Text.Trim(), logo, lblUsuario.Text, DateTime.Today, Environment.MachineName, chkActivo.Checked);
                    ConfiguraBoton(true);
                }
                else
                {
                    if (grdMto.RowCount > 0)
                        taEmpresa.Edita(cboIdentificacion.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), txtAbreviatura.Text.Trim(), txtIdentificacion.Text.Trim(), txtDescripcion.Text.Trim(), txtLemaPublicitario.Text.Trim(), txtSitioWeb.Text.Trim(), logo, chkActivo.Checked, Utilidad.codigoTrabajo, short.Parse(grdMto.CurrentRow.Cells["eCodigo"].Value.ToString()));
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
                        taEmpresa.Elimina(Utilidad.codigoTrabajo, short.Parse(grdMto.CurrentRow.Cells["eCodigo"].Value.ToString()));
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

        private void FrmMtoEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoEmpresa = null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pbLogo.Image = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ofdLogo.Filter = "Imagenes (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;";
            if (ofdLogo.ShowDialog() == DialogResult.OK)
                pbLogo.ImageLocation = ofdLogo.FileName;
        }

        public byte[] imagenByte(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void FrmMtoEmpresa_Load(object sender, EventArgs e)
        {
            taEmpresa.Fill(dsNeo.tbEmpresa, Utilidad.codigoTrabajo);
            taIdentificacion.Fill(dsNeo.tbIdentificacion, 1);
            if (grdMto.Rows.Count > 0)
                grdMto_SelectionChanged(sender, EventArgs.Empty);
            else
                cboIdentificacion.SelectedIndex = -1;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
                cboIdentificacion.Text = grdMto.CurrentRow.Cells["eCodigoIdentificacion"].Value.ToString();
        }
    }
}
