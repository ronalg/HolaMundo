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
    public partial class FrmIniSsn : Form
    {
        public FrmIniSsn()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            taUsuario.FillByUsuarioContrasena(dsNeo.tbUsuario, usuario, contrasena);

            if (dsNeo.tbUsuario.Rows.Count > 0)
            {
                Utilidad.frmPrimario = new FrmPrm();
                Utilidad.frmPrimario.Show();
                Utilidad.codigoTrabajo = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoTrabajo"].ToString());
                Utilidad.codigoEmpresa = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoEmpresa"].ToString());
                Utilidad.codigoUsuario = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoUsuario"].ToString());
                Utilidad.codigoSucursal = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoSucursal"].ToString());
                Utilidad.nombreUsuario = dsNeo.tbUsuario.Rows[0]["Usuario"].ToString();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cuenta de usuario invalida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtContrasena.Focus();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIniciar_Click(sender, EventArgs.Empty);
        }

        private void FrmIniSsn_Load(object sender, EventArgs e)
        {
            Neo.Properties.Settings.Default["csNeo"] = "Data Source=groovestudio.database.windows.net;Initial Catalog=NeoDesarrollo;User ID=administrador;Password=Emmanuel2612%;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            txtUsuario.Text = "hamlert";
            txtContrasena.Text = "hamlert%";
            btnIniciar_Click(sender, EventArgs.Empty);
            this.Hide();
        }
    }
}
