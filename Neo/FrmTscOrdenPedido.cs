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
    public partial class FrmTscOrdenPedido : Form
    {
        string codigoArticulo = null;
        short codigoCliente = 0;

        public FrmTscOrdenPedido()
        {
            InitializeComponent();
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && grdCliente.Rows.Count > 0)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            codigoCliente = Convert.ToInt16(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            string nombre = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
            txtNombre.Text = nombre;
            taCliente.FillByCodigo(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
            lblId.Text = dsNeo.tbCliente.Rows[0]["IdCliente"].ToString();
            lblNombre.Text = dsNeo.tbCliente.Rows[0]["Nombre"].ToString();
            lblRazonSocial.Text = dsNeo.tbCliente.Rows[0]["RazonSocial"].ToString();
            lblLimiteCredito.Text = dsNeo.tbCliente.Rows[0]["LimiteCredito"].ToString();
            grdCliente.Visible = false;
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nombre = txtNombre.Text.Trim();
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                if (dsNeo.tbCliente.Rows.Count == 1)
                {
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                }
                else
                {
                    grdCliente.Visible = true;
                    grdCliente.Focus();
                }
            }
        }
    }
}
