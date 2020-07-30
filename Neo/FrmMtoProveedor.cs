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
            cboIdentificacion.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            dsNeo.tbProveedorSucursal.Rows.Clear();
            dsNeo.tbProveedorSucursalContacto.Rows.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtRazonSocial.Text))
            {
                txtRazonSocial.Focus();
                ep.SetError(txtRazonSocial, Utilidad.campoVacio);
                return;
            }

            if (cboIdentificacion.SelectedIndex == -1)
            {
                cboIdentificacion.Focus();
                ep.SetError(cboIdentificacion, Utilidad.listaVacia);
                return;
            }

            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                txtIdentificacion.Focus();
                ep.SetError(txtIdentificacion, Utilidad.campoVacio);
                return;
            }

            if (cboCategoria.SelectedIndex == -1)
            {
                cboCategoria.Focus();
                ep.SetError(cboCategoria, Utilidad.listaVacia);
                return;
            }

            try
            {
                this.Validate();
                
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    int codigo = cp.fnSiguienteNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "proveedor", null).Value;
                    lblCodigo.Text = codigo.ToString();
                }

                this.bsMto.EndEdit();

                if (!btnNuevo.Available)
                {
                    taProveedor.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text), cboIdentificacion.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), cboCategoria.Text, txtIdentificacion.Text.Trim(), txtCuenta.Text.Trim(), txtSitioWeb.Text.Trim(), lblGrabada.Text, lblUsuario.Text, lblEquipo.Text, chkActivo.Checked);                   
                    ConfiguraBoton(true);
                }
                else
                {
                    taProveedor.Edita(cboIdentificacion.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), txtIdentificacion.Text, txtCuenta.Text.Trim(), txtSitioWeb.Text.Trim(), chkActivo.Checked, cboCategoria.Text, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, short.Parse(lblCodigo.Text)); 
                }

                short proveedor = short.Parse(lblCodigo.Text);

                foreach (DataGridViewRow dgvr in grdSucursal.Rows)
                {                    
                    short codigo = short.Parse(dgvr.Cells["sCodigo"].Value.ToString());
                    string pais = dgvr.Cells["sCodigoPais"].Value.ToString();
                    string provincia = dgvr.Cells["sProvincia"].Value.ToString();
                    string nombre = dgvr.Cells["sNombre"].Value.ToString();
                    string codigoPostal = dgvr.Cells["sCodigoPostal"].Value.ToString();
                    string direccion = dgvr.Cells["sDireccion"].Value.ToString();
                    string representante = dgvr.Cells["sRepresentante"].Value.ToString();
                    DsNeo ds = new DsNeo();
                    taProveedorSucursal.FillByCodigoSucursal(ds.tbProveedorSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigo);
                    if (ds.tbProveedorSucursal.Rows.Count == 0)
                        taProveedorSucursal.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigo, pais, provincia, nombre, codigoPostal, direccion, representante);
                    else
                        taProveedorSucursal.Edita(pais, provincia, nombre, codigoPostal, direccion, representante, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigo);
                }

                foreach (DataGridViewRow dgvr in grdContacto.Rows)
                {
                    short secuencia = short.Parse(dgvr.Cells["cOrden"].Value.ToString());
                    short codigoSucursal = short.Parse(dgvr.Cells["cSucursal"].Value.ToString());
                    string tipo = dgvr.Cells["cTipo"].Value.ToString();
                    string nombreContacto = dgvr.Cells["cNombre"].Value.ToString();
                    string contacto = dgvr.Cells["cContacto"].Value.ToString();
                    DsNeo ds = new DsNeo();
                    taProveedorSucursalContacto.FillBySecuencia(ds.tbProveedorSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigoSucursal, secuencia);
                    if (ds.tbProveedorSucursalContacto.Rows.Count == 0)
                        taProveedorSucursalContacto.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigoSucursal, secuencia, tipo, nombreContacto, contacto);
                    else
                        taProveedorSucursalContacto.Edita(tipo, nombreContacto, contacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, proveedor, codigoSucursal, secuencia);
                }
                this.FrmMtoProveedor_Load(sender, EventArgs.Empty);
                return;
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
                        short codigoProveedor = short.Parse(lblCodigo.Text);
                        taProveedorSucursalContacto.EliminaProveedor(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor);
                        taProveedorSucursal.EliminaProveedor(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor);
                        taProveedor.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor);                        
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
            cboIdentificacion.SelectedIndex = -1;
            taCategoria.Fill(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taProveedor.Fill(dsNeo.tbProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                short codigo = short.Parse(lblCodigo.Text);
                taProveedorSucursal.FillByCodigo(dsNeo.tbProveedorSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                taProveedorSucursalContacto.FillByProveedor(dsNeo.tbProveedorSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
            }
        }

        private void btnNuevoSucursal_Click(object sender, EventArgs e)
        {
            short codigoProveedor = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
            grdSucursal.CurrentRow.Cells["sTrabajo"].Value = Utilidad.codigoTrabajo;
            grdSucursal.CurrentRow.Cells["sEmpresa"].Value = Utilidad.codigoEmpresa;
            grdSucursal.CurrentRow.Cells["sProveedor"].Value = codigoProveedor;
            DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
            short codigo = cp.fnSiguienteProveedorSucursal(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor).Value;
            grdSucursal.CurrentRow.Cells["sCodigo"].Value = codigo;
        }

        private void grdSucursal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSucursal.CurrentRow != null)
                {
                    DataGridViewComboBoxCell cb = grdContacto.CurrentRow.Cells["cNombre"] as DataGridViewComboBoxCell;
                    taContacto.Fill(dsNeo.tbContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
                    foreach (DataRow dr in dsNeo.tbContacto)
                    {
                        string nombre = dr["NombreContacto"].ToString();
                        cb.Items.Add(nombre);
                    }
                    short codigoProveedor = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
                    short codigoSucursal = short.Parse(grdSucursal.CurrentRow.Cells["sCodigo"].Value.ToString());
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    short orden = cp.fnSiguienteProveedorSucursalContacto(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal).Value;
                    grdContacto.CurrentRow.Cells["cEmpresa"].Value = Utilidad.codigoEmpresa;
                    grdContacto.CurrentRow.Cells["cSucursal"].Value = codigoSucursal;
                    grdContacto.CurrentRow.Cells["cProveedor"].Value = codigoProveedor;
                    grdContacto.CurrentRow.Cells["cOrden"].Value = orden;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            if (grdSucursal.CurrentRow != null && grdSucursal.CurrentRow.Cells["sNombrePais"].Selected == true)
            {
                DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sProvincia"] as DataGridViewComboBoxCell;
                string nombrePais = grdSucursal.CurrentRow.Cells["sNombrePais"].Value.ToString();
                DsNeo ds = new DsNeo();
                taPais.FillByNombre(ds.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombrePais);
                string codigoPais = ds.tbPais.Rows[0]["CodigoPais"].ToString();
                grdSucursal.CurrentRow.Cells["sCodigoPais"].Value = codigoPais;
                taProvincia.FillByPais(ds.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoPais);
                cb.Items.Clear();
                foreach (DataRow dr in ds.tbProvincia.Rows)
                {
                    string nombreProvincia = dr["NombreProvincia"].ToString();
                    cb.Items.Add(nombreProvincia);
                }
            }
        }

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
            {
                short codigoSucursal = short.Parse(grdSucursal.CurrentRow.Cells["sCodigo"].Value.ToString());
                short codigoProveedor = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
                DsNeo ds = new DsNeo();
                taProveedorSucursal.FillByCodigoSucursal(ds.tbProveedorSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal);
                if (ds.tbProveedorSucursal.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        taProveedorSucursalContacto.EliminaSucursal(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal);
                        taProveedorSucursal.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal);
                        grdSucursal.Rows.Remove(grdSucursal.CurrentRow);
                    }                                        
                }
                else
                {
                    grdSucursal.Rows.Remove(grdSucursal.CurrentRow);
                }
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (grdContacto.CurrentRow != null)
            {
                DsNeo ds = new DsNeo();
                short secuencia = short.Parse(grdContacto.CurrentRow.Cells["cOrden"].Value.ToString());
                short codigoSucursal = short.Parse(grdContacto.CurrentRow.Cells["cSucursal"].Value.ToString());
                short codigoProveedor = short.Parse(lblCodigo.Text);
                taProveedorSucursalContacto.FillBySecuencia(ds.tbProveedorSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal, secuencia);

                if (ds.tbProveedorSucursalContacto.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        taProveedorSucursalContacto.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal, secuencia);
                        grdContacto.Rows.Remove(grdContacto.CurrentRow);
                    }
                }
                else
                {
                    grdContacto.Rows.Remove(grdContacto.CurrentRow);
                }                
            }
        }       

        private void grdSucursal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string nombreColumna = grdSucursal.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;
            if (nombreColumna == "sNombrePais")
            {
                DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells[nombreColumna] as DataGridViewComboBoxCell;
                if (cb.Items.Count == 0)
                {
                    DsNeo ds = new DsNeo();
                    taPais.Fill(ds.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
                    foreach (DataRow dr in ds.tbPais)
                    {
                        string nombrePais = dr["Nombre"].ToString();
                        cb.Items.Add(nombrePais);
                    }

                    if (!string.IsNullOrEmpty(lblCodigo.Text) && !string.IsNullOrEmpty(grdSucursal.CurrentRow.Cells["sCodigoPais"].Value.ToString()))
                    {
                        string codigoPais = grdSucursal.CurrentRow.Cells["sCodigoPais"].Value.ToString();
                        taPais.FillByCodigo(ds.tbPais, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoPais);
                        string nombre = ds.tbPais.Rows[0]["Nombre"].ToString();
                        grdSucursal.CurrentRow.Cells["sNombrePais"].Value = nombre;
                    }
                }
            }
            else if (nombreColumna == "sProvincia" && !string.IsNullOrEmpty(lblCodigo.Text) && !string.IsNullOrEmpty(grdSucursal.CurrentRow.Cells["sCodigoPais"].Value.ToString()))
            {
                short codigoProveedor = short.Parse(lblCodigo.Text);
                short codigoSucursal = short.Parse(grdSucursal.CurrentRow.Cells["sCodigo"].Value.ToString());
                DsNeo ds = new DsNeo();
                taProveedorSucursal.FillByCodigoSucursal(ds.tbProveedorSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal);
                if (ds.tbProveedorSucursal.Rows.Count > 0)
                {
                    string codigoPais = grdSucursal.CurrentRow.Cells["sCodigoPais"].Value.ToString();
                    taProvincia.FillByPais(ds.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoPais);
                    DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sProvincia"] as DataGridViewComboBoxCell;
                    int i = cb.Items.Count;
                    int j = ds.tbProvincia.Rows.Count;
                    if (i != j)
                    {
                        foreach (DataRow dr in ds.tbProvincia.Rows)
                        {
                            string nombrePronvincia = dr["NombreProvincia"].ToString();
                            cb.Items.Add(nombrePronvincia);
                        }
                    }
                    string nombreProvincia = ds.tbProveedorSucursal.Rows[0]["NombreProvincia"].ToString();
                }
            }        
        }

        private void grdContacto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string nombre = grdContacto.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;
            if (nombre == "cNombre")
            {
                DataGridViewComboBoxCell cb = grdContacto.CurrentRow.Cells["cNombre"] as DataGridViewComboBoxCell;
                if (cb.Items.Count == 0)
                {
                    taContacto.Fill(dsNeo.tbContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
                    foreach (DataRow dr in dsNeo.tbContacto)
                    {
                        nombre = dr["NombreContacto"].ToString();
                        cb.Items.Add(nombre);
                    }

                    cb = grdContacto.Rows[e.RowIndex].Cells["cTipo"] as DataGridViewComboBoxCell;
                    string contacto = grdContacto.Rows[e.RowIndex].Cells["cNombre"].ToString();
                    taTipoContacto.FillByContacto(dsNeo.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, contacto);
                }
            }
            else if (nombre == "cTipo")
            {
                string contacto = grdContacto.Rows[e.RowIndex].Cells["cNombre"].Value.ToString();
                DsNeo ds = new DsNeo();
                taTipoContacto.FillByContacto(ds.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, contacto);
                DataGridViewComboBoxCell cb = grdContacto.Rows[e.RowIndex].Cells["cTipo"] as DataGridViewComboBoxCell;
                int i = cb.Items.Count;
                int j = ds.tbTipoContacto.Rows.Count;

                if (i != j)
                {
                    foreach (DataRow dr in ds.tbTipoContacto.Rows)
                    {
                        string n = dr["NombreTipoContacto"].ToString();
                        cb.Items.Add(n);
                    }
                }
            }        
        }

        private void grdContacto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdContacto.CurrentRow != null && grdContacto.CurrentRow.Cells["cNombre"].Selected == true)
            {
                DataGridViewComboBoxCell cb = grdContacto.CurrentRow.Cells["cTipo"] as DataGridViewComboBoxCell;
                DsNeo ds = new DsNeo();
                string nombreContacto = grdContacto.CurrentRow.Cells["cNombre"].Value.ToString();
                taTipoContacto.FillByContacto(ds.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombreContacto);
                foreach (DataRow dr in ds.tbTipoContacto.Rows)
                {
                    string nombreTipo = dr["NombreTipoContacto"].ToString();
                    cb.Items.Add(nombreTipo);
                }
            }
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                short codigoProveedor = short.Parse(grdMto.CurrentRow.Cells["pCodigo"].Value.ToString());
                taProveedorSucursal.FillByProveedor(dsNeo.tbProveedorSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor);
                if (dsNeo.tbProveedorSucursal.Rows.Count > 0)
                {
                    short codigoSucursal = short.Parse(dsNeo.tbProveedorSucursal.Rows[0]["CodigoProveedorSucursal"].ToString());
                    taProveedorSucursalContacto.FillByProveedorSucursal(dsNeo.tbProveedorSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoProveedor, codigoSucursal);
                }
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                txtRazonSocial.Text = txtNombre.Text.Trim();            
        }
    }
}
