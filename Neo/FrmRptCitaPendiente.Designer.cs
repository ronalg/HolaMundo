namespace Neo
{
    partial class FrmRptCitaPendiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptCitaPendiente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCita = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVerContacto = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.grdCita = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnVerCita = new System.Windows.Forms.ToolStripButton();
            this.grdContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnCerrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlContacto = new System.Windows.Forms.Panel();
            this.btnMarcar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContacto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInformado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCodigoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCita = new System.Windows.Forms.BindingSource(this.components);
            this.taCitaMascota = new Neo.DsNeoTableAdapters.taCitaMascota();
            this.taCitaMascotaPendiente = new Neo.DsNeoTableAdapters.taCitaMascotaPendiente();
            this.taCita = new Neo.DsNeoTableAdapters.taCita();
            this.taCitaDetalle = new Neo.DsNeoTableAdapters.taCitaDetalle();
            this.taContacto = new Neo.DsNeoTableAdapters.taSucursalContacto();
            this.cmsCita = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuVerContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerCita = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAgregarNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).BeginInit();
            this.bnCita.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).BeginInit();
            this.pnlContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).BeginInit();
            this.cmsCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCita);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1076, 27);
            this.pnl1.TabIndex = 0;
            // 
            // bnCita
            // 
            this.bnCita.AddNewItem = null;
            this.bnCita.BindingSource = this.bsCita;
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
            this.toolStripSeparator2,
            this.btnNuevo,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnVerCita,
            this.btnVerContacto,
            this.btnSalir});
            this.bnCita.Location = new System.Drawing.Point(0, 0);
            this.bnCita.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCita.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCita.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCita.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCita.Name = "bnCita";
            this.bnCita.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCita.Size = new System.Drawing.Size(1074, 25);
            this.bnCita.TabIndex = 2;
            this.bnCita.Text = "bindingNavigator1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeftAutoMirrorImage = true;
            this.btnNuevo.Size = new System.Drawing.Size(105, 22);
            this.btnNuevo.Text = "Agregar nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RightToLeftAutoMirrorImage = true;
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVerContacto
            // 
            this.btnVerContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContacto.Image")));
            this.btnVerContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerContacto.Name = "btnVerContacto";
            this.btnVerContacto.Size = new System.Drawing.Size(95, 22);
            this.btnVerContacto.Text = "Ver Contacto";
            this.btnVerContacto.Click += new System.EventHandler(this.btnVerContacto_Click);
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
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.pnl5);
            this.pnl2.Controls.Add(this.pnl4);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 27);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1076, 357);
            this.pnl2.TabIndex = 2;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.grdCita);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 49);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1074, 306);
            this.pnl5.TabIndex = 5;
            // 
            // grdCita
            // 
            this.grdCita.AllowUserToAddRows = false;
            this.grdCita.AllowUserToDeleteRows = false;
            this.grdCita.AutoGenerateColumns = false;
            this.grdCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.cNumero,
            this.nombreMascotaDataGridViewTextBoxColumn,
            this.dueñoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreGrupoDataGridViewTextBoxColumn,
            this.nombreRazaDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cInformado,
            this.cCodigoMascota,
            this.cCodigoCliente});
            this.grdCita.ContextMenuStrip = this.cmsCita;
            this.grdCita.DataSource = this.bsCita;
            this.grdCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCita.Location = new System.Drawing.Point(0, 0);
            this.grdCita.MultiSelect = false;
            this.grdCita.Name = "grdCita";
            this.grdCita.ReadOnly = true;
            this.grdCita.Size = new System.Drawing.Size(1072, 304);
            this.grdCita.TabIndex = 3;
            this.grdCita.DoubleClick += new System.EventHandler(this.grdCita_DoubleClick);
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(0, 39);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1074, 10);
            this.pnl4.TabIndex = 4;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.dtpHasta);
            this.pnl3.Controls.Add(this.kryptonLabel2);
            this.pnl3.Controls.Add(this.dtpDesde);
            this.pnl3.Controls.Add(this.kryptonLabel1);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1074, 39);
            this.pnl3.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(198, 8);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 21);
            this.dtpHasta.TabIndex = 17;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(149, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 18;
            this.kryptonLabel2.Values.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(54, 8);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 16;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // btnVerCita
            // 
            this.btnVerCita.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCita.Image")));
            this.btnVerCita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerCita.Name = "btnVerCita";
            this.btnVerCita.Size = new System.Drawing.Size(67, 22);
            this.btnVerCita.Text = "Ver Cita";
            this.btnVerCita.Click += new System.EventHandler(this.btnVerCita_Click);
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
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.representanteDataGridViewTextBoxColumn,
            this.nombreTipoContactoDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn});
            this.grdContacto.DataSource = this.bsContacto;
            this.grdContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdContacto.Location = new System.Drawing.Point(5, 5);
            this.grdContacto.Name = "grdContacto";
            this.grdContacto.ReadOnly = true;
            this.grdContacto.Size = new System.Drawing.Size(508, 248);
            this.grdContacto.TabIndex = 72;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(246, 258);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 25);
            this.btnCerrar.TabIndex = 73;
            this.btnCerrar.Values.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContacto
            // 
            this.pnlContacto.BackColor = System.Drawing.Color.White;
            this.pnlContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContacto.Controls.Add(this.btnMarcar);
            this.pnlContacto.Controls.Add(this.btnCerrar);
            this.pnlContacto.Controls.Add(this.grdContacto);
            this.pnlContacto.Location = new System.Drawing.Point(232, 84);
            this.pnlContacto.Margin = new System.Windows.Forms.Padding(5);
            this.pnlContacto.Name = "pnlContacto";
            this.pnlContacto.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContacto.Size = new System.Drawing.Size(520, 293);
            this.pnlContacto.TabIndex = 6;
            this.pnlContacto.Visible = false;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(314, 258);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(196, 25);
            this.btnMarcar.TabIndex = 74;
            this.btnMarcar.Values.Text = "Marcar como informado y cerrar";
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // representanteDataGridViewTextBoxColumn
            // 
            this.representanteDataGridViewTextBoxColumn.DataPropertyName = "Representante";
            this.representanteDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.representanteDataGridViewTextBoxColumn.Name = "representanteDataGridViewTextBoxColumn";
            this.representanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.representanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreTipoContactoDataGridViewTextBoxColumn
            // 
            this.nombreTipoContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoContacto";
            this.nombreTipoContactoDataGridViewTextBoxColumn.HeaderText = "Tipo ";
            this.nombreTipoContactoDataGridViewTextBoxColumn.Name = "nombreTipoContactoDataGridViewTextBoxColumn";
            this.nombreTipoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre ";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreContactoDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactoDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsContacto
            // 
            this.bsContacto.DataMember = "tbSucursalContacto";
            this.bsContacto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cNumero
            // 
            this.cNumero.DataPropertyName = "NumeroCita";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cNumero.DefaultCellStyle = dataGridViewCellStyle16;
            this.cNumero.HeaderText = "Número";
            this.cNumero.Name = "cNumero";
            this.cNumero.ReadOnly = true;
            this.cNumero.Width = 70;
            // 
            // nombreMascotaDataGridViewTextBoxColumn
            // 
            this.nombreMascotaDataGridViewTextBoxColumn.DataPropertyName = "NombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.HeaderText = "Mascota";
            this.nombreMascotaDataGridViewTextBoxColumn.Name = "nombreMascotaDataGridViewTextBoxColumn";
            this.nombreMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueñoDataGridViewTextBoxColumn
            // 
            this.dueñoDataGridViewTextBoxColumn.DataPropertyName = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.Name = "dueñoDataGridViewTextBoxColumn";
            this.dueñoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueñoDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "d";
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombreGrupoDataGridViewTextBoxColumn
            // 
            this.nombreGrupoDataGridViewTextBoxColumn.DataPropertyName = "NombreGrupo";
            this.nombreGrupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.nombreGrupoDataGridViewTextBoxColumn.Name = "nombreGrupoDataGridViewTextBoxColumn";
            this.nombreGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreGrupoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombreRazaDataGridViewTextBoxColumn
            // 
            this.nombreRazaDataGridViewTextBoxColumn.DataPropertyName = "NombreRaza";
            this.nombreRazaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.nombreRazaDataGridViewTextBoxColumn.Name = "nombreRazaDataGridViewTextBoxColumn";
            this.nombreRazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRazaDataGridViewTextBoxColumn.Width = 130;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 80;
            // 
            // cInformado
            // 
            this.cInformado.DataPropertyName = "Informado";
            this.cInformado.HeaderText = "Informado";
            this.cInformado.Name = "cInformado";
            this.cInformado.ReadOnly = true;
            this.cInformado.Width = 70;
            // 
            // cCodigoMascota
            // 
            this.cCodigoMascota.DataPropertyName = "CodigoMascota";
            this.cCodigoMascota.HeaderText = "CodigoMascota";
            this.cCodigoMascota.Name = "cCodigoMascota";
            this.cCodigoMascota.ReadOnly = true;
            this.cCodigoMascota.Visible = false;
            // 
            // cCodigoCliente
            // 
            this.cCodigoCliente.DataPropertyName = "CodigoCliente";
            this.cCodigoCliente.HeaderText = "CodigoCliente";
            this.cCodigoCliente.Name = "cCodigoCliente";
            this.cCodigoCliente.ReadOnly = true;
            this.cCodigoCliente.Visible = false;
            // 
            // bsCita
            // 
            this.bsCita.DataMember = "tbCitaMascotaPendiente";
            this.bsCita.DataSource = this.dsNeo;
            // 
            // taCitaMascota
            // 
            this.taCitaMascota.ClearBeforeFill = true;
            // 
            // taCitaMascotaPendiente
            // 
            this.taCitaMascotaPendiente.ClearBeforeFill = true;
            // 
            // taCita
            // 
            this.taCita.ClearBeforeFill = true;
            // 
            // taCitaDetalle
            // 
            this.taCitaDetalle.ClearBeforeFill = true;
            // 
            // taContacto
            // 
            this.taContacto.ClearBeforeFill = true;
            // 
            // cmsCita
            // 
            this.cmsCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsCita.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVerContacto,
            this.mnuVerCita,
            this.toolStripSeparator3,
            this.mnuMarcar,
            this.toolStripSeparator4,
            this.mnuBuscar,
            this.toolStripSeparator5,
            this.mnuAgregarNuevo,
            this.mnuEliminar});
            this.cmsCita.Name = "cmsCita";
            this.cmsCita.Size = new System.Drawing.Size(205, 176);
            // 
            // mnuVerContacto
            // 
            this.mnuVerContacto.Image = ((System.Drawing.Image)(resources.GetObject("mnuVerContacto.Image")));
            this.mnuVerContacto.Name = "mnuVerContacto";
            this.mnuVerContacto.Size = new System.Drawing.Size(204, 22);
            this.mnuVerContacto.Text = "Ver Contacto";
            this.mnuVerContacto.Click += new System.EventHandler(this.mnuVerContacto_Click);
            // 
            // mnuVerCita
            // 
            this.mnuVerCita.Image = ((System.Drawing.Image)(resources.GetObject("mnuVerCita.Image")));
            this.mnuVerCita.Name = "mnuVerCita";
            this.mnuVerCita.Size = new System.Drawing.Size(204, 22);
            this.mnuVerCita.Text = "Ver Cita";
            this.mnuVerCita.Click += new System.EventHandler(this.mnuVerCita_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuMarcar
            // 
            this.mnuMarcar.Image = ((System.Drawing.Image)(resources.GetObject("mnuMarcar.Image")));
            this.mnuMarcar.Name = "mnuMarcar";
            this.mnuMarcar.Size = new System.Drawing.Size(204, 22);
            this.mnuMarcar.Text = "Marcar como informado";
            this.mnuMarcar.Click += new System.EventHandler(this.mnuMarcar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuBuscar
            // 
            this.mnuBuscar.Image = ((System.Drawing.Image)(resources.GetObject("mnuBuscar.Image")));
            this.mnuBuscar.Name = "mnuBuscar";
            this.mnuBuscar.Size = new System.Drawing.Size(204, 22);
            this.mnuBuscar.Text = "Buscar";
            this.mnuBuscar.Click += new System.EventHandler(this.mnuBuscar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuAgregarNuevo
            // 
            this.mnuAgregarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("mnuAgregarNuevo.Image")));
            this.mnuAgregarNuevo.Name = "mnuAgregarNuevo";
            this.mnuAgregarNuevo.Size = new System.Drawing.Size(204, 22);
            this.mnuAgregarNuevo.Text = "Agregar nuevo";
            this.mnuAgregarNuevo.Click += new System.EventHandler(this.mnuAgregarNuevo_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Image = ((System.Drawing.Image)(resources.GetObject("mnuEliminar.Image")));
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(204, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // FrmRptCitaPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 384);
            this.Controls.Add(this.pnlContacto);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmRptCitaPendiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Pendiente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRptCitaPendiente_FormClosed);
            this.Load += new System.EventHandler(this.FrmRptCitaPendiente_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).EndInit();
            this.bnCita.ResumeLayout(false);
            this.bnCita.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).EndInit();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).EndInit();
            this.pnlContacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).EndInit();
            this.cmsCita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsCita;
        private DsNeoTableAdapters.taCitaMascota taCitaMascota;
        private System.Windows.Forms.BindingNavigator bnCita;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Panel pnl5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCita;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DsNeoTableAdapters.taCitaMascotaPendiente taCitaMascotaPendiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnVerContacto;
        private DsNeoTableAdapters.taCita taCita;
        private DsNeoTableAdapters.taCitaDetalle taCitaDetalle;
        private System.Windows.Forms.BindingSource bsContacto;
        private DsNeoTableAdapters.taSucursalContacto taContacto;
        private System.Windows.Forms.ToolStripButton btnVerCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cInformado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCerrar;
        private System.Windows.Forms.Panel pnlContacto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMarcar;
        private System.Windows.Forms.ContextMenuStrip cmsCita;
        private System.Windows.Forms.ToolStripMenuItem mnuVerContacto;
        private System.Windows.Forms.ToolStripMenuItem mnuVerCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuMarcar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
    }
}