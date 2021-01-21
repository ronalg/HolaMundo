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
    public partial class FrmRptCitaPendiente : Form
    {
        public FrmRptCitaPendiente()
        {
            InitializeComponent();
        }      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRptCitaPendiente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.rptCitaPendiente = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            taCitaMascotaPendiente.Fill(dsNeo.tbCitaMascotaPendiente, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString());
            this.Cursor = Cursors.Default;
        }

        private void FrmRptCitaPendiente_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-3);
            dtpHasta.Value = DateTime.Today.AddDays(-3);
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Utilidad.frmPrimario.mnuTscCita_Click(sender, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (dsNeo.tbCitaMascotaPendiente.Rows.Count > 0)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.textoCuadroMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        int numero = int.Parse(grdCita.CurrentRow.Cells["cNumero"].Value.ToString());
                        taCitaDetalle.EliminaNumero(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                        taCita.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                        grdCita.Rows.Remove(grdCita.CurrentRow);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnVerContacto_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCitaMascotaPendiente.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int codigo = int.Parse(grdCita.CurrentRow.Cells["cCodigoCliente"].Value.ToString());
                taContacto.Fill(dsNeo.tbSucursalContacto, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, codigo, "Cliente");
                pnlContacto.Visible = true;
                grdContacto.Focus();
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlContacto.Visible = false;
            bnCita.Focus();
            btnVerContacto.Select();
        }

        private void btnVerCita_Click(object sender, EventArgs e)
        {
            if (dsNeo.tbCitaMascotaPendiente.Rows.Count > 0)
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

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int numero = int.Parse(grdCita.CurrentRow.Cells["cNumero"].Value.ToString());
            taCita.EditaInformado(true, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
            grdCita.CurrentRow.Cells["cInformado"].Value = true;
            btnCerrar_Click(sender, EventArgs.Empty);
            this.Cursor = Cursors.Default;
        }

        private void grdCita_DoubleClick(object sender, EventArgs e)
        {
            btnVerContacto_Click(sender, EventArgs.Empty);
        }

        private void mnuVerContacto_Click(object sender, EventArgs e)
        {
            btnVerContacto_Click(sender, EventArgs.Empty);
        }

        private void mnuVerCita_Click(object sender, EventArgs e)
        {
            btnVerCita_Click(sender, EventArgs.Empty);
        }

        private void mnuMarcar_Click(object sender, EventArgs e)
        {
            btnMarcar_Click(sender, EventArgs.Empty);
        }

        private void mnuBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, EventArgs.Empty);
        }

        private void mnuAgregarNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo_Click(sender, EventArgs.Empty);
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, EventArgs.Empty);
        }
    }
}
