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
    public partial class FrmMtoMascota : Form
    {
        public FrmMtoMascota()
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

        private void tpMascota_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtNombre.Focus();
            lblUsuario.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            cboGrupo.SelectedIndex = -1;
            cboRaza.SelectedIndex = -1;
            dsNeo.tbRaza.Rows.Clear();
            cboSexo.SelectedIndex = -1;
            cboCaracter.SelectedIndex = -1;
            cboPelaje.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            cboSanguineo.SelectedIndex = -1;
            txtBusca.Clear();
            DsNeo ds = new DsNeo();
            taSucursal.FillByCodigo(ds.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
            lblSucursal.Text = ds.tbSucursal.Rows[0]["Nombre"].ToString();
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            txtNacimiento.Text = DateTime.Today.ToShortDateString();
            txtApertura.Text = DateTime.Today.ToShortDateString();
            lblUsuario.Text = Utilidad.nombreUsuario;
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
                        int codigo = int.Parse(lblCodigo.Text);
                        taMascota.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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

        private void FrmMtoMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoMascota = null;
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrupo.SelectedIndex > -1)
            {
                string nombre = cboGrupo.Text;
                taRaza.FillByGrupo(dsNeo.tbRaza, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                cboRaza.SelectedIndex = -1;
            }
        }

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSucursal.SelectedIndex > -1)
            {
                string codigo = cboSucursal.SelectedValue.ToString();
                lblSucursal.Text = codigo;
            }
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
                lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
                lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taMascota.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0, short.Parse(lblSucursal.Text), short.Parse(lblCliente.Text), cboGrupo.Text, cboRaza.Text, cboEstado.Text, short.Parse("0"), cboCaracter.Text, cboPelaje.Text, cboSanguineo.Text, lblUsuario.Text, txtNombre.Text.Trim(), txtApertura.Text, txtNacimiento.Text, cboSexo.Text, txtColor.Text.Trim(), txtPedigri.Text.Trim(), chkCorteOreja.Checked, chkCorteCola.Checked, chkCastrado.Checked, chkPeluqueria.Checked, chkExhibicion.Checked, null, txtDieta.Text.Trim(), txtNota.Text.Trim(), lblEquipo.Text);
                    ConfiguraBoton(true);
                }
                else
                {
                    taMascota.Edita(short.Parse(lblSucursal.Text), short.Parse(lblCliente.Text), cboGrupo.Text, cboRaza.Text, cboEstado.Text, short.Parse("0"), cboCaracter.Text, cboPelaje.Text, cboSanguineo.Text, lblUsuario.Text, txtNombre.Text.Trim(), txtApertura.Text.Trim(), txtNacimiento.Text, cboSexo.Text, txtColor.Text.Trim(), txtPedigri.Text.Trim(), chkCorteOreja.Checked, chkCorteCola.Checked, chkPeluqueria.Checked, chkExhibicion.Checked, null, txtDieta.Text.Trim(), txtNota.Text.Trim(), lblEquipo.Text, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, int.Parse(lblCodigo.Text));
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

        private void FrmMtoMascota_Load(object sender, EventArgs e)
        {
            taGrupo.Fill(dsNeo.tbGrupo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taCaracter.Fill(dsNeo.tbCaracter, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taPelaje.Fill(dsNeo.tbPelaje, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taMascota.Fill(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }
    }
}
