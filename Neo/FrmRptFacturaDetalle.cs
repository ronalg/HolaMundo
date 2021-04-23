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
    public partial class FrmRptFacturaDetalle : Form
    {
        public FrmRptFacturaDetalle()
        {
            InitializeComponent();
        }

        private void FrmRptFacturaDetalle_Load(object sender, EventArgs e)
        {
            taDepartamento.Fill(dsNeo.tbDepartamento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
            cboDepartamento.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today.Date;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex > -1)
            {
                string departamento = cboDepartamento.Text;
                taCategoria.FillByDepartamento(dsNeo.tbCategoria, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, departamento);
                cboCategoria.SelectedIndex = -1;
            }
        }

        private void cboDepartamento_Validated(object sender, EventArgs e)
        {
            string departamento = cboDepartamento.Text;
            DsNeo ds = new DsNeo();
            taDepartamento.FillByDepartamento(ds.tbDepartamento, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, departamento);
            if (ds.tbDepartamento.Rows.Count == 0)
            {
                cboDepartamento.Text = null;
                dsNeo.tbCategoria.Rows.Clear();
            }
        }        
    }
}
