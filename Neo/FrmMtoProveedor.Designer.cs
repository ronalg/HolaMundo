namespace Neo
{
    partial class FrmMtoProveedor
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label sitioWebLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoProveedorLabel;
            System.Windows.Forms.Label grabadaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label equipoLabel;
            System.Windows.Forms.Label cuentaContableLabel;
            System.Windows.Forms.Label nombreTipoCategoriaLabel;
            System.Windows.Forms.Label nombreCategoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.tcProveedor = new System.Windows.Forms.TabControl();
            this.tpGlobal = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.cboTipoCategoria = new System.Windows.Forms.ComboBox();
            this.cboIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblGrabada = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tpSucursal = new System.Windows.Forms.TabPage();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.grdContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContacto = new System.Windows.Forms.BindingSource(this.components);
            this.pnl13 = new System.Windows.Forms.Panel();
            this.bnContacto = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevoContacto = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarContacto = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.grdSucursal = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombrePais = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sProvincia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSucursal = new System.Windows.Forms.BindingSource(this.components);
            this.pnl11 = new System.Windows.Forms.Panel();
            this.bnSucursal = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevoSucursal = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarSucursal = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnMto = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.lblRegistro = new System.Windows.Forms.ToolStripLabel();
            this.btnPrimero = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.spd1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPosicion = new System.Windows.Forms.ToolStripTextBox();
            this.spd2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.spd3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.taProveedor = new Neo.DsNeoTableAdapters.taProveedor();
            this.taTipoCategoria = new Neo.DsNeoTableAdapters.taTipoCategoria();
            this.taCategoria = new Neo.DsNeoTableAdapters.taCategoria();
            this.taIdentificacion = new Neo.DsNeoTableAdapters.taIdentificacion();
            this.taProveedorSucursal = new Neo.DsNeoTableAdapters.taProveedorSucursal();
            this.taProveedorSucursalContacto = new Neo.DsNeoTableAdapters.taProveedorSucursalContacto();
            this.taPais = new Neo.DsNeoTableAdapters.taPais();
            this.taProvincia = new Neo.DsNeoTableAdapters.taProvincia();
            this.taContacto = new Neo.DsNeoTableAdapters.taContacto();
            this.taTipoContacto = new Neo.DsNeoTableAdapters.taTipoContacto();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grabadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            sitioWebLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoProveedorLabel = new System.Windows.Forms.Label();
            grabadaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            cuentaContableLabel = new System.Windows.Forms.Label();
            nombreTipoCategoriaLabel = new System.Windows.Forms.Label();
            nombreCategoriaLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.tcProveedor.SuspendLayout();
            this.tpGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.tpSucursal.SuspendLayout();
            this.pnl9.SuspendLayout();
            this.pnl10.SuspendLayout();
            this.pnl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).BeginInit();
            this.pnl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnContacto)).BeginInit();
            this.bnContacto.SuspendLayout();
            this.pnl7.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).BeginInit();
            this.pnl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnSucursal)).BeginInit();
            this.bnSucursal.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(75, 36);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(49, 62);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 7;
            razonSocialLabel.Text = "Razón Social:";
            // 
            // sitioWebLabel
            // 
            sitioWebLabel.AutoSize = true;
            sitioWebLabel.Location = new System.Drawing.Point(66, 116);
            sitioWebLabel.Name = "sitioWebLabel";
            sitioWebLabel.Size = new System.Drawing.Size(56, 13);
            sitioWebLabel.TabIndex = 10;
            sitioWebLabel.Text = "Sitio Web:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(368, 147);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 11;
            activoLabel.Text = "Activo:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(363, 172);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 12;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(358, 199);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 14;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoProveedorLabel
            // 
            codigoProveedorLabel.AutoSize = true;
            codigoProveedorLabel.Location = new System.Drawing.Point(366, 227);
            codigoProveedorLabel.Name = "codigoProveedorLabel";
            codigoProveedorLabel.Size = new System.Drawing.Size(43, 13);
            codigoProveedorLabel.TabIndex = 16;
            codigoProveedorLabel.Text = "Código:";
            // 
            // grabadaLabel
            // 
            grabadaLabel.AutoSize = true;
            grabadaLabel.Location = new System.Drawing.Point(358, 253);
            grabadaLabel.Name = "grabadaLabel";
            grabadaLabel.Size = new System.Drawing.Size(51, 13);
            grabadaLabel.TabIndex = 18;
            grabadaLabel.Text = "Grabada:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(363, 280);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 20;
            usuarioLabel.Text = "Usuario:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(366, 307);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 22;
            equipoLabel.Text = "Equipo:";
            // 
            // cuentaContableLabel
            // 
            cuentaContableLabel.AutoSize = true;
            cuentaContableLabel.Location = new System.Drawing.Point(365, 36);
            cuentaContableLabel.Name = "cuentaContableLabel";
            cuentaContableLabel.Size = new System.Drawing.Size(44, 13);
            cuentaContableLabel.TabIndex = 25;
            cuentaContableLabel.Text = "Cuenta:";
            // 
            // nombreTipoCategoriaLabel
            // 
            nombreTipoCategoriaLabel.AutoSize = true;
            nombreTipoCategoriaLabel.Location = new System.Drawing.Point(328, 90);
            nombreTipoCategoriaLabel.Name = "nombreTipoCategoriaLabel";
            nombreTipoCategoriaLabel.Size = new System.Drawing.Size(81, 13);
            nombreTipoCategoriaLabel.TabIndex = 27;
            nombreTipoCategoriaLabel.Text = "Tipo Categoría:";
            // 
            // nombreCategoriaLabel
            // 
            nombreCategoriaLabel.AutoSize = true;
            nombreCategoriaLabel.Location = new System.Drawing.Point(352, 119);
            nombreCategoriaLabel.Name = "nombreCategoriaLabel";
            nombreCategoriaLabel.Size = new System.Drawing.Size(57, 13);
            nombreCategoriaLabel.TabIndex = 29;
            nombreCategoriaLabel.Text = "Categoría:";
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
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 38);
            this.pnl3.Name = "pnl3";
            this.pnl3.Padding = new System.Windows.Forms.Padding(5);
            this.pnl3.Size = new System.Drawing.Size(1493, 622);
            this.pnl3.TabIndex = 7;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.tcProveedor);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(293, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(1193, 610);
            this.pnl6.TabIndex = 6;
            // 
            // tcProveedor
            // 
            this.tcProveedor.Controls.Add(this.tpGlobal);
            this.tcProveedor.Controls.Add(this.tpSucursal);
            this.tcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProveedor.Location = new System.Drawing.Point(0, 0);
            this.tcProveedor.Name = "tcProveedor";
            this.tcProveedor.SelectedIndex = 0;
            this.tcProveedor.Size = new System.Drawing.Size(1191, 608);
            this.tcProveedor.TabIndex = 32;
            // 
            // tpGlobal
            // 
            this.tpGlobal.Controls.Add(this.label1);
            this.tpGlobal.Controls.Add(this.cboCategoria);
            this.tpGlobal.Controls.Add(this.txtNombre);
            this.tpGlobal.Controls.Add(nombreCategoriaLabel);
            this.tpGlobal.Controls.Add(nombreLabel);
            this.tpGlobal.Controls.Add(nombreTipoCategoriaLabel);
            this.tpGlobal.Controls.Add(this.txtRazonSocial);
            this.tpGlobal.Controls.Add(this.cboTipoCategoria);
            this.tpGlobal.Controls.Add(razonSocialLabel);
            this.tpGlobal.Controls.Add(cuentaContableLabel);
            this.tpGlobal.Controls.Add(this.cboIdentificacion);
            this.tpGlobal.Controls.Add(this.txtCuenta);
            this.tpGlobal.Controls.Add(this.txtIdentificacion);
            this.tpGlobal.Controls.Add(this.label3);
            this.tpGlobal.Controls.Add(equipoLabel);
            this.tpGlobal.Controls.Add(this.txtSitioWeb);
            this.tpGlobal.Controls.Add(this.lblEquipo);
            this.tpGlobal.Controls.Add(sitioWebLabel);
            this.tpGlobal.Controls.Add(usuarioLabel);
            this.tpGlobal.Controls.Add(this.label2);
            this.tpGlobal.Controls.Add(this.lblUsuario);
            this.tpGlobal.Controls.Add(this.chkActivo);
            this.tpGlobal.Controls.Add(grabadaLabel);
            this.tpGlobal.Controls.Add(activoLabel);
            this.tpGlobal.Controls.Add(this.lblGrabada);
            this.tpGlobal.Controls.Add(this.lblTrabajo);
            this.tpGlobal.Controls.Add(codigoProveedorLabel);
            this.tpGlobal.Controls.Add(codigoTrabajoLabel);
            this.tpGlobal.Controls.Add(this.lblCodigo);
            this.tpGlobal.Controls.Add(this.lblEmpresa);
            this.tpGlobal.Controls.Add(codigoEmpresaLabel);
            this.tpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tpGlobal.Name = "tpGlobal";
            this.tpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tpGlobal.Size = new System.Drawing.Size(1183, 582);
            this.tpGlobal.TabIndex = 0;
            this.tpGlobal.Text = "Global";
            this.tpGlobal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreCategoria", true));
            this.cboCategoria.DataSource = this.dsNeo;
            this.cboCategoria.DisplayMember = "tbCategoria.NombreCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(411, 116);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 31;
            this.cboCategoria.ValueMember = "tbCategoria.NombreCategoria";
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbProveedor";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(124, 33);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "RazonSocial", true));
            this.txtRazonSocial.Location = new System.Drawing.Point(124, 59);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(182, 20);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // cboTipoCategoria
            // 
            this.cboTipoCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreTipoCategoria", true));
            this.cboTipoCategoria.DataSource = this.dsNeo;
            this.cboTipoCategoria.DisplayMember = "tbTipoCategoria.NombreTipoCategoria";
            this.cboTipoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCategoria.FormattingEnabled = true;
            this.cboTipoCategoria.Location = new System.Drawing.Point(411, 87);
            this.cboTipoCategoria.Name = "cboTipoCategoria";
            this.cboTipoCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCategoria.TabIndex = 28;
            this.cboTipoCategoria.ValueMember = "tbTipoCategoria.NombreTipoCategoria";
            this.cboTipoCategoria.SelectedIndexChanged += new System.EventHandler(this.cboTipoCategoria_SelectedIndexChanged);
            // 
            // cboIdentificacion
            // 
            this.cboIdentificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoIdentificacion", true));
            this.cboIdentificacion.DataSource = this.dsNeo;
            this.cboIdentificacion.DisplayMember = "tbIdentificacion.CodigoIdentificacion";
            this.cboIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdentificacion.FormattingEnabled = true;
            this.cboIdentificacion.Location = new System.Drawing.Point(11, 87);
            this.cboIdentificacion.Name = "cboIdentificacion";
            this.cboIdentificacion.Size = new System.Drawing.Size(105, 21);
            this.cboIdentificacion.TabIndex = 9;
            this.cboIdentificacion.ValueMember = "tbIdentificacion.CodigoIdentificacion";
            // 
            // txtCuenta
            // 
            this.txtCuenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CuentaContable", true));
            this.txtCuenta.Location = new System.Drawing.Point(411, 33);
            this.txtCuenta.MaxLength = 12;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(121, 20);
            this.txtCuenta.TabIndex = 26;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Identificacion", true));
            this.txtIdentificacion.Location = new System.Drawing.Point(124, 87);
            this.txtIdentificacion.MaxLength = 20;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(182, 20);
            this.txtIdentificacion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contabilidad";
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSitioWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "SitioWeb", true));
            this.txtSitioWeb.Location = new System.Drawing.Point(124, 113);
            this.txtSitioWeb.MaxLength = 100;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(182, 20);
            this.txtSitioWeb.TabIndex = 11;
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(411, 304);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(121, 20);
            this.lblEquipo.TabIndex = 23;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(411, 277);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 20);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkActivo
            // 
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(414, 142);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(37, 24);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblGrabada
            // 
            this.lblGrabada.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrabada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrabada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Grabada", true));
            this.lblGrabada.Location = new System.Drawing.Point(411, 250);
            this.lblGrabada.Name = "lblGrabada";
            this.lblGrabada.Size = new System.Drawing.Size(121, 20);
            this.lblGrabada.TabIndex = 19;
            this.lblGrabada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(411, 169);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(121, 20);
            this.lblTrabajo.TabIndex = 13;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoProveedor", true));
            this.lblCodigo.Location = new System.Drawing.Point(411, 224);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(121, 20);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(411, 196);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(121, 20);
            this.lblEmpresa.TabIndex = 15;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpSucursal
            // 
            this.tpSucursal.Controls.Add(this.pnl9);
            this.tpSucursal.Controls.Add(this.pnl7);
            this.tpSucursal.Location = new System.Drawing.Point(4, 22);
            this.tpSucursal.Name = "tpSucursal";
            this.tpSucursal.Padding = new System.Windows.Forms.Padding(3);
            this.tpSucursal.Size = new System.Drawing.Size(1183, 582);
            this.tpSucursal.TabIndex = 1;
            this.tpSucursal.Text = "Sucursal";
            this.tpSucursal.UseVisualStyleBackColor = true;
            // 
            // pnl9
            // 
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Controls.Add(this.pnl10);
            this.pnl9.Controls.Add(this.label5);
            this.pnl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl9.Location = new System.Drawing.Point(3, 295);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(1177, 284);
            this.pnl9.TabIndex = 1;
            // 
            // pnl10
            // 
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Controls.Add(this.pnl14);
            this.pnl10.Controls.Add(this.pnl13);
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl10.Location = new System.Drawing.Point(0, 17);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(1175, 265);
            this.pnl10.TabIndex = 8;
            // 
            // pnl14
            // 
            this.pnl14.Controls.Add(this.grdContacto);
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl14.Location = new System.Drawing.Point(0, 28);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(1173, 235);
            this.pnl14.TabIndex = 9;
            // 
            // grdContacto
            // 
            this.grdContacto.AllowUserToAddRows = false;
            this.grdContacto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.grdContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdContacto.AutoGenerateColumns = false;
            this.grdContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOrden,
            this.cSucursal,
            this.cNombre,
            this.cTipo,
            this.cContacto,
            this.cTrabajo,
            this.cEmpresa,
            this.cProveedor});
            this.grdContacto.DataSource = this.bsContacto;
            this.grdContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacto.Location = new System.Drawing.Point(0, 0);
            this.grdContacto.Name = "grdContacto";
            this.grdContacto.Size = new System.Drawing.Size(1173, 235);
            this.grdContacto.TabIndex = 8;
            this.grdContacto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdContacto_CellFormatting);
            this.grdContacto.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContacto_CellValueChanged);
            this.grdContacto.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdContacto_DataError);
            // 
            // cOrden
            // 
            this.cOrden.DataPropertyName = "SecuenciaProveedorSucursalContacto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.cOrden.HeaderText = "Orden";
            this.cOrden.Name = "cOrden";
            this.cOrden.ReadOnly = true;
            this.cOrden.Width = 50;
            // 
            // cSucursal
            // 
            this.cSucursal.DataPropertyName = "CodigoProveedorSucursal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSucursal.DefaultCellStyle = dataGridViewCellStyle3;
            this.cSucursal.HeaderText = "Sucursal";
            this.cSucursal.Name = "cSucursal";
            this.cSucursal.ReadOnly = true;
            this.cSucursal.Width = 55;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "NombreContacto";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cNombre.Width = 120;
            // 
            // cTipo
            // 
            this.cTipo.DataPropertyName = "NombreTipoContacto";
            this.cTipo.HeaderText = "Tipo";
            this.cTipo.Name = "cTipo";
            this.cTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cTipo.Width = 150;
            // 
            // cContacto
            // 
            this.cContacto.DataPropertyName = "Contacto";
            this.cContacto.HeaderText = "Contacto";
            this.cContacto.Name = "cContacto";
            this.cContacto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cContacto.Width = 300;
            // 
            // cTrabajo
            // 
            this.cTrabajo.DataPropertyName = "CodigoTrabajo";
            this.cTrabajo.HeaderText = "CodigoTrabajo";
            this.cTrabajo.Name = "cTrabajo";
            this.cTrabajo.ReadOnly = true;
            this.cTrabajo.Visible = false;
            // 
            // cEmpresa
            // 
            this.cEmpresa.DataPropertyName = "CodigoEmpresa";
            this.cEmpresa.HeaderText = "CodigoEmpresa";
            this.cEmpresa.Name = "cEmpresa";
            this.cEmpresa.ReadOnly = true;
            this.cEmpresa.Visible = false;
            // 
            // cProveedor
            // 
            this.cProveedor.DataPropertyName = "CodigoProveedor";
            this.cProveedor.HeaderText = "CodigoProveedor";
            this.cProveedor.Name = "cProveedor";
            this.cProveedor.ReadOnly = true;
            this.cProveedor.Visible = false;
            // 
            // bsContacto
            // 
            this.bsContacto.DataMember = "tbProveedorSucursalContacto";
            this.bsContacto.DataSource = this.dsNeo;
            // 
            // pnl13
            // 
            this.pnl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl13.Controls.Add(this.bnContacto);
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl13.Location = new System.Drawing.Point(0, 0);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(1173, 28);
            this.pnl13.TabIndex = 8;
            // 
            // bnContacto
            // 
            this.bnContacto.AddNewItem = this.btnNuevoContacto;
            this.bnContacto.BindingSource = this.bsContacto;
            this.bnContacto.CountItem = this.toolStripLabel1;
            this.bnContacto.DeleteItem = null;
            this.bnContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnContacto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.btnNuevoContacto,
            this.btnEliminarContacto});
            this.bnContacto.Location = new System.Drawing.Point(0, 0);
            this.bnContacto.MoveFirstItem = this.toolStripButton3;
            this.bnContacto.MoveLastItem = this.toolStripButton6;
            this.bnContacto.MoveNextItem = this.toolStripButton5;
            this.bnContacto.MovePreviousItem = this.toolStripButton4;
            this.bnContacto.Name = "bnContacto";
            this.bnContacto.PositionItem = this.toolStripTextBox1;
            this.bnContacto.Size = new System.Drawing.Size(1171, 25);
            this.bnContacto.TabIndex = 5;
            this.bnContacto.Text = "bindingNavigator1";
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevoContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoContacto.Image")));
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.RightToLeftAutoMirrorImage = true;
            this.btnNuevoContacto.Size = new System.Drawing.Size(23, 22);
            this.btnNuevoContacto.Text = "Agregar nuevo";
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
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
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarContacto.Image")));
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.RightToLeftAutoMirrorImage = true;
            this.btnEliminarContacto.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarContacto.Text = "Eliminar";
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1175, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contacto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl7
            // 
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Controls.Add(this.pnl8);
            this.pnl7.Controls.Add(this.label4);
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl7.Location = new System.Drawing.Point(3, 3);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(1177, 292);
            this.pnl7.TabIndex = 0;
            // 
            // pnl8
            // 
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(this.pnl12);
            this.pnl8.Controls.Add(this.pnl11);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl8.Location = new System.Drawing.Point(0, 17);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(1175, 273);
            this.pnl8.TabIndex = 7;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.grdSucursal);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(0, 28);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(1173, 243);
            this.pnl12.TabIndex = 8;
            // 
            // grdSucursal
            // 
            this.grdSucursal.AllowUserToAddRows = false;
            this.grdSucursal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.grdSucursal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdSucursal.AutoGenerateColumns = false;
            this.grdSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCodigo,
            this.sNombre,
            this.sCodigoPais,
            this.sNombrePais,
            this.sProvincia,
            this.sCodigoPostal,
            this.sDireccion,
            this.sRepresentante,
            this.sTrabajo,
            this.sEmpresa,
            this.sProveedor});
            this.grdSucursal.DataSource = this.bsSucursal;
            this.grdSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSucursal.Location = new System.Drawing.Point(0, 0);
            this.grdSucursal.Name = "grdSucursal";
            this.grdSucursal.Size = new System.Drawing.Size(1173, 243);
            this.grdSucursal.TabIndex = 7;
            this.grdSucursal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdSucursal_CellFormatting);
            this.grdSucursal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSucursal_CellValueChanged);
            this.grdSucursal.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdSucursal_DataError);
            // 
            // sCodigo
            // 
            this.sCodigo.DataPropertyName = "CodigoProveedorSucursal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sCodigo.DefaultCellStyle = dataGridViewCellStyle5;
            this.sCodigo.HeaderText = "Código";
            this.sCodigo.Name = "sCodigo";
            this.sCodigo.Width = 50;
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "Nombre";
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.Width = 150;
            // 
            // sCodigoPais
            // 
            this.sCodigoPais.DataPropertyName = "CodigoPais";
            this.sCodigoPais.HeaderText = "Codigo País";
            this.sCodigoPais.Name = "sCodigoPais";
            this.sCodigoPais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sCodigoPais.Visible = false;
            this.sCodigoPais.Width = 150;
            // 
            // sNombrePais
            // 
            this.sNombrePais.DataPropertyName = "NombrePais";
            this.sNombrePais.HeaderText = "País";
            this.sNombrePais.Name = "sNombrePais";
            this.sNombrePais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sNombrePais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sNombrePais.Width = 150;
            // 
            // sProvincia
            // 
            this.sProvincia.DataPropertyName = "NombreProvincia";
            this.sProvincia.HeaderText = "Provincia";
            this.sProvincia.Name = "sProvincia";
            this.sProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sProvincia.Width = 150;
            // 
            // sCodigoPostal
            // 
            this.sCodigoPostal.DataPropertyName = "CodigoPostal";
            this.sCodigoPostal.HeaderText = "Codigo Postal";
            this.sCodigoPostal.Name = "sCodigoPostal";
            this.sCodigoPostal.Width = 110;
            // 
            // sDireccion
            // 
            this.sDireccion.DataPropertyName = "Direccion";
            this.sDireccion.HeaderText = "Dirección";
            this.sDireccion.Name = "sDireccion";
            this.sDireccion.Width = 180;
            // 
            // sRepresentante
            // 
            this.sRepresentante.DataPropertyName = "Representante";
            this.sRepresentante.HeaderText = "Representante";
            this.sRepresentante.Name = "sRepresentante";
            this.sRepresentante.Width = 150;
            // 
            // sTrabajo
            // 
            this.sTrabajo.DataPropertyName = "CodigoTrabajo";
            this.sTrabajo.HeaderText = "CodigoTrabajo";
            this.sTrabajo.Name = "sTrabajo";
            this.sTrabajo.ReadOnly = true;
            this.sTrabajo.Visible = false;
            // 
            // sEmpresa
            // 
            this.sEmpresa.DataPropertyName = "CodigoEmpresa";
            this.sEmpresa.HeaderText = "CodigoEmpresa";
            this.sEmpresa.Name = "sEmpresa";
            this.sEmpresa.ReadOnly = true;
            this.sEmpresa.Visible = false;
            // 
            // sProveedor
            // 
            this.sProveedor.DataPropertyName = "CodigoProveedor";
            this.sProveedor.HeaderText = "CodigoProveedor";
            this.sProveedor.Name = "sProveedor";
            this.sProveedor.ReadOnly = true;
            this.sProveedor.Visible = false;
            // 
            // bsSucursal
            // 
            this.bsSucursal.DataMember = "tbProveedorSucursal";
            this.bsSucursal.DataSource = this.dsNeo;
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Controls.Add(this.bnSucursal);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 0);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(1173, 28);
            this.pnl11.TabIndex = 7;
            // 
            // bnSucursal
            // 
            this.bnSucursal.AddNewItem = this.btnNuevoSucursal;
            this.bnSucursal.BindingSource = this.bsSucursal;
            this.bnSucursal.CountItem = this.bindingNavigatorCountItem;
            this.bnSucursal.DeleteItem = null;
            this.bnSucursal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnSucursal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNuevoSucursal,
            this.btnEliminarSucursal});
            this.bnSucursal.Location = new System.Drawing.Point(0, 0);
            this.bnSucursal.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnSucursal.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnSucursal.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnSucursal.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnSucursal.Name = "bnSucursal";
            this.bnSucursal.PositionItem = this.bindingNavigatorPositionItem;
            this.bnSucursal.Size = new System.Drawing.Size(1171, 25);
            this.bnSucursal.TabIndex = 5;
            this.bnSucursal.Text = "bindingNavigator1";
            // 
            // btnNuevoSucursal
            // 
            this.btnNuevoSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevoSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoSucursal.Image")));
            this.btnNuevoSucursal.Name = "btnNuevoSucursal";
            this.btnNuevoSucursal.RightToLeftAutoMirrorImage = true;
            this.btnNuevoSucursal.Size = new System.Drawing.Size(23, 22);
            this.btnNuevoSucursal.Text = "Agregar nuevo";
            this.btnNuevoSucursal.Click += new System.EventHandler(this.btnNuevoSucursal_Click);
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
            // btnEliminarSucursal
            // 
            this.btnEliminarSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSucursal.Image")));
            this.btnEliminarSucursal.Name = "btnEliminarSucursal";
            this.btnEliminarSucursal.RightToLeftAutoMirrorImage = true;
            this.btnEliminarSucursal.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarSucursal.Text = "Eliminar";
            this.btnEliminarSucursal.Click += new System.EventHandler(this.btnEliminarSucursal_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1175, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datos Generales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(283, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 610);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(278, 610);
            this.pnl4.TabIndex = 4;
            // 
            // grdMto
            // 
            this.grdMto.AllowUserToAddRows = false;
            this.grdMto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.pCodigo,
            this.codigoIdentificacionDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.nombreTipoCategoriaDataGridViewTextBoxColumn,
            this.pNombre,
            this.razonSocialDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.cuentaContableDataGridViewTextBoxColumn,
            this.sitioWebDataGridViewTextBoxColumn,
            this.grabadaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(276, 608);
            this.grdMto.TabIndex = 3;
            this.grdMto.SelectionChanged += new System.EventHandler(this.grdMto_SelectionChanged);
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1493, 10);
            this.pnl2.TabIndex = 6;
            // 
            // spd4
            // 
            this.spd4.Name = "spd4";
            this.spd4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnMto);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1493, 28);
            this.pnl1.TabIndex = 5;
            // 
            // bnMto
            // 
            this.bnMto.AddNewItem = this.btnNuevo;
            this.bnMto.BindingSource = this.bsMto;
            this.bnMto.CountItem = this.lblRegistro;
            this.bnMto.DeleteItem = null;
            this.bnMto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnMto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.spd1,
            this.txtPosicion,
            this.lblRegistro,
            this.spd2,
            this.btnSiguiente,
            this.btnUltimo,
            this.spd3,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.spd4,
            this.btnSalir});
            this.bnMto.Location = new System.Drawing.Point(0, 0);
            this.bnMto.MoveFirstItem = this.btnPrimero;
            this.bnMto.MoveLastItem = this.btnUltimo;
            this.bnMto.MoveNextItem = this.btnSiguiente;
            this.bnMto.MovePreviousItem = this.btnAnterior;
            this.bnMto.Name = "bnMto";
            this.bnMto.PositionItem = this.txtPosicion;
            this.bnMto.Size = new System.Drawing.Size(1491, 25);
            this.bnMto.TabIndex = 1;
            this.bnMto.Text = "bindingNavigator1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(37, 22);
            this.lblRegistro.Text = "de {0}";
            this.lblRegistro.ToolTipText = "Número total de elementos";
            // 
            // btnPrimero
            // 
            this.btnPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.RightToLeftAutoMirrorImage = true;
            this.btnPrimero.Size = new System.Drawing.Size(23, 22);
            this.btnPrimero.Text = "Mover primero";
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.RightToLeftAutoMirrorImage = true;
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "Mover anterior";
            // 
            // spd1
            // 
            this.spd1.Name = "spd1";
            this.spd1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPosicion
            // 
            this.txtPosicion.AccessibleName = "Posición";
            this.txtPosicion.AutoSize = false;
            this.txtPosicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(50, 23);
            this.txtPosicion.Text = "0";
            this.txtPosicion.ToolTipText = "Posición actual";
            // 
            // spd2
            // 
            this.spd2.Name = "spd2";
            this.spd2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.RightToLeftAutoMirrorImage = true;
            this.btnSiguiente.Size = new System.Drawing.Size(23, 22);
            this.btnSiguiente.Text = "Mover siguiente";
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.RightToLeftAutoMirrorImage = true;
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "Mover último";
            // 
            // spd3
            // 
            this.spd3.Name = "spd3";
            this.spd3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // taProveedor
            // 
            this.taProveedor.ClearBeforeFill = true;
            // 
            // taTipoCategoria
            // 
            this.taTipoCategoria.ClearBeforeFill = true;
            // 
            // taCategoria
            // 
            this.taCategoria.ClearBeforeFill = true;
            // 
            // taIdentificacion
            // 
            this.taIdentificacion.ClearBeforeFill = true;
            // 
            // taProveedorSucursal
            // 
            this.taProveedorSucursal.ClearBeforeFill = true;
            // 
            // taProveedorSucursalContacto
            // 
            this.taProveedorSucursalContacto.ClearBeforeFill = true;
            // 
            // taPais
            // 
            this.taPais.ClearBeforeFill = true;
            // 
            // taProvincia
            // 
            this.taProvincia.ClearBeforeFill = true;
            // 
            // taContacto
            // 
            this.taContacto.ClearBeforeFill = true;
            // 
            // taTipoContacto
            // 
            this.taTipoContacto.ClearBeforeFill = true;
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
            // pCodigo
            // 
            this.pCodigo.DataPropertyName = "CodigoProveedor";
            this.pCodigo.HeaderText = "CodigoProveedor";
            this.pCodigo.Name = "pCodigo";
            this.pCodigo.ReadOnly = true;
            this.pCodigo.Visible = false;
            // 
            // codigoIdentificacionDataGridViewTextBoxColumn
            // 
            this.codigoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "CodigoIdentificacion";
            this.codigoIdentificacionDataGridViewTextBoxColumn.HeaderText = "CodigoIdentificacion";
            this.codigoIdentificacionDataGridViewTextBoxColumn.Name = "codigoIdentificacionDataGridViewTextBoxColumn";
            this.codigoIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoIdentificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreTipoCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreTipoCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoCategoria";
            this.nombreTipoCategoriaDataGridViewTextBoxColumn.HeaderText = "NombreTipoCategoria";
            this.nombreTipoCategoriaDataGridViewTextBoxColumn.Name = "nombreTipoCategoriaDataGridViewTextBoxColumn";
            this.nombreTipoCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTipoCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pNombre
            // 
            this.pNombre.DataPropertyName = "Nombre";
            this.pNombre.HeaderText = "Nombre";
            this.pNombre.Name = "pNombre";
            this.pNombre.ReadOnly = true;
            this.pNombre.Width = 210;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Visible = false;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaContableDataGridViewTextBoxColumn
            // 
            this.cuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable";
            this.cuentaContableDataGridViewTextBoxColumn.HeaderText = "CuentaContable";
            this.cuentaContableDataGridViewTextBoxColumn.Name = "cuentaContableDataGridViewTextBoxColumn";
            this.cuentaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentaContableDataGridViewTextBoxColumn.Visible = false;
            // 
            // sitioWebDataGridViewTextBoxColumn
            // 
            this.sitioWebDataGridViewTextBoxColumn.DataPropertyName = "SitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.HeaderText = "SitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.Name = "sitioWebDataGridViewTextBoxColumn";
            this.sitioWebDataGridViewTextBoxColumn.ReadOnly = true;
            this.sitioWebDataGridViewTextBoxColumn.Visible = false;
            // 
            // grabadaDataGridViewTextBoxColumn
            // 
            this.grabadaDataGridViewTextBoxColumn.DataPropertyName = "Grabada";
            this.grabadaDataGridViewTextBoxColumn.HeaderText = "Grabada";
            this.grabadaDataGridViewTextBoxColumn.Name = "grabadaDataGridViewTextBoxColumn";
            this.grabadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.grabadaDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FrmMtoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 660);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoProveedor";
            this.Text = "Proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoProveedor_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoProveedor_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.tcProveedor.ResumeLayout(false);
            this.tpGlobal.ResumeLayout(false);
            this.tpGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.tpSucursal.ResumeLayout(false);
            this.pnl9.ResumeLayout(false);
            this.pnl10.ResumeLayout(false);
            this.pnl14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).EndInit();
            this.pnl13.ResumeLayout(false);
            this.pnl13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnContacto)).EndInit();
            this.bnContacto.ResumeLayout(false);
            this.bnContacto.PerformLayout();
            this.pnl7.ResumeLayout(false);
            this.pnl8.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).EndInit();
            this.pnl11.ResumeLayout(false);
            this.pnl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnSucursal)).EndInit();
            this.bnSucursal.ResumeLayout(false);
            this.bnSucursal.PerformLayout();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).EndInit();
            this.bnMto.ResumeLayout(false);
            this.bnMto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
        private System.Windows.Forms.ComboBox cboTipoCategoria;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblGrabada;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cboIdentificacion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ToolStripSeparator spd4;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnMto;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripLabel lblRegistro;
        private System.Windows.Forms.ToolStripButton btnPrimero;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripSeparator spd1;
        private System.Windows.Forms.ToolStripTextBox txtPosicion;
        private System.Windows.Forms.ToolStripSeparator spd2;
        private System.Windows.Forms.ToolStripButton btnSiguiente;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator spd3;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private DsNeoTableAdapters.taProveedor taProveedor;
        private DsNeoTableAdapters.taTipoCategoria taTipoCategoria;
        private DsNeoTableAdapters.taCategoria taCategoria;
        private DsNeoTableAdapters.taIdentificacion taIdentificacion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TabControl tcProveedor;
        private System.Windows.Forms.TabPage tpGlobal;
        private System.Windows.Forms.TabPage tpSucursal;
        private System.Windows.Forms.BindingSource bsSucursal;
        private DsNeoTableAdapters.taProveedorSucursal taProveedorSucursal;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsContacto;
        private DsNeoTableAdapters.taProveedorSucursalContacto taProveedorSucursalContacto;
        private System.Windows.Forms.Panel pnl14;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdContacto;
        private System.Windows.Forms.Panel pnl13;
        private System.Windows.Forms.BindingNavigator bnContacto;
        private System.Windows.Forms.ToolStripButton btnNuevoContacto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnEliminarContacto;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel pnl12;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdSucursal;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.BindingNavigator bnSucursal;
        private System.Windows.Forms.ToolStripButton btnNuevoSucursal;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminarSucursal;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DsNeoTableAdapters.taPais taPais;
        private DsNeoTableAdapters.taProvincia taProvincia;
        private DsNeoTableAdapters.taContacto taContacto;
        private DsNeoTableAdapters.taTipoContacto taTipoContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoPais;
        private System.Windows.Forms.DataGridViewComboBoxColumn sNombrePais;
        private System.Windows.Forms.DataGridViewComboBoxColumn sProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSucursal;
        private System.Windows.Forms.DataGridViewComboBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grabadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}