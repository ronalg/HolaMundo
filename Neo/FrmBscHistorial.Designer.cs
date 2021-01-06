namespace Neo
{
    partial class FrmBscHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBscHistorial));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnHistorial = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnVer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtMascota = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.grdHistorial = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dsNeo = new Neo.DsNeo();
            this.bsHistorial = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroHistorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaHistorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.mascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnHistorial)).BeginInit();
            this.bnHistorial.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnHistorial);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1030, 28);
            this.pnl1.TabIndex = 1;
            // 
            // bnHistorial
            // 
            this.bnHistorial.AddNewItem = null;
            this.bnHistorial.CountItem = this.bindingNavigatorCountItem;
            this.bnHistorial.DeleteItem = null;
            this.bnHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnHistorial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnVer,
            this.toolStripSeparator1,
            this.btnSalir});
            this.bnHistorial.Location = new System.Drawing.Point(0, 0);
            this.bnHistorial.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnHistorial.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnHistorial.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnHistorial.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnHistorial.Name = "bnHistorial";
            this.bnHistorial.PositionItem = this.bindingNavigatorPositionItem;
            this.bnHistorial.Size = new System.Drawing.Size(1028, 25);
            this.bnHistorial.TabIndex = 5;
            this.bnHistorial.Text = "bindingNavigator1";
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
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(43, 22);
            this.btnVer.Text = "Ver";
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
            this.pnl2.Controls.Add(this.txtMascota);
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1030, 42);
            this.pnl2.TabIndex = 2;
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(403, 9);
            this.txtMascota.MaxLength = 15;
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(124, 23);
            this.txtMascota.TabIndex = 0;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(293, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(107, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Mascota/Dueño:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarTodayDate = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(197, 9);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dtpHasta.Size = new System.Drawing.Size(94, 21);
            this.dtpHasta.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(148, 9);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarTodayDate = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(53, 9);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 9);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 70);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1030, 10);
            this.pnl3.TabIndex = 3;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1028, 156);
            this.pnl4.TabIndex = 4;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.grdHistorial);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 80);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1030, 370);
            this.pnl5.TabIndex = 4;
            // 
            // grdHistorial
            // 
            this.grdHistorial.AllowUserToAddRows = false;
            this.grdHistorial.AllowUserToDeleteRows = false;
            this.grdHistorial.AutoGenerateColumns = false;
            this.grdHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.numeroHistorialDataGridViewTextBoxColumn,
            this.codigoMascotaDataGridViewTextBoxColumn,
            this.numeroCitaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.notaHistorialDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.mascotaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.dueñoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.veterinarioDataGridViewTextBoxColumn,
            this.notaDetalleDataGridViewTextBoxColumn});
            this.grdHistorial.DataSource = this.bsHistorial;
            this.grdHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHistorial.Location = new System.Drawing.Point(0, 0);
            this.grdHistorial.Name = "grdHistorial";
            this.grdHistorial.ReadOnly = true;
            this.grdHistorial.Size = new System.Drawing.Size(1028, 368);
            this.grdHistorial.TabIndex = 0;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsHistorial
            // 
            this.bsHistorial.DataMember = "tbHistorialMascota";
            this.bsHistorial.DataSource = this.dsNeo;
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
            // numeroHistorialDataGridViewTextBoxColumn
            // 
            this.numeroHistorialDataGridViewTextBoxColumn.DataPropertyName = "NumeroHistorial";
            this.numeroHistorialDataGridViewTextBoxColumn.HeaderText = "NumeroHistorial";
            this.numeroHistorialDataGridViewTextBoxColumn.Name = "numeroHistorialDataGridViewTextBoxColumn";
            this.numeroHistorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoMascotaDataGridViewTextBoxColumn
            // 
            this.codigoMascotaDataGridViewTextBoxColumn.DataPropertyName = "CodigoMascota";
            this.codigoMascotaDataGridViewTextBoxColumn.HeaderText = "CodigoMascota";
            this.codigoMascotaDataGridViewTextBoxColumn.Name = "codigoMascotaDataGridViewTextBoxColumn";
            this.codigoMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoMascotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroCitaDataGridViewTextBoxColumn
            // 
            this.numeroCitaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn.HeaderText = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn.Name = "numeroCitaDataGridViewTextBoxColumn";
            this.numeroCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
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
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaHistorialDataGridViewTextBoxColumn
            // 
            this.notaHistorialDataGridViewTextBoxColumn.DataPropertyName = "NotaHistorial";
            this.notaHistorialDataGridViewTextBoxColumn.HeaderText = "NotaHistorial";
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
            // mascotaDataGridViewTextBoxColumn
            // 
            this.mascotaDataGridViewTextBoxColumn.DataPropertyName = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.HeaderText = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.Name = "mascotaDataGridViewTextBoxColumn";
            this.mascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // dueñoDataGridViewTextBoxColumn
            // 
            this.dueñoDataGridViewTextBoxColumn.DataPropertyName = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.Name = "dueñoDataGridViewTextBoxColumn";
            this.dueñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veterinarioDataGridViewTextBoxColumn
            // 
            this.veterinarioDataGridViewTextBoxColumn.DataPropertyName = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.HeaderText = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.Name = "veterinarioDataGridViewTextBoxColumn";
            this.veterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDetalleDataGridViewTextBoxColumn
            // 
            this.notaDetalleDataGridViewTextBoxColumn.DataPropertyName = "NotaDetalle";
            this.notaDetalleDataGridViewTextBoxColumn.HeaderText = "NotaDetalle";
            this.notaDetalleDataGridViewTextBoxColumn.Name = "notaDetalleDataGridViewTextBoxColumn";
            this.notaDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDetalleDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmBscHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmBscHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBscHistorial_FormClosed);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnHistorial)).EndInit();
            this.bnHistorial.ResumeLayout(false);
            this.bnHistorial.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnHistorial;
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
        private System.Windows.Forms.ToolStripButton btnVer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdHistorial;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHistorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaHistorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDetalleDataGridViewTextBoxColumn;
    }
}