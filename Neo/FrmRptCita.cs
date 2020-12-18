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
    public partial class FrmRptCita : Form
    {
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
                int numero = int.Parse(grdCita.CurrentRow.Cells["cNumero"].Value.ToString());
                Utilidad.tscCita.taCita.FillByNumero(Utilidad.tscCita.dsNeo.tbCita, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                int codigo = int.Parse(Utilidad.tscCita.dsNeo.tbCita.Rows[0]["CodigoMascota"].ToString());
                Utilidad.tscCita.taMascota.FillByCodigo(Utilidad.tscCita.dsNeo.tbMascota, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, null, codigo);
                Utilidad.tscCita.taCitaDetalle.FillByNumero(Utilidad.tscCita.dsNeo.tbCitaDetalle, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, Utilidad.codigoSucursal, numero);
                this.Close();
            }
        }
    }
}
