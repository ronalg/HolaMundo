namespace Neo
{
    partial class FrmTscReciboIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTscReciboIngreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCuentaCobrar = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCuentaCobrar = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.grdFactura = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.grdCliente = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.taCuentaCobrar = new Neo.DsNeoTableAdapters.taCuentaCobrar();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBalance = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCobro = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblVenta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnVerFactura = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPantalla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalr = new System.Windows.Forms.ToolStripButton();
            this.taFrecuencia = new Neo.DsNeoTableAdapters.taFrecuencia();
            this.taCita = new Neo.DsNeoTableAdapters.taCita();
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.taEmpresa = new Neo.DsNeoTableAdapters.taEmpresa();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSaldar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rAplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCuentaCobrar)).BeginInit();
            this.bnCuentaCobrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCuentaCobrar);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1110, 27);
            this.pnl1.TabIndex = 0;
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
            this.bnCuentaCobrar.Size = new System.Drawing.Size(1108, 25);
            this.bnCuentaCobrar.TabIndex = 4;
            this.bnCuentaCobrar.Text = "bindingNavigator1";
            // 
            // bsCuentaCobrar
            // 
            this.bsCuentaCobrar.DataMember = "tbCuentaCobrar";
            this.bsCuentaCobrar.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 27);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1110, 38);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 65);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1110, 437);
            this.pnl3.TabIndex = 2;
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
            this.pnl6.Location = new System.Drawing.Point(0, 340);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(1108, 95);
            this.pnl6.TabIndex = 1;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.grdFactura);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1108, 435);
            this.pnl5.TabIndex = 0;
            // 
            // grdFactura
            // 
            this.grdFactura.AllowUserToAddRows = false;
            this.grdFactura.AllowUserToDeleteRows = false;
            this.grdFactura.AutoGenerateColumns = false;
            this.grdFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.rNumero,
            this.rCondicion,
            this.dataGridViewTextBoxColumn6,
            this.rCaja,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.rVence,
            this.rVendedor,
            this.rVenta,
            this.rCobro,
            this.rCosto,
            this.rBalance,
            this.rSaldar,
            this.rAplicar});
            this.grdFactura.DataSource = this.bsCuentaCobrar;
            this.grdFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFactura.Location = new System.Drawing.Point(0, 0);
            this.grdFactura.Name = "grdFactura";
            this.grdFactura.Size = new System.Drawing.Size(1106, 433);
            this.grdFactura.TabIndex = 0;
            this.grdFactura.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFactura_CellValidated);
            this.grdFactura.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdFactura_RowPostPaint);
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
            this.cNombre});
            this.grdCliente.DataSource = this.bsCliente;
            this.grdCliente.Location = new System.Drawing.Point(356, 58);
            this.grdCliente.MultiSelect = false;
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersVisible = false;
            this.grdCliente.Size = new System.Drawing.Size(280, 131);
            this.grdCliente.TabIndex = 36;
            this.grdCliente.Visible = false;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            this.grdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCliente_KeyDown);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(357, 34);
            this.txtCliente.MaxLength = 15;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 23);
            this.txtCliente.TabIndex = 30;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(205, 35);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 21);
            this.dtpHasta.TabIndex = 33;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(61, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 32;
            // 
            // taCuentaCobrar
            // 
            this.taCuentaCobrar.ClearBeforeFill = true;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(300, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 38;
            this.kryptonLabel3.Values.Text = "Cliente:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(155, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 37;
            this.kryptonLabel2.Values.Text = "Hasta:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 36;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // lblBalance
            // 
            this.lblBalance.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblBalance.Location = new System.Drawing.Point(1026, 63);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 20);
            this.lblBalance.TabIndex = 20;
            this.lblBalance.Values.Text = "0.00";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(959, 63);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel6.TabIndex = 19;
            this.kryptonLabel6.Values.Text = "Balance:";
            // 
            // lblCobro
            // 
            this.lblCobro.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCobro.Location = new System.Drawing.Point(1024, 37);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(35, 20);
            this.lblCobro.TabIndex = 18;
            this.lblCobro.Values.Text = "0.00";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(967, 37);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "Cobro:";
            // 
            // lblVenta
            // 
            this.lblVenta.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblVenta.Location = new System.Drawing.Point(1026, 11);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(35, 20);
            this.lblVenta.TabIndex = 16;
            this.lblVenta.Values.Text = "0.00";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(967, 11);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "Venta:";
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
            this.mnuPantalla.Click += new System.EventHandler(this.mnuPantalla_Click);
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
            // taFrecuencia
            // 
            this.taFrecuencia.ClearBeforeFill = true;
            // 
            // taCita
            // 
            this.taCita.ClearBeforeFill = true;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // taSucursal
            // 
            this.taSucursal.ClearBeforeFill = true;
            // 
            // taEmpresa
            // 
            this.taEmpresa.ClearBeforeFill = true;
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "tbCliente";
            this.bsCliente.DataSource = this.dsNeo;
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "CodigoCliente";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigo.DefaultCellStyle = dataGridViewCellStyle20;
            this.cCodigo.HeaderText = "CodigoCliente";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            this.cCodigo.Width = 70;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoTrabajo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoTrabajo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoEmpresa";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoEmpresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoSucursal";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoSucursal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // rNumero
            // 
            this.rNumero.DataPropertyName = "NumeroFactura";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rNumero.DefaultCellStyle = dataGridViewCellStyle11;
            this.rNumero.HeaderText = "Número";
            this.rNumero.Name = "rNumero";
            this.rNumero.ReadOnly = true;
            this.rNumero.Width = 70;
            // 
            // rCondicion
            // 
            this.rCondicion.DataPropertyName = "Condicion";
            this.rCondicion.HeaderText = "Condición";
            this.rCondicion.Name = "rCondicion";
            this.rCondicion.ReadOnly = true;
            this.rCondicion.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CantidadDias";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.HeaderText = "Dias";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // rCaja
            // 
            this.rCaja.DataPropertyName = "NombreCaja";
            this.rCaja.HeaderText = "Caja";
            this.rCaja.Name = "rCaja";
            this.rCaja.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "d";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // rVence
            // 
            this.rVence.DataPropertyName = "Vence";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "d";
            this.rVence.DefaultCellStyle = dataGridViewCellStyle14;
            this.rVence.HeaderText = "Vence";
            this.rVence.Name = "rVence";
            this.rVence.ReadOnly = true;
            this.rVence.Width = 80;
            // 
            // rVendedor
            // 
            this.rVendedor.DataPropertyName = "Vendedor";
            this.rVendedor.HeaderText = "Vendedor";
            this.rVendedor.Name = "rVendedor";
            this.rVendedor.ReadOnly = true;
            this.rVendedor.Visible = false;
            // 
            // rVenta
            // 
            this.rVenta.DataPropertyName = "TotalVenta";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            this.rVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.rVenta.HeaderText = "Venta";
            this.rVenta.Name = "rVenta";
            this.rVenta.ReadOnly = true;
            this.rVenta.Width = 80;
            // 
            // rCobro
            // 
            this.rCobro.DataPropertyName = "TotalCobro";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.rCobro.DefaultCellStyle = dataGridViewCellStyle16;
            this.rCobro.HeaderText = "Cobro";
            this.rCobro.Name = "rCobro";
            this.rCobro.ReadOnly = true;
            this.rCobro.Width = 80;
            // 
            // rCosto
            // 
            this.rCosto.DataPropertyName = "TotalCosto";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.rCosto.DefaultCellStyle = dataGridViewCellStyle17;
            this.rCosto.HeaderText = "Costo";
            this.rCosto.Name = "rCosto";
            this.rCosto.ReadOnly = true;
            this.rCosto.Visible = false;
            this.rCosto.Width = 80;
            // 
            // rBalance
            // 
            this.rBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            this.rBalance.DefaultCellStyle = dataGridViewCellStyle18;
            this.rBalance.HeaderText = "Balance";
            this.rBalance.Name = "rBalance";
            this.rBalance.ReadOnly = true;
            this.rBalance.Width = 80;
            // 
            // rSaldar
            // 
            this.rSaldar.DataPropertyName = "Saldar";
            this.rSaldar.HeaderText = "Saldar";
            this.rSaldar.Name = "rSaldar";
            this.rSaldar.Width = 50;
            // 
            // rAplicar
            // 
            this.rAplicar.DataPropertyName = "Aplicar";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = "0.00";
            this.rAplicar.DefaultCellStyle = dataGridViewCellStyle19;
            this.rAplicar.HeaderText = "Aplicar";
            this.rAplicar.Name = "rAplicar";
            this.rAplicar.Width = 90;
            // 
            // FrmTscReciboIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 502);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmTscReciboIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo de Ingreso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTscReciboIngreso_FormClosed);
            this.Load += new System.EventHandler(this.FrmTscReciboIngreso_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCuentaCobrar)).EndInit();
            this.bnCuentaCobrar.ResumeLayout(false);
            this.bnCuentaCobrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCuentaCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.pnl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
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
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBalance;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCobro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnVerFactura;
        private System.Windows.Forms.ToolStripDropDownButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem mnuPantalla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalr;
        private DsNeoTableAdapters.taFrecuencia taFrecuencia;
        private DsNeoTableAdapters.taCita taCita;
        private DsNeoTableAdapters.taCliente taCliente;
        private DsNeoTableAdapters.taSucursal taSucursal;
        private DsNeoTableAdapters.taEmpresa taEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn rVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn rVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn rVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rBalance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rSaldar;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAplicar;
    }
}