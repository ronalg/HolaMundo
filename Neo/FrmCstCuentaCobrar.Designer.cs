namespace Neo
{
    partial class FrmCstCuentaCobrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCstCuentaCobrar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.lblBalance = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCobro = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblVenta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.grdFactura = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCuentaCobrar = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnVerFactura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalr = new System.Windows.Forms.ToolStripButton();
            this.grdCliente = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCuentaCobrar = new System.Windows.Forms.BindingSource(this.components);
            this.taCuentaCobrar = new Neo.DsNeoTableAdapters.taCuentaCobrar();
            this.taFrecuencia = new Neo.DsNeoTableAdapters.taFrecuencia();
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPantalla = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).BeginInit();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCuentaCobrar)).BeginInit();
            this.bnCuentaCobrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 66);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1278, 537);
            this.pnl3.TabIndex = 5;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.lblBalance);
            this.pnl6.Controls.Add(this.kryptonLabel6);
            this.pnl6.Controls.Add(this.lblCobro);
            this.pnl6.Controls.Add(this.kryptonLabel5);
            this.pnl6.Controls.Add(this.lblVenta);
            this.pnl6.Controls.Add(this.kryptonLabel8);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl6.Location = new System.Drawing.Point(0, 488);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(1276, 47);
            this.pnl6.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblBalance.Location = new System.Drawing.Point(1201, 13);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 20);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Values.Text = "0.00";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(1134, 13);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel6.TabIndex = 13;
            this.kryptonLabel6.Values.Text = "Balance:";
            // 
            // lblCobro
            // 
            this.lblCobro.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCobro.Location = new System.Drawing.Point(1090, 13);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(35, 20);
            this.lblCobro.TabIndex = 12;
            this.lblCobro.Values.Text = "0.00";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(1031, 13);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "Cobro:";
            // 
            // lblVenta
            // 
            this.lblVenta.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblVenta.Location = new System.Drawing.Point(964, 13);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(35, 20);
            this.lblVenta.TabIndex = 10;
            this.lblVenta.Values.Text = "0.00";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(910, 13);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel8.TabIndex = 8;
            this.kryptonLabel8.Values.Text = "Venta:";
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.grdFactura);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1276, 535);
            this.pnl5.TabIndex = 0;
            // 
            // grdFactura
            // 
            this.grdFactura.AllowUserToAddRows = false;
            this.grdFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.grdFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFactura.AutoGenerateColumns = false;
            this.grdFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cNumero,
            this.cNombre,
            this.cFecha,
            this.cVence,
            this.cCondicion,
            this.cDias,
            this.cCaja,
            this.cUsuario,
            this.cVendedor,
            this.cVenta,
            this.cCobro,
            this.cCosto,
            this.cBalance});
            this.grdFactura.DataSource = this.bsCuentaCobrar;
            this.grdFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFactura.Location = new System.Drawing.Point(0, 0);
            this.grdFactura.Name = "grdFactura";
            this.grdFactura.ReadOnly = true;
            this.grdFactura.Size = new System.Drawing.Size(1274, 533);
            this.grdFactura.TabIndex = 0;
            this.grdFactura.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdFactura_RowPostPaint);
            // 
            // cBalance
            // 
            this.cBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.cBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.cBalance.HeaderText = "Balance";
            this.cBalance.Name = "cBalance";
            this.cBalance.ReadOnly = true;
            this.cBalance.Width = 80;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.txtCliente);
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 27);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1278, 39);
            this.pnl2.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(350, 6);
            this.txtCliente.MaxLength = 15;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 23);
            this.txtCliente.TabIndex = 30;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(293, 7);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 35;
            this.kryptonLabel3.Values.Text = "Cliente:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(197, 7);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 21);
            this.dtpHasta.TabIndex = 33;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(148, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 34;
            this.kryptonLabel2.Values.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(53, 7);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 32;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCuentaCobrar);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1278, 27);
            this.pnl1.TabIndex = 3;
            // 
            // bnCuentaCobrar
            // 
            this.bnCuentaCobrar.AddNewItem = null;
            this.bnCuentaCobrar.BindingSource = this.bsCuentaCobrar;
            this.bnCuentaCobrar.CountItem = this.bindingNavigatorCountItem;
            this.bnCuentaCobrar.DeleteItem = null;
            this.bnCuentaCobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnCuentaCobrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnBuscar,
            this.btnVerFactura,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnSalr});
            this.bnCuentaCobrar.Location = new System.Drawing.Point(0, 0);
            this.bnCuentaCobrar.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCuentaCobrar.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCuentaCobrar.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCuentaCobrar.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCuentaCobrar.Name = "bnCuentaCobrar";
            this.bnCuentaCobrar.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCuentaCobrar.Size = new System.Drawing.Size(1276, 25);
            this.bnCuentaCobrar.TabIndex = 7;
            this.bnCuentaCobrar.Text = "bindingNavigator1";
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
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnVerFactura.Image")));
            this.btnVerFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(85, 22);
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalr
            // 
            this.btnSalr.Image = ((System.Drawing.Image)(resources.GetObject("btnSalr.Image")));
            this.btnSalr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalr.Name = "btnSalr";
            this.btnSalr.Size = new System.Drawing.Size(49, 22);
            this.btnSalr.Text = "Salir";
            this.btnSalr.Click += new System.EventHandler(this.btnSalr_Click);
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AutoGenerateColumns = false;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.ColumnHeadersVisible = false;
            this.grdCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.ccNombre});
            this.grdCliente.DataSource = this.bsCliente;
            this.grdCliente.Location = new System.Drawing.Point(351, 58);
            this.grdCliente.MultiSelect = false;
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersVisible = false;
            this.grdCliente.Size = new System.Drawing.Size(282, 131);
            this.grdCliente.TabIndex = 37;
            this.grdCliente.Visible = false;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            this.grdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCliente_KeyDown);
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "tbCliente";
            this.bsCliente.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoTrabajo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoTrabajo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoEmpresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoEmpresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoSucursal";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoSucursal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // cNumero
            // 
            this.cNumero.DataPropertyName = "NumeroFactura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNumero.DefaultCellStyle = dataGridViewCellStyle2;
            this.cNumero.HeaderText = "Nro Factura";
            this.cNumero.Name = "cNumero";
            this.cNumero.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 200;
            // 
            // cFecha
            // 
            this.cFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            this.cFecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            this.cFecha.Width = 80;
            // 
            // cVence
            // 
            this.cVence.DataPropertyName = "Vence";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            this.cVence.DefaultCellStyle = dataGridViewCellStyle4;
            this.cVence.HeaderText = "Vence";
            this.cVence.Name = "cVence";
            this.cVence.ReadOnly = true;
            this.cVence.Width = 80;
            // 
            // cCondicion
            // 
            this.cCondicion.DataPropertyName = "Condicion";
            this.cCondicion.HeaderText = "Condición";
            this.cCondicion.Name = "cCondicion";
            this.cCondicion.ReadOnly = true;
            // 
            // cDias
            // 
            this.cDias.DataPropertyName = "CantidadDias";
            this.cDias.HeaderText = "Dias";
            this.cDias.Name = "cDias";
            this.cDias.ReadOnly = true;
            this.cDias.Width = 50;
            // 
            // cCaja
            // 
            this.cCaja.DataPropertyName = "NombreCaja";
            this.cCaja.HeaderText = "Caja";
            this.cCaja.Name = "cCaja";
            this.cCaja.ReadOnly = true;
            // 
            // cUsuario
            // 
            this.cUsuario.DataPropertyName = "Usuario";
            this.cUsuario.HeaderText = "Usuario";
            this.cUsuario.Name = "cUsuario";
            this.cUsuario.ReadOnly = true;
            // 
            // cVendedor
            // 
            this.cVendedor.DataPropertyName = "Vendedor";
            this.cVendedor.HeaderText = "Vendedor";
            this.cVendedor.Name = "cVendedor";
            this.cVendedor.ReadOnly = true;
            this.cVendedor.Width = 160;
            // 
            // cVenta
            // 
            this.cVenta.DataPropertyName = "TotalVenta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.cVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.cVenta.HeaderText = "Venta";
            this.cVenta.Name = "cVenta";
            this.cVenta.ReadOnly = true;
            this.cVenta.Width = 80;
            // 
            // cCobro
            // 
            this.cCobro.DataPropertyName = "TotalCobro";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.cCobro.DefaultCellStyle = dataGridViewCellStyle6;
            this.cCobro.HeaderText = "Cobro";
            this.cCobro.Name = "cCobro";
            this.cCobro.ReadOnly = true;
            this.cCobro.Width = 80;
            // 
            // cCosto
            // 
            this.cCosto.DataPropertyName = "TotalCosto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.cCosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.cCosto.HeaderText = "Costo";
            this.cCosto.Name = "cCosto";
            this.cCosto.ReadOnly = true;
            this.cCosto.Visible = false;
            this.cCosto.Width = 80;
            // 
            // bsCuentaCobrar
            // 
            this.bsCuentaCobrar.DataMember = "tbCuentaCobrar";
            this.bsCuentaCobrar.DataSource = this.dsNeo;
            // 
            // taCuentaCobrar
            // 
            this.taCuentaCobrar.ClearBeforeFill = true;
            // 
            // taFrecuencia
            // 
            this.taFrecuencia.ClearBeforeFill = true;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "CodigoCliente";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigo.DefaultCellStyle = dataGridViewCellStyle9;
            this.cCodigo.HeaderText = "CodigoCliente";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            this.cCodigo.Width = 70;
            // 
            // ccNombre
            // 
            this.ccNombre.DataPropertyName = "Nombre";
            this.ccNombre.HeaderText = "Nombre";
            this.ccNombre.Name = "ccNombre";
            this.ccNombre.ReadOnly = true;
            this.ccNombre.Width = 200;
            // 
            // btnImprimir
            // 
            this.btnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPantalla});
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // mnuPantalla
            // 
            this.mnuPantalla.Name = "mnuPantalla";
            this.mnuPantalla.Size = new System.Drawing.Size(180, 22);
            this.mnuPantalla.Text = "Pantalla";
            // 
            // FrmCstCuentaCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 603);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmCstCuentaCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Cobrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCstCuentaCobrar_FormClosed);
            this.Load += new System.EventHandler(this.FrmCstCuentaCobrar_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.pnl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCuentaCobrar)).EndInit();
            this.bnCuentaCobrar.ResumeLayout(false);
            this.bnCuentaCobrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaCobrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsCuentaCobrar;
        private DsNeoTableAdapters.taCuentaCobrar taCuentaCobrar;
        private System.Windows.Forms.BindingNavigator bnCuentaCobrar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdFactura;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCliente;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnVerFactura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCobro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBalance;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBalance;
        private DsNeoTableAdapters.taFrecuencia taFrecuencia;
        private DsNeoTableAdapters.taCliente taCliente;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccNombre;
        private System.Windows.Forms.ToolStripDropDownButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem mnuPantalla;
    }
}