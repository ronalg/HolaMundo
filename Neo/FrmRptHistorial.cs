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
    public partial class FrmRptHistorial : Form
    {
        short? codigoCliente = null;
        int? codigoMascota = null;
        int? codigoServicio = null;

        public FrmRptHistorial()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taHistorialMascota.Fill(dsNeo.tbHistorialMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigoMascota, dtpDesde.Value.Date, dtpHasta.Value.Date, null, codigoCliente, null, codigoServicio, null, null);
            this.Cursor = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRptHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.rptHistorial = null;
        }

        private void txtDueno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDueno.Text))
            {
                grdCliente.Visible = false;
                codigoCliente = null;
            }
        }

        private void txtDueno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taCliente.FillByNombre(dsNeo.tbCliente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtDueno.Text);
                grdCliente.Visible = true;
                if (dsNeo.tbCliente.Rows.Count == 1)
                    grdCliente_DoubleClick(sender, EventArgs.Empty);
                else if (dsNeo.tbCliente.Rows.Count > 1)
                    grdCliente.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdCliente.Visible = false;
                txtDueno.SelectAll();
                txtDueno.Focus();
            }
        }

        private void grdCliente_DoubleClick(object sender, EventArgs e)
        {
            if (dsNeo.tbCliente.Rows.Count > 0)
            {
                codigoCliente = short.Parse(grdCliente.CurrentRow.Cells["cCodigo"].Value.ToString());
                txtDueno.Text = grdCliente.CurrentRow.Cells["cNombre"].Value.ToString();
                grdCliente.Visible = false;
                txtMascota.Focus();
            }
        }

        private void grdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdCliente_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtDueno.Focus();
                txtDueno.SelectAll();
                grdCliente.Visible = false;
            }
        }

        private void txtMascota_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMascota.Text))
            {
                grdMascota.Visible = false;
                codigoMascota = null;
            }
        }

        private void txtMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taMascota.FillByNombre(dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtMascota.Text);
                grdMascota.Visible = true;
                if (dsNeo.tbMascota.Rows.Count == 1)
                    grdMascota_DoubleClick(sender, EventArgs.Empty);
                else if (dsNeo.tbMascota.Rows.Count > 1)
                    grdMascota.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdMascota.Visible = false;
                txtMascota.SelectAll();
                txtMascota.Focus();
            }

        }

        private void grdMascota_DoubleClick(object sender, EventArgs e)
        {
            if (dsNeo.tbMascota.Rows.Count > 0)
            {
                codigoMascota = short.Parse(grdMascota.CurrentRow.Cells["mCodigo"].Value.ToString());
                txtMascota.Text = grdMascota.CurrentRow.Cells["mNombre"].Value.ToString();
                grdMascota.Visible = false;
                txtMascota.Focus();
            }
        }

        private void grdMascota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdMascota_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMascota.Focus();
                txtMascota.SelectAll();
                grdMascota.Visible = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                grdServicio.Visible = false;
                codigoServicio = null;
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taArticulo.FillByDescripcion(dsNeo.tbArticulo, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtDescripcion.Text.Trim());
                grdServicio.Visible = true;
                if (dsNeo.tbArticulo.Rows.Count == 1)
                    grdServicio_DoubleClick(sender, EventArgs.Empty);
                else if (dsNeo.tbArticulo.Rows.Count > 1)
                    grdServicio.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdServicio.Visible = false;
                txtDescripcion.SelectAll();
                txtDescripcion.Focus();
            }
        }

        private void grdServicio_DoubleClick(object sender, EventArgs e)
        {
            if (dsNeo.tbArticulo.Rows.Count > 0)
            {
                codigoServicio = short.Parse(grdServicio.CurrentRow.Cells["sCodigo"].Value.ToString());
                txtDescripcion.Text = grdServicio.CurrentRow.Cells["sDescripcion"].Value.ToString();
                grdServicio.Visible = false;
                txtDescripcion.Focus();
            }
        }

        private void grdServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdServicio_DoubleClick(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grdServicio.Visible = false;
                txtDescripcion.Focus();
                txtDescripcion.SelectAll();
            }
        }

        private void btnVerCita_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbHistorialMascota.Rows.Count > 0)
            {
                if (Utilidad.tscCita == null)
                {
                    Utilidad.tscHistorial = new FrmTscHistorial();
                    Utilidad.tscHistorial.MdiParent = Utilidad.frmPrimario;
                }

                int numero = int.Parse(grdHistorial.CurrentRow.Cells["hNumero"].Value.ToString());
                Utilidad.tscHistorial.taHistorial.Fill(Utilidad.tscHistorial.dsNeo.tbHistorial, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                int codigo = int.Parse(grdHistorial.CurrentRow.Cells["hCodigo"].Value.ToString());
                //Utilidad.tscHistorial.taMascota.Fill(Utilidad.tscHistorial.dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null);
                Utilidad.tscHistorial.lblNombre.Text = grdHistorial.CurrentRow.Cells["hNombre"].Value.ToString();
                Utilidad.tscHistorial.lblDueno.Text = grdHistorial.CurrentRow.Cells["hDueno"].Value.ToString();
                Utilidad.tscHistorial.lblSexo.Text = grdHistorial.CurrentRow.Cells["hSexo"].Value.ToString();
                Utilidad.tscHistorial.lblGrupo.Text = grdHistorial.CurrentRow.Cells["hGrupo"].Value.ToString();
                Utilidad.tscHistorial.lblRaza.Text = grdHistorial.CurrentRow.Cells["hRaza"].Value.ToString();
                Utilidad.tscHistorial.lblCodigo.Text = grdHistorial.CurrentRow.Cells["hCodigo"].Value.ToString();
                Utilidad.tscHistorial.dtpFecha.Value = DateTime.Parse(grdHistorial.CurrentRow.Cells["hFecha"].Value.ToString());
                Utilidad.tscHistorial.taHistorialDetalle.Fill(Utilidad.tscHistorial.dsNeo.tbHistorialDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscHistorial.Show();
                Utilidad.tscHistorial.BringToFront();
            }
        }

        private void FrmRptHistorial_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }
    }
}
