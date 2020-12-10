namespace Neo
{
    partial class FrmBscCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBscCita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.dsNeo = new Neo.DsNeo();
            this.bsCita = new System.Windows.Forms.BindingSource(this.components);
            this.taCitaMascota = new Neo.DsNeoTableAdapters.taCitaMascota();
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDesde = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHasta = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMascota = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.grdCita = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chkPendiente = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMascota = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsMascota = new System.Windows.Forms.BindingSource(this.components);
            this.mCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).BeginInit();
            this.bnCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCita);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1067, 28);
            this.pnl1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.chkPendiente);
            this.pnl2.Controls.Add(this.txtMascota);
            this.pnl2.Controls.Add(this.kryptonLabel3);
            this.pnl2.Controls.Add(this.dtpHasta);
            this.pnl2.Controls.Add(this.kryptonLabel2);
            this.pnl2.Controls.Add(this.dtpDesde);
            this.pnl2.Controls.Add(this.kryptonLabel1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1067, 42);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 70);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1067, 10);
            this.pnl3.TabIndex = 2;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdCita);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl4.Location = new System.Drawing.Point(0, 80);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1067, 370);
            this.pnl4.TabIndex = 3;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCita
            // 
            this.bsCita.DataMember = "tbCitaMascota";
            this.bsCita.DataSource = this.dsNeo;
            // 
            // taCitaMascota
            // 
            this.taCitaMascota.ClearBeforeFill = true;
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
            this.toolStripButton1,
            this.btnCargar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.bnCita.Location = new System.Drawing.Point(0, 0);
            this.bnCita.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCita.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCita.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCita.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCita.Name = "bnCita";
            this.bnCita.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCita.Size = new System.Drawing.Size(1065, 25);
            this.bnCita.TabIndex = 5;
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 9);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(53, 9);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 21);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(197, 9);
            this.dtpHasta.Name = "dtpHasta";
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
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(293, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Mascota:";
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(358, 9);
            this.txtMascota.MaxLength = 15;
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(129, 23);
            this.txtMascota.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Buscar";
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
            this.numeroCitaDataGridViewTextBoxColumn,
            this.dueñoDataGridViewTextBoxColumn,
            this.nombreMascotaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.veterinarioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.pendienteDataGridViewCheckBoxColumn,
            this.activaDataGridViewCheckBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.grdCita.DataSource = this.bsCita;
            this.grdCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCita.Location = new System.Drawing.Point(0, 0);
            this.grdCita.Name = "grdCita";
            this.grdCita.ReadOnly = true;
            this.grdCita.Size = new System.Drawing.Size(1065, 368);
            this.grdCita.TabIndex = 3;
            // 
            // chkPendiente
            // 
            this.chkPendiente.Checked = true;
            this.chkPendiente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPendiente.Location = new System.Drawing.Point(495, 10);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(78, 20);
            this.chkPendiente.TabIndex = 6;
            this.chkPendiente.Values.Text = "Pendiente";
            // 
            // btnCargar
            // 
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(43, 22);
            this.btnCargar.Text = "Ver";
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
            // numeroCitaDataGridViewTextBoxColumn
            // 
            this.numeroCitaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCita";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numeroCitaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numeroCitaDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroCitaDataGridViewTextBoxColumn.Name = "numeroCitaDataGridViewTextBoxColumn";
            this.numeroCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCitaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dueñoDataGridViewTextBoxColumn
            // 
            this.dueñoDataGridViewTextBoxColumn.DataPropertyName = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.Name = "dueñoDataGridViewTextBoxColumn";
            this.dueñoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueñoDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreMascotaDataGridViewTextBoxColumn
            // 
            this.nombreMascotaDataGridViewTextBoxColumn.DataPropertyName = "NombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.HeaderText = "Mascota";
            this.nombreMascotaDataGridViewTextBoxColumn.Name = "nombreMascotaDataGridViewTextBoxColumn";
            this.nombreMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMascotaDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 220;
            // 
            // veterinarioDataGridViewTextBoxColumn
            // 
            this.veterinarioDataGridViewTextBoxColumn.DataPropertyName = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.HeaderText = "Veterinario";
            this.veterinarioDataGridViewTextBoxColumn.Name = "veterinarioDataGridViewTextBoxColumn";
            this.veterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.veterinarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 80;
            // 
            // pendienteDataGridViewCheckBoxColumn
            // 
            this.pendienteDataGridViewCheckBoxColumn.DataPropertyName = "Pendiente";
            this.pendienteDataGridViewCheckBoxColumn.HeaderText = "Pendiente";
            this.pendienteDataGridViewCheckBoxColumn.Name = "pendienteDataGridViewCheckBoxColumn";
            this.pendienteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pendienteDataGridViewCheckBoxColumn.Width = 70;
            // 
            // activaDataGridViewCheckBoxColumn
            // 
            this.activaDataGridViewCheckBoxColumn.DataPropertyName = "Activa";
            this.activaDataGridViewCheckBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewCheckBoxColumn.Name = "activaDataGridViewCheckBoxColumn";
            this.activaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // grdMascota
            // 
            this.grdMascota.AllowUserToAddRows = false;
            this.grdMascota.AllowUserToDeleteRows = false;
            this.grdMascota.AutoGenerateColumns = false;
            this.grdMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mCodigo,
            this.mNombre,
            this.mDueno});
            this.grdMascota.DataSource = this.bsMascota;
            this.grdMascota.Location = new System.Drawing.Point(359, 62);
            this.grdMascota.Name = "grdMascota";
            this.grdMascota.ReadOnly = true;
            this.grdMascota.RowHeadersVisible = false;
            this.grdMascota.Size = new System.Drawing.Size(432, 150);
            this.grdMascota.TabIndex = 5;
            this.grdMascota.Visible = false;
            // 
            // bsMascota
            // 
            this.bsMascota.DataMember = "tbMascota";
            this.bsMascota.DataSource = this.dsNeo;
            // 
            // mCodigo
            // 
            this.mCodigo.DataPropertyName = "CodigoMascota";
            this.mCodigo.HeaderText = "CodigoMascota";
            this.mCodigo.Name = "mCodigo";
            this.mCodigo.ReadOnly = true;
            this.mCodigo.Visible = false;
            this.mCodigo.Width = 80;
            // 
            // mNombre
            // 
            this.mNombre.DataPropertyName = "Nombre";
            this.mNombre.HeaderText = "Nombre";
            this.mNombre.Name = "mNombre";
            this.mNombre.ReadOnly = true;
            this.mNombre.Visible = false;
            // 
            // mDueno
            // 
            this.mDueno.DataPropertyName = "nombreDueno";
            this.mDueno.HeaderText = "nombreDueno";
            this.mDueno.Name = "mDueno";
            this.mDueno.ReadOnly = true;
            this.mDueno.Visible = false;
            this.mDueno.Width = 230;
            // 
            // FrmBscCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.grdMascota);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmBscCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBscCita_FormClosed);
            this.Load += new System.EventHandler(this.FrmBscCita_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).EndInit();
            this.bnCita.ResumeLayout(false);
            this.bnCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsCita;
        private DsNeoTableAdapters.taCitaMascota taCitaMascota;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkPendiente;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pendienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDueno;
        private System.Windows.Forms.BindingSource bsMascota;
    }
}