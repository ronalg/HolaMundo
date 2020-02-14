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
    public partial class FrmMtoProveedor : Form
    {
        public FrmMtoProveedor()
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
            txtNombre.Focus();
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblEquipo.Text = Environment.MachineName;
            lblGrabada.Text = DateTime.Today.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.consultasProgramadas cp = new DsNeoTableAdapters.consultasProgramadas();
                    int codigo = cp.fnSiguienteNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "proveedor").Value;
                    lblCodigo.Text = codigo.ToString();
                }

                this.bsMto.EndEdit();

                if (!btnNuevo.Available)
                {
                    taProveedor.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text), cboIdentificacion.Text, cboCategoria.Text, cboTipoCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), txtIdentificacion.Text.Trim(), txtCuenta.Text.Trim(), txtSitioWeb.Text.Trim(), lblGrabada.Text, lblUsuario.Text, lblEquipo.Text, chkActivo.Checked);
                    ConfiguraBoton(true);
                }
                else
                {
                    taProveedor.Edita(cboIdentificacion.Text, cboCategoria.Text, cboTipoCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), txtIdentificacion.Text, txtCuenta.Text.Trim(), txtSitioWeb.Text.Trim(), chkActivo.Checked, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text)); 
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
                        taProveedor.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text));
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

        private void FrmMtoProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoProveedor = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMtoProveedor_Load(object sender, EventArgs e)
        {
            taIdentificacion.Fill(dsNeo.tbIdentificacion, Utilidad.codigoTrabajo);
            taTipoCategoria.Fill(dsNeo.tbTipoCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboIdentificacion.SelectedIndex = -1;
            cboTipoCategoria.SelectedIndex = -1;
            taCategoria.Fill(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taProveedor.Fill(dsNeo.tbProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void cboTipoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            taCategoria.FillByTipo(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "CLIENTE");
            //cboCategoria.SelectedIndex = -1;
        }

        private void btnNuevoSucursal_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sPais"] as DataGridViewComboBoxCell;
            taPais.Fill(dsNeo.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            foreach (DataRow dr in dsNeo.tbPais)
            {
                string nombre = dr["Nombre"].ToString();
                cb.Items.Add(nombre);
            }            
        }

        private void grdSucursal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre = grdSucursal.Columns[e.ColumnIndex].Name;
            if (nombre == "sProvincia")
            {
                DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sProvincia"] as DataGridViewComboBoxCell;
                cb.Items.Clear();
                nombre = grdSucursal.CurrentRow.Cells["sPais"].Value.ToString();
                taPais.FillByNombre(dsNeo.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                string codigo = dsNeo.tbPais.Rows[0]["CodigoPais"].ToString();
                taProvincia.FillByPais(dsNeo.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                foreach (DataRow dr in dsNeo.tbProvincia.Rows)
                {
                    nombre = dr["NombreProvincia"].ToString();
                    cb.Items.Add(nombre);
                }
            }
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cb = grdContacto.CurrentRow.Cells["cNombre"] as DataGridViewComboBoxCell;
            taContacto.Fill(dsNeo.tbContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            foreach (DataRow dr in dsNeo.tbContacto)
            {
                string nombre = dr["NombreContacto"].ToString();
                cb.Items.Add(nombre);
            }
        }

        private void grdContacto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre = grdContacto.Columns[e.ColumnIndex].Name;
            if (nombre == "cTipo")
            {
                DataGridViewComboBoxCell cb = grdContacto.CurrentRow.Cells["cTipo"] as DataGridViewComboBoxCell;
                cb.Items.Clear();
                nombre = grdContacto.CurrentRow.Cells["cNombre"].Value.ToString();
                taTipoContacto.FillByContacto(dsNeo.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                foreach (DataRow dr in dsNeo.tbTipoContacto)
                {
                    nombre = dr["NombreTipoContacto"].ToString();
                    cb.Items.Add(nombre);
                }
            }
        }

        private void grdSucursal_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void grdContacto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void grdSucursal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSucursal.CurrentRow != null && grdSucursal.CurrentRow.Cells["sProvincia"].Value != null && grdSucursal.CurrentRow.Cells["sPais"].Selected == true)
            {
                DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sProvincia"] as DataGridViewComboBoxCell;
                cb.Items.Clear();
            }
        }
    }
}
