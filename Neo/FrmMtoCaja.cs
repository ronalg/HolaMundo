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
    public partial class FrmMtoCaja : Form
    {
        public FrmMtoCaja()
        {
            InitializeComponent();
        }

        private void FrmMtoCaja_Load(object sender, EventArgs e)
        {
            taCaja.Fill(dsNeo.tbCaja, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal);
        }
    }
}
