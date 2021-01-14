using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    public partial class FrmRptCita : Form
    {
        short? codigoCliente = null;
        int? codigoMascota = null;
        int? codigoServicio = null;

        public FrmRptCita()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRptCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.rptCita = null;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCitaMascota.Rows.Count > 0)
            {
                if (Utilidad.tscCita == null)
                {
                    Utilidad.tscCita = new FrmTscCita();
                    Utilidad.tscCita.MdiParent = Utilidad.frmPrimario;
                }

                int numero = int.Parse(grdCita.CurrentRow.Cells["cNumero"].Value.ToString());
                Utilidad.tscCita.taCita.FillByNumero(Utilidad.tscCita.dsNeo.tbCita, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                int codigo = int.Parse(Utilidad.tscCita.dsNeo.tbCita.Rows[0]["CodigoMascota"].ToString());
                Utilidad.tscCita.taMascota.Fill(Utilidad.tscCita.dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, null);
                Utilidad.tscCita.taCitaDetalle.FillByNumero(Utilidad.tscCita.dsNeo.tbCitaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                Utilidad.tscCita.chkInformado.Checked = bool.Parse(grdCita.CurrentRow.Cells["cInformado"].Value.ToString());
                Utilidad.tscCita.Refresh();
                Utilidad.tscCita.Show();
                Utilidad.tscCita.BringToFront();
            }
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

        private void FrmRptCita_Load(object sender, EventArgs e)
        {
            cboPendiente.SelectedIndex = 0;
            cboActiva.SelectedIndex = 0;
            cboInformado.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bool? pendiente = null;
                bool? activa = null;
                if (cboPendiente.SelectedIndex == 1)
                    pendiente = true;
                else if (cboPendiente.SelectedIndex == 2)
                    pendiente = false;
                if (cboActiva.SelectedIndex == 1)
                    activa = true;
                else if (cboActiva.SelectedIndex == 2)
                    activa = false;
                bool? informado = null;
                if (cboInformado.SelectedIndex == 1)
                    informado = true;
                else if (cboInformado.SelectedIndex == 2)
                    informado = false;
                taCitaMascota.FillReporte(dsNeo.tbCitaMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, dtpDesde.Value.Date, dtpHasta.Value.Date, codigoMascota, codigoCliente, codigoServicio, pendiente, activa, informado);
                if (dsNeo.tbCitaMascota.Rows.Count > 0)
                {
                    decimal costo = decimal.Parse(dsNeo.tbCitaMascota.Compute("SUM(Costo)", null).ToString());
                    decimal venta = decimal.Parse(dsNeo.tbCitaMascota.Compute("SUM(Venta)", null).ToString());
                    lblCosto.Text = costo.ToString("N2");
                    lblVenta.Text = venta.ToString("N2");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlContacto.Visible = false;
            grdCita.Focus();
        }

        private void btnVerContacto_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCitaMascota.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int codigo = int.Parse(grdCita.CurrentRow.Cells["cCliente"].Value.ToString());
                taContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                pnlContacto.Visible = true;
                grdContacto.Focus();
                this.Cursor = Cursors.Default;
            }
        }

        private void mnuBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void mnuVerCita_Click(object sender, EventArgs e)
        {
            btnVer_Click(sender, EventArgs.Empty);
        }

        private void mnuVerContacto_Click(object sender, EventArgs e)
        {
            btnVerContacto_Click(sender, EventArgs.Empty);
        }

        private void grdContacto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCerrar_Click(sender, EventArgs.Empty);
        }

        private void mnuPantalla_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                taEmpresa.FillByCodigo(dsNeo.tbEmpresa, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
                taSucursal.FillByCodigo(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
                //RptCita rpt = new RptCita();
                //rpt.SetDataSource(dsNeo);
                FrmRpt frm = new FrmRpt();
                //frm.crv.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
