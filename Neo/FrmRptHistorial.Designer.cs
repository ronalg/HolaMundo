namespace Neo
{
    partial class FrmRptHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptHistorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCita = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnVerCita = new System.Windows.Forms.ToolStripButton();
            this.btnVerContacto = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPantalla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMascota = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDueno = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grdHistorial = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsHistorial = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.taHistorialMascota = new Neo.DsNeoTableAdapters.taHistorialMascota();
            this.grdCliente = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.bsMascota = new System.Windows.Forms.BindingSource(this.components);
            this.grdMascota = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.mCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsServicio = new System.Windows.Forms.BindingSource(this.components);
            this.grdServicio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.taMascota = new Neo.DsNeoTableAdapters.taMascota();
            this.taArticulo = new Neo.DsNeoTableAdapters.taArticulo();
            this.bsContacto = new System.Windows.Forms.BindingSource(this.components);
            this.taContacto = new Neo.DsNeoTableAdapters.taSucursalContacto();
            this.pnlContacto = new System.Windows.Forms.Panel();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grdContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaHistorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).BeginInit();
            this.bnCita.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).BeginInit();
            this.pnlContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCita);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1231, 28);
            this.pnl1.TabIndex = 1;
            // 
            // bnCita
            // 
            this.bnCita.AddNewItem = null;
            this.bnCita.CountItem = this.bindingNavigatorCountItem;
            this.bnCita.DeleteItem = null;
            this.bnCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnCita.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnVerCita,
            this.btnVerContacto,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnSalir});
            this.bnCita.Location = new System.Drawing.Point(0, 0);
            this.bnCita.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCita.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCita.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCita.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCita.Name = "bnCita";
            this.bnCita.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCita.Size = new System.Drawing.Size(1229, 25);
            this.bnCita.TabIndex = 7;
            this.bnCita.Text = "bindingNavigator1";
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
            // btnVerCita
            // 
            this.btnVerCita.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCita.Image")));
            this.btnVerCita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerCita.Name = "btnVerCita";
            this.btnVerCita.Size = new System.Drawing.Size(90, 22);
            this.btnVerCita.Text = "Ver Historial";
            this.btnVerCita.Click += new System.EventHandler(this.btnVerCita_Click);
            // 
            // btnVerContacto
            // 
            this.btnVerContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContacto.Image")));
            this.btnVerContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerContacto.Name = "btnVerContacto";
            this.btnVerContacto.Size = new System.Drawing.Size(95, 22);
            this.btnVerContacto.Text = "Ver Contacto";
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
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.txtDescripcion);
            this.pnl2.Controls.Add(this.kryptonLabel7);
            this.pnl2.Controls.Add(this.txtMascota);
            this.pnl2.Controls.Add(this.kryptonLabel6);
            this.pnl2.Controls.Add(this.txtDueno);
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1231, 36);
            this.pnl2.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(714, 7);
            this.txtDescripcion.MaxLength = 15;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 23);
            this.txtDescripcion.TabIndex = 22;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(631, 8);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel7.TabIndex = 23;
            this.kryptonLabel7.Values.Text = "Descripción:";
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(564, 7);
            this.txtMascota.MaxLength = 15;
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(64, 23);
            this.txtMascota.TabIndex = 20;
            this.txtMascota.TextChanged += new System.EventHandler(this.txtMascota_TextChanged);
            this.txtMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMascota_KeyDown);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(498, 8);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel6.TabIndex = 21;
            this.kryptonLabel6.Values.Text = "Mascota:";
            // 
            // txtDueno
            // 
            this.txtDueno.Location = new System.Drawing.Point(348, 6);
            this.txtDueno.MaxLength = 15;
            this.txtDueno.Name = "txtDueno";
            this.txtDueno.Size = new System.Drawing.Size(147, 23);
            this.txtDueno.TabIndex = 10;
            this.txtDueno.TextChanged += new System.EventHandler(this.txtDueno_TextChanged);
            this.txtDueno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDueno_KeyDown);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(294, 7);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Dueño:";
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
            // grdHistorial
            // 
            this.grdHistorial.AllowUserToAddRows = false;
            this.grdHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            this.grdHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdHistorial.AutoGenerateColumns = false;
            this.grdHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.hNumero,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.hCodigo,
            this.numeroCitaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.hFecha,
            this.notaHistorialDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.hNombre,
            this.hSexo,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.hDueno,
            this.descripcionDataGridViewTextBoxColumn,
            this.veterinarioDataGridViewTextBoxColumn,
            this.notaDetalleDataGridViewTextBoxColumn,
            this.codigoArticuloDataGridViewTextBoxColumn,
            this.hGrupo,
            this.hRaza});
            this.grdHistorial.DataSource = this.bsHistorial;
            this.grdHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHistorial.Location = new System.Drawing.Point(0, 64);
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.ReadOnly = true;
            this.grdHistorial.Size = new System.Drawing.Size(1231, 448);
            this.grdHistorial.TabIndex = 5;
            // 
            // bsHistorial
            // 
            this.bsHistorial.DataMember = "tbHistorialMascota";
            this.bsHistorial.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taHistorialMascota
            // 
            this.taHistorialMascota.ClearBeforeFill = true;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue;
            this.grdCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
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
            this.grdCliente.Size = new System.Drawing.Size(268, 150);
            this.grdCliente.TabIndex = 7;
            this.grdCliente.Visible = false;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            this.grdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCliente_KeyDown);
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "CodigoCliente";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigo.DefaultCellStyle = dataGridViewCellStyle13;
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
            this.cNombre.Width = 180;
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "tbCliente";
            this.bsCliente.DataSource = this.dsNeo;
            // 
            // bsMascota
            // 
            this.bsMascota.DataMember = "tbMascota";
            this.bsMascota.DataSource = this.dsNeo;
            // 
            // grdMascota
            // 
            this.grdMascota.AllowUserToAddRows = false;
            this.grdMascota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMascota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grdMascota.AutoGenerateColumns = false;
            this.grdMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMascota.ColumnHeadersVisible = false;
            this.grdMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mCodigo,
            this.mNombre,
            this.mDueno});
            this.grdMascota.DataSource = this.bsMascota;
            this.grdMascota.Location = new System.Drawing.Point(566, 60);
            this.grdMascota.MultiSelect = false;
            this.grdMascota.Name = "grdMascota";
            this.grdMascota.ReadOnly = true;
            this.grdMascota.RowHeadersVisible = false;
            this.grdMascota.Size = new System.Drawing.Size(377, 150);
            this.grdMascota.TabIndex = 8;
            this.grdMascota.Visible = false;
            this.grdMascota.DoubleClick += new System.EventHandler(this.grdMascota_DoubleClick);
            this.grdMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMascota_KeyDown);
            // 
            // mCodigo
            // 
            this.mCodigo.DataPropertyName = "CodigoMascota";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mCodigo.DefaultCellStyle = dataGridViewCellStyle15;
            this.mCodigo.HeaderText = "CodigoMascota";
            this.mCodigo.Name = "mCodigo";
            this.mCodigo.ReadOnly = true;
            this.mCodigo.Width = 60;
            // 
            // mNombre
            // 
            this.mNombre.DataPropertyName = "Nombre";
            this.mNombre.HeaderText = "Nombre";
            this.mNombre.Name = "mNombre";
            this.mNombre.ReadOnly = true;
            // 
            // mDueno
            // 
            this.mDueno.DataPropertyName = "NombreDueno";
            this.mDueno.HeaderText = "NombreDueno";
            this.mDueno.Name = "mDueno";
            this.mDueno.ReadOnly = true;
            this.mDueno.Width = 200;
            // 
            // bsServicio
            // 
            this.bsServicio.DataMember = "tbArticulo";
            this.bsServicio.DataSource = this.dsNeo;
            // 
            // grdServicio
            // 
            this.grdServicio.AllowUserToAddRows = false;
            this.grdServicio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.AliceBlue;
            this.grdServicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.grdServicio.AutoGenerateColumns = false;
            this.grdServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicio.ColumnHeadersVisible = false;
            this.grdServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCodigo,
            this.sDescripcion});
            this.grdServicio.DataSource = this.bsServicio;
            this.grdServicio.Location = new System.Drawing.Point(717, 61);
            this.grdServicio.MultiSelect = false;
            this.grdServicio.Name = "grdServicio";
            this.grdServicio.ReadOnly = true;
            this.grdServicio.RowHeadersVisible = false;
            this.grdServicio.Size = new System.Drawing.Size(278, 150);
            this.grdServicio.TabIndex = 9;
            this.grdServicio.Visible = false;
            this.grdServicio.DoubleClick += new System.EventHandler(this.grdServicio_DoubleClick);
            this.grdServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdServicio_KeyDown);
            // 
            // sCodigo
            // 
            this.sCodigo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sCodigo.DefaultCellStyle = dataGridViewCellStyle17;
            this.sCodigo.HeaderText = "CodigoArticulo";
            this.sCodigo.Name = "sCodigo";
            this.sCodigo.ReadOnly = true;
            this.sCodigo.Width = 60;
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "Descripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            this.sDescripcion.Width = 200;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // taMascota
            // 
            this.taMascota.ClearBeforeFill = true;
            // 
            // taArticulo
            // 
            this.taArticulo.ClearBeforeFill = true;
            // 
            // bsContacto
            // 
            this.bsContacto.DataMember = "tbSucursalContacto";
            this.bsContacto.DataSource = this.dsNeo;
            // 
            // taContacto
            // 
            this.taContacto.ClearBeforeFill = true;
            // 
            // pnlContacto
            // 
            this.pnlContacto.BackColor = System.Drawing.Color.White;
            this.pnlContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContacto.Controls.Add(this.btnCerrar);
            this.pnlContacto.Controls.Add(this.grdContacto);
            this.pnlContacto.Location = new System.Drawing.Point(223, 110);
            this.pnlContacto.Margin = new System.Windows.Forms.Padding(5);
            this.pnlContacto.Name = "pnlContacto";
            this.pnlContacto.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContacto.Size = new System.Drawing.Size(785, 293);
            this.pnlContacto.TabIndex = 10;
            this.pnlContacto.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(712, 259);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 25);
            this.btnCerrar.TabIndex = 73;
            this.btnCerrar.Values.Text = "Cerrar";
            // 
            // grdContacto
            // 
            this.grdContacto.AllowUserToAddRows = false;
            this.grdContacto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            this.grdContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.grdContacto.AutoGenerateColumns = false;
            this.grdContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreContactoDataGridViewTextBoxColumn,
            this.nombreTipoContactoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.representanteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.grdContacto.DataSource = this.bsContacto;
            this.grdContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdContacto.Location = new System.Drawing.Point(5, 5);
            this.grdContacto.Name = "grdContacto";
            this.grdContacto.ReadOnly = true;
            this.grdContacto.Size = new System.Drawing.Size(773, 248);
            this.grdContacto.TabIndex = 72;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTipoContactoDataGridViewTextBoxColumn
            // 
            this.nombreTipoContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoContacto";
            this.nombreTipoContactoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.nombreTipoContactoDataGridViewTextBoxColumn.Name = "nombreTipoContactoDataGridViewTextBoxColumn";
            this.nombreTipoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTipoContactoDataGridViewTextBoxColumn.Width = 70;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactoDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 340;
            // 
            // representanteDataGridViewTextBoxColumn
            // 
            this.representanteDataGridViewTextBoxColumn.DataPropertyName = "Representante";
            this.representanteDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.representanteDataGridViewTextBoxColumn.Name = "representanteDataGridViewTextBoxColumn";
            this.representanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.representanteDataGridViewTextBoxColumn.Visible = false;
            this.representanteDataGridViewTextBoxColumn.Width = 130;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Visible = false;
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
            // hNumero
            // 
            this.hNumero.DataPropertyName = "NumeroHistorial";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.hNumero.DefaultCellStyle = dataGridViewCellStyle11;
            this.hNumero.HeaderText = "Numero";
            this.hNumero.Name = "hNumero";
            this.hNumero.ReadOnly = true;
            this.hNumero.Width = 70;
            // 
            // codigoSucursalDataGridViewTextBoxColumn
            // 
            this.codigoSucursalDataGridViewTextBoxColumn.DataPropertyName = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.Name = "codigoSucursalDataGridViewTextBoxColumn";
            this.codigoSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoSucursalDataGridViewTextBoxColumn.Width = 70;
            // 
            // hCodigo
            // 
            this.hCodigo.DataPropertyName = "CodigoMascota";
            this.hCodigo.HeaderText = "CodigoMascota";
            this.hCodigo.Name = "hCodigo";
            this.hCodigo.ReadOnly = true;
            this.hCodigo.Visible = false;
            // 
            // numeroCitaDataGridViewTextBoxColumn
            // 
            this.numeroCitaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn.HeaderText = "Cita";
            this.numeroCitaDataGridViewTextBoxColumn.Name = "numeroCitaDataGridViewTextBoxColumn";
            this.numeroCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCitaDataGridViewTextBoxColumn.Width = 70;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // hFecha
            // 
            this.hFecha.DataPropertyName = "Fecha";
            this.hFecha.HeaderText = "Fecha";
            this.hFecha.Name = "hFecha";
            this.hFecha.ReadOnly = true;
            // 
            // notaHistorialDataGridViewTextBoxColumn
            // 
            this.notaHistorialDataGridViewTextBoxColumn.DataPropertyName = "NotaHistorial";
            this.notaHistorialDataGridViewTextBoxColumn.HeaderText = "Nota Historial";
            this.notaHistorialDataGridViewTextBoxColumn.Name = "notaHistorialDataGridViewTextBoxColumn";
            this.notaHistorialDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaHistorialDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            this.imagenDataGridViewImageColumn.Visible = false;
            // 
            // hNombre
            // 
            this.hNombre.DataPropertyName = "Mascota";
            this.hNombre.HeaderText = "Mascota";
            this.hNombre.Name = "hNombre";
            this.hNombre.ReadOnly = true;
            this.hNombre.Width = 90;
            // 
            // hSexo
            // 
            this.hSexo.DataPropertyName = "Sexo";
            this.hSexo.HeaderText = "Sexo";
            this.hSexo.Name = "hSexo";
            this.hSexo.ReadOnly = true;
            this.hSexo.Visible = false;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // hDueno
            // 
            this.hDueno.DataPropertyName = "Dueño";
            this.hDueno.HeaderText = "Dueño";
            this.hDueno.Name = "hDueno";
            this.hDueno.ReadOnly = true;
            this.hDueno.Width = 180;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 180;
            // 
            // veterinarioDataGridViewTextBoxColumn
            // 
            this.veterinarioDataGridViewTextBoxColumn.DataPropertyName = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.HeaderText = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.Name = "veterinarioDataGridViewTextBoxColumn";
            this.veterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinarioDataGridViewTextBoxColumn.Width = 180;
            // 
            // notaDetalleDataGridViewTextBoxColumn
            // 
            this.notaDetalleDataGridViewTextBoxColumn.DataPropertyName = "NotaDetalle";
            this.notaDetalleDataGridViewTextBoxColumn.HeaderText = "Nota Detalle";
            this.notaDetalleDataGridViewTextBoxColumn.Name = "notaDetalleDataGridViewTextBoxColumn";
            this.notaDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDetalleDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            this.codigoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // hGrupo
            // 
            this.hGrupo.DataPropertyName = "NombreGrupo";
            this.hGrupo.HeaderText = "NombreGrupo";
            this.hGrupo.Name = "hGrupo";
            this.hGrupo.ReadOnly = true;
            this.hGrupo.Visible = false;
            // 
            // hRaza
            // 
            this.hRaza.DataPropertyName = "NombreRaza";
            this.hRaza.HeaderText = "NombreRaza";
            this.hRaza.Name = "hRaza";
            this.hRaza.ReadOnly = true;
            this.hRaza.Visible = false;
            // 
            // FrmRptHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 512);
            this.Controls.Add(this.pnlContacto);
            this.Controls.Add(this.grdServicio);
            this.Controls.Add(this.grdMascota);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.grdHistorial);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmRptHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRptHistorial_FormClosed);
            this.Load += new System.EventHandler(this.FrmRptHistorial_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).EndInit();
            this.bnCita.ResumeLayout(false);
            this.bnCita.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).EndInit();
            this.pnlContacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnCita;
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
        private System.Windows.Forms.ToolStripButton btnVerCita;
        private System.Windows.Forms.ToolStripButton btnVerContacto;
        private System.Windows.Forms.ToolStripDropDownButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem mnuPantalla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescripcion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDueno;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdHistorial;
        private System.Windows.Forms.BindingSource bsHistorial;
        private DsNeo dsNeo;
        private DsNeoTableAdapters.taHistorialMascota taHistorialMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.BindingSource bsMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDueno;
        private System.Windows.Forms.BindingSource bsServicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private DsNeoTableAdapters.taCliente taCliente;
        private DsNeoTableAdapters.taMascota taMascota;
        private DsNeoTableAdapters.taArticulo taArticulo;
        private System.Windows.Forms.BindingSource bsContacto;
        private DsNeoTableAdapters.taSucursalContacto taContacto;
        private System.Windows.Forms.Panel pnlContacto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaHistorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRaza;
    }
}