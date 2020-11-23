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
    public partial class FrmPrm : Form
    {
        public FrmPrm()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void mnuMtoProveedor_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoProveedor == null)
            {
                Utilidad.mtoProveedor = new FrmMtoProveedor();
                Utilidad.mtoProveedor.StartPosition = FormStartPosition.CenterParent;
                Utilidad.mtoProveedor.WindowState = FormWindowState.Maximized;
                Utilidad.mtoProveedor.MdiParent = this;
            }
            Utilidad.mtoProveedor.BringToFront();
            Utilidad.mtoProveedor.Show();
        }

        private void mnuMtoUnidad_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoUnidad == null)
            {
                Utilidad.mtoUnidad = new FrmMtoUnidad();
                Utilidad.mtoUnidad.MdiParent = this;
            }
            Utilidad.mtoUnidad.BringToFront();
            Utilidad.mtoUnidad.Show();
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

        private void mnuMtoPerfilArticulo_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoArticulo == null)
            {
                Utilidad.mtoArticulo = new FrmMtoArticulo();
                Utilidad.mtoArticulo.MdiParent = this;
            }
            Utilidad.mtoArticulo.BringToFront();
            Utilidad.mtoArticulo.Show();
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

        private void FrmPrm_Load(object sender, EventArgs e)
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

        private void cboEmpresa_DropDownClosed(object sender, EventArgs e)
        {
            if (cboEmpresa.SelectedIndex > -1)
            {
                string nombre = cboEmpresa.Text;
                taEmpresa.FillByNombre(dsNeo.tbEmpresa, Utilidad.codigoTrabajo, nombre);
                short codigo = short.Parse(dsNeo.tbEmpresa.Rows[0]["CodigoEmpresa"].ToString());
                Utilidad.codigoEmpresa = codigo;

                foreach (Form frm in this.MdiChildren)
                    frm.Close();
            }

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

        private void mnuMtoPerfilCliente_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoCliente == null)
            {
                Utilidad.mtoCliente = new FrmMtoCliente();
                Utilidad.mtoCliente.StartPosition = FormStartPosition.CenterParent;
                Utilidad.mtoCliente.WindowState = FormWindowState.Maximized;
                Utilidad.mtoCliente.MdiParent = this;
            }
            Utilidad.mtoCliente.BringToFront();
            Utilidad.mtoCliente.Show();
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

        private void mnuTscOrdenPedido_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscOrdenPedido == null)
            {
                Utilidad.tscOrdenPedido = new FrmTscOrdenPedido();
                Utilidad.tscOrdenPedido.MdiParent = this;                
            }
            Utilidad.tscOrdenPedido.BringToFront();
            Utilidad.tscOrdenPedido.Show();
        }

        private void mnuTscFactura_Click(object sender, EventArgs e)
        {
            if (Utilidad.tscFactura == null)
            {
                Utilidad.tscFactura = new FrmTscFactura();
                Utilidad.tscFactura.WindowState = FormWindowState.Maximized;
                Utilidad.tscFactura.MdiParent = this;
            }
            Utilidad.tscFactura.BringToFront();
            Utilidad.tscFactura.Show();
        }

        private void listadoSucursal ()
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

        private void mnuMtoVtnMascota_Click(object sender, EventArgs e)
        {
            if (Utilidad.mtoMascota == null)
            {
                Utilidad.mtoMascota = new FrmMtoMascota();
                Utilidad.mtoMascota.MdiParent = this;
            }
            Utilidad.mtoMascota.BringToFront();
            Utilidad.mtoMascota.Show();
        }
    }
}
