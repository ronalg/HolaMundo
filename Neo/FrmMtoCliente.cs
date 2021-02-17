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
        const string tipoMiembro = "Cliente";
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

        private void FrmMtoCliente_Load(object sender, EventArgs e)
        {
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Vendedor");
            taTipoContacto.Fill(dsNeo.tbTipoContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taProvincia.Fill(dsNeo.tbProvincia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taEstado.FillByTipo(dsNeo.tbEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Estado Civil");
            taCliente.Fill(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            if (string.IsNullOrEmpty(lblCodigo.Text))
                taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0, tipoMiembro);                
            cboSucursal.Text = Utilidad.nombreSucursal;
        }

        public void btnNuevo_Click(object sender, EventArgs e)
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
            dsNeo.tbSucursalMiembro.Rows.Clear();
            dsNeo.tbContactoMiembro.Rows.Clear();
            lblTipoEstado.Text = "Estado Civil";
            taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0, tipoMiembro);
            tcMto.SelectedTab = tpPerfil;
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

            if (cboVendedor.SelectedIndex == -1)
            {
                cboVendedor.Focus();
                ep.SetError(cboVendedor, Utilidad.listaVacia);
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

            foreach (DataGridViewRow dgvr in grdSucursal.Rows)
            {
                string codigoPais = dgvr.Cells["sCodigoPais"].Value.ToString();
                string nombrePronvicia = dgvr.Cells["sNombreProvincia"].Value.ToString();
                string nombre = dgvr.Cells["sNombre"].Value.ToString();

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Falta ingresar nombre de sucursal", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["sNombre"].Selected = true;
                    return;
                }

                if (string.IsNullOrEmpty(codigoPais))
                {
                    MessageBox.Show("Falta ingresar país de sucursal", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["sCodigoPais"].Selected = true;
                    return;
                }

                if (string.IsNullOrEmpty(nombrePronvicia))
                {
                    MessageBox.Show("Falta ingresar provincia de sucursal", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["sNombreProvincia"].Selected = true;
                    return;
                }
            }

            foreach (DataGridViewRow dgvr in grdContacto.Rows)
            {
                string nombre = dgvr.Cells["cNombre"].Value.ToString();
                string tipo = dgvr.Cells["cTipoContacto"].Value.ToString();
                string contacto = dgvr.Cells["cContacto"].Value.ToString();

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Falta ingresar nombre de contacto", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["cNombre"].Selected = true;
                    return;
                }

                if (string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Falta ingresar tipo de contacto", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["cTipoContacto"].Selected = true;
                    return;
                }

                if (string.IsNullOrEmpty(contacto))
                {
                    MessageBox.Show("Falta ingresar contacto", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgvr.Cells["cContacto"].Selected = true;
                    return;
                }
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
                short vendedor = short.Parse(cboVendedor.Text);
                this.Validate();
                if (!btnNuevo.Available)
                {
                    taCliente.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, sucursal, cboEstadoCivil.Text, lblTipoEstado.Text, txtUserWeb.Text, txtId.Text.Trim(), cboCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), dtpNacimiento.Value.ToShortDateString(), lblApertura.Text, cboSexo.Text, txtCuentaContable.Text.Trim(), txtNota.Text.Trim(), chkActivo.Checked, Utilidad.nombreUsuario, lblEquipo.Text, limite, cboFactura.Text, cboRecibo.Text, cboPedido.Text, vendedor);
                    ConfiguraBoton(true);
                }
                else
                {
                    taCliente.Edita(sucursal, cboEstadoCivil.Text, lblTipoEstado.Text, txtUserWeb.Text.Trim(), txtId.Text.Trim(), cboCategoria.Text, txtNombre.Text.Trim(), txtRazonSocial.Text.Trim(), dtpNacimiento.Value.ToShortDateString(), lblApertura.Text, cboSexo.Text, txtCuentaContable.Text.Trim(), txtNota.Text.Trim(), chkActivo.Checked, limite, cboFactura.Text, cboRecibo.Text, cboPedido.Text, vendedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                }               

                foreach (DataGridViewRow dgvr in grdSucursal.Rows)
                {
                    short secuencia = Convert.ToInt16(dgvr.Cells["sSecuencia"].Value.ToString());
                    string codigoPais = dgvr.Cells["sCodigoPais"].Value.ToString();
                    string nombrePronvicia = dgvr.Cells["sNombreProvincia"].Value.ToString();
                    string nombre = dgvr.Cells["sNombre"].Value.ToString();
                    string codigoPostal = dgvr.Cells["sCodigoPostal"].Value.ToString();
                    string direccion = dgvr.Cells["sDireccion"].Value.ToString();
                    string representante = dgvr.Cells["sRepresentante"].Value.ToString();

                    DsNeo ds = new DsNeo();
                    taSucursalMiembro.FillBySecuencia(ds.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro, secuencia);
                    if (ds.tbSucursalMiembro.Rows.Count == 0)
                        taSucursalMiembro.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, secuencia, tipoMiembro, codigoPais, nombrePronvicia, nombre, codigoPostal, direccion, representante);
                    else
                        taSucursalMiembro.Edita(codigoPais, nombrePronvicia, nombre, codigoPostal, direccion, representante, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, secuencia, "Cliente");
                }

                taContactoMiembro.EliminaCodigo(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                foreach (DataGridViewRow dgvr in grdContacto.Rows)
                {
                    short secuencia = Convert.ToInt16(dgvr.Cells["cSecuencia"].Value.ToString());
                    short orden = Convert.ToInt16(dgvr.Cells["cOrden"].Value.ToString());
                    string nombreContacto = dgvr.Cells["cNombre"].Value.ToString();
                    string tipoContacto = dgvr.Cells["cTipoContacto"].Value.ToString();
                    string contacto = dgvr.Cells["cContacto"].Value.ToString();
                    taContactoMiembro.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, secuencia, tipoMiembro, orden, nombreContacto, tipoContacto, contacto);
                }

                taIdentificacionMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                foreach (DataRow dr in dsNeo.fnIdentificacionMiembro)
                {
                    string codigoId = dr["CodigoIdentificacion"].ToString();
                    string nacionalodad = dr["NombreNacionalidad"].ToString();
                    string identificacion = dr["Identificacion"].ToString();
                    if (!string.IsNullOrEmpty(identificacion))
                        taIdentificacionMiembro.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, codigoId, nacionalodad, tipoMiembro, identificacion);
                }

                if (this.Text == "Mascota")
                {
                    Utilidad.mtoMascota.lblCliente.Text = lblCodigo.Text;
                    Utilidad.mtoMascota.lblDueno.Text = txtNombre.Text.Trim();
                    Utilidad.mtoMascota.CargaContacto(int.Parse(lblCodigo.Text));
                    this.Close();
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
                        taIdentificacionMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                        taContactoMiembro.EliminaCodigo(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                        taSucursalMiembro.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
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
        }

        private void grdSucursal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void grdSucursal_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        private void grdContacto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void grdContacto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        private void btnNuevoSucursal_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNeo.tbSucursalMiembro.NewRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;            
            dr["Codigo"] = string.IsNullOrEmpty(lblCodigo.Text) ? short.Parse("0") : short.Parse(lblCodigo.Text); 
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

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                short codigo = Convert.ToInt16(lblCodigo.Text);
                taSucursalMiembro.Fill(dsNeo.tbSucursalMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                taContactoMiembro.Fill(dsNeo.tbContactoMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
                taIdentificacionMiembro.Fill(dsNeo.fnIdentificacionMiembro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, tipoMiembro);
            }
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

        private void seleccionContacto ()
        {
            string secuencia = grdSucursal.CurrentRow.Cells["sSecuencia"].Value.ToString();
            foreach (DataGridViewRow dgvr in grdContacto.Rows)
            {
                string tmp = dgvr.Cells["cSecuencia"].Value.ToString();
                dgvr.DefaultCellStyle.BackColor = secuencia == tmp ? Color.CadetBlue : Color.White;                
            }
        }      

        private void grdSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
              seleccionContacto();
        }

        private void btnProvinciaCancelar_Click(object sender, EventArgs e)
        {
            pnlProvincia.Visible = false;
        }

        private void btnProvinciaAceptar_Click(object sender, EventArgs e)
        {
            string pais = grdProvincia.CurrentRow.Cells["pPais"].Value.ToString();
            string provincia = grdProvincia.CurrentRow.Cells["pProvincia"].Value.ToString();
            grdSucursal.CurrentRow.Cells["sCodigoPais"].Value = pais;
            grdSucursal.CurrentRow.Cells["sNombreProvincia"].Value = provincia;
            pnlProvincia.Visible = false;
            grdSucursal.CurrentRow.Cells["sCodigoPostal"].Selected = true;
            grdSucursal.BeginEdit(true);
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

        private void grdProvincia_DoubleClick(object sender, EventArgs e)
        {
            btnProvinciaAceptar_Click(sender, EventArgs.Empty);
        }

        private void btnTipoContactoCancelar_Click(object sender, EventArgs e)
        {
            pnlTipoContacto.Visible = false;
        }

        private void btnTipoContactoAceptar_Click(object sender, EventArgs e)
        {
            string nombre = grdTipoContacto.CurrentRow.Cells["tcNombre"].Value.ToString();
            string tipo = grdTipoContacto.CurrentRow.Cells["tcTipo"].Value.ToString();
            grdContacto.CurrentRow.Cells["cNombre"].Value = nombre;
            grdContacto.CurrentRow.Cells["cTipoContacto"].Value = tipo;
            pnlTipoContacto.Visible = false;
            grdContacto.CurrentRow.Cells["cContacto"].Selected = true;
            grdContacto.BeginEdit(true);
        }

        private void grdContacto_DoubleClick(object sender, EventArgs e)
        {
            if (grdContacto.CurrentRow != null)
                pnlTipoContacto.Visible = true;
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

        private void grdTipoContacto_DoubleClick(object sender, EventArgs e)
        {
            btnTipoContactoAceptar_Click(sender, EventArgs.Empty);
        }

        private void grdSucursal_DoubleClick(object sender, EventArgs e)
        {
            if (grdSucursal.CurrentRow != null)
                pnlProvincia.Visible = true;
        }

        private void kryptonLabel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}
