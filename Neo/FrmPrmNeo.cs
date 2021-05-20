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
    public partial class FrmPrmNeo : Form
    {

        public FrmPrmNeo()
        {
            InitializeComponent();
        }

        private void mnuMtoVtnMascota_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Utilidad.mtoMascota == null)
            {
                Utilidad.mtoMascota = new FrmMtoMascota();
                Utilidad.mtoMascota.MdiParent = this;
            }
            Utilidad.mtoMascota.BringToFront();
            Utilidad.mtoMascota.Show();
            this.Cursor = Cursors.Default;
        }

        private void mnuMtoVtnRaza_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoRaza == null)
            {
                Utilidad.mtoRaza = new FrmMtoRaza();
                Utilidad.mtoRaza.MdiParent = this;
            }
            Utilidad.mtoRaza.BringToFront();
            Utilidad.mtoRaza.Show();
        }

        private void mntoVtnGrupoSanguineo_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoGrupoSanguineo == null)
            {
                Utilidad.mtoGrupoSanguineo = new FrmMtoGrupoSanguineo();
                Utilidad.mtoGrupoSanguineo.MdiParent = this;
            }
            Utilidad.mtoGrupoSanguineo.BringToFront();
            Utilidad.mtoGrupoSanguineo.Show();
        }

        private void mnuMtoVtnGrupo_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoGrupo == null)
            {
                Utilidad.mtoGrupo = new FrmMtoGrupo();
                Utilidad.mtoGrupo.MdiParent = this;
            }
            Utilidad.mtoGrupo.BringToFront();
            Utilidad.mtoGrupo.Show();
        }

        private void mnuMtoVtnCaracter_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoCaracter == null)
            {
                Utilidad.mtoCaracter = new FrmMtoCaracter();
                Utilidad.mtoCaracter.MdiParent = this;
            }
            Utilidad.mtoCaracter.BringToFront();
            Utilidad.mtoCaracter.Show();
        }

        private void mnuMtoVtnPelo_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoPelaje == null)
            {
                Utilidad.mtoPelaje = new FrmMtoPelaje();
                Utilidad.mtoPelaje.MdiParent = this;
            }
            Utilidad.mtoPelaje.BringToFront();
            Utilidad.mtoPelaje.Show();
        }

        private void mnuMtoVtnPropiedad_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoPropiedad == null)
            {
                Utilidad.mtoPropiedad = new FrmMtoPropiedad();
                Utilidad.mtoPropiedad.MdiParent = this;
            }
            FrmMtoPropiedad.miembro = "Veterinaria";
            Utilidad.mtoPropiedad.BringToFront();
            Utilidad.mtoPropiedad.Show();

        }

        private void mnuMtoPerfilCliente_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Utilidad.mtoCliente == null)
            {
                Utilidad.mtoCliente = new FrmMtoCliente();
                Utilidad.mtoCliente.MdiParent = this;
            }
            Utilidad.mtoCliente.BringToFront();
            Utilidad.mtoCliente.Show();
            this.Cursor = Cursors.Default;
        }

        private void mnuMtoNacionalidad_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoNacionalidad == null)
            {
                Utilidad.mtoNacionalidad = new FrmMtoNacionalidad();
                Utilidad.mtoNacionalidad.MdiParent = this;
            }
            Utilidad.mtoNacionalidad.BringToFront();
            Utilidad.mtoNacionalidad.Show();
        }

        private void mnuMtoProveedor_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (Utilidad.mtoProveedor == null)
            {
                Utilidad.mtoProveedor = new FrmMtoProveedor();
                Utilidad.mtoProveedor.StartPosition = FormStartPosition.CenterParent;
                Utilidad.mtoProveedor.WindowState = FormWindowState.Maximized;
                Utilidad.mtoProveedor.MdiParent = this;
            }
            Utilidad.mtoProveedor.BringToFront();
            Utilidad.mtoProveedor.Show();
            this.Cursor = Cursors.Default;
        }

        private void mnuMtoProvincia_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoProvincia == null)
            {
                Utilidad.mtoProvincia = new FrmMtoProvincia();
                Utilidad.mtoProvincia.MdiParent = this;
            }
            Utilidad.mtoProvincia.BringToFront();
            Utilidad.mtoProvincia.Show();
        }

        private void mnuMtoPais_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoPais == null)
            {
                Utilidad.mtoPais = new FrmMtoPais();
                Utilidad.mtoPais.MdiParent = this;
            }
            Utilidad.mtoPais.BringToFront();
            Utilidad.mtoPais.Show();
        }

        private void mnuMtoCategoria_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoCategoria == null)
            {
                Utilidad.mtoCategoria = new FrmMtoCategoria();
                Utilidad.mtoCategoria.MdiParent = this;
            }
            Utilidad.mtoCategoria.BringToFront();
            Utilidad.mtoCategoria.Show();
        }

        private void mnuMtoDepartamento_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoDepartamento == null)
            {
                Utilidad.mtoDepartamento = new FrmMtoDepartamento();
                Utilidad.mtoDepartamento.MdiParent = this;
            }
            Utilidad.mtoDepartamento.BringToFront();
            Utilidad.mtoDepartamento.Show();
        }

        private void mnuMtoOcupacion_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoOcupacion == null)
            {
                Utilidad.mtoOcupacion = new FrmMtoOcupacion();
                Utilidad.mtoOcupacion.MdiParent = this;
            }
            Utilidad.mtoOcupacion.BringToFront();
            Utilidad.mtoOcupacion.Show();
        }

        private void mnuMtoEstado_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoEstado == null)
            {
                Utilidad.mtoEstado = new FrmMtoEstado();
                Utilidad.mtoEstado.MdiParent = this;
            }
            Utilidad.mtoEstado.BringToFront();
            Utilidad.mtoEstado.Show();
        }

        private void mnuMtoFrecuencia_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoFrecuencia == null)
            {
                Utilidad.mtoFrecuencia = new FrmMtoFrecuencia();
                Utilidad.mtoFrecuencia.MdiParent = this;
            }
            Utilidad.mtoFrecuencia.BringToFront();
            Utilidad.mtoFrecuencia.Show();
        }

        private void mnuMtoIdentificacion_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoIdentificacion == null)
            {
                Utilidad.mtoIdentificacion = new FrmMtoIdentificacion();
                Utilidad.mtoIdentificacion.MdiParent = this;
            }
            Utilidad.mtoIdentificacion.BringToFront();
            Utilidad.mtoIdentificacion.Show();
        }

        private void mnuMtoPerfilContacto_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoTipoContacto == null)
            {
                Utilidad.mtoTipoContacto = new FrmMtoTipoContacto();
                Utilidad.mtoTipoContacto.MdiParent = this;
            }
            Utilidad.mtoTipoContacto.BringToFront();
            Utilidad.mtoTipoContacto.Show();
        }

        private void mnuMtoTipoContacto_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoContacto == null)
            {
                Utilidad.mtoContacto = new FrmMtoContacto();
                Utilidad.mtoContacto.StartPosition = FormStartPosition.CenterScreen;
                Utilidad.mtoContacto.MdiParent = this;
            }
            Utilidad.mtoContacto.BringToFront();
            Utilidad.mtoContacto.Show();
        }

        private void mnuMtoFormaPago_Click(object sender, EventArgs e)
        {

            if (Utilidad.mtoFormaPago == null)
            {
                Utilidad.mtoFormaPago = new FrmMtoFormaPago();
                Utilidad.mtoFormaPago.MdiParent = this;
            }
            Utilidad.mtoFormaPago.BringToFront();
            Utilidad.mtoFormaPago.Show();
        }

        private void mnuMtoCaja_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoCaja == null)
            {
                Utilidad.mtoCaja = new FrmMtoCaja();
                Utilidad.mtoCaja.MdiParent = this;
            }
            Utilidad.mtoCaja.BringToFront();
            Utilidad.mtoCaja.Show();
        }

        private void mnuMtoMoneda_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoMoneda == null)
            {
                Utilidad.mtoMoneda = new FrmMtoMoneda();
                Utilidad.mtoMoneda.MdiParent = this;
            }
            Utilidad.mtoMoneda.BringToFront();
            Utilidad.mtoMoneda.Show();
        }

        private void mnuMtoTipo_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoTipoTributo == null)
            {
                Utilidad.mtoTipoTributo = new FrmMtoTipoTributo();
                Utilidad.mtoTipoTributo.MdiParent = this;
            }
            Utilidad.mtoTipoTributo.BringToFront();
            Utilidad.mtoTipoTributo.Show();
        }

        private void mnuMtoTributos_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoTributo == null)
            {
                Utilidad.mtoTributo = new FrmMtoTributo();
                Utilidad.mtoTributo.MdiParent = this;
            }
            Utilidad.mtoTributo.BringToFront();
            Utilidad.mtoTributo.Show();
        }

        private void mnuMtoSucursal_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoSucursal == null)
            {
                Utilidad.mtoSucursal = new FrmMtoSucursal();
                Utilidad.mtoSucursal.MdiParent = this;
            }
            Utilidad.mtoSucursal.BringToFront();
            Utilidad.mtoSucursal.Show();
        }

        private void mnuMtoEmpresa_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoEmpresa == null)
            {
                Utilidad.mtoEmpresa = new FrmMtoEmpresa();
                Utilidad.mtoEmpresa.MdiParent = this;
            }
            Utilidad.mtoEmpresa.BringToFront();
            Utilidad.mtoEmpresa.Show();
        }

        private void mnuMtoPerfilFinanciera_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoFinanciera == null)
            {
                Utilidad.mtoFinanciera = new FrmMtoFinanciera();
                Utilidad.mtoFinanciera.MdiParent = this;
            }
            Utilidad.mtoFinanciera.BringToFront();
            Utilidad.mtoFinanciera.Show();
        }

        private void mnuMtoTipoFinanciera_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoTipoFinanciera == null)
            {
                Utilidad.mtoTipoFinanciera = new FrmMtoTipoFinanciera();
                Utilidad.mtoTipoFinanciera.MdiParent = this;
            }
            Utilidad.mtoTipoFinanciera.BringToFront();
            Utilidad.mtoTipoFinanciera.Show();
        }

        private void mnuMtoNmnEmpleado_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoEmpleado == null)
            {
                Utilidad.mtoEmpleado = new FrmMtoEmpleado();
                Utilidad.mtoEmpleado.MdiParent = this;
            }
            Utilidad.mtoEmpleado.BringToFront();
            Utilidad.mtoEmpleado.Show();
        }

        private void mnuMtoNmnPuesto_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoPuesto == null)
            {
                Utilidad.mtoPuesto = new FrmMtoPuesto();
                Utilidad.mtoPuesto.MdiParent = this;
            }
            Utilidad.mtoPuesto.BringToFront();
            Utilidad.mtoPuesto.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            mnuMtoPerfilCliente_Click(sender, EventArgs.Empty);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            mnuMtoProveedor_Click(sender, EventArgs.Empty);
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            mnuMtoPerfilArticulo_Click(sender, EventArgs.Empty);
        }

        private void mnuMtoPerfilArticulo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Utilidad.mtoArticulo == null)
            {
                Utilidad.mtoArticulo = new FrmMtoArticulo();
                Utilidad.mtoArticulo.MdiParent = this;
            }
            Utilidad.mtoArticulo.BringToFront();
            Utilidad.mtoArticulo.Show();
            this.Cursor = Cursors.Default;
        }

        private void mnuPrecioVenta_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoPrecioVenta == null)
            {
                Utilidad.mtoPrecioVenta = new FrmMtoPrecioVenta();
                Utilidad.mtoPrecioVenta.MdiParent = this;
            }
            Utilidad.mtoPrecioVenta.BringToFront();
            Utilidad.mtoPrecioVenta.Show();
        }

        private void mnuCita_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscCita == null)
            {
                Utilidad.tscCita = new FrmTscCita();
                Utilidad.tscCita.MdiParent = Utilidad.frmPrimario;
            }
            Utilidad.tscCita.btnNuevo_Click(sender, EventArgs.Empty);
            Utilidad.tscCita.BringToFront();
            Utilidad.tscCita.Show();
        }

        private void mnuMascta_Click(object sender, EventArgs e)
        {
            mnuMtoVtnMascota_Click(sender, EventArgs.Empty);
        }

        public void mnuTscCita_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscCita == null)
            {
                Utilidad.tscCita = new FrmTscCita();
                Utilidad.tscCita.MdiParent = Utilidad.frmPrimario;
            }
            Utilidad.tscCita.btnNuevo_Click(sender, EventArgs.Empty);
            Utilidad.tscCita.BringToFront();
            Utilidad.tscCita.Show();
        }

        private void mnuCstCuentaCobrar_Click(object sender, EventArgs e)
        {
            if (Utilidad.cstCuentaCobrar == null)
            {
                Utilidad.cstCuentaCobrar = new FrmCstCuentaCobrar();
                Utilidad.cstCuentaCobrar.MdiParent = this;
            }
            Utilidad.cstCuentaCobrar.BringToFront();
            Utilidad.cstCuentaCobrar.Show();
        }

        private void mnuCstCitaPendiente_Click(object sender, EventArgs e)
        {
            if (Utilidad.rptCitaPendiente == null)
            {
                Utilidad.rptCitaPendiente = new FrmRptCitaPendiente();
                Utilidad.rptCitaPendiente.WindowState = FormWindowState.Maximized;
                Utilidad.rptCitaPendiente.MdiParent = this;
            }
            Utilidad.rptCitaPendiente.BringToFront();
            Utilidad.rptCitaPendiente.Show();
        }

        private void mnuRptVentaResumen_Click(object sender, EventArgs e)
        {
            if (Utilidad.rptFacturaResumen == null)
            {
                Utilidad.rptFacturaResumen = new FrmRptFacturaResumen();
                Utilidad.rptFacturaResumen.WindowState = FormWindowState.Maximized;
                Utilidad.rptFacturaResumen.MdiParent = this;
            }
            Utilidad.rptFacturaResumen.BringToFront();
            Utilidad.rptFacturaResumen.Show();
        }

        private void mnuRptVentaDetalle_Click(object sender, EventArgs e)
        {
            if (Utilidad.rptFacturaDetalle == null)
            {
                Utilidad.rptFacturaDetalle = new FrmRptFacturaDetalle();
                Utilidad.rptFacturaDetalle.WindowState = FormWindowState.Maximized;
                Utilidad.rptFacturaDetalle.MdiParent = this;
            }
            Utilidad.rptFacturaDetalle.BringToFront();
            Utilidad.rptFacturaDetalle.Show();
        }

        private void mnuRptCita_Click(object sender, EventArgs e)
        {
            if (Utilidad.rptCita == null)
            {
                Utilidad.rptCita = new FrmRptCita();
                Utilidad.rptCita.WindowState = FormWindowState.Maximized;
                Utilidad.rptCita.MdiParent = this;
            }
            Utilidad.rptCita.BringToFront();
            Utilidad.rptCita.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrmNeo_Load(object sender, EventArgs e)
        {
            taEmpresa.Fill(dsNeo.tbEmpresa, Utilidad.codigoTrabajo);
            foreach (DataRow dr in dsNeo.tbEmpresa.Rows)
            {
                string nombre = dr["Nombre"].ToString();
                cboEmpresa.Items.Add(nombre);
                short codigo = short.Parse(dr["CodigoEmpresa"].ToString());
                if (codigo == Utilidad.codigoEmpresa)
                    cboEmpresa.Text = nombre;
            }
            listadoSucursal();
        }

        private void listadoSucursal()
        {
            cboSucursal.Items.Clear();
            taSucursal.Fill(dsNeo.tbSucursal, Utilidad.codigoTrabajo, Utilidad.codigoSucursal);
            foreach (DataRow dr in dsNeo.tbSucursal.Rows)
            {
                short codigo = Convert.ToInt16(dsNeo.tbSucursal.Rows[0]["CodigoSucursal"].ToString());
                string nombre = dsNeo.tbSucursal.Rows[0]["Nombre"].ToString();
                cboSucursal.Items.Add(nombre);
                if (Utilidad.codigoSucursal == codigo)
                {
                    cboSucursal.Text = nombre;
                    Utilidad.nombreSucursal = nombre;
                }
            }
        }

        private void mnuTscFactura_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscFactura == null)
            {
                Utilidad.tscFactura = new FrmTscFactura();
                Utilidad.tscFactura.MdiParent = this;
            }
            Utilidad.tscFactura.BringToFront();
            Utilidad.tscFactura.Show();
        }

        private void mnuTscReciboIngreso_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscReciboIngreso == null)
            {
                Utilidad.tscReciboIngreso = new FrmTscReciboIngreso();
                Utilidad.tscReciboIngreso.MdiParent = this;
            }
            Utilidad.tscReciboIngreso.BringToFront();
            Utilidad.tscReciboIngreso.Show();
        }
    }
}
