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
    public partial class FrmMtoArticulo : Form
    {
        public FrmMtoArticulo()
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

        private void FrmMtoArticulo_Load(object sender, EventArgs e)
        {            
            taUnidad.Fill(dsNeo.tbUnidad, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taDepartamento.Fill(dsNeo.tbDepartamento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            taArticulo.Fill(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            if (grdMto.CurrentRow == null)
            {
                taArticuloPrecioVenta.Fill(dsNeo.tbArticuloPrecioVenta, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0);
                taArticuloProveedor.Fill(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0);
            }           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtId.Focus();
            taArticuloProveedor.Fill(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, 0);
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoTrabajo.ToString();
            cboDepartamento.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            dsNeo.tbArticuloMultimedia.Rows.Clear();
            foreach (DataRow dr in dsNeo.tbArticuloPrecioVenta)
            {
                dr["Precio"] = 0.00M;
                dr["AplicaOrdenPedido"] = false;
            }
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
            lblApertura.Text = DateTime.Today.ToShortDateString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            lblEquipo.Text = Environment.MachineName;
            tcArticulo.SelectedTab = tpPerfil;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                txtId.Focus();
                ep.SetError(txtId, Utilidad.campoVacio);
                return;
            }           

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                txtDescripcion.Focus();
                ep.SetError(txtDescripcion, Utilidad.campoVacio);
                return;
            }

            if (cboDepartamento.SelectedIndex == -1)
            {
                cboDepartamento.Focus();
                ep.SetError(cboDepartamento, Utilidad.listaVacia);
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
                this.Cursor = Cursors.WaitCursor;
                int codigoArticulo;
                if (!btnNuevo.Available)
                {
                    DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas();
                    codigoArticulo = cp.fnSiguienteNumero("articulo", Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null).Value;
                    lblCodigo.Text = codigoArticulo.ToString();
                }
                else
                {
                    codigoArticulo = Convert.ToInt32(lblCodigo.Text);
                }

                this.Validate();
                this.bsMto.EndEdit();

                byte[] caratula = null;
                if (pbCaratula.Image != null)
                {
                    Image img = pbCaratula.Image;
                    ImageConverter ic = new ImageConverter();
                    caratula = (byte[])ic.ConvertTo(img, typeof(byte[]));
                }

                decimal? existencia = null;
                if (!string.IsNullOrEmpty(txtExistencia.Text))
                    existencia = Convert.ToDecimal(txtExistencia.Text);

                if (!btnNuevo.Available)
                    taArticulo.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, cboCategoria.Text, cboDepartamento.Text, txtId.Text.Trim(), txtDescripcion.Text.Trim(), caratula, lblApertura.Text, lblUsuario.Text, chkActivo.Checked, lblEquipo.Text, existencia, chkInventario.Checked, chkOrdenPedido.Checked, chkInscripcion.Checked, chkVeterinaria.Checked);                   
                else
                    taArticulo.Edita(cboCategoria.Text, cboDepartamento.Text, txtId.Text.Trim(), txtDescripcion.Text.Trim(), caratula, existencia, chkInventario.Checked, chkActivo.Checked, chkOrdenPedido.Checked, chkInscripcion.Checked, chkVeterinaria.Checked, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo);
                
                DsNeo ds = new DsNeo();
                foreach (DataRow dr in dsNeo.tbArticuloPrecioVenta)
                {
                    string codigoPrecioVenta = dr["CodigoPrecioVenta"].ToString();
                    //string tmp = dr["Precio"].ToString();
                    decimal precio = Convert.ToDecimal(dr["Precio"].ToString());
                    bool aplicaOrdenPedido = Convert.ToBoolean(dr["AplicaOrdenPedido"].ToString());
                    taArticuloPrecioVenta.FillByCodigoPrecioVenta(ds.tbArticuloPrecioVenta, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, codigoPrecioVenta);
                    if (ds.tbArticuloPrecioVenta.Rows.Count == 0)
                        taArticuloPrecioVenta.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, codigoPrecioVenta, precio);
                    else
                        taArticuloPrecioVenta.Edita(precio, aplicaOrdenPedido, Utilidad.codigoEmpresa, Utilidad.codigoTrabajo, codigoArticulo, codigoPrecioVenta);
                }

                DsNeoTableAdapters.ConsultasProgramadas cpm = new DsNeoTableAdapters.ConsultasProgramadas();
                foreach (DataRow dr in dsNeo.tbArticuloMultimedia)
                {
                    short codigoMultimedia = short.Parse(dr["CodigoMultimedia"].ToString());
                    taArticuloMultimedia.FillByCodigo(ds.tbArticuloMultimedia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, codigoMultimedia);
                    if (ds.tbArticuloMultimedia.Rows.Count == 0)
                    {
                        byte[] imagen = null;
                        if (pbCaratula.Image != null)
                        {
                            ///Image img = dr["Imagen"];
                            ImageConverter ic = new ImageConverter();
                            imagen = (byte[])ic.ConvertTo(dr["Imagen"], typeof(byte[]));
                        }
                        codigoMultimedia = cpm.fnSiguienteArticuloMultimedia(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo).Value;
                        taArticuloMultimedia.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, codigoMultimedia, imagen);
                    }
                }

                taArticuloProveedor.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo);
                foreach (DataRow dr in dsNeo.tbArticuloProveedor)
                {
                    short codigoProveedor = short.Parse(dr["CodigoProveedor"].ToString());
                    string c = dr["Costo"].ToString();
                    decimal? costo = null;
                    bool? actual = false;
                    if (!string.IsNullOrEmpty(dr["Actual"].ToString()))
                        actual = Convert.ToBoolean(dr["Actual"].ToString());

                    if (!string.IsNullOrEmpty(c))
                    {
                        costo = Convert.ToDecimal(c);
                        taArticuloProveedor.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo, codigoProveedor, costo, actual);
                    }
                }

                if (!btnNuevo.Available)
                    ConfiguraBoton(true);                
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
            finally
            {
                this.Cursor = Cursors.Default;
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
                        int codigo = Convert.ToInt32(lblCodigo.Text);
                        taArticuloMultimedia.EliminaArticulo(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                        taArticuloPrecioVenta.EliminaArticulo(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                        taArticuloProveedor.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
                        taArticulo.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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

        private void FrmMtoArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoArticulo = null;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex > -1)
            {
                taCategoria.FillByDepartamento(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, cboDepartamento.Text);
                cboCategoria.SelectedIndex = -1;
            }
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null && !string.IsNullOrEmpty(grdMto.CurrentRow.Cells["aId"].Value.ToString()))
            {
                short codigoArticulo = short.Parse(grdMto.CurrentRow.Cells["aId"].Value.ToString());
                taArticuloPrecioVenta.Fill(dsNeo.tbArticuloPrecioVenta, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo);
                taArticuloProveedor.Fill(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoArticulo);
                if (cboCategoria.SelectedIndex == -1)
                    cboCategoria.Text = grdMto.CurrentRow.Cells["aNombreCategoria"].Value.ToString();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargaImagen(pbCaratula);
        }

        private void cargaImagen(PictureBox pb)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Imagenes (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
                pbCaratula.ImageLocation = of.FileName;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pbCaratula.Image = null;
        }

        private void btnNuevoMultimedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Imagenes (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                DsNeoTableAdapters.ConsultasProgramadas cp = new DsNeoTableAdapters.ConsultasProgramadas(); 
                Bitmap bmp = (Bitmap)Bitmap.FromFile(of.FileName);
                DataGridViewImageColumn iCell = new DataGridViewImageColumn();
                iCell.Image = bmp;
                int i = iCell.Image.Width;
                grdMultimedia.CurrentRow.Cells["mCodigo"].Value = 0;
                grdMultimedia.CurrentRow.Cells["mImagen"].Value = iCell;
            }
        }

        private void grdMultimedia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public byte[] ReadImageFile(string imageLocation)
        {
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }

        private void grdProveedor_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = grdProveedor.CurrentRow.Cells[e.ColumnIndex].OwningColumn.Name;
            if (nombre == "pActual")
            {
                string tmp = grdProveedor.CurrentRow.Cells[nombre].Value.ToString();
                bool actual = string.IsNullOrEmpty(tmp) ? false : Convert.ToBoolean(tmp);
                if (actual)
                {
                    foreach (DataGridViewRow dgvr in grdProveedor.Rows)
                    {
                        if (dgvr != grdProveedor.CurrentRow)
                            dgvr.Cells[nombre].Value = false;
                    }
                }
            }
        }

        private void kryptonLabel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tpPerfil_Click(object sender, EventArgs e)
        {

        }

        private void grdPrecio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
