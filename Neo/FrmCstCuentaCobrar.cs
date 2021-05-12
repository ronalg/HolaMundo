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
    public partial class FrmCstCuentaCobrar : Form
    {
        string codigoCliente = null;

        public FrmCstCuentaCobrar()
        {
            InitializeComponent();
        }

        private void grdFactura_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string columna = "cVenta";
            decimal valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "cCobro";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "cCosto";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "cBalance";
            valor = decimal.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = valor >= 0.00M ? Color.Black : Color.Red;

            columna = "cVence";
            DateTime vence = DateTime.Parse(grdFactura.Rows[e.RowIndex].Cells[columna].Value.ToString());
            grdFactura.Rows[e.RowIndex].Cells[columna].Style.ForeColor = DateTime.Today.Date >= vence ? Color.Black : Color.Red;
        }
    }
}
