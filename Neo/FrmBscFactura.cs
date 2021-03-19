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
    public partial class FrmBscFactura : Form
    {
        public FrmBscFactura()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBscFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.bscFactura = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //taFactura.Fill();
            this.Cursor = Cursors.Default;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void FrmBscFactura_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }
    }
}
