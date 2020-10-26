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
    public partial class FrmMtoIdentificacion : Form
    {
        public FrmMtoIdentificacion()
        {
            InitializeComponent();
        }

        string codigoIdentificacion = null;
        string nombreNacionalidad = null;

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
            txtCodigo.Focus();
            cboNacionalidad.SelectedIndex = -1;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
            {
                txtCodigo.Focus();
                ep.SetError(txtCodigo, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (cboNacionalidad.SelectedIndex == -1)
            {
                cboNacionalidad.Focus();
                ep.SetError(cboNacionalidad, Utilidad.campoVacio);
                return;
            }

            try
            {
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taIdentificacion.Inserta(Utilidad.codigoTrabajo, txtCodigo.Text.Trim(), cboNacionalidad.Text, txtNombre.Text.Trim());
                    codigoIdentificacion = txtCodigo.Text.Trim();
                    nombreNacionalidad = cboNacionalidad.Text;
                    ConfiguraBoton(true);
                }
                else
                {
                    taIdentificacion.Edita(txtCodigo.Text.Trim(), cboNacionalidad.Text, txtNombre.Text.Trim(), Utilidad.codigoTrabajo, codigoIdentificacion, nombreNacionalidad);
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
                        taIdentificacion.Elimina(Utilidad.codigoTrabajo, codigoIdentificacion, nombreNacionalidad);
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

        private void FrmMtoIdentificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoIdentificacion = null;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
            {
                codigoIdentificacion = grdMto.CurrentRow.Cells["iCodigo"].Value.ToString();
                nombreNacionalidad = grdMto.CurrentRow.Cells["iNombreNacionalidad"].Value.ToString();
            }
        }

        private void FrmMtoIdentificacion_Load(object sender, EventArgs e)
        {
            taNacionalidad.Fill(dsNeo.tbNacionalidad, Utilidad.codigoTrabajo);
            taIdentificacion.Fill(dsNeo.tbIdentificacion, Utilidad.codigoTrabajo);
        }

        private void pnl6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
