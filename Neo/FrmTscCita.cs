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
            //taArticulo.FillByVeterinaria(dataSet.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, true);
            //taEmpleado.FillByPuesto(dataSet.tbEmpleado, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, "Veterinaria");
        }
    }
}
