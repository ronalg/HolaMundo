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
    public partial class FrmBscOrdenPedido : Form
    {
        public FrmBscOrdenPedido()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscOrdenPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscOrdenPedido = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taFnOrdenPedido.Fill(dsNeo.fnOrdenPedido, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, dtpDesde.Value.Date, dtpHasta.Value.Date, txtCliente.Text.Trim());
            this.Cursor = Cursors.Default;
        }

        private void FrmBscOrdenPedido_Load(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, null);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
                btnBuscar_Click(sender, EventArgs.Empty);
        }
    }
}
