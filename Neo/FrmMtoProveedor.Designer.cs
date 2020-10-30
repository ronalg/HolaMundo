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
            System.Windows.Forms.Label categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.tcProveedor = new System.Windows.Forms.TabControl();
            this.tpPerfil = new System.Windows.Forms.TabPage();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
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
            this.codigoTrabajoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secuenciaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContactoMiembro = new System.Windows.Forms.BindingSource(this.components);
            this.pnl13 = new System.Windows.Forms.Panel();
            this.bnContacto = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevoContacto = new System.Windows.Forms.ToolStripButton();
            this.bsContacto = new System.Windows.Forms.BindingSource(this.components);
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
            this.sTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSucursalMiembro = new System.Windows.Forms.BindingSource(this.components);
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
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grabadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.taCategoria = new Neo.DsNeoTableAdapters.taCategoria();
            this.taIdentificacion = new Neo.DsNeoTableAdapters.taIdentificacion();
            this.taPais = new Neo.DsNeoTableAdapters.taPais();
            this.taProvincia = new Neo.DsNeoTableAdapters.taProvincia();
            this.taContacto = new Neo.DsNeoTableAdapters.taContacto();
            this.taTipoContacto = new Neo.DsNeoTableAdapters.taTipoContacto();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTipoContacto = new System.Windows.Forms.Panel();
            this.btnTipoContactoAceptar = new System.Windows.Forms.Button();
            this.btnTipoContactoCancelar = new System.Windows.Forms.Button();
            this.pnlTipoContactoSub = new System.Windows.Forms.Panel();
            this.grdTipoContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlProvincia = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnProvinciaCancelar = new System.Windows.Forms.Button();
            this.pnlProvinciaSub = new System.Windows.Forms.Panel();
            this.grdProvincia = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.taSucursalMiembro = new Neo.DsNeoTableAdapters.taSucursalMiembro();
            this.taContactoMiembro = new Neo.DsNeoTableAdapters.taContactoMiembro();
            this.bsTipoContacto = new System.Windows.Forms.BindingSource(this.components);
            this.bsProvincia = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTipoContactoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            categoriaLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.tcProveedor.SuspendLayout();
            this.tpPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.tpSucursal.SuspendLayout();
            this.pnl9.SuspendLayout();
            this.pnl10.SuspendLayout();
            this.pnl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContactoMiembro)).BeginInit();
            this.pnl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnContacto)).BeginInit();
            this.bnContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).BeginInit();
            this.pnl7.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursalMiembro)).BeginInit();
            this.pnl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnSucursal)).BeginInit();
            this.bnSucursal.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnlTipoContacto.SuspendLayout();
            this.pnlTipoContactoSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoContacto)).BeginInit();
            this.pnlProvincia.SuspendLayout();
            this.pnlProvinciaSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvincia)).BeginInit();
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
            activoLabel.Location = new System.Drawing.Point(377, 87);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 11;
            activoLabel.Text = "Activo:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(372, 112);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 12;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(367, 139);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 14;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoProveedorLabel
            // 
            codigoProveedorLabel.AutoSize = true;
            codigoProveedorLabel.Location = new System.Drawing.Point(375, 167);
            codigoProveedorLabel.Name = "codigoProveedorLabel";
            codigoProveedorLabel.Size = new System.Drawing.Size(43, 13);
            codigoProveedorLabel.TabIndex = 16;
            codigoProveedorLabel.Text = "Código:";
            // 
            // grabadaLabel
            // 
            grabadaLabel.AutoSize = true;
            grabadaLabel.Location = new System.Drawing.Point(367, 193);
            grabadaLabel.Name = "grabadaLabel";
            grabadaLabel.Size = new System.Drawing.Size(51, 13);
            grabadaLabel.TabIndex = 18;
            grabadaLabel.Text = "Grabada:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(372, 220);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 20;
            usuarioLabel.Text = "Usuario:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(375, 247);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 22;
            equipoLabel.Text = "Equipo:";
            // 
            // cuentaContableLabel
            // 
            cuentaContableLabel.AutoSize = true;
            cuentaContableLabel.Location = new System.Drawing.Point(378, 36);
            cuentaContableLabel.Name = "cuentaContableLabel";
            cuentaContableLabel.Size = new System.Drawing.Size(44, 13);
            cuentaContableLabel.TabIndex = 25;
            cuentaContableLabel.Text = "Cuenta:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(60, 142);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(58, 13);
            categoriaLabel.TabIndex = 27;
            categoriaLabel.Text = " Categoria:";
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
            this.pnl3.Size = new System.Drawing.Size(1370, 622);
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
            this.pnl6.Size = new System.Drawing.Size(1070, 610);
            this.pnl6.TabIndex = 6;
            // 
            // tcProveedor
            // 
            this.tcProveedor.Controls.Add(this.tpPerfil);
            this.tcProveedor.Controls.Add(this.tpSucursal);
            this.tcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProveedor.Location = new System.Drawing.Point(0, 0);
            this.tcProveedor.Name = "tcProveedor";
            this.tcProveedor.SelectedIndex = 0;
            this.tcProveedor.Size = new System.Drawing.Size(1068, 608);
            this.tcProveedor.TabIndex = 32;
            // 
            // tpPerfil
            // 
            this.tpPerfil.Controls.Add(categoriaLabel);
            this.tpPerfil.Controls.Add(this.cboCategoria);
            this.tpPerfil.Controls.Add(this.label1);
            this.tpPerfil.Controls.Add(this.txtNombre);
            this.tpPerfil.Controls.Add(nombreLabel);
            this.tpPerfil.Controls.Add(this.txtRazonSocial);
            this.tpPerfil.Controls.Add(razonSocialLabel);
            this.tpPerfil.Controls.Add(cuentaContableLabel);
            this.tpPerfil.Controls.Add(this.cboIdentificacion);
            this.tpPerfil.Controls.Add(this.txtCuenta);
            this.tpPerfil.Controls.Add(this.txtIdentificacion);
            this.tpPerfil.Controls.Add(this.label3);
            this.tpPerfil.Controls.Add(equipoLabel);
            this.tpPerfil.Controls.Add(this.txtSitioWeb);
            this.tpPerfil.Controls.Add(this.lblEquipo);
            this.tpPerfil.Controls.Add(sitioWebLabel);
            this.tpPerfil.Controls.Add(usuarioLabel);
            this.tpPerfil.Controls.Add(this.label2);
            this.tpPerfil.Controls.Add(this.lblUsuario);
            this.tpPerfil.Controls.Add(this.chkActivo);
            this.tpPerfil.Controls.Add(grabadaLabel);
            this.tpPerfil.Controls.Add(activoLabel);
            this.tpPerfil.Controls.Add(this.lblGrabada);
            this.tpPerfil.Controls.Add(this.lblTrabajo);
            this.tpPerfil.Controls.Add(codigoProveedorLabel);
            this.tpPerfil.Controls.Add(codigoTrabajoLabel);
            this.tpPerfil.Controls.Add(this.lblCodigo);
            this.tpPerfil.Controls.Add(this.lblEmpresa);
            this.tpPerfil.Controls.Add(codigoEmpresaLabel);
            this.tpPerfil.Location = new System.Drawing.Point(4, 22);
            this.tpPerfil.Name = "tpPerfil";
            this.tpPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerfil.Size = new System.Drawing.Size(1060, 582);
            this.tpPerfil.TabIndex = 0;
            this.tpPerfil.Text = "Perfil";
            this.tpPerfil.UseVisualStyleBackColor = true;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Categoria", true));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "COORPORATIVO",
            "PERSONAL"});
            this.cboCategoria.Location = new System.Drawing.Point(124, 139);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(182, 21);
            this.cboCategoria.TabIndex = 28;
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
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(124, 33);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
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
            this.txtCuenta.Location = new System.Drawing.Point(424, 33);
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
            this.label3.Location = new System.Drawing.Point(340, 11);
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
            this.lblEquipo.Location = new System.Drawing.Point(420, 244);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(121, 20);
            this.lblEquipo.TabIndex = 23;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 63);
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
            this.lblUsuario.Location = new System.Drawing.Point(420, 217);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 20);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkActivo
            // 
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(423, 82);
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
            this.lblGrabada.Location = new System.Drawing.Point(420, 190);
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
            this.lblTrabajo.Location = new System.Drawing.Point(420, 109);
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
            this.lblCodigo.Location = new System.Drawing.Point(420, 164);
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
            this.lblEmpresa.Location = new System.Drawing.Point(420, 136);
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
            this.tpSucursal.Size = new System.Drawing.Size(1060, 582);
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
            this.pnl9.Location = new System.Drawing.Point(3, 191);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(1054, 388);
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
            this.pnl10.Size = new System.Drawing.Size(1052, 369);
            this.pnl10.TabIndex = 8;
            // 
            // pnl14
            // 
            this.pnl14.Controls.Add(this.grdContacto);
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl14.Location = new System.Drawing.Point(0, 28);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(1050, 339);
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
            this.codigoTrabajoDataGridViewTextBoxColumn2,
            this.codigoEmpresaDataGridViewTextBoxColumn2,
            this.codigoDataGridViewTextBoxColumn1,
            this.secuenciaDataGridViewTextBoxColumn1,
            this.tipoDataGridViewTextBoxColumn1,
            this.ordenDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.nombreTipoContactoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn});
            this.grdContacto.DataSource = this.bsContactoMiembro;
            this.grdContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacto.Location = new System.Drawing.Point(0, 0);
            this.grdContacto.MultiSelect = false;
            this.grdContacto.Name = "grdContacto";
            this.grdContacto.Size = new System.Drawing.Size(1050, 339);
            this.grdContacto.TabIndex = 9;
            this.grdContacto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContacto_CellDoubleClick);
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
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn1.Width = 60;
            // 
            // secuenciaDataGridViewTextBoxColumn1
            // 
            this.secuenciaDataGridViewTextBoxColumn1.DataPropertyName = "Secuencia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.secuenciaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.secuenciaDataGridViewTextBoxColumn1.HeaderText = "Sec.";
            this.secuenciaDataGridViewTextBoxColumn1.Name = "secuenciaDataGridViewTextBoxColumn1";
            this.secuenciaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            this.tipoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "Orden";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ordenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordenDataGridViewTextBoxColumn.HeaderText = "Orden";
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            this.ordenDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordenDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            // 
            // nombreTipoContactoDataGridViewTextBoxColumn
            // 
            this.nombreTipoContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreTipoContacto";
            this.nombreTipoContactoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.nombreTipoContactoDataGridViewTextBoxColumn.Name = "nombreTipoContactoDataGridViewTextBoxColumn";
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            // 
            // bsContactoMiembro
            // 
            this.bsContactoMiembro.DataMember = "tbContactoMiembro";
            this.bsContactoMiembro.DataSource = this.dsNeo;
            // 
            // pnl13
            // 
            this.pnl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl13.Controls.Add(this.bnContacto);
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl13.Location = new System.Drawing.Point(0, 0);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(1050, 28);
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
            this.bnContacto.Size = new System.Drawing.Size(1048, 25);
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
            // bsContacto
            // 
            this.bsContacto.DataMember = "tbProveedorSucursalContacto";
            this.bsContacto.DataSource = this.dsNeo;
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
            this.label5.Size = new System.Drawing.Size(1052, 17);
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
            this.pnl7.Size = new System.Drawing.Size(1054, 188);
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
            this.pnl8.Size = new System.Drawing.Size(1052, 169);
            this.pnl8.TabIndex = 7;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.grdSucursal);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(0, 28);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(1050, 139);
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
            this.sTrabajo,
            this.sEmpresa,
            this.sCodigo,
            this.sSecuencia,
            this.sTipo,
            this.sPais,
            this.sProvincia,
            this.sNombre,
            this.sCodigoPostal,
            this.sDireccion,
            this.sRepresentante});
            this.grdSucursal.DataSource = this.bsSucursalMiembro;
            this.grdSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSucursal.Location = new System.Drawing.Point(0, 0);
            this.grdSucursal.MultiSelect = false;
            this.grdSucursal.Name = "grdSucursal";
            this.grdSucursal.Size = new System.Drawing.Size(1050, 139);
            this.grdSucursal.TabIndex = 8;
            this.grdSucursal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSucursal_CellDoubleClick);
            this.grdSucursal.SelectionChanged += new System.EventHandler(this.grdSucursal_SelectionChanged);
            this.grdSucursal.DoubleClick += new System.EventHandler(this.grdSucursal_DoubleClick);
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
            // sCodigo
            // 
            this.sCodigo.DataPropertyName = "Codigo";
            this.sCodigo.HeaderText = "Codigo";
            this.sCodigo.Name = "sCodigo";
            this.sCodigo.ReadOnly = true;
            this.sCodigo.Width = 60;
            // 
            // sSecuencia
            // 
            this.sSecuencia.DataPropertyName = "Secuencia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sSecuencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.sSecuencia.HeaderText = "Sec.";
            this.sSecuencia.Name = "sSecuencia";
            this.sSecuencia.ReadOnly = true;
            this.sSecuencia.Width = 50;
            // 
            // sTipo
            // 
            this.sTipo.DataPropertyName = "Tipo";
            this.sTipo.HeaderText = "Tipo";
            this.sTipo.Name = "sTipo";
            this.sTipo.ReadOnly = true;
            // 
            // sPais
            // 
            this.sPais.DataPropertyName = "CodigoPais";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sPais.DefaultCellStyle = dataGridViewCellStyle6;
            this.sPais.HeaderText = "País";
            this.sPais.Name = "sPais";
            this.sPais.Width = 45;
            // 
            // sProvincia
            // 
            this.sProvincia.DataPropertyName = "NombreProvincia";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sProvincia.DefaultCellStyle = dataGridViewCellStyle7;
            this.sProvincia.HeaderText = "Provincia";
            this.sProvincia.Name = "sProvincia";
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "Nombre";
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.Width = 200;
            // 
            // sCodigoPostal
            // 
            this.sCodigoPostal.DataPropertyName = "CodigoPostal";
            this.sCodigoPostal.HeaderText = "Código Postal";
            this.sCodigoPostal.Name = "sCodigoPostal";
            this.sCodigoPostal.Width = 110;
            // 
            // sDireccion
            // 
            this.sDireccion.DataPropertyName = "Direccion";
            this.sDireccion.HeaderText = "Dirección";
            this.sDireccion.Name = "sDireccion";
            this.sDireccion.Width = 200;
            // 
            // sRepresentante
            // 
            this.sRepresentante.DataPropertyName = "Representante";
            this.sRepresentante.HeaderText = "Representante";
            this.sRepresentante.Name = "sRepresentante";
            this.sRepresentante.Width = 200;
            // 
            // bsSucursalMiembro
            // 
            this.bsSucursalMiembro.DataMember = "tbSucursalMiembro";
            this.bsSucursalMiembro.DataSource = this.dsNeo;
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Controls.Add(this.bnSucursal);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 0);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(1050, 28);
            this.pnl11.TabIndex = 7;
            // 
            // bnSucursal
            // 
            this.bnSucursal.AddNewItem = this.btnNuevoSucursal;
            this.bnSucursal.BindingSource = this.bsSucursalMiembro;
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
            this.bnSucursal.Size = new System.Drawing.Size(1048, 25);
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
            this.label4.Size = new System.Drawing.Size(1052, 17);
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.pCodigo,
            this.codigoIdentificacionDataGridViewTextBoxColumn,
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
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1370, 10);
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
            this.pnl1.Size = new System.Drawing.Size(1370, 28);
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
            this.bnMto.Size = new System.Drawing.Size(1368, 25);
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
            // taCategoria
            // 
            this.taCategoria.ClearBeforeFill = true;
            // 
            // taIdentificacion
            // 
            this.taIdentificacion.ClearBeforeFill = true;
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pnlTipoContacto
            // 
            this.pnlTipoContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoContacto.Controls.Add(this.btnTipoContactoAceptar);
            this.pnlTipoContacto.Controls.Add(this.btnTipoContactoCancelar);
            this.pnlTipoContacto.Controls.Add(this.pnlTipoContactoSub);
            this.pnlTipoContacto.Controls.Add(this.label8);
            this.pnlTipoContacto.Location = new System.Drawing.Point(346, 189);
            this.pnlTipoContacto.Name = "pnlTipoContacto";
            this.pnlTipoContacto.Size = new System.Drawing.Size(364, 282);
            this.pnlTipoContacto.TabIndex = 15;
            this.pnlTipoContacto.Visible = false;
            // 
            // btnTipoContactoAceptar
            // 
            this.btnTipoContactoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoContactoAceptar.Location = new System.Drawing.Point(294, 251);
            this.btnTipoContactoAceptar.Name = "btnTipoContactoAceptar";
            this.btnTipoContactoAceptar.Size = new System.Drawing.Size(59, 23);
            this.btnTipoContactoAceptar.TabIndex = 3;
            this.btnTipoContactoAceptar.Text = "Aceptar";
            this.btnTipoContactoAceptar.UseVisualStyleBackColor = true;
            // 
            // btnTipoContactoCancelar
            // 
            this.btnTipoContactoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoContactoCancelar.Location = new System.Drawing.Point(7, 251);
            this.btnTipoContactoCancelar.Name = "btnTipoContactoCancelar";
            this.btnTipoContactoCancelar.Size = new System.Drawing.Size(59, 23);
            this.btnTipoContactoCancelar.TabIndex = 2;
            this.btnTipoContactoCancelar.Text = "Cancelar";
            this.btnTipoContactoCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlTipoContactoSub
            // 
            this.pnlTipoContactoSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoContactoSub.Controls.Add(this.grdTipoContacto);
            this.pnlTipoContactoSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTipoContactoSub.Location = new System.Drawing.Point(0, 17);
            this.pnlTipoContactoSub.Name = "pnlTipoContactoSub";
            this.pnlTipoContactoSub.Size = new System.Drawing.Size(362, 229);
            this.pnlTipoContactoSub.TabIndex = 1;
            // 
            // grdTipoContacto
            // 
            this.grdTipoContacto.AllowUserToAddRows = false;
            this.grdTipoContacto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.grdTipoContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdTipoContacto.AutoGenerateColumns = false;
            this.grdTipoContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn1,
            this.codigoEmpresaDataGridViewTextBoxColumn1,
            this.nombreContactoDataGridViewTextBoxColumn1,
            this.nombreTipoContactoDataGridViewTextBoxColumn1});
            this.grdTipoContacto.DataSource = this.bsTipoContacto;
            this.grdTipoContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTipoContacto.Location = new System.Drawing.Point(0, 0);
            this.grdTipoContacto.Name = "grdTipoContacto";
            this.grdTipoContacto.ReadOnly = true;
            this.grdTipoContacto.Size = new System.Drawing.Size(360, 227);
            this.grdTipoContacto.TabIndex = 4;
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
            this.label8.Text = "Tipos de Contactos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlProvincia
            // 
            this.pnlProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProvincia.Controls.Add(this.btnAceptar);
            this.pnlProvincia.Controls.Add(this.btnProvinciaCancelar);
            this.pnlProvincia.Controls.Add(this.pnlProvinciaSub);
            this.pnlProvincia.Controls.Add(this.label7);
            this.pnlProvincia.Location = new System.Drawing.Point(612, 189);
            this.pnlProvincia.Name = "pnlProvincia";
            this.pnlProvincia.Size = new System.Drawing.Size(317, 282);
            this.pnlProvincia.TabIndex = 14;
            this.pnlProvincia.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(249, 251);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(59, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnProvinciaCancelar
            // 
            this.btnProvinciaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvinciaCancelar.Location = new System.Drawing.Point(7, 251);
            this.btnProvinciaCancelar.Name = "btnProvinciaCancelar";
            this.btnProvinciaCancelar.Size = new System.Drawing.Size(59, 23);
            this.btnProvinciaCancelar.TabIndex = 2;
            this.btnProvinciaCancelar.Text = "Cancelar";
            this.btnProvinciaCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlProvinciaSub
            // 
            this.pnlProvinciaSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProvinciaSub.Controls.Add(this.grdProvincia);
            this.pnlProvinciaSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProvinciaSub.Location = new System.Drawing.Point(0, 17);
            this.pnlProvinciaSub.Name = "pnlProvinciaSub";
            this.pnlProvinciaSub.Size = new System.Drawing.Size(315, 229);
            this.pnlProvinciaSub.TabIndex = 1;
            // 
            // grdProvincia
            // 
            this.grdProvincia.AllowUserToAddRows = false;
            this.grdProvincia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            this.grdProvincia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdProvincia.AutoGenerateColumns = false;
            this.grdProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn3,
            this.codigoEmpresaDataGridViewTextBoxColumn3,
            this.codigoPaisDataGridViewTextBoxColumn,
            this.nombreProvinciaDataGridViewTextBoxColumn});
            this.grdProvincia.DataSource = this.bsProvincia;
            this.grdProvincia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProvincia.Location = new System.Drawing.Point(0, 0);
            this.grdProvincia.Name = "grdProvincia";
            this.grdProvincia.ReadOnly = true;
            this.grdProvincia.Size = new System.Drawing.Size(313, 227);
            this.grdProvincia.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Provincias";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taSucursalMiembro
            // 
            this.taSucursalMiembro.ClearBeforeFill = true;
            // 
            // taContactoMiembro
            // 
            this.taContactoMiembro.ClearBeforeFill = true;
            // 
            // bsTipoContacto
            // 
            this.bsTipoContacto.DataMember = "tbTipoContacto";
            this.bsTipoContacto.DataSource = this.dsNeo;
            // 
            // bsProvincia
            // 
            this.bsProvincia.DataMember = "tbProvincia";
            this.bsProvincia.DataSource = this.dsNeo;
            // 
            // codigoTrabajoDataGridViewTextBoxColumn1
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn1.DataPropertyName = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn1.HeaderText = "CodigoTrabajo";
            this.codigoTrabajoDataGridViewTextBoxColumn1.Name = "codigoTrabajoDataGridViewTextBoxColumn1";
            this.codigoTrabajoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoTrabajoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codigoEmpresaDataGridViewTextBoxColumn1
            // 
            this.codigoEmpresaDataGridViewTextBoxColumn1.DataPropertyName = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn1.HeaderText = "CodigoEmpresa";
            this.codigoEmpresaDataGridViewTextBoxColumn1.Name = "codigoEmpresaDataGridViewTextBoxColumn1";
            this.codigoEmpresaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoEmpresaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nombreContactoDataGridViewTextBoxColumn1
            // 
            this.nombreContactoDataGridViewTextBoxColumn1.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn1.HeaderText = "Contacto";
            this.nombreContactoDataGridViewTextBoxColumn1.Name = "nombreContactoDataGridViewTextBoxColumn1";
            this.nombreContactoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreContactoDataGridViewTextBoxColumn1.Width = 200;
            // 
            // nombreTipoContactoDataGridViewTextBoxColumn1
            // 
            this.nombreTipoContactoDataGridViewTextBoxColumn1.DataPropertyName = "NombreTipoContacto";
            this.nombreTipoContactoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.nombreTipoContactoDataGridViewTextBoxColumn1.Name = "nombreTipoContactoDataGridViewTextBoxColumn1";
            this.nombreTipoContactoDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // codigoPaisDataGridViewTextBoxColumn
            // 
            this.codigoPaisDataGridViewTextBoxColumn.DataPropertyName = "CodigoPais";
            this.codigoPaisDataGridViewTextBoxColumn.HeaderText = "Codigo Pais";
            this.codigoPaisDataGridViewTextBoxColumn.Name = "codigoPaisDataGridViewTextBoxColumn";
            this.codigoPaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProvinciaDataGridViewTextBoxColumn
            // 
            this.nombreProvinciaDataGridViewTextBoxColumn.DataPropertyName = "NombreProvincia";
            this.nombreProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.nombreProvinciaDataGridViewTextBoxColumn.Name = "nombreProvinciaDataGridViewTextBoxColumn";
            this.nombreProvinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmMtoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 660);
            this.Controls.Add(this.pnlTipoContacto);
            this.Controls.Add(this.pnlProvincia);
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
            this.tpPerfil.ResumeLayout(false);
            this.tpPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.tpSucursal.ResumeLayout(false);
            this.pnl9.ResumeLayout(false);
            this.pnl10.ResumeLayout(false);
            this.pnl14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContactoMiembro)).EndInit();
            this.pnl13.ResumeLayout(false);
            this.pnl13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnContacto)).EndInit();
            this.bnContacto.ResumeLayout(false);
            this.bnContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacto)).EndInit();
            this.pnl7.ResumeLayout(false);
            this.pnl8.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursalMiembro)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnlTipoContacto.ResumeLayout(false);
            this.pnlTipoContactoSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoContacto)).EndInit();
            this.pnlProvincia.ResumeLayout(false);
            this.pnlProvinciaSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
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
        private DsNeoTableAdapters.taCategoria taCategoria;
        private DsNeoTableAdapters.taIdentificacion taIdentificacion;
        private System.Windows.Forms.TabControl tcProveedor;
        private System.Windows.Forms.TabPage tpPerfil;
        private System.Windows.Forms.TabPage tpSucursal;
        private System.Windows.Forms.BindingSource bsSucursalMiembro;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsContacto;
        private System.Windows.Forms.Panel pnl14;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grabadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ErrorProvider ep;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdSucursal;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdContacto;
        private System.Windows.Forms.Panel pnlTipoContacto;
        private System.Windows.Forms.Button btnTipoContactoAceptar;
        private System.Windows.Forms.Button btnTipoContactoCancelar;
        private System.Windows.Forms.Panel pnlTipoContactoSub;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTipoContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlProvincia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnProvinciaCancelar;
        private System.Windows.Forms.Panel pnlProvinciaSub;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bsContactoMiembro;
        private DsNeoTableAdapters.taSucursalMiembro taSucursalMiembro;
        private DsNeoTableAdapters.taContactoMiembro taContactoMiembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn secuenciaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRepresentante;
        private System.Windows.Forms.BindingSource bsTipoContacto;
        private System.Windows.Forms.BindingSource bsProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoContactoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProvinciaDataGridViewTextBoxColumn;
    }
}