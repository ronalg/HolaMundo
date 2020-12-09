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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnCita = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsCita = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl16 = new System.Windows.Forms.Panel();
            this.pnl15 = new System.Windows.Forms.Panel();
            this.lblTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.grdArticulo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.pnl13 = new System.Windows.Forms.Panel();
            this.bnDetalle = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.kryptonDataGridView2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPropiedad = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.cboTipo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtpFecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.bsMascota = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Neo.DsNeo();
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
            this.grdMascota = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.mCodigoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlServicio = new System.Windows.Forms.Panel();
            this.btnAceptaServicio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelaServicio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlTipoContactoSub = new System.Windows.Forms.Panel();
            this.grdServicio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsServicio = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pnlVeterinario = new System.Windows.Forms.Panel();
            this.btnAceptaVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelaVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdVeterinario = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsVeterinario = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.taCita = new Neo.DsNeoTableAdapters.taCita();
            this.taCitaDetalle = new Neo.DsNeoTableAdapters.taCitaDetalle();
            this.taCitaPropiedad = new Neo.DsNeoTableAdapters.taCitaPropiedad();
            this.taMascota = new Neo.DsNeoTableAdapters.taMascota();
            this.taArticulo = new Neo.DsNeoTableAdapters.taArticulo();
            this.taEmpleado = new Neo.DsNeoTableAdapters.taEmpleado();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCodigoVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.codigoTrabajoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCodigoVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
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
            this.pnl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPropiedad)).BeginInit();
            this.pnl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipo)).BeginInit();
            this.pnl6.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).BeginInit();
            this.pnlServicio.SuspendLayout();
            this.pnlTipoContactoSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).BeginInit();
            this.pnlVeterinario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeterinario)).BeginInit();
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
            this.pnl1.Size = new System.Drawing.Size(1370, 28);
            this.pnl1.TabIndex = 0;
            // 
            // bnCita
            // 
            this.bnCita.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnCita.BindingSource = this.bsCita;
            this.bnCita.CountItem = this.bindingNavigatorCountItem;
            this.bnCita.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbCitaBindingNavigatorSaveItem,
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
            this.bnCita.Size = new System.Drawing.Size(1368, 25);
            this.bnCita.TabIndex = 3;
            this.bnCita.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(105, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(70, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // tbCitaBindingNavigatorSaveItem
            // 
            this.tbCitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbCitaBindingNavigatorSaveItem.Image")));
            this.tbCitaBindingNavigatorSaveItem.Name = "tbCitaBindingNavigatorSaveItem";
            this.tbCitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(101, 22);
            this.tbCitaBindingNavigatorSaveItem.Text = "Guardar datos";
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
            this.pnl2.Size = new System.Drawing.Size(1370, 642);
            this.pnl2.TabIndex = 1;
            // 
            // pnl16
            // 
            this.pnl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl16.Location = new System.Drawing.Point(0, 587);
            this.pnl16.Name = "pnl16";
            this.pnl16.Size = new System.Drawing.Size(1366, 10);
            this.pnl16.TabIndex = 4;
            // 
            // pnl15
            // 
            this.pnl15.BackColor = System.Drawing.Color.White;
            this.pnl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl15.Controls.Add(this.lblTotal);
            this.pnl15.Controls.Add(this.kryptonLabel2);
            this.pnl15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl15.Location = new System.Drawing.Point(0, 597);
            this.pnl15.Name = "pnl15";
            this.pnl15.Size = new System.Drawing.Size(1366, 41);
            this.pnl15.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblTotal.Location = new System.Drawing.Point(970, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Values.Text = "0.00";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(903, 10);
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
            this.pnl12.Size = new System.Drawing.Size(1366, 439);
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
            this.pnl14.Size = new System.Drawing.Size(1364, 412);
            this.pnl14.TabIndex = 3;
            // 
            // grdArticulo
            // 
            this.grdArticulo.AllowUserToAddRows = false;
            this.grdArticulo.AllowUserToDeleteRows = false;
            this.grdArticulo.AutoGenerateColumns = false;
            this.grdArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.numeroCitaDataGridViewTextBoxColumn,
            this.aCodigoVeterinario,
            this.aCodigoArticulo,
            this.aDescripcion,
            this.aVeterinario,
            this.pendienteDataGridViewCheckBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.activaDataGridViewCheckBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn});
            this.grdArticulo.DataSource = this.bsDetalle;
            this.grdArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArticulo.Location = new System.Drawing.Point(0, 0);
            this.grdArticulo.Name = "grdArticulo";
            this.grdArticulo.ReadOnly = true;
            this.grdArticulo.Size = new System.Drawing.Size(1362, 410);
            this.grdArticulo.TabIndex = 0;
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
            this.pnl13.Size = new System.Drawing.Size(1364, 25);
            this.pnl13.TabIndex = 2;
            // 
            // bnDetalle
            // 
            this.bnDetalle.AddNewItem = this.toolStripButton1;
            this.bnDetalle.BindingSource = this.bsCita;
            this.bnDetalle.CountItem = this.toolStripLabel1;
            this.bnDetalle.DeleteItem = this.toolStripButton2;
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bnDetalle.Location = new System.Drawing.Point(0, 0);
            this.bnDetalle.MoveFirstItem = this.toolStripButton3;
            this.bnDetalle.MoveLastItem = this.toolStripButton6;
            this.bnDetalle.MoveNextItem = this.toolStripButton5;
            this.bnDetalle.MovePreviousItem = this.toolStripButton4;
            this.bnDetalle.Name = "bnDetalle";
            this.bnDetalle.PositionItem = this.toolStripTextBox1;
            this.bnDetalle.Size = new System.Drawing.Size(1362, 25);
            this.bnDetalle.TabIndex = 5;
            this.bnDetalle.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Agregar nuevo";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de elementos";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Eliminar";
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
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Guardar datos";
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 189);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(1366, 10);
            this.pnl11.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.pnl10);
            this.pnl3.Controls.Add(this.pnl9);
            this.pnl3.Controls.Add(this.pnl8);
            this.pnl3.Controls.Add(this.pnl7);
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1366, 189);
            this.pnl3.TabIndex = 0;
            // 
            // pnl10
            // 
            this.pnl10.AutoScroll = true;
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Controls.Add(this.kryptonDataGridView2);
            this.pnl10.Controls.Add(this.label4);
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl10.Location = new System.Drawing.Point(870, 0);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(230, 189);
            this.pnl10.TabIndex = 6;
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.AllowUserToAddRows = false;
            this.kryptonDataGridView2.AllowUserToDeleteRows = false;
            this.kryptonDataGridView2.AutoGenerateColumns = false;
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn1,
            this.codigoEmpresaDataGridViewTextBoxColumn1,
            this.numeroCitaDataGridViewTextBoxColumn1,
            this.codigoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.kryptonDataGridView2.DataSource = this.bsPropiedad;
            this.kryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(0, 17);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.Size = new System.Drawing.Size(228, 170);
            this.kryptonDataGridView2.TabIndex = 4;
            // 
            // codigoTrabajoDataGridViewTextBoxColumn1
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn1.HeaderText = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn1.Name = "codigoTrabajoDataGridViewTextBoxColumn1";
            this.codigoTrabajoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codigoEmpresaDataGridViewTextBoxColumn1
            // 
            this.codigoEmpresaDataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn1.HeaderText = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn1.Name = "codigoEmpresaDataGridViewTextBoxColumn1";
            this.codigoEmpresaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numeroCitaDataGridViewTextBoxColumn1
            // 
            this.numeroCitaDataGridViewTextBoxColumn1.DataPropertyName = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn1.HeaderText = "NumeroCita";
            this.numeroCitaDataGridViewTextBoxColumn1.Name = "numeroCitaDataGridViewTextBoxColumn1";
            this.numeroCitaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 70;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPropiedad
            // 
            this.bsPropiedad.DataMember = "tbCitaPropiedad";
            this.bsPropiedad.DataSource = this.dsNeo;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propiedades";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl9
            // 
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl9.Location = new System.Drawing.Point(860, 0);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(10, 189);
            this.pnl9.TabIndex = 5;
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
            this.pnl8.Location = new System.Drawing.Point(678, 0);
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
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "NumeroCita", true));
            this.lblNumero.Location = new System.Drawing.Point(62, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 20);
            this.lblNumero.TabIndex = 3;
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
            // pnl7
            // 
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl7.Location = new System.Drawing.Point(668, 0);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(10, 189);
            this.pnl7.TabIndex = 3;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl6.Location = new System.Drawing.Point(354, 0);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(314, 189);
            this.pnl6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contactos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(344, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 189);
            this.pnl5.TabIndex = 1;
            // 
            // pnl4
            // 
            this.pnl4.AutoScroll = true;
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnl4.Size = new System.Drawing.Size(344, 189);
            this.pnl4.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascota, "Sexo", true));
            this.lblSexo.Location = new System.Drawing.Point(79, 159);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(251, 20);
            this.lblSexo.TabIndex = 21;
            // 
            // bsMascota
            // 
            this.bsMascota.DataMember = "tbMascota";
            this.bsMascota.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DsNeo";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRaza
            // 
            this.lblRaza.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRaza.Location = new System.Drawing.Point(79, 133);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(251, 20);
            this.lblRaza.TabIndex = 20;
            // 
            // lblGrupo
            // 
            this.lblGrupo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascota, "NombreGrupo", true));
            this.lblGrupo.Location = new System.Drawing.Point(79, 107);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(251, 20);
            this.lblGrupo.TabIndex = 19;
            // 
            // lblDueno
            // 
            this.lblDueno.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDueno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMascota, "nombreDueno", true));
            this.lblDueno.Location = new System.Drawing.Point(79, 80);
            this.lblDueno.Name = "lblDueno";
            this.lblDueno.Size = new System.Drawing.Size(251, 20);
            this.lblDueno.TabIndex = 18;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(10, 159);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "Sexo:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 133);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Raza:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 105);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "Grupo:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 79);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Dueño:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 53);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(79, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(251, 20);
            this.lblNombre.TabIndex = 12;
            // 
            // txtBuscaMascota
            // 
            this.txtBuscaMascota.Location = new System.Drawing.Point(79, 26);
            this.txtBuscaMascota.Name = "txtBuscaMascota";
            this.txtBuscaMascota.Size = new System.Drawing.Size(251, 23);
            this.txtBuscaMascota.TabIndex = 2;
            this.txtBuscaMascota.TextChanged += new System.EventHandler(this.txtBuscaMascota_TextChanged);
            this.txtBuscaMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaMascota_KeyDown);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 27);
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
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdMascota
            // 
            this.grdMascota.AllowUserToAddRows = false;
            this.grdMascota.AllowUserToDeleteRows = false;
            this.grdMascota.AutoGenerateColumns = false;
            this.grdMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mCodigoMascota,
            this.mCodigoCliente,
            this.mNombre,
            this.mDueno});
            this.grdMascota.DataSource = this.bsMascota;
            this.grdMascota.Location = new System.Drawing.Point(82, 81);
            this.grdMascota.Name = "grdMascota";
            this.grdMascota.ReadOnly = true;
            this.grdMascota.RowHeadersVisible = false;
            this.grdMascota.Size = new System.Drawing.Size(371, 150);
            this.grdMascota.TabIndex = 2;
            this.grdMascota.Visible = false;
            this.grdMascota.DoubleClick += new System.EventHandler(this.grdMascota_DoubleClick);
            this.grdMascota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMascota_KeyDown);
            // 
            // mCodigoMascota
            // 
            this.mCodigoMascota.DataPropertyName = "CodigoMascota";
            this.mCodigoMascota.HeaderText = "CodigoMascota";
            this.mCodigoMascota.Name = "mCodigoMascota";
            this.mCodigoMascota.ReadOnly = true;
            this.mCodigoMascota.Visible = false;
            // 
            // mCodigoCliente
            // 
            this.mCodigoCliente.DataPropertyName = "CodigoCliente";
            this.mCodigoCliente.HeaderText = "CodigoCliente";
            this.mCodigoCliente.Name = "mCodigoCliente";
            this.mCodigoCliente.ReadOnly = true;
            this.mCodigoCliente.Visible = false;
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
            this.mDueno.Width = 250;
            // 
            // pnlServicio
            // 
            this.pnlServicio.BackColor = System.Drawing.Color.White;
            this.pnlServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicio.Controls.Add(this.btnAceptaServicio);
            this.pnlServicio.Controls.Add(this.btnCancelaServicio);
            this.pnlServicio.Controls.Add(this.pnlTipoContactoSub);
            this.pnlServicio.Controls.Add(this.label8);
            this.pnlServicio.Location = new System.Drawing.Point(160, 154);
            this.pnlServicio.Name = "pnlServicio";
            this.pnlServicio.Size = new System.Drawing.Size(364, 289);
            this.pnlServicio.TabIndex = 14;
            this.pnlServicio.Visible = false;
            // 
            // btnAceptaServicio
            // 
            this.btnAceptaServicio.Location = new System.Drawing.Point(265, 254);
            this.btnAceptaServicio.Name = "btnAceptaServicio";
            this.btnAceptaServicio.Size = new System.Drawing.Size(90, 25);
            this.btnAceptaServicio.TabIndex = 3;
            this.btnAceptaServicio.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptaServicio.Values.Image")));
            this.btnAceptaServicio.Values.Text = "Aceptar";
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
            this.pnlTipoContactoSub.Controls.Add(this.grdServicio);
            this.pnlTipoContactoSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTipoContactoSub.Location = new System.Drawing.Point(0, 17);
            this.pnlTipoContactoSub.Name = "pnlTipoContactoSub";
            this.pnlTipoContactoSub.Size = new System.Drawing.Size(362, 229);
            this.pnlTipoContactoSub.TabIndex = 1;
            // 
            // grdServicio
            // 
            this.grdServicio.AllowUserToAddRows = false;
            this.grdServicio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.grdServicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdServicio.AutoGenerateColumns = false;
            this.grdServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn2,
            this.codigoEmpresaDataGridViewTextBoxColumn2,
            this.sCodigoArticulo,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.nombreDepartamentoDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
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
            this.veterinariaDataGridViewCheckBoxColumn});
            this.grdServicio.DataSource = this.bsServicio;
            this.grdServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdServicio.Location = new System.Drawing.Point(0, 0);
            this.grdServicio.Name = "grdServicio";
            this.grdServicio.ReadOnly = true;
            this.grdServicio.Size = new System.Drawing.Size(360, 227);
            this.grdServicio.TabIndex = 4;
            // 
            // bsServicio
            // 
            this.bsServicio.DataMember = "tbArticulo";
            this.bsServicio.DataSource = this.dataSet;
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
            this.pnlVeterinario.Location = new System.Drawing.Point(535, 154);
            this.pnlVeterinario.Name = "pnlVeterinario";
            this.pnlVeterinario.Size = new System.Drawing.Size(364, 256);
            this.pnlVeterinario.TabIndex = 15;
            this.pnlVeterinario.Visible = false;
            // 
            // btnAceptaVeterinario
            // 
            this.btnAceptaVeterinario.Location = new System.Drawing.Point(265, 220);
            this.btnAceptaVeterinario.Name = "btnAceptaVeterinario";
            this.btnAceptaVeterinario.Size = new System.Drawing.Size(90, 25);
            this.btnAceptaVeterinario.TabIndex = 3;
            this.btnAceptaVeterinario.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptaVeterinario.Values.Image")));
            this.btnAceptaVeterinario.Values.Text = "Aceptar";
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
            this.panel2.Size = new System.Drawing.Size(362, 197);
            this.panel2.TabIndex = 1;
            // 
            // grdVeterinario
            // 
            this.grdVeterinario.AllowUserToAddRows = false;
            this.grdVeterinario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            this.grdVeterinario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdVeterinario.AutoGenerateColumns = false;
            this.grdVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVeterinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn3,
            this.codigoEmpresaDataGridViewTextBoxColumn3,
            this.vCodigoVeterinario,
            this.codigoSucursalDataGridViewTextBoxColumn1,
            this.nombrePuestoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn1,
            this.activoDataGridViewCheckBoxColumn1,
            this.notaDataGridViewTextBoxColumn1,
            this.vNombre});
            this.grdVeterinario.DataSource = this.bsVeterinario;
            this.grdVeterinario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVeterinario.Location = new System.Drawing.Point(0, 0);
            this.grdVeterinario.Name = "grdVeterinario";
            this.grdVeterinario.ReadOnly = true;
            this.grdVeterinario.Size = new System.Drawing.Size(360, 195);
            this.grdVeterinario.TabIndex = 4;
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
            this.label5.Size = new System.Drawing.Size(362, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Veterinarios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taCita
            // 
            this.taCita.ClearBeforeFill = true;
            // 
            // taCitaDetalle
            // 
            this.taCitaDetalle.ClearBeforeFill = true;
            // 
            // taCitaPropiedad
            // 
            this.taCitaPropiedad.ClearBeforeFill = true;
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
            // aCodigoArticulo
            // 
            this.aCodigoArticulo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aCodigoArticulo.DefaultCellStyle = dataGridViewCellStyle11;
            this.aCodigoArticulo.HeaderText = "Código";
            this.aCodigoArticulo.Name = "aCodigoArticulo";
            this.aCodigoArticulo.ReadOnly = true;
            this.aCodigoArticulo.Width = 70;
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
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Visible = false;
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
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Width = 230;
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "venta";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.ventaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaDataGridViewTextBoxColumn.Width = 80;
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
            // sCodigoArticulo
            // 
            this.sCodigoArticulo.DataPropertyName = "CodigoArticulo";
            this.sCodigoArticulo.HeaderText = "CodigoArticulo";
            this.sCodigoArticulo.Name = "sCodigoArticulo";
            this.sCodigoArticulo.ReadOnly = true;
            this.sCodigoArticulo.Visible = false;
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
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "Descripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            this.sDescripcion.Width = 295;
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
            // vCodigoVeterinario
            // 
            this.vCodigoVeterinario.DataPropertyName = "CodigoEmpleado";
            this.vCodigoVeterinario.HeaderText = "CodigoEmpleado";
            this.vCodigoVeterinario.Name = "vCodigoVeterinario";
            this.vCodigoVeterinario.ReadOnly = true;
            this.vCodigoVeterinario.Visible = false;
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
            // vNombre
            // 
            this.vNombre.DataPropertyName = "Nombre";
            this.vNombre.HeaderText = "Nombre";
            this.vNombre.Name = "vNombre";
            this.vNombre.ReadOnly = true;
            this.vNombre.Width = 300;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // FrmTscCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 670);
            this.Controls.Add(this.pnlVeterinario);
            this.Controls.Add(this.pnlServicio);
            this.Controls.Add(this.grdMascota);
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
            this.pnl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPropiedad)).EndInit();
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipo)).EndInit();
            this.pnl6.ResumeLayout(false);
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMascota)).EndInit();
            this.pnlServicio.ResumeLayout(false);
            this.pnlTipoContactoSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServicio)).EndInit();
            this.pnlVeterinario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeterinario)).EndInit();
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
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsCita;
        private DsNeoTableAdapters.taCita taCita;
        private System.Windows.Forms.BindingNavigator bnCita;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbCitaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscaMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTipo;
        private System.Windows.Forms.Label lblUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.BindingSource bsDetalle;
        private DsNeoTableAdapters.taCitaDetalle taCitaDetalle;
        private System.Windows.Forms.BindingNavigator bnDetalle;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Panel pnl16;
        private System.Windows.Forms.Panel pnl15;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdArticulo;
        private System.Windows.Forms.BindingSource bsPropiedad;
        private DsNeoTableAdapters.taCitaPropiedad taCitaPropiedad;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMascota;
        private System.Windows.Forms.BindingSource bsMascota;
        private DsNeoTableAdapters.taMascota taMascota;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDueno;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigoVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVeterinario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pendienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCodigoVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNombre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}