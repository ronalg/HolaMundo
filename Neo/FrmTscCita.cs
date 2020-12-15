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
    public partial class FrmTscCita : Form
    {
        public FrmTscCita()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void tbCitaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numeroCitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroCitaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            

        }

        private void txtBuscaMascota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscaMascota.Text.Trim()))
                grdMascota.Visible = false;
        }

        private void txtBuscaMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taMascota.Fill(dataSet.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtBuscaMascota.Text.Trim());
                if (dataSet.tbMascota.Rows.Count == 1)
                    grdMascota_DoubleClick(sender, EventArgs.Empty);
                else
                    grdMascota.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBuscaMascota.Focus();
                txtBuscaMascota.SelectAll();
                grdMascota.Visible = false;
            }
        }

        private void grdMascota_DoubleClick(object sender, EventArgs e)
        {
            int codigo = int.Parse(grdMascota.CurrentRow.Cells["mCodigoMascota"].Value.ToString());
            taMascota.FillByCodigo(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, codigo);
            grdMascota.Visible = false;
            cboTipo.Focus();
        }

        private void grdMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdMascota_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdMascota.Visible = false;
                txtBuscaMascota.Focus();
                txtBuscaMascota.SelectAll();
            }
        }

        private void btnCancelaServicio_Click(object sender, EventArgs e)
        {
            pnlServicio.Visible = false;
        }

        private void btnCancelaVeterinario_Click(object sender, EventArgs e)
        {
            pnlVeterinario.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTscCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.tscCita = null;
        }

        private void FrmTscCita_Load(object sender, EventArgs e)
        {
            taArticulo.FillByVeterinaria(dataSet.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, null);
            //taEmpleado.FillByPuesto(dataSet.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinaria");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidad.bscCita == null)
                Utilidad.bscCita = new FrmBscCita();
            Utilidad.bscCita.BringToFront();
            Utilidad.bscCita.Show();
        }

        private void grdServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtServicio_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServicio.Text))
                taArticulo.FillByVeterinaria(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, null);
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            DataRow dr = dsNeo.tbCitaDetalle.NewtbCitaDetalleRow();
            dr["CodigoTrabajo"] = Utilidad.codigoTrabajo;
            dr["CodigoEmpresa"] = Utilidad.codigoEmpresa;
            dr["CodigoSucursal"] = Utilidad.codigoSucursal;
            dr["NumeroCita"] = 0;
            dr["CodigoEmpleado"] = 0;
            dr["Veterinario"] = "Ha";
            dr["CodigoArticulo"] = 0;
            dr["Descripcion"] = "sfs";
            dr["Pendiente"] = true;
            dr["Costo"] = 0.00M;
            dr["Venta"] = 0.00;
            dr["Activa"] = true;
            dr["Nota"] = null;
            dsNeo.tbCitaDetalle.Rows.Add(dr);
            pnlServicio.Visible = true;
            txtServicio.Clear();
            txtServicio.Focus();
            grdArticulo.Rows[grdArticulo.RowCount - 1].Cells["aCodigo"].Selected = true;
        }

        private void btnAceptaServicio_Click(object sender, EventArgs e)
        {
            if (grdServicio.CurrentRow.Cells["sCodigo"].Value != DBNull.Value)
            {
                int codigo = int.Parse(grdServicio.CurrentRow.Cells["sCodigo"].Value.ToString());
                grdArticulo.CurrentRow.Cells["aCodigo"].Value = codigo;
                grdArticulo.CurrentRow.Cells["aDescripcion"].Value = grdServicio.CurrentRow.Cells["sDescripcion"].Value.ToString();
                taArticuloProveedor.FillByActual(dsNeo.tbArticuloProveedor, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, true);
                if (dsNeo.tbArticuloProveedor.Rows.Count > 0)
                {
                    decimal costo = decimal.Parse(dsNeo.tbArticuloProveedor.Rows[0]["Costo"].ToString());
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = codigo;
                }
                else
                {
                    grdArticulo.CurrentRow.Cells["aCosto"].Value = 0.00M;
                }
                pnlServicio.Visible = false;
            }
        }

        private void txtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taArticulo.FillByVeterinaria(dataSet.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true, txtServicio.Text);
                if (dataSet.tbArticulo.Rows.Count == 1)
                    btnAceptaServicio_Click(sender, EventArgs.Empty);
                else
                    grdMascota.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtServicio.Focus();
                txtServicio.SelectAll();
                pnlServicio.Visible = false;
            }
        }

        private void grdArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdServicio_DoubleClick(object sender, EventArgs e)
        {
            btnAceptaServicio_Click(sender, EventArgs.Empty);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
