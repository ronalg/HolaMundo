namespace Neo
{
    partial class FrmTscCita
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
            System.Windows.Forms.Label numeroCitaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label tipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTscCita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCita = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCita = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl16 = new System.Windows.Forms.Panel();
            this.pnl15 = new System.Windows.Forms.Panel();
            this.lblTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.grdArticulo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.aTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCodigoVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.pnl13 = new System.Windows.Forms.Panel();
            this.bnDetalle = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevoServicio = new System.Windows.Forms.ToolStripButton();
            this.btnEliminaServicio = new System.Windows.Forms.ToolStripButton();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.cboTipo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtpFecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.bsMascotaCita = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDueno = new System.Windows.Forms.Label();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscaMascota = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.btnServicioAceptarNuevo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAceptaServicio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelaServicio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlTipoContactoSub = new System.Windows.Forms.Panel();
            this.txtServicio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grdServicio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caratulaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicaInscripcionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.veterinariaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsServicio = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Neo.DsNeo();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlVeterinario = new System.Windows.Forms.Panel();
            this.btnAceptaVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelaVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVeterinario = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.grdMascota = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.mCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDuenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMascota = new System.Windows.Forms.BindingSource(this.components);
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.taCita = new Neo.DsNeoTableAdapters.taCita();
            this.taCitaDetalle = new Neo.DsNeoTableAdapters.taCitaDetalle();
            this.taMascota = new Neo.DsNeoTableAdapters.taMascota();
            this.taArticulo = new Neo.DsNeoTableAdapters.taArticulo();
            this.taEmpleado = new Neo.DsNeoTableAdapters.taEmpleado();
            this.taArticuloProveedor = new Neo.DsNeoTableAdapters.taArticuloProveedor();
            this.tableAdapterManager = new Neo.DsNeoTableAdapters.TableAdapterManager();
            this.taArticulo1 = new Neo.DsNeoTableAdapters.taArticulo();
            this.taArticuloPrecioVenta = new Neo.DsNeoTableAdapters.taArticuloPrecioVenta();
            numeroCitaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).BeginInit();
            this.bnCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl2.SuspendLayout();
            this.pnl15.SuspendLayout();
            this.pnl12.SuspendLayout();
            this.pnl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalle)).BeginInit();
            this.pnl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetalle)).BeginInit();
            this.bnDetalle.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipo)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascotaCita)).BeginInit();
            this.pnlServicio.SuspendLayout();
            this.pnlTipoContactoSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnlVeterinario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroCitaLabel
            // 
            numeroCitaLabel.AutoSize = true;
            numeroCitaLabel.Location = new System.Drawing.Point(13, 29);
            numeroCitaLabel.Name = "numeroCitaLabel";
            numeroCitaLabel.Size = new System.Drawing.Size(47, 13);
            numeroCitaLabel.TabIndex = 2;
            numeroCitaLabel.Text = "Número:";
            numeroCitaLabel.Click += new System.EventHandler(this.numeroCitaLabel_Click);
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(9, 54);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 3;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(20, 107);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(14, 80);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 7;
            usuarioLabel.Text = "Usuario:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(25, 133);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "Tipo:";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCita);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(999, 28);
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
            this.btnNuevo,
            this.btnEliminar,
            this.btnGuardar,
            this.toolStripSeparator4,
            this.btnBuscar,
            this.toolStripSeparator5,
            this.btnSalir});
            this.bnCita.Location = new System.Drawing.Point(0, 0);
            this.bnCita.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCita.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCita.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCita.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCita.Name = "bnCita";
            this.bnCita.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCita.Size = new System.Drawing.Size(997, 25);
            this.bnCita.TabIndex = 3;
            this.bnCita.Text = "bindingNavigator1";
            // 
            // bsCita
            // 
            this.bsCita.DataMember = "tbCita";
            this.bsCita.DataSource = this.dsNeo;
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
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeftAutoMirrorImage = true;
            this.btnNuevo.Size = new System.Drawing.Size(105, 22);
            this.btnNuevo.Text = "Agregar nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 22);
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.pnl16);
            this.pnl2.Controls.Add(this.pnl15);
            this.pnl2.Controls.Add(this.pnl12);
            this.pnl2.Controls.Add(this.pnl11);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(999, 420);
            this.pnl2.TabIndex = 1;
            // 
            // pnl16
            // 
            this.pnl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl16.Location = new System.Drawing.Point(0, 365);
            this.pnl16.Name = "pnl16";
            this.pnl16.Size = new System.Drawing.Size(995, 10);
            this.pnl16.TabIndex = 4;
            // 
            // pnl15
            // 
            this.pnl15.BackColor = System.Drawing.Color.White;
            this.pnl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl15.Controls.Add(this.lblTotal);
            this.pnl15.Controls.Add(this.kryptonLabel2);
            this.pnl15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl15.Location = new System.Drawing.Point(0, 375);
            this.pnl15.Name = "pnl15";
            this.pnl15.Size = new System.Drawing.Size(995, 41);
            this.pnl15.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblTotal.Location = new System.Drawing.Point(913, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Values.Text = "0.00";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(864, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Total:";
            // 
            // pnl12
            // 
            this.pnl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl12.Controls.Add(this.pnl14);
            this.pnl12.Controls.Add(this.pnl13);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(0, 199);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(995, 217);
            this.pnl12.TabIndex = 2;
            // 
            // pnl14
            // 
            this.pnl14.AutoScroll = true;
            this.pnl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl14.Controls.Add(this.grdArticulo);
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl14.Location = new System.Drawing.Point(0, 25);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(993, 190);
            this.pnl14.TabIndex = 3;
            // 
            // grdArticulo
            // 
            this.grdArticulo.AllowUserToAddRows = false;
            this.grdArticulo.AllowUserToDeleteRows = false;
            this.grdArticulo.AutoGenerateColumns = false;
            this.grdArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aTrabajo,
            this.aEmpresa,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.numeroCitaDataGridViewTextBoxColumn,
            this.aCodigoVeterinario,
            this.aCodigo,
            this.aDescripcion,
            this.aVeterinario,
            this.pendienteDataGridViewCheckBoxColumn,
            this.aCosto,
            this.activaDataGridViewCheckBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.aVenta});
            this.grdArticulo.DataSource = this.bsDetalle;
            this.grdArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArticulo.Location = new System.Drawing.Point(0, 0);
            this.grdArticulo.MultiSelect = false;
            this.grdArticulo.Name = "grdArticulo";
            this.grdArticulo.Size = new System.Drawing.Size(991, 188);
            this.grdArticulo.TabIndex = 1;
            this.grdArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulo_CellClick);
            this.grdArticulo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulo_CellDoubleClick);
            // 
            // aTrabajo
            // 
            this.aTrabajo.DataPropertyName = "CodigoTrabajo";
            this.aTrabajo.HeaderText = "CodigoTrabajo";
            this.aTrabajo.Name = "aTrabajo";
            this.aTrabajo.ReadOnly = true;
            this.aTrabajo.Visible = false;
            // 
            // aEmpresa
            // 
            this.aEmpresa.DataPropertyName = "CodigoEmpresa";
            this.aEmpresa.HeaderText = "CodigoEmpresa";
            this.aEmpresa.Name = "aEmpresa";
            this.aEmpresa.ReadOnly = true;
            this.aEmpresa.Visible = false;
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
            this.numeroCitaDataGridViewTextBoxColumn.HeaderText = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn.Name = "numeroCitaDataGridViewTextBoxColumn";
            this.numeroCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCodigoVeterinario
            // 
            this.aCodigoVeterinario.DataPropertyName = "CodigoEmpleado";
            this.aCodigoVeterinario.HeaderText = "CodigoEmpleado";
            this.aCodigoVeterinario.Name = "aCodigoVeterinario";
            this.aCodigoVeterinario.ReadOnly = true;
            this.aCodigoVeterinario.Visible = false;
            // 
            // aCodigo
            // 
            this.aCodigo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aCodigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.aCodigo.HeaderText = "Código";
            this.aCodigo.Name = "aCodigo";
            this.aCodigo.ReadOnly = true;
            this.aCodigo.Width = 70;
            // 
            // aDescripcion
            // 
            this.aDescripcion.DataPropertyName = "Descripcion";
            this.aDescripcion.HeaderText = "Descripción";
            this.aDescripcion.Name = "aDescripcion";
            this.aDescripcion.ReadOnly = true;
            this.aDescripcion.Width = 220;
            // 
            // aVeterinario
            // 
            this.aVeterinario.DataPropertyName = "Veterinario";
            this.aVeterinario.HeaderText = "Veterinario";
            this.aVeterinario.Name = "aVeterinario";
            this.aVeterinario.ReadOnly = true;
            this.aVeterinario.Width = 200;
            // 
            // pendienteDataGridViewCheckBoxColumn
            // 
            this.pendienteDataGridViewCheckBoxColumn.DataPropertyName = "pendiente";
            this.pendienteDataGridViewCheckBoxColumn.HeaderText = "Pendiente";
            this.pendienteDataGridViewCheckBoxColumn.Name = "pendienteDataGridViewCheckBoxColumn";
            this.pendienteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pendienteDataGridViewCheckBoxColumn.Width = 70;
            // 
            // aCosto
            // 
            this.aCosto.DataPropertyName = "costo";
            this.aCosto.HeaderText = "costo";
            this.aCosto.Name = "aCosto";
            this.aCosto.ReadOnly = true;
            this.aCosto.Visible = false;
            // 
            // activaDataGridViewCheckBoxColumn
            // 
            this.activaDataGridViewCheckBoxColumn.DataPropertyName = "activa";
            this.activaDataGridViewCheckBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewCheckBoxColumn.Name = "activaDataGridViewCheckBoxColumn";
            this.activaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activaDataGridViewCheckBoxColumn.Width = 60;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.Width = 230;
            // 
            // aVenta
            // 
            this.aVenta.DataPropertyName = "venta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.aVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.aVenta.HeaderText = "Venta";
            this.aVenta.Name = "aVenta";
            this.aVenta.ReadOnly = true;
            this.aVenta.Width = 80;
            // 
            // bsDetalle
            // 
            this.bsDetalle.DataMember = "tbCitaDetalle";
            this.bsDetalle.DataSource = this.dsNeo;
            // 
            // pnl13
            // 
            this.pnl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl13.Controls.Add(this.bnDetalle);
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl13.Location = new System.Drawing.Point(0, 0);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(993, 25);
            this.pnl13.TabIndex = 2;
            // 
            // bnDetalle
            // 
            this.bnDetalle.AddNewItem = null;
            this.bnDetalle.BindingSource = this.bsDetalle;
            this.bnDetalle.CountItem = this.toolStripLabel1;
            this.bnDetalle.DeleteItem = null;
            this.bnDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.btnNuevoServicio,
            this.btnEliminaServicio});
            this.bnDetalle.Location = new System.Drawing.Point(0, 0);
            this.bnDetalle.MoveFirstItem = this.toolStripButton3;
            this.bnDetalle.MoveLastItem = this.toolStripButton6;
            this.bnDetalle.MoveNextItem = this.toolStripButton5;
            this.bnDetalle.MovePreviousItem = this.toolStripButton4;
            this.bnDetalle.Name = "bnDetalle";
            this.bnDetalle.PositionItem = this.toolStripTextBox1;
            this.bnDetalle.Size = new System.Drawing.Size(991, 25);
            this.bnDetalle.TabIndex = 5;
            this.bnDetalle.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de elementos";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover primero";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posición";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover siguiente";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoServicio.Image")));
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.RightToLeftAutoMirrorImage = true;
            this.btnNuevoServicio.Size = new System.Drawing.Size(105, 22);
            this.btnNuevoServicio.Text = "Agregar nuevo";
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // btnEliminaServicio
            // 
            this.btnEliminaServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminaServicio.Image")));
            this.btnEliminaServicio.Name = "btnEliminaServicio";
            this.btnEliminaServicio.RightToLeftAutoMirrorImage = true;
            this.btnEliminaServicio.Size = new System.Drawing.Size(70, 22);
            this.btnEliminaServicio.Text = "Eliminar";
            this.btnEliminaServicio.Click += new System.EventHandler(this.btnEliminaServicio_Click);
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 189);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(995, 10);
            this.pnl11.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.pnl8);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(995, 189);
            this.pnl3.TabIndex = 0;
            // 
            // pnl8
            // 
            this.pnl8.AutoScroll = true;
            this.pnl8.BackColor = System.Drawing.Color.White;
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(tipoLabel);
            this.pnl8.Controls.Add(this.cboTipo);
            this.pnl8.Controls.Add(usuarioLabel);
            this.pnl8.Controls.Add(this.lblUsuario);
            this.pnl8.Controls.Add(fechaLabel);
            this.pnl8.Controls.Add(this.dtpFecha);
            this.pnl8.Controls.Add(codigoSucursalLabel);
            this.pnl8.Controls.Add(this.lblSucursal);
            this.pnl8.Controls.Add(numeroCitaLabel);
            this.pnl8.Controls.Add(this.lblNumero);
            this.pnl8.Controls.Add(this.label3);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl8.Location = new System.Drawing.Point(353, 0);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(182, 189);
            this.pnl8.TabIndex = 4;
            // 
            // cboTipo
            // 
            this.cboTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Tipo", true));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DropDownWidth = 103;
            this.cboTipo.Items.AddRange(new object[] {
            "Local",
            "Dominicilio"});
            this.cboTipo.Location = new System.Drawing.Point(62, 130);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(103, 21);
            this.cboTipo.TabIndex = 10;
            this.cboTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipo_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(62, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFecha
            // 
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCita, "Fecha", true));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(62, 103);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.dtpFecha.Size = new System.Drawing.Size(103, 21);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblSucursal
            // 
            this.lblSucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "CodigoSucursal", true));
            this.lblSucursal.Location = new System.Drawing.Point(62, 51);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(100, 20);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "NumeroCita", true));
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(62, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumero.Click += new System.EventHandler(this.numeroCitaLabel1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cita";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(343, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 189);
            this.pnl5.TabIndex = 1;
            // 
            // pnl4
            // 
            this.pnl4.AutoScroll = true;
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.lblCodigo);
            this.pnl4.Controls.Add(this.kryptonLabel9);
            this.pnl4.Controls.Add(this.lblSexo);
            this.pnl4.Controls.Add(this.lblRaza);
            this.pnl4.Controls.Add(this.lblGrupo);
            this.pnl4.Controls.Add(this.lblDueno);
            this.pnl4.Controls.Add(this.kryptonLabel7);
            this.pnl4.Controls.Add(this.kryptonLabel6);
            this.pnl4.Controls.Add(this.kryptonLabel5);
            this.pnl4.Controls.Add(this.kryptonLabel4);
            this.pnl4.Controls.Add(this.kryptonLabel3);
            this.pnl4.Controls.Add(this.lblNombre);
            this.pnl4.Controls.Add(this.txtBuscaMascota);
            this.pnl4.Controls.Add(this.kryptonLabel1);
            this.pnl4.Controls.Add(this.label1);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(343, 189);
            this.pnl4.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "CodigoMascota", true));
            this.lblCodigo.Location = new System.Drawing.Point(272, 159);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // bsMascotaCita
            // 
            this.bsMascotaCita.DataMember = "tbMascota";
            this.bsMascotaCita.DataSource = this.dsNeo;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(219, 159);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel9.TabIndex = 22;
            this.kryptonLabel9.Values.Text = "Código:";
            // 
            // lblSexo
            // 
            this.lblSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "Sexo", true));
            this.lblSexo.Location = new System.Drawing.Point(80, 159);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(133, 20);
            this.lblSexo.TabIndex = 21;
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRaza
            // 
            this.lblRaza.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRaza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "NombreRaza", true));
            this.lblRaza.Location = new System.Drawing.Point(80, 133);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(251, 20);
            this.lblRaza.TabIndex = 20;
            this.lblRaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrupo
            // 
            this.lblGrupo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "NombreGrupo", true));
            this.lblGrupo.Location = new System.Drawing.Point(80, 107);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(251, 20);
            this.lblGrupo.TabIndex = 19;
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDueno
            // 
            this.lblDueno.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDueno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "nombreDueno", true));
            this.lblDueno.Location = new System.Drawing.Point(80, 80);
            this.lblDueno.Name = "lblDueno";
            this.lblDueno.Size = new System.Drawing.Size(251, 20);
            this.lblDueno.TabIndex = 18;
            this.lblDueno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDueno.Click += new System.EventHandler(this.lblDueno_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(14, 159);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "Sexo:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(13, 133);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Raza:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(13, 105);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "Grupo:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(13, 79);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Dueño:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 53);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascotaCita, "Nombre", true));
            this.lblNombre.Location = new System.Drawing.Point(80, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(251, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscaMascota
            // 
            this.txtBuscaMascota.Location = new System.Drawing.Point(80, 26);
            this.txtBuscaMascota.Name = "txtBuscaMascota";
            this.txtBuscaMascota.Size = new System.Drawing.Size(251, 23);
            this.txtBuscaMascota.TabIndex = 2;
            this.txtBuscaMascota.TextChanged += new System.EventHandler(this.txtBuscaMascota_TextChanged);
            this.txtBuscaMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaMascota_KeyDown);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 27);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlServicio
            // 
            this.pnlServicio.BackColor = System.Drawing.Color.White;
            this.pnlServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicio.Controls.Add(this.btnServicioAceptarNuevo);
            this.pnlServicio.Controls.Add(this.btnAceptaServicio);
            this.pnlServicio.Controls.Add(this.btnCancelaServicio);
            this.pnlServicio.Controls.Add(this.pnlTipoContactoSub);
            this.pnlServicio.Controls.Add(this.label8);
            this.pnlServicio.Location = new System.Drawing.Point(351, 124);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(364, 289);
            this.pnlServicio.TabIndex = 14;
            this.pnlServicio.Visible = false;
            // 
            // btnServicioAceptarNuevo
            // 
            this.btnServicioAceptarNuevo.Location = new System.Drawing.Point(142, 254);
            this.btnServicioAceptarNuevo.Name = "btnServicioAceptarNuevo";
            this.btnServicioAceptarNuevo.Size = new System.Drawing.Size(115, 25);
            this.btnServicioAceptarNuevo.TabIndex = 4;
            this.btnServicioAceptarNuevo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnServicioAceptarNuevo.Values.Image")));
            this.btnServicioAceptarNuevo.Values.Text = "Aceptar/Nuevo";
            this.btnServicioAceptarNuevo.Click += new System.EventHandler(this.btnServicioAceptarNuevo_Click);
            // 
            // btnAceptaServicio
            // 
            this.btnAceptaServicio.Location = new System.Drawing.Point(263, 254);
            this.btnAceptaServicio.Name = "btnAceptaServicio";
            this.btnAceptaServicio.Size = new System.Drawing.Size(90, 25);
            this.btnAceptaServicio.TabIndex = 3;
            this.btnAceptaServicio.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptaServicio.Values.Image")));
            this.btnAceptaServicio.Values.Text = "Aceptar";
            this.btnAceptaServicio.Click += new System.EventHandler(this.btnAceptaServicio_Click);
            // 
            // btnCancelaServicio
            // 
            this.btnCancelaServicio.Location = new System.Drawing.Point(7, 254);
            this.btnCancelaServicio.Name = "btnCancelaServicio";
            this.btnCancelaServicio.Size = new System.Drawing.Size(90, 25);
            this.btnCancelaServicio.TabIndex = 2;
            this.btnCancelaServicio.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelaServicio.Values.Image")));
            this.btnCancelaServicio.Values.Text = "Cancelar";
            this.btnCancelaServicio.Click += new System.EventHandler(this.btnCancelaServicio_Click);
            // 
            // pnlTipoContactoSub
            // 
            this.pnlTipoContactoSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoContactoSub.Controls.Add(this.txtServicio);
            this.pnlTipoContactoSub.Controls.Add(this.kryptonLabel8);
            this.pnlTipoContactoSub.Controls.Add(this.grdServicio);
            this.pnlTipoContactoSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTipoContactoSub.Location = new System.Drawing.Point(0, 17);
            this.pnlTipoContactoSub.Name = "pnlTipoContactoSub";
            this.pnlTipoContactoSub.Size = new System.Drawing.Size(362, 229);
            this.pnlTipoContactoSub.TabIndex = 1;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(63, 8);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(281, 23);
            this.txtServicio.TabIndex = 6;
            this.txtServicio.TextChanged += new System.EventHandler(this.txtServicio_TextChanged);
            this.txtServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServicio_KeyDown);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(8, 9);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel8.TabIndex = 5;
            this.kryptonLabel8.Values.Text = "Buscar:";
            // 
            // grdServicio
            // 
            this.grdServicio.AllowUserToAddRows = false;
            this.grdServicio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.grdServicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdServicio.AutoGenerateColumns = false;
            this.grdServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDescripcion,
            this.caratulaDataGridViewImageColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.inventarioDataGridViewCheckBoxColumn,
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn,
            this.aplicaInscripcionDataGridViewCheckBoxColumn,
            this.veterinariaDataGridViewCheckBoxColumn,
            this.codigoTrabajoDataGridViewTextBoxColumn2,
            this.codigoEmpresaDataGridViewTextBoxColumn2,
            this.sCodigo,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.nombreDepartamentoDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn});
            this.grdServicio.DataSource = this.bsServicio;
            this.grdServicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdServicio.Location = new System.Drawing.Point(0, 40);
            this.grdServicio.Name = "grdServicio";
            this.grdServicio.ReadOnly = true;
            this.grdServicio.Size = new System.Drawing.Size(360, 187);
            this.grdServicio.TabIndex = 4;
            this.grdServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdServicio_CellContentClick);
            this.grdServicio.DoubleClick += new System.EventHandler(this.grdServicio_DoubleClick);
            this.grdServicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdServicio_KeyDown);
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "Descripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            this.sDescripcion.Width = 300;
            // 
            // caratulaDataGridViewImageColumn
            // 
            this.caratulaDataGridViewImageColumn.DataPropertyName = "Caratula";
            this.caratulaDataGridViewImageColumn.HeaderText = "Caratula";
            this.caratulaDataGridViewImageColumn.Name = "caratulaDataGridViewImageColumn";
            this.caratulaDataGridViewImageColumn.ReadOnly = true;
            this.caratulaDataGridViewImageColumn.Visible = false;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.existenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // inventarioDataGridViewCheckBoxColumn
            // 
            this.inventarioDataGridViewCheckBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewCheckBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewCheckBoxColumn.Name = "inventarioDataGridViewCheckBoxColumn";
            this.inventarioDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inventarioDataGridViewCheckBoxColumn.Visible = false;
            // 
            // aplicaOrdenPedidoDataGridViewCheckBoxColumn
            // 
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn.DataPropertyName = "AplicaOrdenPedido";
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn.HeaderText = "AplicaOrdenPedido";
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn.Name = "aplicaOrdenPedidoDataGridViewCheckBoxColumn";
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aplicaOrdenPedidoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // aplicaInscripcionDataGridViewCheckBoxColumn
            // 
            this.aplicaInscripcionDataGridViewCheckBoxColumn.DataPropertyName = "AplicaInscripcion";
            this.aplicaInscripcionDataGridViewCheckBoxColumn.HeaderText = "AplicaInscripcion";
            this.aplicaInscripcionDataGridViewCheckBoxColumn.Name = "aplicaInscripcionDataGridViewCheckBoxColumn";
            this.aplicaInscripcionDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aplicaInscripcionDataGridViewCheckBoxColumn.Visible = false;
            // 
            // veterinariaDataGridViewCheckBoxColumn
            // 
            this.veterinariaDataGridViewCheckBoxColumn.DataPropertyName = "Veterinaria";
            this.veterinariaDataGridViewCheckBoxColumn.HeaderText = "Veterinaria";
            this.veterinariaDataGridViewCheckBoxColumn.Name = "veterinariaDataGridViewCheckBoxColumn";
            this.veterinariaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.veterinariaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // codigoTrabajoDataGridViewTextBoxColumn2
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn2.DataPropertyName = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn2.HeaderText = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn2.Name = "codigoTrabajoDataGridViewTextBoxColumn2";
            this.codigoTrabajoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.codigoTrabajoDataGridViewTextBoxColumn2.Visible = false;
            // 
            // codigoEmpresaDataGridViewTextBoxColumn2
            // 
            this.codigoEmpresaDataGridViewTextBoxColumn2.DataPropertyName = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn2.HeaderText = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn2.Name = "codigoEmpresaDataGridViewTextBoxColumn2";
            this.codigoEmpresaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.codigoEmpresaDataGridViewTextBoxColumn2.Visible = false;
            // 
            // sCodigo
            // 
            this.sCodigo.DataPropertyName = "CodigoArticulo";
            this.sCodigo.HeaderText = "CodigoArticulo";
            this.sCodigo.Name = "sCodigo";
            this.sCodigo.ReadOnly = true;
            this.sCodigo.Visible = false;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDepartamentoDataGridViewTextBoxColumn
            // 
            this.nombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "NombreDepartamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "NombreDepartamento";
            this.nombreDepartamentoDataGridViewTextBoxColumn.Name = "nombreDepartamentoDataGridViewTextBoxColumn";
            this.nombreDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDepartamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsServicio
            // 
            this.bsServicio.DataMember = "tbArticulo";
            this.bsServicio.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DsNeo";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Servicios";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlVeterinario
            // 
            this.pnlVeterinario.BackColor = System.Drawing.Color.White;
            this.pnlVeterinario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVeterinario.Controls.Add(this.btnAceptaVeterinario);
            this.pnlVeterinario.Controls.Add(this.btnCancelaVeterinario);
            this.pnlVeterinario.Controls.Add(this.panel2);
            this.pnlVeterinario.Controls.Add(this.label5);
            this.pnlVeterinario.Location = new System.Drawing.Point(672, 140);
            this.pnlVeterinario.Name = "pnlVeterinario";
            this.pnlVeterinario.Size = new System.Drawing.Size(314, 256);
            this.pnlVeterinario.TabIndex = 15;
            this.pnlVeterinario.Visible = false;
            // 
            // btnAceptaVeterinario
            // 
            this.btnAceptaVeterinario.Location = new System.Drawing.Point(212, 220);
            this.btnAceptaVeterinario.Name = "btnAceptaVeterinario";
            this.btnAceptaVeterinario.Size = new System.Drawing.Size(90, 25);
            this.btnAceptaVeterinario.TabIndex = 3;
            this.btnAceptaVeterinario.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptaVeterinario.Values.Image")));
            this.btnAceptaVeterinario.Values.Text = "Aceptar";
            this.btnAceptaVeterinario.Click += new System.EventHandler(this.btnAceptaVeterinario_Click);
            // 
            // btnCancelaVeterinario
            // 
            this.btnCancelaVeterinario.Location = new System.Drawing.Point(7, 220);
            this.btnCancelaVeterinario.Name = "btnCancelaVeterinario";
            this.btnCancelaVeterinario.Size = new System.Drawing.Size(90, 25);
            this.btnCancelaVeterinario.TabIndex = 2;
            this.btnCancelaVeterinario.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelaVeterinario.Values.Image")));
            this.btnCancelaVeterinario.Values.Text = "Cancelar";
            this.btnCancelaVeterinario.Click += new System.EventHandler(this.btnCancelaVeterinario_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grdVeterinario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 197);
            this.panel2.TabIndex = 1;
            // 
            // grdVeterinario
            // 
            this.grdVeterinario.AllowUserToAddRows = false;
            this.grdVeterinario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.grdVeterinario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVeterinario.AutoGenerateColumns = false;
            this.grdVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVeterinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNombre,
            this.codigoTrabajoDataGridViewTextBoxColumn3,
            this.codigoEmpresaDataGridViewTextBoxColumn3,
            this.vCodigo,
            this.codigoSucursalDataGridViewTextBoxColumn1,
            this.nombrePuestoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn1,
            this.activoDataGridViewCheckBoxColumn1,
            this.notaDataGridViewTextBoxColumn1});
            this.grdVeterinario.DataSource = this.bsVeterinario;
            this.grdVeterinario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVeterinario.Location = new System.Drawing.Point(0, 0);
            this.grdVeterinario.Name = "grdVeterinario";
            this.grdVeterinario.ReadOnly = true;
            this.grdVeterinario.Size = new System.Drawing.Size(310, 195);
            this.grdVeterinario.TabIndex = 4;
            this.grdVeterinario.DoubleClick += new System.EventHandler(this.grdVeterinario_DoubleClick);
            this.grdVeterinario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVeterinario_KeyDown);
            // 
            // vNombre
            // 
            this.vNombre.DataPropertyName = "Nombre";
            this.vNombre.HeaderText = "Nombre";
            this.vNombre.Name = "vNombre";
            this.vNombre.ReadOnly = true;
            this.vNombre.Width = 250;
            // 
            // codigoTrabajoDataGridViewTextBoxColumn3
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn3.DataPropertyName = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn3.HeaderText = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn3.Name = "codigoTrabajoDataGridViewTextBoxColumn3";
            this.codigoTrabajoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.codigoTrabajoDataGridViewTextBoxColumn3.Visible = false;
            // 
            // codigoEmpresaDataGridViewTextBoxColumn3
            // 
            this.codigoEmpresaDataGridViewTextBoxColumn3.DataPropertyName = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn3.HeaderText = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn3.Name = "codigoEmpresaDataGridViewTextBoxColumn3";
            this.codigoEmpresaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.codigoEmpresaDataGridViewTextBoxColumn3.Visible = false;
            // 
            // vCodigo
            // 
            this.vCodigo.DataPropertyName = "CodigoEmpleado";
            this.vCodigo.HeaderText = "CodigoEmpleado";
            this.vCodigo.Name = "vCodigo";
            this.vCodigo.ReadOnly = true;
            this.vCodigo.Visible = false;
            // 
            // codigoSucursalDataGridViewTextBoxColumn1
            // 
            this.codigoSucursalDataGridViewTextBoxColumn1.DataPropertyName = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn1.HeaderText = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn1.Name = "codigoSucursalDataGridViewTextBoxColumn1";
            this.codigoSucursalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoSucursalDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombrePuestoDataGridViewTextBoxColumn
            // 
            this.nombrePuestoDataGridViewTextBoxColumn.DataPropertyName = "NombrePuesto";
            this.nombrePuestoDataGridViewTextBoxColumn.HeaderText = "NombrePuesto";
            this.nombrePuestoDataGridViewTextBoxColumn.Name = "nombrePuestoDataGridViewTextBoxColumn";
            this.nombrePuestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePuestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            // 
            // aperturaDataGridViewTextBoxColumn1
            // 
            this.aperturaDataGridViewTextBoxColumn1.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn1.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn1.Name = "aperturaDataGridViewTextBoxColumn1";
            this.aperturaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn1
            // 
            this.activoDataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn1.Name = "activoDataGridViewCheckBoxColumn1";
            this.activoDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // notaDataGridViewTextBoxColumn1
            // 
            this.notaDataGridViewTextBoxColumn1.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn1.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn1.Name = "notaDataGridViewTextBoxColumn1";
            this.notaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsVeterinario
            // 
            this.bsVeterinario.DataMember = "tbEmpleado";
            this.bsVeterinario.DataSource = this.dataSet;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Veterinarios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdMascota
            // 
            this.grdMascota.AllowUserToAddRows = false;
            this.grdMascota.AllowUserToDeleteRows = false;
            this.grdMascota.AutoGenerateColumns = false;
            this.grdMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mCodigo,
            this.nombreDataGridViewTextBoxColumn,
            this.nombreDuenoDataGridViewTextBoxColumn});
            this.grdMascota.DataSource = this.bsMascota;
            this.grdMascota.Location = new System.Drawing.Point(82, 81);
            this.grdMascota.Name = "grdMascota";
            this.grdMascota.ReadOnly = true;
            this.grdMascota.RowHeadersVisible = false;
            this.grdMascota.Size = new System.Drawing.Size(453, 150);
            this.grdMascota.TabIndex = 16;
            this.grdMascota.Visible = false;
            this.grdMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMascota_CellContentClick);
            this.grdMascota.DoubleClick += new System.EventHandler(this.grdMascota_DoubleClick);
            this.grdMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMascota_KeyDown);
            // 
            // mCodigo
            // 
            this.mCodigo.DataPropertyName = "CodigoMascota";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mCodigo.DefaultCellStyle = dataGridViewCellStyle5;
            this.mCodigo.HeaderText = "Codigo";
            this.mCodigo.Name = "mCodigo";
            this.mCodigo.ReadOnly = true;
            this.mCodigo.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDuenoDataGridViewTextBoxColumn
            // 
            this.nombreDuenoDataGridViewTextBoxColumn.DataPropertyName = "nombreDueno";
            this.nombreDuenoDataGridViewTextBoxColumn.HeaderText = "nombreDueno";
            this.nombreDuenoDataGridViewTextBoxColumn.Name = "nombreDuenoDataGridViewTextBoxColumn";
            this.nombreDuenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDuenoDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsMascota
            // 
            this.bsMascota.DataMember = "tbMascota";
            this.bsMascota.DataSource = this.dsNeo;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // taCita
            // 
            this.taCita.ClearBeforeFill = true;
            // 
            // taCitaDetalle
            // 
            this.taCitaDetalle.ClearBeforeFill = true;
            // 
            // taMascota
            // 
            this.taMascota.ClearBeforeFill = true;
            // 
            // taArticulo
            // 
            this.taArticulo.ClearBeforeFill = true;
            // 
            // taEmpleado
            // 
            this.taEmpleado.ClearBeforeFill = true;
            // 
            // taArticuloProveedor
            // 
            this.taArticuloProveedor.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taArticulo = this.taArticulo;
            this.tableAdapterManager.taArticuloMultimedia = null;
            this.tableAdapterManager.taCaracter = null;
            this.tableAdapterManager.taCategoria = null;
            this.tableAdapterManager.taCliente = null;
            this.tableAdapterManager.taClienteNacionalidad = null;
            this.tableAdapterManager.taClienteSucursalContacto = null;
            this.tableAdapterManager.taContacto = null;
            this.tableAdapterManager.taContactoMiembro = null;
            this.tableAdapterManager.taDepartamento = null;
            this.tableAdapterManager.taEmpleado = this.taEmpleado;
            this.tableAdapterManager.taEmpresa = null;
            this.tableAdapterManager.taEstado = null;
            this.tableAdapterManager.taFinanciera = null;
            this.tableAdapterManager.taFormaPago = null;
            this.tableAdapterManager.taFrecuencia = null;
            this.tableAdapterManager.taGrupo = null;
            this.tableAdapterManager.taGrupoSanguineo = null;
            this.tableAdapterManager.taIdentificacion = null;
            this.tableAdapterManager.taMoneda = null;
            this.tableAdapterManager.taNacionalidad = null;
            this.tableAdapterManager.taOcupacion = null;
            this.tableAdapterManager.taOrdenPedido = null;
            this.tableAdapterManager.taOrdenPedidoArticulo = null;
            this.tableAdapterManager.taOrdenPedidoEstado = null;
            this.tableAdapterManager.taPais = null;
            this.tableAdapterManager.taPelaje = null;
            this.tableAdapterManager.taPrecioVenta = null;
            this.tableAdapterManager.taPropiedad = null;
            this.tableAdapterManager.taProveedor = null;
            this.tableAdapterManager.taProveedorSucursal = null;
            this.tableAdapterManager.taProveedorSucursalContacto = null;
            this.tableAdapterManager.taProvincia = null;
            this.tableAdapterManager.taPuesto = null;
            this.tableAdapterManager.taRaza = null;
            this.tableAdapterManager.taSucursal = null;
            this.tableAdapterManager.taSucursalMiembro = null;
            this.tableAdapterManager.taTipoContacto = null;
            this.tableAdapterManager.taTipoFinanciera = null;
            this.tableAdapterManager.taTipoTributo = null;
            this.tableAdapterManager.taTrabajo = null;
            this.tableAdapterManager.taTributo = null;
            this.tableAdapterManager.taUnidad = null;
            this.tableAdapterManager.taUsuario = null;
            this.tableAdapterManager.UpdateOrder = Neo.DsNeoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taArticulo1
            // 
            this.taArticulo1.ClearBeforeFill = true;
            // 
            // taArticuloPrecioVenta
            // 
            this.taArticuloPrecioVenta.ClearBeforeFill = true;
            // 
            // FrmTscCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 448);
            this.Controls.Add(this.grdMascota);
            this.Controls.Add(this.pnlVeterinario);
            this.Controls.Add(this.pnlServicio);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmTscCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTscCita_FormClosed);
            this.Load += new System.EventHandler(this.FrmTscCita_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).EndInit();
            this.bnCita.ResumeLayout(false);
            this.bnCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl15.ResumeLayout(false);
            this.pnl15.PerformLayout();
            this.pnl12.ResumeLayout(false);
            this.pnl14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalle)).EndInit();
            this.pnl13.ResumeLayout(false);
            this.pnl13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnDetalle)).EndInit();
            this.bnDetalle.ResumeLayout(false);
            this.bnDetalle.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipo)).EndInit();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascotaCita)).EndInit();
            this.pnlServicio.ResumeLayout(false);
            this.pnlTipoContactoSub.ResumeLayout(false);
            this.pnlTipoContactoSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnlVeterinario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl12;
        private System.Windows.Forms.Panel pnl14;
        private System.Windows.Forms.Panel pnl13;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.BindingSource bsCita;
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
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscaMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTipo;
        private System.Windows.Forms.Label lblUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.BindingSource bsDetalle;
        private System.Windows.Forms.BindingNavigator bnDetalle;
        private System.Windows.Forms.ToolStripButton btnNuevoServicio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnEliminaServicio;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel pnl16;
        private System.Windows.Forms.Panel pnl15;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.BindingSource bsMascota;
        private System.Windows.Forms.Label lblSexo;
        private DsNeo dataSet;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDueno;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlServicio;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptaServicio;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelaServicio;
        private System.Windows.Forms.Panel pnlTipoContactoSub;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlVeterinario;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAceptaVeterinario;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelaVeterinario;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdVeterinario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsServicio;
        private DsNeoTableAdapters.taArticulo taArticulo;
        private System.Windows.Forms.BindingSource bsVeterinario;
        private DsNeoTableAdapters.taEmpleado taEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdArticulo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServicio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private DsNeoTableAdapters.taArticuloProveedor taArticuloProveedor;
        private System.Windows.Forms.BindingSource bsMascotaCita;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMascota;
        private System.Windows.Forms.Label lblCodigo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private DsNeoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider ep;
        private DsNeoTableAdapters.taArticulo taArticulo1;
        private DsNeoTableAdapters.taArticuloPrecioVenta taArticuloPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDuenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigoVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVeterinario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pendienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCosto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVenta;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnServicioAceptarNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn caratulaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inventarioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicaOrdenPedidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicaInscripcionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn veterinariaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn1;
        public DsNeo dsNeo;
        public DsNeoTableAdapters.taCita taCita;
        public DsNeoTableAdapters.taMascota taMascota;
        public DsNeoTableAdapters.taCitaDetalle taCitaDetalle;
    }
}