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
    public partial class FrmRptFacturaDetalle : Form
    {
        short? codigoCliente = null;
        short? codigoArticulo = null;

        public FrmRptFacturaDetalle()
        {
            InitializeComponent();
        }

        private void FrmRptFacturaDetalle_Load(object sender, EventArgs e)
        {
            taDepartamento.Fill(dsNeo.tbDepartamento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboDepartamento.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex > -1)
            {
                string departamento = cboDepartamento.Text;
                taCategoria.FillByDepartamento(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, departamento);
                cboCategoria.SelectedIndex = -1;
            }
        }

        private void cboDepartamento_Validated(object sender, EventArgs e)
        {
            string departamento = cboDepartamento.Text;
            DsNeo ds = new DsNeo();
            taDepartamento.FillByDepartamento(ds.tbDepartamento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, departamento);
            if (ds.tbDepartamento.Rows.Count == 0)
            {
                cboDepartamento.Text = null;
                dsNeo.tbCategoria.Rows.Clear();
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtCliente.Text.Trim());
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
                txtCliente.Focus();
                txtCliente.SelectAll();
                grdCliente.Visible = false;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text.Trim()))
            {
                codigoCliente = null;
                grdCliente.Visible = false;
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            txtCliente.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            grdCliente.Visible = false;
            txtArticulo.Focus();
            txtArticulo.SelectAll();
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArticulo.Text))
            {
                codigoArticulo = null;
                grdArticulo.Visible = false;
            }
        }

        private void grdArticulo_DoubleClick(object sender, EventArgs e)
        {
            codigoArticulo = short.Parse(grdArticulo.CurrentRow.Cells["aCodigo"].Value.ToString());
            txtArticulo.Text = grdArticulo.CurrentRow.Cells["aDescripcion"].Value.ToString();
            grdArticulo.Visible = false;
            txtArticulo.Focus();
            txtArticulo.SelectAll();
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
                txtCliente.Focus();
                txtCliente.SelectAll();
            }
        }

        private void grdArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdArticulo_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdArticulo.Visible = false;
                txtArticulo.Focus();
                txtArticulo.SelectAll();
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taArticulo.FillByDescripcion(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtArticulo.Text);
                if (grdCliente.RowCount == 1)
                {
                    grdArticulo_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdArticulo.Visible = true;
                    grdArticulo.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtArticulo.Focus();
                txtArticulo.SelectAll();
                grdArticulo.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taFnFactura.Fill(dsNeo.fnFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
            this.Cursor = Cursors.Default;
        }
    }
}
