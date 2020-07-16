﻿using System;
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
    public partial class FrmMtoFrecuencia : Form
    {
        public FrmMtoFrecuencia()
        {
            InitializeComponent();
        }

        string nombre = null;

        private void ConfiguraBoton(bool configura)
        {
            btnPrimero.Available = configura;
            btnAnterior.Available = configura;
            spd1.Available = configura;
            txtPosicion.Available = configura;
            lblRegistro.Available = configura;
            spd2.Available = configura;
            btnSiguiente.Available = configura;
            btnUltimo.Available = configura;
            spd3.Available = configura;
            btnNuevo.Available = configura;
            spd4.Available = configura;
            btnSalir.Available = configura;
            pnl4.Visible = configura;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguraBoton(false);
            txtNombre.Focus();
            nudCantidad.Value = 0;
            lblTrabajo.Text = Utilidad.codigoTrabajo.ToString();
            lblEmpresa.Text = Utilidad.codigoEmpresa.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                txtNombre.Focus();
                ep.SetError(txtNombre, Utilidad.campoVacio);
                return;
            }

            try
            {
                this.Validate();
                this.bsMto.EndEdit();
                if (!btnNuevo.Available)
                {
                    taFrecuencia.Inserta(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, txtNombre.Text.Trim(), Convert.ToInt16(nudCantidad.Value.ToString()));
                    ConfiguraBoton(true);
                    nombre = txtNombre.Text.Trim();
                }
                else
                {
                    taFrecuencia.Edita(txtNombre.Text.Trim(), Convert.ToInt16(nudCantidad.Value.ToString()), Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                }
            }
            catch (NoNullAllowedException nullEx)
            {
                MessageBox.Show(nullEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utilidad.textoCuadroMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnNuevo.Available && grdMto.CurrentRow != null)
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show(Utilidad.mensajeElimina, Utilidad.textoCuadroMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        taFrecuencia.Elimina(Utilidad.codigoTrabajo, Utilidad.codigoEmpresa, nombre);
                        grdMto.Rows.Remove(grdMto.CurrentRow);
                    }
                }
                else if (grdMto.CurrentRow != null)
                {
                    grdMto.Rows.Remove(grdMto.CurrentRow);
                    ConfiguraBoton(true);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMtoFrecuencia_Load(object sender, EventArgs e)
        {
            taFrecuencia.Fill(dsNeo.tbFrecuencia, Utilidad.codigoTrabajo, Utilidad.codigoEmpresa);
        }

        private void FrmMtoFrecuencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilidad.mtoFrecuencia = null;
        }

        private void grdMto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMto.CurrentRow != null)
                nombre = grdMto.CurrentRow.Cells["fNombre"].Value.ToString();
        }
    }
}
