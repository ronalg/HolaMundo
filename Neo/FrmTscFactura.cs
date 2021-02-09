using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    public partial class FrmTscFactura : Form
    {
        public FrmTscFactura()
        {
            InitializeComponent();
        }

        private void txtBuscaMascota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusca.Text.Trim()))            
                grdCliente.Visible = false;
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taCliente.FillByNombre(dataSet.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtBusca.Text.Trim());
                if (grdCliente.RowCount == 1)
                {
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdCliente.Visible = true;
                    grdCliente.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBusca.Focus();
                txtBusca.SelectAll();
                grdCliente.Visible = false;
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            lblRazonSocial.Text = grdCliente.CurrentRow.Cells["cRazonSocial"].Value.ToString();
            lblLimite.Text = grdCliente.CurrentRow.Cells["cLimite"].Value.ToString();
            short codigo = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            lblCodigo.Text = codigo.ToString();
            taSucursalContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
            grdCliente.Visible = false;
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtBusca.Focus();
                txtBusca.SelectAll();
            }
        }

        private void FrmTscFactura_Load(object sender, EventArgs e)
        {
            taEmpleado.FillByPuesto(dsNeo.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Vendedor");
            taFrecuencia.Fill(dsNeo.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            btnNuevo_Click(sender, EventArgs.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscFactura = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblNumero.Text = null;
            lblSucursal.Text = Utilidad.codigoSucursal.ToString();
            lblUsuario.Text = Utilidad.nombreUsuario;
            dtpFecha.Value = DateTime.Today.Date;
            cboCondicion.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            txtBusca.Clear();
            txtNombre.Clear();
            lblRazonSocial.Text = null;
            lblLimite.Text = null;
            lblCodigo.Text = null;
            grdCliente.Visible = false;
            dsNeo.tbSucursalContacto.Rows.Clear();
            dsNeo.tbFacturaDetalle.Rows.Clear();
            txtNota.Clear();
            lblSubTotal.Text = "0.00";
            txtDescuento.Text = "0.00";
            lblTotal.Text = "0.00";
            cboCondicion.Text = "Contado";
        }

        private void tbSucursalContactoKryptonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
