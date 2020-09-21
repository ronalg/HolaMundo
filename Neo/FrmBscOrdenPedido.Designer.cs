namespace Neo
{
    partial class FrmBscOrdenPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBscOrdenPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdPedido = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.oCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCodigoClienteSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNeo = new Neo.DsNeo();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.bnOrdenPedido = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.taBuscaArticulo = new Neo.DsNeoTableAdapters.taBuscaArticulo();
            this.oCodigoSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCodigoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrdenPedido = new System.Windows.Forms.BindingSource(this.components);
            this.taFnOrdenPedido = new Neo.DsNeoTableAdapters.taFnOrdenPedido();
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.pnl1.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl2.SuspendLayout();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrdenPedido)).BeginInit();
            this.bnOrdenPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.pnl4);
            this.pnl1.Controls.Add(this.pnl3);
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(5, 5);
            this.pnl1.Name = "pnl1";
            this.pnl1.Padding = new System.Windows.Forms.Padding(5);
            this.pnl1.Size = new System.Drawing.Size(811, 472);
            this.pnl1.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdPedido);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl4.Location = new System.Drawing.Point(5, 98);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(799, 367);
            this.pnl4.TabIndex = 2;
            // 
            // grdPedido
            // 
            this.grdPedido.AllowUserToAddRows = false;
            this.grdPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.grdPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPedido.AutoGenerateColumns = false;
            this.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oNumero,
            this.oNombre,
            this.oCodigoMoneda,
            this.oFecha,
            this.oHora,
            this.oCodigoCliente,
            this.oCodigoClienteSucursal,
            this.oCodigoSucursal});
            this.grdPedido.DataSource = this.bsOrdenPedido;
            this.grdPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPedido.Location = new System.Drawing.Point(0, 0);
            this.grdPedido.Name = "grdPedido";
            this.grdPedido.ReadOnly = true;
            this.grdPedido.Size = new System.Drawing.Size(797, 365);
            this.grdPedido.TabIndex = 6;
            // 
            // oCodigoCliente
            // 
            this.oCodigoCliente.DataPropertyName = "CodigoCliente";
            this.oCodigoCliente.HeaderText = "CodigoCliente";
            this.oCodigoCliente.Name = "oCodigoCliente";
            this.oCodigoCliente.ReadOnly = true;
            this.oCodigoCliente.Visible = false;
            // 
            // oCodigoClienteSucursal
            // 
            this.oCodigoClienteSucursal.DataPropertyName = "CodigoClienteSucursal";
            this.oCodigoClienteSucursal.HeaderText = "CodigoClienteSucursal";
            this.oCodigoClienteSucursal.Name = "oCodigoClienteSucursal";
            this.oCodigoClienteSucursal.ReadOnly = true;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl3
            // 
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(5, 88);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(799, 10);
            this.pnl3.TabIndex = 1;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.pnl5);
            this.pnl2.Controls.Add(this.label4);
            this.pnl2.Controls.Add(this.btnBuscar);
            this.pnl2.Controls.Add(this.txtCliente);
            this.pnl2.Controls.Add(this.label3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.label1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(5, 5);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(799, 83);
            this.pnl2.TabIndex = 0;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.bnOrdenPedido);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl5.Location = new System.Drawing.Point(0, 14);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(797, 27);
            this.pnl5.TabIndex = 9;
            // 
            // bnOrdenPedido
            // 
            this.bnOrdenPedido.AddNewItem = null;
            this.bnOrdenPedido.BindingSource = this.bsOrdenPedido;
            this.bnOrdenPedido.CountItem = this.bindingNavigatorCountItem;
            this.bnOrdenPedido.DeleteItem = null;
            this.bnOrdenPedido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnOrdenPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnVer,
            this.toolStripSeparator1,
            this.btnSalir});
            this.bnOrdenPedido.Location = new System.Drawing.Point(0, 0);
            this.bnOrdenPedido.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOrdenPedido.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOrdenPedido.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOrdenPedido.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOrdenPedido.Name = "bnOrdenPedido";
            this.bnOrdenPedido.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOrdenPedido.Size = new System.Drawing.Size(795, 25);
            this.bnOrdenPedido.TabIndex = 8;
            this.bnOrdenPedido.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(43, 22);
            this.btnVer.Text = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(797, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filtros";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(633, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(337, 52);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(290, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(192, 51);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(88, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(54, 51);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(88, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // taBuscaArticulo
            // 
            this.taBuscaArticulo.ClearBeforeFill = true;
            // 
            // oCodigoSucursal
            // 
            this.oCodigoSucursal.DataPropertyName = "CodigoSucursal";
            this.oCodigoSucursal.HeaderText = "CodigoSucursal";
            this.oCodigoSucursal.Name = "oCodigoSucursal";
            this.oCodigoSucursal.ReadOnly = true;
            this.oCodigoSucursal.Visible = false;
            // 
            // oNumero
            // 
            this.oNumero.DataPropertyName = "NumeroOrdenPedido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oNumero.DefaultCellStyle = dataGridViewCellStyle2;
            this.oNumero.HeaderText = "Número";
            this.oNumero.Name = "oNumero";
            this.oNumero.ReadOnly = true;
            this.oNumero.Width = 80;
            // 
            // oNombre
            // 
            this.oNombre.DataPropertyName = "Nombre";
            this.oNombre.HeaderText = "Nombre";
            this.oNombre.Name = "oNombre";
            this.oNombre.ReadOnly = true;
            this.oNombre.Width = 400;
            // 
            // oCodigoMoneda
            // 
            this.oCodigoMoneda.DataPropertyName = "CodigoMoneda";
            this.oCodigoMoneda.HeaderText = "CodigoMoneda";
            this.oCodigoMoneda.Name = "oCodigoMoneda";
            this.oCodigoMoneda.ReadOnly = true;
            this.oCodigoMoneda.Visible = false;
            // 
            // oFecha
            // 
            this.oFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            this.oFecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.oFecha.HeaderText = "Fecha";
            this.oFecha.Name = "oFecha";
            this.oFecha.ReadOnly = true;
            this.oFecha.Width = 80;
            // 
            // oHora
            // 
            this.oHora.DataPropertyName = "Hora";
            this.oHora.HeaderText = "Hora";
            this.oHora.Name = "oHora";
            this.oHora.ReadOnly = true;
            this.oHora.Width = 70;
            // 
            // bsOrdenPedido
            // 
            this.bsOrdenPedido.DataMember = "fnOrdenPedido";
            this.bsOrdenPedido.DataSource = this.dsNeo;
            // 
            // taFnOrdenPedido
            // 
            this.taFnOrdenPedido.ClearBeforeFill = true;
            // 
            // taSucursal
            // 
            this.taSucursal.ClearBeforeFill = true;
            // 
            // FrmBscOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 482);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmBscOrdenPedido";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Ordenes de Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBscOrdenPedido_FormClosed);
            this.Load += new System.EventHandler(this.FrmBscOrdenPedido_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl5.ResumeLayout(false);
            this.pnl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrdenPedido)).EndInit();
            this.bnOrdenPedido.ResumeLayout(false);
            this.bnOrdenPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdPedido;
        private System.Windows.Forms.BindingSource bsOrdenPedido;
        private DsNeo dsNeo;
        private DsNeoTableAdapters.taBuscaArticulo taBuscaArticulo;
        private DsNeoTableAdapters.taFnOrdenPedido taFnOrdenPedido;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.BindingNavigator bnOrdenPedido;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCodigoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCodigoClienteSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCodigoSucursal;
        private DsNeoTableAdapters.taSucursal taSucursal;
    }
}