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
            spd5.Available = configura;
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
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            lblEquipo.Text = Environment.MachineName;
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
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            txtNacimiento.Text = DateTime.Today.ToShortDateString();
            txtApertura.Text = DateTime.Today.ToShortDateString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            cboVeterinario.SelectedIndex = -1;
            cboSucursal.Text = ds.tbSucursal.Rows[0]["Nombre"].ToString();
            dsNeo.tbSucursalContacto.Rows.Clear();
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
            Utilidad.mtoCliente = null;
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrupo.SelectedIndex > -1)
            {
                string nombre = cboGrupo.Text;
                taRaza.FillByGrupo(dsNeo.tbRaza, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                cboRaza.SelectedIndex = -1;
                taGrupoSanguineo.FillByGrupo(dsNeo.tbGrupoSanguineo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                cboSanguineo.SelectedIndex = -1;
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

            if (cboGrupo.SelectedIndex == -1)
            {
                cboGrupo.Focus();
                ep.SetError(cboGrupo, Utilidad.campoVacio);
                return;
            }

            if (cboRaza.SelectedIndex == -1)
            {
                cboRaza.Focus();
                ep.SetError(cboRaza, Utilidad.campoVacio);
                return;
            }

            if (cboSexo.SelectedIndex == -1)
            {
                cboSexo.Focus();
                ep.SetError(cboSexo, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtNacimiento.Text))
            {
                txtNacimiento.Focus();
                ep.SetError(txtNacimiento, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(lblCliente.Text))
            {
                txtBusca.Focus();
                ep.SetError(txtBusca, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(lblVeterinario.Text))
            {
                cboVeterinario.Focus();
                ep.SetError(cboVeterinario, Utilidad.campoVacio);
                return;
            }

            try
            {
                string caracter = string.IsNullOrEmpty(cboCaracter.Text) ? null : cboCaracter.Text;
                string pelaje = string.IsNullOrEmpty(cboPelaje.Text) ? null : cboPelaje.Text;
                string sanguineo = string.IsNullOrEmpty(cboSanguineo.Text) ? null : cboSanguineo.Text;
                short cliente = short.Parse(lblCliente.Text);
                short sucursal = short.Parse(lblSucursal.Text);
                short veterinario = short.Parse(lblVeterinario.Text);
                short codigo;
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    codigo = Convert.ToInt16(cp.fnSiguienteNumero("mascota", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value.ToString());
                    lblCodigo.Text = codigo.ToString();
                }
                else
                {
                    codigo = Convert.ToInt16(lblCodigo.Text);
                }

                this.Validate();
                byte[] imagen = pbImagen.Image != null ? imagenByte(pbImagen.Image) : null;

                if (!btnNuevo.Available)
                {
                    taMascota.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, sucursal, cliente, cboGrupo.Text, cboRaza.Text, cboEstado.Text, veterinario, caracter, pelaje, sanguineo, lblUsuario.Text, txtNombre.Text.Trim(), txtApertura.Text, txtNacimiento.Text, cboSexo.Text, txtColor.Text.Trim(), txtPedigri.Text.Trim(), chkCorteOreja.Checked, chkCorteCola.Checked, chkCastrado.Checked, chkPeluqueria.Checked, chkExhibicion.Checked, imagen, txtDieta.Text.Trim(), txtNota.Text.Trim(), lblEquipo.Text);
                    ConfiguraBoton(true);
                }
                else
                {
                    taMascota.Edita(sucursal, cliente, cboGrupo.Text, cboRaza.Text, cboEstado.Text, veterinario, caracter, pelaje, sanguineo, txtNombre.Text.Trim(), txtApertura.Text.Trim(), txtNacimiento.Text, cboSexo.Text, txtColor.Text.Trim(), txtPedigri.Text.Trim(), chkCorteOreja.Checked, chkCorteCola.Checked, chkPeluqueria.Checked, chkExhibicion.Checked, imagen, txtDieta.Text.Trim(), txtNota.Text.Trim(), Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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
            cboPendiente.SelectedIndex = 0;
            cboActiva.SelectedIndex = 0;
            taEstado.FillByTipo(dsNeo.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinaria");
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinario");
            taGrupo.Fill(dsNeo.tbGrupo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taCaracter.Fill(dsNeo.tbCaracter, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taPelaje.Fill(dsNeo.tbPelaje, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboSucursal.SelectedIndex = -1;
            cboVeterinario.SelectedIndex = -1;
            taMascota.Fill(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null);
            grdMto_SelectionChanged(sender, EventArgs.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ofdLogo.Filter = "Imagenes (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;";
            if (ofdLogo.ShowDialog() == DialogResult.OK)
                pbImagen.ImageLocation = ofdLogo.FileName;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pbImagen.Image = null;
        }

        public byte[] imagenByte(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void cboEstado_Validated(object sender, EventArgs e)
        {
            string nombre = cboEstado.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DsNeo ds = new DsNeo();
                taEstado.FillByNombre(ds.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (ds.tbEstado.Rows.Count == 0)
                {
                    MessageBox.Show(string.Concat(Utilidad.mensajeNoEncontrado, "Estado"), Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboEstado.Focus();                    
                }
            }
        }

        private void cboCaracter_Validated(object sender, EventArgs e)
        {
            string nombre = cboCaracter.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DsNeo ds = new DsNeo();
                taCaracter.FillByNombre(ds.tbCaracter, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (ds.tbCaracter.Rows.Count == 0)
                {
                    MessageBox.Show(string.Concat(Utilidad.mensajeNoEncontrado, "Caracter"), Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboCaracter.Focus();
                }
            }
        }

        private void cboPelaje_Validated(object sender, EventArgs e)
        {
            string nombre = cboPelaje.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DsNeo ds = new DsNeo();
                taPelaje.FillByNombre(ds.tbPelaje, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (ds.tbPelaje.Rows.Count == 0)
                {
                    MessageBox.Show(string.Concat(Utilidad.mensajeNoEncontrado, "Pelaje"), Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboPelaje.Focus();
                }
            }
        }

        private void cboSanguineo_Validated(object sender, EventArgs e)
        {
            string nombre = cboSanguineo.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DsNeo ds = new DsNeo();
                taGrupoSanguineo.FillByNombre(ds.tbGrupoSanguineo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (ds.tbGrupoSanguineo.Rows.Count == 0)
                {
                    MessageBox.Show(string.Concat(Utilidad.mensajeNoEncontrado, "Grupo Sanguineo"), Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cboSanguineo.Focus();
                }
            }
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nombre = txtBusca.Text;
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (dsNeo.tbCliente.Rows.Count > 2)
                {
                    grdCliente.Visible = true;
                    grdCliente.Focus();
                }
                else if (dsNeo.tbCliente.Count == 1)
                {
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdCliente.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtBusca.Focus();
                txtBusca.SelectAll();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusca.Text))
                grdCliente.Visible = false;
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lblCliente.Text = grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString();
            lblDueno.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            grdCliente.Visible = false;
            int codigo = int.Parse(lblCliente.Text);
            CargaContacto(codigo);
            this.Cursor = Cursors.Default;
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
                txtBusca.Focus();
                txtBusca.SelectAll();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
            }
        }

        private void cboVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVeterinario.SelectedIndex > -1)
            {
                string nombre = cboVeterinario.Text;
                DsNeo ds = new DsNeo();
                taEmpleado.FillByNombre(ds.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                string codigo = ds.tbEmpleado.Rows[0]["CodigoEmpleado"].ToString();
                lblVeterinario.Text = codigo;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoCliente == null)
            {
                Utilidad.mtoCliente = new FrmMtoCliente();
                Utilidad.mtoCliente.StartPosition = FormStartPosition.CenterParent;
                Utilidad.mtoCliente.MdiParent = Utilidad.frmPrimario;
            }

            Utilidad.mtoCliente.Text = "Mascota";
            Utilidad.mtoCliente.BringToFront();
            Utilidad.mtoCliente.Show();
        }

        public void CargaContacto (int codigo)
        {
            taSucursalContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null && grdMto.CurrentRow.Cells["mCodigo"].Value != DBNull.Value)
            {
                this.Cursor = Cursors.WaitCursor;
                int codigo = int.Parse(grdMto.CurrentRow.Cells["mCodigo"].Value.ToString());
                taSucursalContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                DsNeo ds = new DsNeo();
                short i = short.Parse(lblVeterinario.Text);
                taEmpleado.FillByCodigo(ds.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, i);
                string nombre = ds.tbEmpleado.Rows[0]["Nombre"].ToString();
                cboVeterinario.Text = nombre;
                i = short.Parse(lblSucursal.Text);
                taSucursal.FillByCodigo(ds.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, i);
                nombre = ds.tbSucursal.Rows[0]["Nombre"].ToString();
                cboSucursal.Text = nombre;
                CargaContacto(int.Parse(lblCliente.Text));
                cita(codigo);
                this.Cursor = Cursors.Default;
            }
        }

        private void cita (int codigoMascota)
        {
            this.Cursor = Cursors.WaitCursor;
            bool? pendiente = null;
            if (cboPendiente.SelectedIndex == 1)
                pendiente = true;
            else if (cboPendiente.SelectedIndex == 2)
                pendiente = false;
            bool? activa = null;
            if (cboActiva.SelectedIndex == 1)
                activa = true;
            else if (cboActiva.SelectedIndex == 2)
                activa = false;
            taCitaMascota.Fill(dsNeo.tbCitaMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoMascota, pendiente, activa);
            this.Cursor = Cursors.Default;
        }

        private void cboPendiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
            {
                int codigo = int.Parse(grdMto.CurrentRow.Cells["mCodigo"].Value.ToString());
                cita(codigo);
            }
        }

        private void cboActiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
            {
                int codigo = int.Parse(grdMto.CurrentRow.Cells["mCodigo"].Value.ToString());
                cita(codigo);
            }
        }
    }
}
