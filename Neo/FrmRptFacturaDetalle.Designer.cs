﻿namespace Neo
{
    partial class FrmRptFacturaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptFacturaDetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnFactura = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPantalla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.cboCategoria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dsNeo = new Neo.DsNeo();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboDepartamento = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtArticulo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBeneficio = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCosto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblVenta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdFactura = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.taFactura = new Neo.DsNeoTableAdapters.taFactura();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.grdCliente = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taFnFactura = new Neo.DsNeoTableAdapters.taFnFactura();
            this.grdArticulo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.aCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsArticulo = new System.Windows.Forms.BindingSource(this.components);
            this.taDepartamento = new Neo.DsNeoTableAdapters.taDepartamento();
            this.taCategoria = new Neo.DsNeoTableAdapters.taCategoria();
            this.taArticulo = new Neo.DsNeoTableAdapters.taArticulo();
            this.taFrecuencia = new Neo.DsNeoTableAdapters.taFrecuencia();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secuenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOrdenPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPrecioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFormaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnFactura)).BeginInit();
            this.bnFactura.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento)).BeginInit();
            this.pnl5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnFactura);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1218, 28);
            this.pnl1.TabIndex = 2;
            // 
            // bnFactura
            // 
            this.bnFactura.AddNewItem = null;
            this.bnFactura.CountItem = this.bindingNavigatorCountItem;
            this.bnFactura.DeleteItem = null;
            this.bnFactura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnFactura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSalir});
            this.bnFactura.Location = new System.Drawing.Point(0, 0);
            this.bnFactura.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnFactura.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnFactura.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnFactura.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnFactura.Name = "bnFactura";
            this.bnFactura.PositionItem = this.bindingNavigatorPositionItem;
            this.bnFactura.Size = new System.Drawing.Size(1216, 25);
            this.bnFactura.TabIndex = 7;
            this.bnFactura.Text = "bindingNavigator1";
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
            this.mnuPantalla.Size = new System.Drawing.Size(116, 22);
            this.mnuPantalla.Text = "Pantalla";
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
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.cboCategoria);
            this.pnl2.Controls.Add(this.kryptonLabel9);
            this.pnl2.Controls.Add(this.cboDepartamento);
            this.pnl2.Controls.Add(this.kryptonLabel7);
            this.pnl2.Controls.Add(this.txtArticulo);
            this.pnl2.Controls.Add(this.kryptonLabel6);
            this.pnl2.Controls.Add(this.txtCliente);
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1218, 36);
            this.pnl2.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataSource = this.dsNeo;
            this.cboCategoria.DisplayMember = "tbCategoria.NombreCategoria";
            this.cboCategoria.DropDownWidth = 110;
            this.cboCategoria.Location = new System.Drawing.Point(1097, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(104, 21);
            this.cboCategoria.TabIndex = 21;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel9.Location = new System.Drawing.Point(1024, 6);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel9.TabIndex = 20;
            this.kryptonLabel9.Values.Text = "Categoría:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DataSource = this.dsNeo;
            this.cboDepartamento.DisplayMember = "tbDepartamento.NombreDepartamento";
            this.cboDepartamento.DropDownWidth = 110;
            this.cboDepartamento.Location = new System.Drawing.Point(909, 6);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(110, 21);
            this.cboDepartamento.TabIndex = 19;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            this.cboDepartamento.Validated += new System.EventHandler(this.cboDepartamento_Validated);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(808, 7);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel7.TabIndex = 18;
            this.kryptonLabel7.Values.Text = "Departamento:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(613, 6);
            this.txtArticulo.MaxLength = 15;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(193, 23);
            this.txtArticulo.TabIndex = 16;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(550, 7);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel6.TabIndex = 17;
            this.kryptonLabel6.Values.Text = "Artículo:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(351, 7);
            this.txtCliente.MaxLength = 15;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 23);
            this.txtCliente.TabIndex = 10;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(294, 7);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Cliente:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(198, 7);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 21);
            this.dtpHasta.TabIndex = 13;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(149, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(54, 7);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 12;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // pnl5
            // 
            this.pnl5.Controls.Add(this.pnl6);
            this.pnl5.Controls.Add(this.panel1);
            this.pnl5.Controls.Add(this.pnl4);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 64);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1218, 386);
            this.pnl5.TabIndex = 4;
            // 
            // pnl6
            // 
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl6.Location = new System.Drawing.Point(0, 330);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(1218, 10);
            this.pnl6.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBeneficio);
            this.panel1.Controls.Add(this.kryptonLabel5);
            this.panel1.Controls.Add(this.lblCosto);
            this.panel1.Controls.Add(this.kryptonLabel10);
            this.panel1.Controls.Add(this.lblVenta);
            this.panel1.Controls.Add(this.kryptonLabel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 46);
            this.panel1.TabIndex = 6;
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblBeneficio.Location = new System.Drawing.Point(875, 14);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(6, 2);
            this.lblBeneficio.TabIndex = 7;
            this.lblBeneficio.Values.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(803, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "Beneficio:";
            // 
            // lblCosto
            // 
            this.lblCosto.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCosto.Location = new System.Drawing.Point(595, 14);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(6, 2);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Values.Text = "";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel10.Location = new System.Drawing.Point(546, 14);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel10.TabIndex = 4;
            this.kryptonLabel10.Values.Text = "Coste:";
            // 
            // lblVenta
            // 
            this.lblVenta.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblVenta.Location = new System.Drawing.Point(727, 14);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(6, 2);
            this.lblVenta.TabIndex = 3;
            this.lblVenta.Values.Text = "";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(678, 14);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Venta:";
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdFactura);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1218, 386);
            this.pnl4.TabIndex = 0;
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
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.fNumero,
            this.secuenciaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.condicionDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.numeroOrdenPedidoDataGridViewTextBoxColumn,
            this.numeroCotizacionDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.codigoComprobanteDataGridViewTextBoxColumn,
            this.numeroComprobanteDataGridViewTextBoxColumn,
            this.descuentoFacturaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.fVendedor,
            this.descuentoArticuloDataGridViewTextBoxColumn,
            this.codigoArticuloDataGridViewTextBoxColumn,
            this.codigoPrecioVentaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.NombreDepartamento,
            this.NombreCategoria,
            this.cantidadDataGridViewTextBoxColumn,
            this.fCosto,
            this.fVenta,
            this.nombreFormaPagoDataGridViewTextBoxColumn,
            this.fMonto,
            this.fRecibido,
            this.fCaja});
            this.grdFactura.DataSource = this.bsDetalle;
            this.grdFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFactura.Location = new System.Drawing.Point(0, 0);
            this.grdFactura.Name = "grdFactura";
            this.grdFactura.ReadOnly = true;
            this.grdFactura.Size = new System.Drawing.Size(1216, 384);
            this.grdFactura.TabIndex = 6;
            this.grdFactura.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdFactura_RowPostPaint);
            // 
            // bsDetalle
            // 
            this.bsDetalle.DataMember = "fnFactura";
            this.bsDetalle.DataSource = this.dsNeo;
            // 
            // taFactura
            // 
            this.taFactura.ClearBeforeFill = true;
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "tbCliente";
            this.bsCliente.DataSource = this.dsNeo;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
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
            this.grdCliente.Location = new System.Drawing.Point(350, 59);
            this.grdCliente.MultiSelect = false;
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersVisible = false;
            this.grdCliente.Size = new System.Drawing.Size(389, 131);
            this.grdCliente.TabIndex = 31;
            this.grdCliente.Visible = false;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            this.grdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCliente_KeyDown);
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
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 300;
            // 
            // taFnFactura
            // 
            this.taFnFactura.ClearBeforeFill = true;
            // 
            // grdArticulo
            // 
            this.grdArticulo.AllowUserToAddRows = false;
            this.grdArticulo.AllowUserToDeleteRows = false;
            this.grdArticulo.AutoGenerateColumns = false;
            this.grdArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulo.ColumnHeadersVisible = false;
            this.grdArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCodigo,
            this.aDescripcion});
            this.grdArticulo.DataSource = this.bsArticulo;
            this.grdArticulo.Location = new System.Drawing.Point(613, 58);
            this.grdArticulo.MultiSelect = false;
            this.grdArticulo.Name = "grdArticulo";
            this.grdArticulo.ReadOnly = true;
            this.grdArticulo.RowHeadersVisible = false;
            this.grdArticulo.Size = new System.Drawing.Size(338, 131);
            this.grdArticulo.TabIndex = 32;
            this.grdArticulo.Visible = false;
            this.grdArticulo.DoubleClick += new System.EventHandler(this.grdArticulo_DoubleClick);
            this.grdArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdArticulo_KeyDown);
            // 
            // aCodigo
            // 
            this.aCodigo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aCodigo.DefaultCellStyle = dataGridViewCellStyle10;
            this.aCodigo.HeaderText = "CodigoArticulo";
            this.aCodigo.Name = "aCodigo";
            this.aCodigo.ReadOnly = true;
            this.aCodigo.Width = 70;
            // 
            // aDescripcion
            // 
            this.aDescripcion.DataPropertyName = "Descripcion";
            this.aDescripcion.HeaderText = "Descripcion";
            this.aDescripcion.Name = "aDescripcion";
            this.aDescripcion.ReadOnly = true;
            this.aDescripcion.Width = 250;
            // 
            // bsArticulo
            // 
            this.bsArticulo.DataMember = "tbArticulo";
            this.bsArticulo.DataSource = this.dsNeo;
            // 
            // taDepartamento
            // 
            this.taDepartamento.ClearBeforeFill = true;
            // 
            // taCategoria
            // 
            this.taCategoria.ClearBeforeFill = true;
            // 
            // taArticulo
            // 
            this.taArticulo.ClearBeforeFill = true;
            // 
            // taFrecuencia
            // 
            this.taFrecuencia.ClearBeforeFill = true;
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
            // fNumero
            // 
            this.fNumero.DataPropertyName = "NumeroFactura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fNumero.DefaultCellStyle = dataGridViewCellStyle2;
            this.fNumero.HeaderText = "Número";
            this.fNumero.Name = "fNumero";
            this.fNumero.ReadOnly = true;
            this.fNumero.Width = 70;
            // 
            // secuenciaDataGridViewTextBoxColumn
            // 
            this.secuenciaDataGridViewTextBoxColumn.DataPropertyName = "Secuencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.secuenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.secuenciaDataGridViewTextBoxColumn.HeaderText = "Sec";
            this.secuenciaDataGridViewTextBoxColumn.Name = "secuenciaDataGridViewTextBoxColumn";
            this.secuenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.secuenciaDataGridViewTextBoxColumn.Width = 35;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            this.codigoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // condicionDataGridViewTextBoxColumn
            // 
            this.condicionDataGridViewTextBoxColumn.DataPropertyName = "Condicion";
            this.condicionDataGridViewTextBoxColumn.HeaderText = "Condicion";
            this.condicionDataGridViewTextBoxColumn.Name = "condicionDataGridViewTextBoxColumn";
            this.condicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionDataGridViewTextBoxColumn.Width = 80;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroOrdenPedidoDataGridViewTextBoxColumn
            // 
            this.numeroOrdenPedidoDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrdenPedido";
            this.numeroOrdenPedidoDataGridViewTextBoxColumn.HeaderText = "NumeroOrdenPedido";
            this.numeroOrdenPedidoDataGridViewTextBoxColumn.Name = "numeroOrdenPedidoDataGridViewTextBoxColumn";
            this.numeroOrdenPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroOrdenPedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroCotizacionDataGridViewTextBoxColumn
            // 
            this.numeroCotizacionDataGridViewTextBoxColumn.DataPropertyName = "NumeroCotizacion";
            this.numeroCotizacionDataGridViewTextBoxColumn.HeaderText = "NumeroCotizacion";
            this.numeroCotizacionDataGridViewTextBoxColumn.Name = "numeroCotizacionDataGridViewTextBoxColumn";
            this.numeroCotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCotizacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigoComprobanteDataGridViewTextBoxColumn
            // 
            this.codigoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "CodigoComprobante";
            this.codigoComprobanteDataGridViewTextBoxColumn.HeaderText = "CodigoComprobante";
            this.codigoComprobanteDataGridViewTextBoxColumn.Name = "codigoComprobanteDataGridViewTextBoxColumn";
            this.codigoComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoComprobanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroComprobanteDataGridViewTextBoxColumn
            // 
            this.numeroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumeroComprobante";
            this.numeroComprobanteDataGridViewTextBoxColumn.HeaderText = "NumeroComprobante";
            this.numeroComprobanteDataGridViewTextBoxColumn.Name = "numeroComprobanteDataGridViewTextBoxColumn";
            this.numeroComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroComprobanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // descuentoFacturaDataGridViewTextBoxColumn
            // 
            this.descuentoFacturaDataGridViewTextBoxColumn.DataPropertyName = "DescuentoFactura";
            this.descuentoFacturaDataGridViewTextBoxColumn.HeaderText = "DescuentoFactura";
            this.descuentoFacturaDataGridViewTextBoxColumn.Name = "descuentoFacturaDataGridViewTextBoxColumn";
            this.descuentoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fVendedor
            // 
            this.fVendedor.DataPropertyName = "Vendedor";
            this.fVendedor.HeaderText = "Vendedor";
            this.fVendedor.Name = "fVendedor";
            this.fVendedor.ReadOnly = true;
            this.fVendedor.Visible = false;
            // 
            // descuentoArticuloDataGridViewTextBoxColumn
            // 
            this.descuentoArticuloDataGridViewTextBoxColumn.DataPropertyName = "DescuentoArticulo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.descuentoArticuloDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.descuentoArticuloDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descuentoArticuloDataGridViewTextBoxColumn.Name = "descuentoArticuloDataGridViewTextBoxColumn";
            this.descuentoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoArticuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            this.codigoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn.Visible = false;
            this.codigoArticuloDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigoPrecioVentaDataGridViewTextBoxColumn
            // 
            this.codigoPrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "CodigoPrecioVenta";
            this.codigoPrecioVentaDataGridViewTextBoxColumn.HeaderText = "CodigoPrecioVenta";
            this.codigoPrecioVentaDataGridViewTextBoxColumn.Name = "codigoPrecioVentaDataGridViewTextBoxColumn";
            this.codigoPrecioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPrecioVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // NombreDepartamento
            // 
            this.NombreDepartamento.DataPropertyName = "NombreDepartamento";
            this.NombreDepartamento.HeaderText = "Departamento";
            this.NombreDepartamento.Name = "NombreDepartamento";
            this.NombreDepartamento.ReadOnly = true;
            this.NombreDepartamento.Width = 130;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.DataPropertyName = "NombreCategoria";
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cnt";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 40;
            // 
            // fCosto
            // 
            this.fCosto.DataPropertyName = "Costo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.fCosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.fCosto.HeaderText = "Costo";
            this.fCosto.Name = "fCosto";
            this.fCosto.ReadOnly = true;
            this.fCosto.Width = 80;
            // 
            // fVenta
            // 
            this.fVenta.DataPropertyName = "Venta";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.fVenta.DefaultCellStyle = dataGridViewCellStyle8;
            this.fVenta.HeaderText = "Venta";
            this.fVenta.Name = "fVenta";
            this.fVenta.ReadOnly = true;
            this.fVenta.Width = 80;
            // 
            // nombreFormaPagoDataGridViewTextBoxColumn
            // 
            this.nombreFormaPagoDataGridViewTextBoxColumn.DataPropertyName = "NombreFormaPago";
            this.nombreFormaPagoDataGridViewTextBoxColumn.HeaderText = "NombreFormaPago";
            this.nombreFormaPagoDataGridViewTextBoxColumn.Name = "nombreFormaPagoDataGridViewTextBoxColumn";
            this.nombreFormaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreFormaPagoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fMonto
            // 
            this.fMonto.DataPropertyName = "Monto";
            this.fMonto.HeaderText = "Monto";
            this.fMonto.Name = "fMonto";
            this.fMonto.ReadOnly = true;
            this.fMonto.Visible = false;
            // 
            // fRecibido
            // 
            this.fRecibido.DataPropertyName = "Recibido";
            this.fRecibido.HeaderText = "Recibido";
            this.fRecibido.Name = "fRecibido";
            this.fRecibido.ReadOnly = true;
            this.fRecibido.Visible = false;
            // 
            // fCaja
            // 
            this.fCaja.DataPropertyName = "NombreCaja";
            this.fCaja.HeaderText = "NombreCaja";
            this.fCaja.Name = "fCaja";
            this.fCaja.ReadOnly = true;
            this.fCaja.Visible = false;
            // 
            // FrmRptFacturaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.grdArticulo);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmRptFacturaDetalle";
            this.Text = "Factura Detalles";
            this.Load += new System.EventHandler(this.FrmRptFacturaDetalle_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnFactura)).EndInit();
            this.bnFactura.ResumeLayout(false);
            this.bnFactura.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartamento)).EndInit();
            this.pnl5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnFactura;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnVerFactura;
        private System.Windows.Forms.ToolStripDropDownButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem mnuPantalla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBeneficio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCosto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdFactura;
        private DsNeo dsNeo;
        private DsNeoTableAdapters.taFactura taFactura;
        private System.Windows.Forms.BindingSource bsCliente;
        private DsNeoTableAdapters.taCliente taCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtArticulo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.BindingSource bsDetalle;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCliente;
        private DsNeoTableAdapters.taFnFactura taFnFactura;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdArticulo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboCategoria;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboDepartamento;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private DsNeoTableAdapters.taDepartamento taDepartamento;
        private DsNeoTableAdapters.taCategoria taCategoria;
        private DsNeoTableAdapters.taArticulo taArticulo;
        private System.Windows.Forms.BindingSource bsArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDescripcion;
        private DsNeoTableAdapters.taFrecuencia taFrecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn secuenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrdenPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPrecioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFormaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCaja;
    }
}