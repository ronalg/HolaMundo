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
    public partial class FrmTscCita : Form
    {
        public FrmTscCita()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.taCita.Fill(this.dsNeo.tbCita, ((short)(System.Convert.ChangeType(codigoTrabajoToolStripTextBox.Text, typeof(short)))), ((short)(System.Convert.ChangeType(codigoEmpresaToolStripTextBox.Text, typeof(short)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tbCitaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numeroCitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroCitaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
