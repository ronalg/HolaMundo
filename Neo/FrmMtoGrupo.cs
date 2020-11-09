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
    public partial class FrmMtoGrupo : Form
    {
        public FrmMtoGrupo()
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
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
        }

        private void FrmMtoGrupo_Load(object sender, EventArgs e)
        {
            taGrupo.Fill(dsNeo.tbGrupo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtNombre.Focus();
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            try
            {
                lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
                lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taGrupo.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtNombre.Text.Trim());
                    ConfiguraBoton(true);
                    nombre = txtNombre.Text.Trim();
                }
                else
                {
                    taGrupo.Edita(txtNombre.Text.Trim(), Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
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
                        taGrupo.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
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

        private void FrmMtoGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoGrupo = null;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
                nombre = grdMto.CurrentRow.Cells["gNombre"].Value.ToString();
        }
    }
}
