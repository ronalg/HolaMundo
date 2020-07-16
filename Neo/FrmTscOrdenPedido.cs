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
                codigoCliente = Convert.ToInt16(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
                string nombre = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
                txtNombre.Text = nombre;
                taCliente.FillByCodigo(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }
    }
}
