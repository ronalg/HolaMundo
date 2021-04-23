using ComponentFactory.Krypton.Toolkit;
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
    public partial class FrmIniSsn : KryptonForm
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
                Utilidad.codigoTrabajo = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoTrabajo"].ToString());
                Utilidad.codigoEmpresa = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoEmpresa"].ToString());
                Utilidad.codigoUsuario = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoUsuario"].ToString());
                Utilidad.codigoSucursal = short.Parse(dsNeo.tbUsuario.Rows[0]["CodigoSucursal"].ToString());
                Utilidad.nombreUsuario = dsNeo.tbUsuario.Rows[0]["Usuario"].ToString();
                Utilidad.frmPrimario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cuenta de usuario invalida", Utilidad.nombrePrograma, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            Neo.Properties.Settings.Default["csNeo"] = "Data Source=ronalgemmanuel.database.windows.net;Initial Catalog=Neo;User ID=administrador;Password=BA7297();Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            //Neo.Properties.Settings.Default["csNeo"] = @"Data Source=DESKTOP-7T00K3A\SQLEXPRESS;Initial Catalog=Neo;Integrated Security=True";
            txtUsuario.Text = "bienestar";
            txtContrasena.Text = "animal";
            btnIniciar_Click(sender, EventArgs.Empty);
            this.Hide();
        }
    }
}
