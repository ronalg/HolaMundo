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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

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
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtBusca.Text.Trim());
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
            short codigo = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
            taCliente.FillByCodigo(dataSet.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo);
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
    }
}
