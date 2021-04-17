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
    public partial class FrmBscFactura : Form
    {
        public FrmBscFactura()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscFactura = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string nombre = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
            taFactura.Fill(dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, null, dtpDesde.Value.Date, dtpHasta.Value.Date, nombre, null);
            this.Cursor = Cursors.Default;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbFactura.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int numero = int.Parse(grdFactura.CurrentRow.Cells["fNumero"].Value.ToString());
                Utilidad.tscFactura.taFactura.Fill(Utilidad.tscFactura.dsNeo.tbFactura, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero, null, null, null, null);
                short? codigoCliente = null;
                string codigo = Utilidad.tscFactura.dsNeo.tbFactura.Rows[0]["CodigoCliente"].ToString();
                if (!string.IsNullOrEmpty(codigo))
                    codigoCliente = short.Parse(codigo);
                Utilidad.tscFactura.taCliente.FillByCodigo(Utilidad.tscFactura.dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoCliente);
                Utilidad.tscFactura.taFacturaDetalle.Fill(Utilidad.tscFactura.dsNeo.tbFacturaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscFactura.taFacturaCobro.Fill(Utilidad.tscFactura.dsNeo.tbFacturaCobro, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscFactura.cboVendedor.Text = grdFactura.CurrentRow.Cells["fVendedor"].Value.ToString();
                Utilidad.tscFactura.btnLimpiar.Available = false;
                if (!string.IsNullOrEmpty(Utilidad.tscFactura.txtRecibido.Text))
                {
                    decimal r = decimal.Parse(Utilidad.tscFactura.txtRecibido.Text);
                    Utilidad.tscFactura.txtRecibido.Text = r.ToString("N2");
                    Utilidad.tscFactura.lblDevuelta.Text = Utilidad.tscFactura.devuelta().ToString("N2");
                }
                this.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void FrmBscFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void grdFactura_DoubleClick(object sender, EventArgs e)
        {
            btnVer_Click(sender, EventArgs.Empty);
        }
    }
}
