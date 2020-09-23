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
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            btnBuscar_Click(sender, null);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
                btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (grdPedido.CurrentRow != null)
            {
                Utilidad.tscOrdenPedido.codigoCliente = Convert.ToInt16(grdPedido.CurrentRow.Cells["oCodigoCliente"].Value.ToString());
                string nombre = grdPedido.CurrentRow.Cells["oNombre"].Value.ToString();
                Utilidad.tscOrdenPedido.txtNombre.Text = nombre;
                Utilidad.tscOrdenPedido.taCliente.FillByCodigo(Utilidad.tscOrdenPedido.dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.tscOrdenPedido.codigoCliente);
                Utilidad.tscOrdenPedido.lblId.Text = Utilidad.tscOrdenPedido.dsNeo.tbCliente.Rows[0]["IdCliente"].ToString();
                Utilidad.tscOrdenPedido.lblNombre.Text = Utilidad.tscOrdenPedido.dsNeo.tbCliente.Rows[0]["Nombre"].ToString();
                Utilidad.tscOrdenPedido.lblRazonSocial.Text = Utilidad.tscOrdenPedido.dsNeo.tbCliente.Rows[0]["RazonSocial"].ToString();
                Utilidad.tscOrdenPedido.lblLimiteCredito.Text = Utilidad.tscOrdenPedido.dsNeo.tbCliente.Rows[0]["LimiteCredito"].ToString();

                Utilidad.tscOrdenPedido.taClienteDomicilio.Fill(Utilidad.tscOrdenPedido.dsNeo.tbClienteDomicilio, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.tscOrdenPedido.codigoCliente);
                short codigoClienteSucursal = grdPedido.CurrentRow.Cells["oCodigoClienteSucursal"].Value != DBNull.Value ? Convert.ToInt16(grdPedido.CurrentRow.Cells["oCodigoClienteSucursal"].Value.ToString()) : Convert.ToInt16("0");
                
                short codigoSucursal = Convert.ToInt16(grdPedido.CurrentRow.Cells["oCodigoSucursal"].Value.ToString());                
                string numero = grdPedido.CurrentRow.Cells["oNumero"].Value.ToString();
                Utilidad.tscOrdenPedido.taOrdenPedido.FillByNumero(Utilidad.tscOrdenPedido.dsNeo.tbOrdenPedido, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero);
                taSucursal.FillByCodigo(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal);
                nombre = dsNeo.tbSucursal.Rows[0]["Nombre"].ToString();
                Utilidad.tscOrdenPedido.cboSucursal.Text = nombre;
                Utilidad.tscOrdenPedido.lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
                Utilidad.tscOrdenPedido.lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();

                Utilidad.tscOrdenPedido.taOrdenPedidoArticulo.Fill(Utilidad.tscOrdenPedido.dsNeo.tbOrdenPedidoArticulo, Utilidad.codigoTrabajo, Utilidad.codigoSucursal, codigoSucursal, numero);
                Utilidad.tscOrdenPedido.lblTotal.Text = Utilidad.tscOrdenPedido.total().ToString("N2");

                taOrdenPedidoEstado.Ultimo(dsNeo.tbOrdenPedidoEstado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoSucursal, numero);
                nombre = dsNeo.tbOrdenPedidoEstado.Rows[0]["NombreTipoEstado"].ToString();
                Utilidad.tscOrdenPedido.cboEstado.Enabled = false;                
                this.Close();
            }
        }
    }
}
