﻿namespace Neo
{
    partial class FrmMtoCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreCajaLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoCaja));
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.codigoTrabajoLabel1 = new System.Windows.Forms.Label();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.nombreCajaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnMto = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.lblRegistro = new System.Windows.Forms.ToolStripLabel();
            this.btnPrimero = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.spd1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPosicion = new System.Windows.Forms.ToolStripTextBox();
            this.spd2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.spd3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.taCaja = new Neo.DsNeoTableAdapters.taCaja();
            this.codigoEmpresaLabel1 = new System.Windows.Forms.Label();
            this.codigoSucursalLabel1 = new System.Windows.Forms.Label();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCajaLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreCajaLabel
            // 
            nombreCajaLabel.AutoSize = true;
            nombreCajaLabel.Location = new System.Drawing.Point(24, 27);
            nombreCajaLabel.Name = "nombreCajaLabel";
            nombreCajaLabel.Size = new System.Drawing.Size(47, 13);
            nombreCajaLabel.TabIndex = 6;
            nombreCajaLabel.Text = "Nombre:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(25, 71);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 7;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // spd4
            // 
            this.spd4.Name = "spd4";
            this.spd4.Size = new System.Drawing.Size(6, 25);
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 38);
            this.pnl3.Name = "pnl3";
            this.pnl3.Padding = new System.Windows.Forms.Padding(5);
            this.pnl3.Size = new System.Drawing.Size(493, 221);
            this.pnl3.TabIndex = 7;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(codigoSucursalLabel);
            this.pnl6.Controls.Add(this.codigoSucursalLabel1);
            this.pnl6.Controls.Add(codigoEmpresaLabel);
            this.pnl6.Controls.Add(this.codigoEmpresaLabel1);
            this.pnl6.Controls.Add(codigoTrabajoLabel);
            this.pnl6.Controls.Add(this.codigoTrabajoLabel1);
            this.pnl6.Controls.Add(nombreCajaLabel);
            this.pnl6.Controls.Add(this.nombreCajaTextBox);
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Controls.Add(this.label1);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(237, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(249, 209);
            this.pnl6.TabIndex = 6;
            // 
            // codigoTrabajoLabel1
            // 
            this.codigoTrabajoLabel1.BackColor = System.Drawing.Color.LightGray;
            this.codigoTrabajoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTrabajoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.codigoTrabajoLabel1.Location = new System.Drawing.Point(73, 68);
            this.codigoTrabajoLabel1.Name = "codigoTrabajoLabel1";
            this.codigoTrabajoLabel1.Size = new System.Drawing.Size(143, 20);
            this.codigoTrabajoLabel1.TabIndex = 8;
            this.codigoTrabajoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbCaja";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreCajaTextBox
            // 
            this.nombreCajaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreCaja", true));
            this.nombreCajaTextBox.Location = new System.Drawing.Point(73, 24);
            this.nombreCajaTextBox.Name = "nombreCajaTextBox";
            this.nombreCajaTextBox.Size = new System.Drawing.Size(143, 20);
            this.nombreCajaTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(227, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 209);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(222, 209);
            this.pnl4.TabIndex = 4;
            // 
            // grdMto
            // 
            this.grdMto.AllowUserToAddRows = false;
            this.grdMto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.cNombre});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(220, 207);
            this.grdMto.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(493, 10);
            this.pnl2.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnMto);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(493, 28);
            this.pnl1.TabIndex = 5;
            // 
            // bnMto
            // 
            this.bnMto.AddNewItem = this.btnNuevo;
            this.bnMto.BindingSource = this.bsMto;
            this.bnMto.CountItem = this.lblRegistro;
            this.bnMto.DeleteItem = null;
            this.bnMto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnMto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.spd1,
            this.txtPosicion,
            this.lblRegistro,
            this.spd2,
            this.btnSiguiente,
            this.btnUltimo,
            this.spd3,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.spd4,
            this.btnSalir});
            this.bnMto.Location = new System.Drawing.Point(0, 0);
            this.bnMto.MoveFirstItem = this.btnPrimero;
            this.bnMto.MoveLastItem = this.btnUltimo;
            this.bnMto.MoveNextItem = this.btnSiguiente;
            this.bnMto.MovePreviousItem = this.btnAnterior;
            this.bnMto.Name = "bnMto";
            this.bnMto.PositionItem = this.txtPosicion;
            this.bnMto.Size = new System.Drawing.Size(491, 25);
            this.bnMto.TabIndex = 1;
            this.bnMto.Text = "bindingNavigator1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(37, 22);
            this.lblRegistro.Text = "de {0}";
            this.lblRegistro.ToolTipText = "Número total de elementos";
            // 
            // btnPrimero
            // 
            this.btnPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.RightToLeftAutoMirrorImage = true;
            this.btnPrimero.Size = new System.Drawing.Size(23, 22);
            this.btnPrimero.Text = "Mover primero";
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.RightToLeftAutoMirrorImage = true;
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Mover anterior";
            // 
            // spd1
            // 
            this.spd1.Name = "spd1";
            this.spd1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPosicion
            // 
            this.txtPosicion.AccessibleName = "Posición";
            this.txtPosicion.AutoSize = false;
            this.txtPosicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(50, 23);
            this.txtPosicion.Text = "0";
            this.txtPosicion.ToolTipText = "Posición actual";
            // 
            // spd2
            // 
            this.spd2.Name = "spd2";
            this.spd2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.RightToLeftAutoMirrorImage = true;
            this.btnSiguiente.Size = new System.Drawing.Size(23, 22);
            this.btnSiguiente.Text = "Mover siguiente";
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.RightToLeftAutoMirrorImage = true;
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "Mover último";
            // 
            // spd3
            // 
            this.spd3.Name = "spd3";
            this.spd3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // taCaja
            // 
            this.taCaja.ClearBeforeFill = true;
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(20, 94);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 8;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoEmpresaLabel1
            // 
            this.codigoEmpresaLabel1.BackColor = System.Drawing.Color.LightGray;
            this.codigoEmpresaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoEmpresaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.codigoEmpresaLabel1.Location = new System.Drawing.Point(73, 91);
            this.codigoEmpresaLabel1.Name = "codigoEmpresaLabel1";
            this.codigoEmpresaLabel1.Size = new System.Drawing.Size(143, 20);
            this.codigoEmpresaLabel1.TabIndex = 9;
            this.codigoEmpresaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(20, 117);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 9;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // codigoSucursalLabel1
            // 
            this.codigoSucursalLabel1.BackColor = System.Drawing.Color.LightGray;
            this.codigoSucursalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoSucursalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoSucursal", true));
            this.codigoSucursalLabel1.Location = new System.Drawing.Point(73, 114);
            this.codigoSucursalLabel1.Name = "codigoSucursalLabel1";
            this.codigoSucursalLabel1.Size = new System.Drawing.Size(143, 20);
            this.codigoSucursalLabel1.TabIndex = 10;
            this.codigoSucursalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codigoTrabajoDataGridViewTextBoxColumn
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn.HeaderText = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn.Name = "codigoTrabajoDataGridViewTextBoxColumn";
            this.codigoTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoTrabajoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoEmpresaDataGridViewTextBoxColumn
            // 
            this.codigoEmpresaDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn.HeaderText = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn.Name = "codigoEmpresaDataGridViewTextBoxColumn";
            this.codigoEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoEmpresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoSucursalDataGridViewTextBoxColumn
            // 
            this.codigoSucursalDataGridViewTextBoxColumn.DataPropertyName = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.HeaderText = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.Name = "codigoSucursalDataGridViewTextBoxColumn";
            this.codigoSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "NombreCaja";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 160;
            // 
            // FrmMtoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 259);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajas";
            this.Load += new System.EventHandler(this.FrmMtoCaja_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).EndInit();
            this.bnMto.ResumeLayout(false);
            this.bnMto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator spd4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnMto;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripLabel lblRegistro;
        private System.Windows.Forms.ToolStripButton btnPrimero;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripSeparator spd1;
        private System.Windows.Forms.ToolStripTextBox txtPosicion;
        private System.Windows.Forms.ToolStripSeparator spd2;
        private System.Windows.Forms.ToolStripButton btnSiguiente;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator spd3;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Label codigoTrabajoLabel1;
        private System.Windows.Forms.TextBox nombreCajaTextBox;
        private DsNeoTableAdapters.taCaja taCaja;
        private System.Windows.Forms.Label codigoSucursalLabel1;
        private System.Windows.Forms.Label codigoEmpresaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
    }
}