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
        const string tipoMiembro = "Proveedor";

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
                    int codigo = cp.fnSiguienteNumero("proveedor", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null).Value;
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
                        //taIdentificacionMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                        taSucursalMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                        taProveedor.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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
            taTipoContacto.Fill(dsNeo.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taProvincia.Fill(dsNeo.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taIdentificacion.Fill(dsNeo.tbIdentificacion, Utilidad.codigoTrabajo);
            cboIdentificacion.SelectedIndex = -1;
            taCategoria.Fill(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taProveedor.Fill(dsNeo.tbProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);           
        }

        private void btnNuevoSucursal_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNeo.tbSucursalMiembro.NewRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["Codigo"] = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text); ;
            dr["Tipo"] = tipoMiembro;
            dr["Secuencia"] = Utilidad.ValoMaxGrilla(grdSucursal, "sSecuencia"); ;
            dr["CodigoPais"] = null;
            dr["NombreProvincia"] = null;
            dr["Nombre"] = null;
            dr["CodigoPostal"] = null;
            dr["Direccion"] = null;
            dr["Representante"] = null;
            dsNeo.tbSucursalMiembro.Rows.Add(dr);

            grdSucursal.Rows[grdSucursal.RowCount - 1].Cells["sNombre"].Selected = true;
            grdSucursal.BeginEdit(true);
            seleccionContacto();

        }

        private void grdSucursal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNeo.tbContactoMiembro.NewRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["Codigo"] = string.IsNullOrEmpty(lblCodigo.Text) ? "0" : lblCodigo.Text;
            dr["Secuencia"] = grdSucursal.CurrentRow.Cells["sSecuencia"].Value; ;
            dr["Tipo"] = tipoMiembro;
            dr["NombreContacto"] = null;
            dr["NombreTipoContacto"] = null;
            dr["Contacto"] = null;

            int orden = 0;
            short secuencia = Convert.ToInt16(grdSucursal.CurrentRow.Cells["sSecuencia"].Value.ToString());
            int filas = grdContacto.Rows.Count - 1;
            if (filas >= 0)
            {
                for (int i = 0; i < grdContacto.Rows.Count; i++)
                {
                    short sec = Convert.ToInt16(grdContacto.Rows[i].Cells["cSecuencia"].Value.ToString());
                    if (sec == secuencia)
                    {
                        int valor1 = Convert.ToInt32(grdContacto.Rows[i].Cells["cOrden"].Value.ToString());
                        orden = valor1;
                        for (int j = i; j < grdContacto.Rows.Count; j++)
                        {
                            sec = Convert.ToInt16(grdContacto.Rows[j].Cells["cSecuencia"].Value.ToString());
                            if (secuencia == sec && !string.IsNullOrEmpty(grdContacto.Rows[j].Cells["cOrden"].Value.ToString()))
                            {
                                int valor2 = Convert.ToInt32(grdContacto.Rows[j].Cells["cOrden"].Value.ToString());
                                if (valor2 > valor1)
                                    orden = valor2;
                            }
                        }
                    }
                }
                orden++;
            }
            else
            {
                orden++;
            }
            dr["Orden"] = orden;

            dsNeo.tbContactoMiembro.Rows.Add(dr);
            grdContacto.Rows[grdContacto.RowCount - 1].Cells["cNombre"].Selected = true;
            pnlTipoContacto.Visible = true;
            grdProvincia.Focus();
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
                short codigoCliente = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text);
                short secuencia = short.Parse(grdSucursal.CurrentRow.Cells["sSecuencia"].Value.ToString());
                DsNeo ds = new DsNeo();
                taSucursalMiembro.FillBySecuencia(ds.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, tipoMiembro, secuencia);
                if (ds.tbSucursalMiembro.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        taContactoMiembro.EliminaSecuencia(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, secuencia, tipoMiembro);
                        taContactoMiembro.Fill(dsNeo.tbContactoMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, tipoMiembro);
                        taSucursalMiembro.EliminaSecuencia(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, secuencia, tipoMiembro);
                        taSucursalMiembro.FillByCodigo(dsNeo.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente, tipoMiembro);
                    }
                }
                else
                {
                    foreach (DataGridViewRow dgvr in grdContacto.Rows)
                    {
                        short sec = Convert.ToInt16(dgvr.Cells["cSecuencia"].Value.ToString());
                        if (secuencia == sec)
                            grdContacto.Rows.Remove(dgvr);
                    }
                    grdSucursal.Rows.Remove(grdSucursal.CurrentRow);
                }
            }

        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (grdContacto.CurrentRow != null)
            {
                short secuencia = short.Parse(grdContacto.CurrentRow.Cells["cSecuencia"].Value.ToString());
                short orden = short.Parse(grdContacto.CurrentRow.Cells["cOrden"].Value.ToString());
                short codigo = short.Parse(lblCodigo.Text);

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.nombreUsuario, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    taContactoMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, secuencia, orden, tipoMiembro);
                    grdContacto.Rows.Remove(grdContacto.CurrentRow);
                }
                else
                {
                    grdContacto.Rows.Remove(grdContacto.CurrentRow);
                }
            }
        }       

        private void grdSucursal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
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
                short codigo = Convert.ToInt16(lblCodigo.Text);
                taSucursalMiembro.Fill(dsNeo.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                taContactoMiembro.Fill(dsNeo.tbContactoMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                //taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
            }

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
                txtRazonSocial.Text = txtNombre.Text.Trim();            
        }

        private void grdSucursal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
            {
                string nombre = grdSucursal.CurrentRow.Cells[e.ColumnIndex].OwningColumn.Name;
                if (nombre == "sCodigoPais" || nombre == "sNombreProvincia")
                {
                    pnlProvincia.Visible = true;
                    grdProvincia.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe provincia registradas", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void seleccionContacto()
        {
            string secuencia = grdSucursal.CurrentRow.Cells["sSecuencia"].Value.ToString();
            foreach (DataGridViewRow dgvr in grdContacto.Rows)
            {
                string tmp = dgvr.Cells["cSecuencia"].Value.ToString();
                dgvr.DefaultCellStyle.BackColor = secuencia == tmp ? Color.CadetBlue : Color.White;
            }
        }

        private void grdContacto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdContacto.CurrentRow != null)
            {
                string nombre = grdContacto.CurrentRow.Cells[e.ColumnIndex].OwningColumn.Name;
                if (nombre == "cNombre" || nombre == "cTipoContacto")
                {
                    pnlTipoContacto.Visible = true;
                    grdTipoContacto.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe tipo de contacto registrados", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void grdSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
                seleccionContacto();
        }

        private void grdSucursal_DoubleClick(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
                pnlProvincia.Visible = true;
        }
    }
}
