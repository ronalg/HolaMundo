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
    public partial class FrmMtoTipoTributo : Form
    {
        public FrmMtoTipoTributo()
        {
            InitializeComponent();
        }

        string codigo = null;

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
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
            {
                txtCodigo.Focus();
                ep.SetError(txtCodigo, Utilidad.campoVacio);
                return;
            }

            if (cboTributo.SelectedIndex == -1)
            {
                cboTributo.Focus();
                ep.SetError(cboTributo, Utilidad.campoVacio);
                return;
            }

            try
            {
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taTipoTributo.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtCodigo.Text.Trim(), cboTributo.Text, txtDescripcion.Text.Trim(), Convert.ToDecimal(txtTasa.Text), dtpDesde.Value.Date, dtpHasta.Value.Date);
                    ConfiguraBoton(true);
                    codigo = txtCodigo.Text.Trim();
                }
                else
                {
                    taTipoTributo.Edita(txtCodigo.Text.Trim(), cboTributo.Text, txtDescripcion.Text.Trim(), Convert.ToDecimal(txtTasa.Text), dtpDesde.Value.Date, dtpHasta.Value.Date, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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
                        taTipoTributo.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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

        private void FrmMtoTipoTributo_Load(object sender, EventArgs e)
        {
            taTributo.Fill(dsNeo.tbTributo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taTipoTributo.Fill(dsNeo.tbTipoTributo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void FrmMtoTipoTributo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoTipoTributo = null;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
                codigo = grdMto.CurrentRow.Cells["tbCodigo"].Value.ToString();
        }
    }
}

