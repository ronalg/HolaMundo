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
    public partial class FrmMtoCliente : Form
    {
        public FrmMtoCliente()
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

        private void tpPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMtoCliente_Load(object sender, EventArgs e)
        {
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);            
            taEstado.FillByTipo(dsNeo.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Estado Civil");
            taCliente.Fill(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                short codigo = short.Parse(lblCodigo.Text);
                taSucursalMiembro.Fill(dsNeo.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
            }
            else
            {
                taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0, "Cliente");
            }
            cboSucursal.Text = Utilidad.nombreSucursal;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            cboSexo.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboFactura.SelectedIndex = -1;
            cboRecibo.SelectedIndex = -1;
            cboPedido.SelectedIndex = -1;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblEquipo.Text = Environment.MachineName;
            lblApertura.Text = DateTime.Today.ToShortDateString();
            txtId.Focus();
            dsNeo.tbClienteSucursal.Rows.Clear();
            lblTipoEstado.Text = "Estado Civil";
            taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0, "Cliente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMtoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoCliente = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                txtId.Focus();
                ep.SetError(txtId, Utilidad.campoVacio);
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            if (cboSexo.SelectedIndex == -1)
            {
                cboSexo.Focus();
                ep.SetError(cboSexo, Utilidad.listaVacia);
                return;
            }

            if (cboEstadoCivil.SelectedIndex == -1)
            {
                cboEstadoCivil.Focus();
                ep.SetError(cboEstadoCivil, Utilidad.listaVacia);
                return;
            }

            if (cboSucursal.SelectedIndex == -1)
            {
                cboSucursal.Focus();
                ep.SetError(cboSucursal, Utilidad.listaVacia);
                return;
            }

            if (cboFactura.SelectedIndex == -1)
            {
                cboFactura.Focus();
                ep.SetError(cboFactura, Utilidad.listaVacia);
                return;
            }

            if (cboRecibo.SelectedIndex == -1)
            {
                cboRecibo.Focus();
                ep.SetError(cboRecibo, Utilidad.listaVacia);
                return;
            }

            if (cboPedido.SelectedIndex == -1)
            {
                cboPedido.Focus();
                ep.SetError(cboPedido, Utilidad.listaVacia);
                return;
            }

            try
            {
                short codigo;
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    codigo = Convert.ToInt16(cp.fnSiguienteNumero("cliente", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal).Value.ToString());
                    lblCodigo.Text = codigo.ToString();
                }
                else
                {
                    codigo = Convert.ToInt16(lblCodigo.Text);
                }
                short sucursal = short.Parse(cboSucursal.SelectedValue.ToString());
                decimal? limite = null;
                if (!string.IsNullOrEmpty(txtLimiteCredito.Text))
                    limite = decimal.Parse(txtLimiteCredito.Text);
                this.Validate();
                if (!btnNuevo.Available)
                {
                    taCliente.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, sucursal, cboEstadoCivil.Text, lblTipoEstado.Text, txtUserWeb.Text, txtId.Text.Trim(), txtCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), dtpNacimiento.Value.ToShortDateString(), lblApertura.Text, cboSexo.Text, txtCuentaContable.Text.Trim(), txtNota.Text.Trim(), chkActivo.Checked, Utilidad.nombreUsuario, lblEquipo.Text, limite, cboFactura.Text, cboRecibo.Text, cboPedido.Text);
                    ConfiguraBoton(true);
                }
                else
                {
                    taCliente.Edita(sucursal, cboEstadoCivil.Text, lblTipoEstado.Text, txtUserWeb.Text.Trim(), txtId.Text.Trim(), txtCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), dtpNacimiento.Value.ToShortDateString(), lblApertura.Text, cboSexo.Text, txtCuentaContable.Text.Trim(), txtNota.Text.Trim(), chkActivo.Checked, limite, cboFactura.Text, cboRecibo.Text, cboPedido.Text, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                }

                taIdentificacionMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                foreach (DataRow dr in dsNeo.fnIdentificacionMiembro)
                {
                    string codigoId = dr["CodigoIdentificacion"].ToString();
                    string identificacion = dr["Identificacion"].ToString();
                    if (!string.IsNullOrEmpty(identificacion))
                        taIdentificacionMiembro.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, codigoId, "Cliente", identificacion);
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
                        taIdentificacionMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                        taSucursalMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                        taCliente.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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
                short codigoCliente = short.Parse(lblCodigo.Text);
                short codigoSucursal = short.Parse(grdSucursal.CurrentRow.Cells["sCodigo"].Value.ToString());
                DsNeo ds = new DsNeo();
                taSucursalMiembro.FillByCodigo(ds.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, "Cliente");
                if (ds.tbClienteSucursal.Rows.Count > 0)
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
                    string nombreProvincia = ds.tbClienteSucursal.Rows[0]["NombreProvincia"].ToString();
                }
            }
        }

        private void grdSucursal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSucursal.CurrentRow != null && grdSucursal.CurrentRow.Cells["sNombrePais"].Selected == true)
            {
                DataGridViewComboBoxCell cb = grdSucursal.CurrentRow.Cells["sNombreProvincia"] as DataGridViewComboBoxCell;
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

        private void grdSucursal_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
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

        private void grdContacto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnNuevoSucursal_Click(object sender, EventArgs e)
        {
            short codigoCliente = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
            grdSucursal.CurrentRow.Cells["sCodigoTrabajo"].Value = Utilidad.codigoTrabajo;
            grdSucursal.CurrentRow.Cells["sCodigoEmpresa"].Value = Utilidad.codigoEmpresa;
            grdSucursal.CurrentRow.Cells["sCodigo"].Value = codigoCliente;
            DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
            short codigo = 0;
            grdSucursal.CurrentRow.Cells["sSecuencia"].Value = codigo;
        }

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
            {
                short codigo = short.Parse(grdSucursal.CurrentRow.Cells["sCodigo"].Value.ToString());
                short codigoCliente = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
                short secuencia = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(grdSucursal.CurrentRow.Cells["sSecuencia"].Value.ToString());
                DsNeo ds = new DsNeo();
                taSucursalMiembro.FillBySecuencia(ds.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente", secuencia);
                if (ds.tbClienteSucursal.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        //taClienteSucursalContacto.EliminaClienteSucursal(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, codigoSucursal);
                        taSucursalMiembro.EliminaSecuencia(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, secuencia, "Cliente");
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
                short codigoCliente = short.Parse(lblCodigo.Text);
                taClienteSucursalContacto.FillBySecuencia(dsNeo.tbClienteSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, codigoSucursal, secuencia);

                if (ds.tbClienteSucursalContacto.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        taClienteSucursalContacto.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, codigoSucursal, secuencia);
                        grdContacto.Rows.Remove(grdContacto.CurrentRow);
                    }
                }
                else
                {
                    grdContacto.Rows.Remove(grdContacto.CurrentRow);
                }
            }
        }

        private void cboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
                taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Convert.ToInt16(lblCodigo.Text) , "Cliente");
        }
    }
}
