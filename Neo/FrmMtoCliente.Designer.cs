namespace Neo
{
    partial class FrmMtoCliente
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label nacimientoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label nombreEstadoCivilLabel;
            System.Windows.Forms.Label tipoEstadoLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label idUserWebLabel;
            System.Windows.Forms.Label aperturaLabel;
            System.Windows.Forms.Label cuentaContableLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label equipoLabel;
            System.Windows.Forms.Label formatoFacturaLabel;
            System.Windows.Forms.Label formatoReciboIngresoLabel;
            System.Windows.Forms.Label formatoOrdenPedidoLabel;
            System.Windows.Forms.Label limiteCreditoLabel;
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.tcMto = new System.Windows.Forms.TabControl();
            this.tpPerfil = new System.Windows.Forms.TabPage();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.cboPedido = new System.Windows.Forms.ComboBox();
            this.cboRecibo = new System.Windows.Forms.ComboBox();
            this.cboFactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCuentaContable = new System.Windows.Forms.TextBox();
            this.lblApertura = new System.Windows.Forms.Label();
            this.txtUserWeb = new System.Windows.Forms.TextBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.bsSucursal = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoEstado = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSucursal = new System.Windows.Forms.TabPage();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.grdContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cSecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContacto = new System.Windows.Forms.BindingSource(this.components);
            this.pnl13 = new System.Windows.Forms.Panel();
            this.bnContacto = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevoContacto = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarContacto = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.grdSucursal = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sSecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombrePais = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sNombreProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClienteSucursal = new System.Windows.Forms.BindingSource(this.components);
            this.pnl11 = new System.Windows.Forms.Panel();
            this.bnClienteSucursal = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevoSucursal = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarSucursal = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tpIdentificacion = new System.Windows.Forms.TabPage();
            this.grdIdentificacion = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoIdentificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreNacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIdentificacionMiembro = new System.Windows.Forms.BindingSource(this.components);
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteCreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoReciboIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoOrdenPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.taEstado = new Neo.DsNeoTableAdapters.taEstado();
            this.taIdentificacionMiembro = new Neo.DsNeoTableAdapters.taIdentificacionMiembro();
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.taPais = new Neo.DsNeoTableAdapters.taPais();
            this.taProvincia = new Neo.DsNeoTableAdapters.taProvincia();
            this.taSucursalMiembro = new Neo.DsNeoTableAdapters.taSucursalMiembro();
            this.taContacto = new Neo.DsNeoTableAdapters.taContacto();
            this.taContactoMiembro = new Neo.DsNeoTableAdapters.taContactoMiembro();
            this.taTipoContacto = new Neo.DsNeoTableAdapters.taTipoContacto();
            this.pnlProvincia = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnProvinciaCancelar = new System.Windows.Forms.Button();
            this.pnlProvinciaSub = new System.Windows.Forms.Panel();
            this.grdProvincia = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProvincia = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTipoContacto = new System.Windows.Forms.Panel();
            this.btnTipoContactoAceptar = new System.Windows.Forms.Button();
            this.btnTipoContactoCancelar = new System.Windows.Forms.Button();
            this.pnlTipoContactoSub = new System.Windows.Forms.Panel();
            this.grdTipoContacto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTrabajoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTipoContacto = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            nacimientoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            nombreEstadoCivilLabel = new System.Windows.Forms.Label();
            tipoEstadoLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            idUserWebLabel = new System.Windows.Forms.Label();
            aperturaLabel = new System.Windows.Forms.Label();
            cuentaContableLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            formatoFacturaLabel = new System.Windows.Forms.Label();
            formatoReciboIngresoLabel = new System.Windows.Forms.Label();
            formatoOrdenPedidoLabel = new System.Windows.Forms.Label();
            limiteCreditoLabel = new System.Windows.Forms.Label();
            codigoClienteLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.tcMto.SuspendLayout();
            this.tpPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            this.tpSucursal.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteSucursal)).BeginInit();
            this.pnl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnClienteSucursal)).BeginInit();
            this.bnClienteSucursal.SuspendLayout();
            this.tpIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIdentificacionMiembro)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnlProvincia.SuspendLayout();
            this.pnlProvinciaSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvincia)).BeginInit();
            this.pnlTipoContacto.SuspendLayout();
            this.pnlTipoContactoSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(62, 33);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(21, 13);
            idClienteLabel.TabIndex = 1;
            idClienteLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(36, 59);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(10, 85);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 5;
            razonSocialLabel.Text = "Razón Social:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(26, 111);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(57, 13);
            categoriaLabel.TabIndex = 7;
            categoriaLabel.Text = "Categoría:";
            // 
            // nacimientoLabel
            // 
            nacimientoLabel.AutoSize = true;
            nacimientoLabel.Location = new System.Drawing.Point(20, 138);
            nacimientoLabel.Name = "nacimientoLabel";
            nacimientoLabel.Size = new System.Drawing.Size(63, 13);
            nacimientoLabel.TabIndex = 9;
            nacimientoLabel.Text = "Nacimiento:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(49, 164);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // nombreEstadoCivilLabel
            // 
            nombreEstadoCivilLabel.AutoSize = true;
            nombreEstadoCivilLabel.Location = new System.Drawing.Point(16, 191);
            nombreEstadoCivilLabel.Name = "nombreEstadoCivilLabel";
            nombreEstadoCivilLabel.Size = new System.Drawing.Size(67, 13);
            nombreEstadoCivilLabel.TabIndex = 13;
            nombreEstadoCivilLabel.Text = "Estado Cívil:";
            // 
            // tipoEstadoLabel
            // 
            tipoEstadoLabel.AutoSize = true;
            tipoEstadoLabel.Location = new System.Drawing.Point(52, 219);
            tipoEstadoLabel.Name = "tipoEstadoLabel";
            tipoEstadoLabel.Size = new System.Drawing.Size(31, 13);
            tipoEstadoLabel.TabIndex = 15;
            tipoEstadoLabel.Text = "Tipo:";
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(318, 28);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 18;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // idUserWebLabel
            // 
            idUserWebLabel.AutoSize = true;
            idUserWebLabel.Location = new System.Drawing.Point(311, 55);
            idUserWebLabel.Name = "idUserWebLabel";
            idUserWebLabel.Size = new System.Drawing.Size(58, 13);
            idUserWebLabel.TabIndex = 20;
            idUserWebLabel.Text = "User Web:";
            // 
            // aperturaLabel
            // 
            aperturaLabel.AutoSize = true;
            aperturaLabel.Location = new System.Drawing.Point(319, 156);
            aperturaLabel.Name = "aperturaLabel";
            aperturaLabel.Size = new System.Drawing.Size(50, 13);
            aperturaLabel.TabIndex = 22;
            aperturaLabel.Text = "Apertura:";
            // 
            // cuentaContableLabel
            // 
            cuentaContableLabel.AutoSize = true;
            cuentaContableLabel.Location = new System.Drawing.Point(280, 80);
            cuentaContableLabel.Name = "cuentaContableLabel";
            cuentaContableLabel.Size = new System.Drawing.Size(89, 13);
            cuentaContableLabel.TabIndex = 24;
            cuentaContableLabel.Text = "Cuenta Contable:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(323, 183);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 26;
            usuarioLabel.Text = "Usuario:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(326, 207);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 28;
            equipoLabel.Text = "Equipo:";
            // 
            // formatoFacturaLabel
            // 
            formatoFacturaLabel.AutoSize = true;
            formatoFacturaLabel.Location = new System.Drawing.Point(552, 35);
            formatoFacturaLabel.Name = "formatoFacturaLabel";
            formatoFacturaLabel.Size = new System.Drawing.Size(46, 13);
            formatoFacturaLabel.TabIndex = 31;
            formatoFacturaLabel.Text = "Factura:";
            // 
            // formatoReciboIngresoLabel
            // 
            formatoReciboIngresoLabel.AutoSize = true;
            formatoReciboIngresoLabel.Location = new System.Drawing.Point(516, 61);
            formatoReciboIngresoLabel.Name = "formatoReciboIngresoLabel";
            formatoReciboIngresoLabel.Size = new System.Drawing.Size(82, 13);
            formatoReciboIngresoLabel.TabIndex = 33;
            formatoReciboIngresoLabel.Text = "Recibo Ingreso:";
            // 
            // formatoOrdenPedidoLabel
            // 
            formatoOrdenPedidoLabel.AutoSize = true;
            formatoOrdenPedidoLabel.Location = new System.Drawing.Point(523, 88);
            formatoOrdenPedidoLabel.Name = "formatoOrdenPedidoLabel";
            formatoOrdenPedidoLabel.Size = new System.Drawing.Size(75, 13);
            formatoOrdenPedidoLabel.TabIndex = 35;
            formatoOrdenPedidoLabel.Text = "Orden Pedido:";
            // 
            // limiteCreditoLabel
            // 
            limiteCreditoLabel.AutoSize = true;
            limiteCreditoLabel.Location = new System.Drawing.Point(294, 106);
            limiteCreditoLabel.Name = "limiteCreditoLabel";
            limiteCreditoLabel.Size = new System.Drawing.Size(75, 13);
            limiteCreditoLabel.TabIndex = 37;
            limiteCreditoLabel.Text = "Límite Crédito:";
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(327, 233);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(43, 13);
            codigoClienteLabel.TabIndex = 39;
            codigoClienteLabel.Text = "Código:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(319, 259);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 41;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(324, 285);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 43;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(325, 132);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 45;
            activoLabel.Text = "Activo:";
            // 
            // spd4
            // 
            this.spd4.Name = "spd4";
            this.spd4.Size = new System.Drawing.Size(6, 25);
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
            this.pnl3.Size = new System.Drawing.Size(1232, 429);
            this.pnl3.TabIndex = 11;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.tcMto);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(293, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(932, 417);
            this.pnl6.TabIndex = 6;
            // 
            // tcMto
            // 
            this.tcMto.Controls.Add(this.tpPerfil);
            this.tcMto.Controls.Add(this.tpSucursal);
            this.tcMto.Controls.Add(this.tpIdentificacion);
            this.tcMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMto.Location = new System.Drawing.Point(0, 0);
            this.tcMto.Name = "tcMto";
            this.tcMto.SelectedIndex = 0;
            this.tcMto.Size = new System.Drawing.Size(930, 415);
            this.tcMto.TabIndex = 0;
            // 
            // tpPerfil
            // 
            this.tpPerfil.AutoScroll = true;
            this.tpPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPerfil.Controls.Add(this.txtCategoria);
            this.tpPerfil.Controls.Add(this.txtNota);
            this.tpPerfil.Controls.Add(this.label4);
            this.tpPerfil.Controls.Add(activoLabel);
            this.tpPerfil.Controls.Add(this.chkActivo);
            this.tpPerfil.Controls.Add(codigoTrabajoLabel);
            this.tpPerfil.Controls.Add(this.lblTrabajo);
            this.tpPerfil.Controls.Add(codigoEmpresaLabel);
            this.tpPerfil.Controls.Add(this.lblEmpresa);
            this.tpPerfil.Controls.Add(codigoClienteLabel);
            this.tpPerfil.Controls.Add(this.lblCodigo);
            this.tpPerfil.Controls.Add(limiteCreditoLabel);
            this.tpPerfil.Controls.Add(this.txtLimiteCredito);
            this.tpPerfil.Controls.Add(formatoOrdenPedidoLabel);
            this.tpPerfil.Controls.Add(this.cboPedido);
            this.tpPerfil.Controls.Add(formatoReciboIngresoLabel);
            this.tpPerfil.Controls.Add(this.cboRecibo);
            this.tpPerfil.Controls.Add(formatoFacturaLabel);
            this.tpPerfil.Controls.Add(this.cboFactura);
            this.tpPerfil.Controls.Add(this.label3);
            this.tpPerfil.Controls.Add(equipoLabel);
            this.tpPerfil.Controls.Add(this.lblEquipo);
            this.tpPerfil.Controls.Add(usuarioLabel);
            this.tpPerfil.Controls.Add(this.lblUsuario);
            this.tpPerfil.Controls.Add(cuentaContableLabel);
            this.tpPerfil.Controls.Add(this.txtCuentaContable);
            this.tpPerfil.Controls.Add(aperturaLabel);
            this.tpPerfil.Controls.Add(this.lblApertura);
            this.tpPerfil.Controls.Add(idUserWebLabel);
            this.tpPerfil.Controls.Add(this.txtUserWeb);
            this.tpPerfil.Controls.Add(codigoSucursalLabel);
            this.tpPerfil.Controls.Add(this.cboSucursal);
            this.tpPerfil.Controls.Add(this.label2);
            this.tpPerfil.Controls.Add(tipoEstadoLabel);
            this.tpPerfil.Controls.Add(this.lblTipoEstado);
            this.tpPerfil.Controls.Add(nombreEstadoCivilLabel);
            this.tpPerfil.Controls.Add(this.cboEstadoCivil);
            this.tpPerfil.Controls.Add(sexoLabel);
            this.tpPerfil.Controls.Add(this.cboSexo);
            this.tpPerfil.Controls.Add(nacimientoLabel);
            this.tpPerfil.Controls.Add(this.dtpNacimiento);
            this.tpPerfil.Controls.Add(categoriaLabel);
            this.tpPerfil.Controls.Add(razonSocialLabel);
            this.tpPerfil.Controls.Add(this.txtRazonSocial);
            this.tpPerfil.Controls.Add(nombreLabel);
            this.tpPerfil.Controls.Add(this.txtNombre);
            this.tpPerfil.Controls.Add(idClienteLabel);
            this.tpPerfil.Controls.Add(this.txtId);
            this.tpPerfil.Controls.Add(this.label1);
            this.tpPerfil.Location = new System.Drawing.Point(4, 22);
            this.tpPerfil.Name = "tpPerfil";
            this.tpPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerfil.Size = new System.Drawing.Size(922, 389);
            this.tpPerfil.TabIndex = 0;
            this.tpPerfil.Text = "Perfil";
            this.tpPerfil.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Categoria", true));
            this.txtCategoria.Location = new System.Drawing.Point(85, 108);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(181, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbCliente";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNota
            // 
            this.txtNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nota", true));
            this.txtNota.Location = new System.Drawing.Point(513, 156);
            this.txtNota.MaxLength = 500;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(198, 146);
            this.txtNota.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nota";
            // 
            // chkActivo
            // 
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(371, 127);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(21, 24);
            this.chkActivo.TabIndex = 46;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(372, 282);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(120, 20);
            this.lblTrabajo.TabIndex = 44;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(372, 256);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(120, 20);
            this.lblEmpresa.TabIndex = 42;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoCliente", true));
            this.lblCodigo.Location = new System.Drawing.Point(372, 230);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(120, 20);
            this.lblCodigo.TabIndex = 40;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "LimiteCredito", true));
            this.txtLimiteCredito.Location = new System.Drawing.Point(371, 103);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(121, 20);
            this.txtLimiteCredito.TabIndex = 38;
            // 
            // cboPedido
            // 
            this.cboPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "FormatoOrdenPedido", true));
            this.cboPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPedido.FormattingEnabled = true;
            this.cboPedido.Items.AddRange(new object[] {
            "Personal",
            "Empresa"});
            this.cboPedido.Location = new System.Drawing.Point(600, 85);
            this.cboPedido.Name = "cboPedido";
            this.cboPedido.Size = new System.Drawing.Size(111, 21);
            this.cboPedido.TabIndex = 36;
            // 
            // cboRecibo
            // 
            this.cboRecibo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "FormatoReciboIngreso", true));
            this.cboRecibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecibo.FormattingEnabled = true;
            this.cboRecibo.Items.AddRange(new object[] {
            "Personal",
            "Empresa"});
            this.cboRecibo.Location = new System.Drawing.Point(600, 58);
            this.cboRecibo.Name = "cboRecibo";
            this.cboRecibo.Size = new System.Drawing.Size(111, 21);
            this.cboRecibo.TabIndex = 34;
            // 
            // cboFactura
            // 
            this.cboFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "FormatoFactura", true));
            this.cboFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactura.FormattingEnabled = true;
            this.cboFactura.Items.AddRange(new object[] {
            "Personal",
            "Empresa"});
            this.cboFactura.Location = new System.Drawing.Point(600, 32);
            this.cboFactura.Name = "cboFactura";
            this.cboFactura.Size = new System.Drawing.Size(111, 21);
            this.cboFactura.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Impresion";
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(371, 204);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(121, 20);
            this.lblEquipo.TabIndex = 29;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(371, 179);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 20);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuentaContable
            // 
            this.txtCuentaContable.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CuentaContable", true));
            this.txtCuentaContable.Location = new System.Drawing.Point(371, 77);
            this.txtCuentaContable.Name = "txtCuentaContable";
            this.txtCuentaContable.Size = new System.Drawing.Size(121, 20);
            this.txtCuentaContable.TabIndex = 25;
            // 
            // lblApertura
            // 
            this.lblApertura.BackColor = System.Drawing.Color.Gainsboro;
            this.lblApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApertura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Apertura", true));
            this.lblApertura.Location = new System.Drawing.Point(371, 153);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(121, 20);
            this.lblApertura.TabIndex = 23;
            this.lblApertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserWeb
            // 
            this.txtUserWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "IdUserWeb", true));
            this.txtUserWeb.Location = new System.Drawing.Point(371, 52);
            this.txtUserWeb.Name = "txtUserWeb";
            this.txtUserWeb.Size = new System.Drawing.Size(121, 20);
            this.txtUserWeb.TabIndex = 21;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoSucursal", true));
            this.cboSucursal.DataSource = this.bsSucursal;
            this.cboSucursal.DisplayMember = "Nombre";
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(371, 25);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 21);
            this.cboSucursal.TabIndex = 19;
            this.cboSucursal.ValueMember = "CodigoSucursal";
            // 
            // bsSucursal
            // 
            this.bsSucursal.DataMember = "tbSucursal";
            this.bsSucursal.DataSource = this.dsNeo;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sistema";
            // 
            // lblTipoEstado
            // 
            this.lblTipoEstado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTipoEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "TipoEstado", true));
            this.lblTipoEstado.Location = new System.Drawing.Point(85, 216);
            this.lblTipoEstado.Name = "lblTipoEstado";
            this.lblTipoEstado.Size = new System.Drawing.Size(181, 20);
            this.lblTipoEstado.TabIndex = 16;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreEstadoCivil", true));
            this.cboEstadoCivil.DataSource = this.bsEstado;
            this.cboEstadoCivil.DisplayMember = "NombreEstado";
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(85, 188);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(181, 21);
            this.cboEstadoCivil.TabIndex = 14;
            this.cboEstadoCivil.ValueMember = "NombreEstado";
            // 
            // bsEstado
            // 
            this.bsEstado.DataMember = "tbEstado";
            this.bsEstado.DataSource = this.dsNeo;
            // 
            // cboSexo
            // 
            this.cboSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Sexo", true));
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No Definido"});
            this.cboSexo.Location = new System.Drawing.Point(85, 161);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(181, 21);
            this.cboSexo.TabIndex = 12;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMto, "Nacimiento", true));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(85, 135);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(181, 20);
            this.dtpNacimiento.TabIndex = 10;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "RazonSocial", true));
            this.txtRazonSocial.Location = new System.Drawing.Point(85, 82);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(181, 20);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(85, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "IdCliente", true));
            this.txtId.Location = new System.Drawing.Point(85, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // tpSucursal
            // 
            this.tpSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpSucursal.Controls.Add(this.pnl10);
            this.tpSucursal.Controls.Add(this.label6);
            this.tpSucursal.Controls.Add(this.pnl7);
            this.tpSucursal.Location = new System.Drawing.Point(4, 22);
            this.tpSucursal.Name = "tpSucursal";
            this.tpSucursal.Padding = new System.Windows.Forms.Padding(3);
            this.tpSucursal.Size = new System.Drawing.Size(922, 389);
            this.tpSucursal.TabIndex = 1;
            this.tpSucursal.Text = "Sucursales";
            this.tpSucursal.UseVisualStyleBackColor = true;
            // 
            // pnl10
            // 
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Controls.Add(this.pnl14);
            this.pnl10.Controls.Add(this.pnl13);
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl10.Location = new System.Drawing.Point(3, 204);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(914, 180);
            this.pnl10.TabIndex = 9;
            // 
            // pnl14
            // 
            this.pnl14.Controls.Add(this.grdContacto);
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl14.Location = new System.Drawing.Point(0, 28);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(912, 150);
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
            this.cSecuencia,
            this.cOrden,
            this.cNombre,
            this.cTipoContacto,
            this.cContacto,
            this.codigoTrabajoDataGridViewTextBoxColumn3,
            this.codigoEmpresaDataGridViewTextBoxColumn3,
            this.codigoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.grdContacto.DataSource = this.bsContacto;
            this.grdContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacto.Location = new System.Drawing.Point(0, 0);
            this.grdContacto.MultiSelect = false;
            this.grdContacto.Name = "grdContacto";
            this.grdContacto.Size = new System.Drawing.Size(912, 150);
            this.grdContacto.TabIndex = 8;
            this.grdContacto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContacto_CellDoubleClick);
            this.grdContacto.DoubleClick += new System.EventHandler(this.grdContacto_DoubleClick);
            // 
            // cSecuencia
            // 
            this.cSecuencia.DataPropertyName = "Secuencia";
            this.cSecuencia.HeaderText = "Secuencia";
            this.cSecuencia.Name = "cSecuencia";
            this.cSecuencia.ReadOnly = true;
            this.cSecuencia.Visible = false;
            // 
            // cOrden
            // 
            this.cOrden.DataPropertyName = "Orden";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.cOrden.HeaderText = "Orden";
            this.cOrden.Name = "cOrden";
            this.cOrden.ReadOnly = true;
            this.cOrden.Width = 50;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "NombreContacto";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 200;
            // 
            // cTipoContacto
            // 
            this.cTipoContacto.DataPropertyName = "NombreTipoContacto";
            this.cTipoContacto.HeaderText = "Tipo";
            this.cTipoContacto.Name = "cTipoContacto";
            this.cTipoContacto.ReadOnly = true;
            this.cTipoContacto.Width = 200;
            // 
            // cContacto
            // 
            this.cContacto.DataPropertyName = "Contacto";
            this.cContacto.HeaderText = "Contacto";
            this.cContacto.Name = "cContacto";
            this.cContacto.Width = 200;
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
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsContacto
            // 
            this.bsContacto.DataMember = "tbContactoMiembro";
            this.bsContacto.DataSource = this.dsNeo;
            // 
            // pnl13
            // 
            this.pnl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl13.Controls.Add(this.bnContacto);
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl13.Location = new System.Drawing.Point(0, 0);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(912, 28);
            this.pnl13.TabIndex = 8;
            // 
            // bnContacto
            // 
            this.bnContacto.AddNewItem = null;
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
            this.bnContacto.Size = new System.Drawing.Size(910, 25);
            this.bnContacto.TabIndex = 5;
            this.bnContacto.Text = "bindingNavigator1";
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
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(914, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contacto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl7
            // 
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Controls.Add(this.pnl8);
            this.pnl7.Controls.Add(this.label5);
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl7.Location = new System.Drawing.Point(3, 3);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(914, 182);
            this.pnl7.TabIndex = 1;
            // 
            // pnl8
            // 
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(this.pnl12);
            this.pnl8.Controls.Add(this.pnl11);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl8.Location = new System.Drawing.Point(0, 17);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(912, 163);
            this.pnl8.TabIndex = 7;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.grdSucursal);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(0, 28);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(910, 133);
            this.pnl12.TabIndex = 8;
            // 
            // grdSucursal
            // 
            this.grdSucursal.AllowUserToAddRows = false;
            this.grdSucursal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.grdSucursal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSucursal.AutoGenerateColumns = false;
            this.grdSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSecuencia,
            this.sTipo,
            this.sNombre,
            this.sCodigoPais,
            this.sNombrePais,
            this.sNombreProvincia,
            this.sCodigoPostal,
            this.sDireccion,
            this.sRepresentante,
            this.sCodigoTrabajo,
            this.sCodigoEmpresa,
            this.sCodigo});
            this.grdSucursal.DataSource = this.bsClienteSucursal;
            this.grdSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSucursal.Location = new System.Drawing.Point(0, 0);
            this.grdSucursal.MultiSelect = false;
            this.grdSucursal.Name = "grdSucursal";
            this.grdSucursal.Size = new System.Drawing.Size(910, 133);
            this.grdSucursal.TabIndex = 7;
            this.grdSucursal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSucursal_CellDoubleClick);
            this.grdSucursal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdSucursal_CellFormatting);
            this.grdSucursal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSucursal_CellValueChanged);
            this.grdSucursal.SelectionChanged += new System.EventHandler(this.grdSucursal_SelectionChanged);
            this.grdSucursal.DoubleClick += new System.EventHandler(this.grdSucursal_DoubleClick);
            // 
            // sSecuencia
            // 
            this.sSecuencia.DataPropertyName = "Secuencia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sSecuencia.DefaultCellStyle = dataGridViewCellStyle4;
            this.sSecuencia.HeaderText = "Secuencia";
            this.sSecuencia.Name = "sSecuencia";
            this.sSecuencia.ReadOnly = true;
            this.sSecuencia.Width = 65;
            // 
            // sTipo
            // 
            this.sTipo.DataPropertyName = "Tipo";
            this.sTipo.HeaderText = "Tipo";
            this.sTipo.Name = "sTipo";
            this.sTipo.ReadOnly = true;
            this.sTipo.Visible = false;
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "Nombre";
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.Width = 130;
            // 
            // sCodigoPais
            // 
            this.sCodigoPais.DataPropertyName = "CodigoPais";
            this.sCodigoPais.HeaderText = "País";
            this.sCodigoPais.Name = "sCodigoPais";
            this.sCodigoPais.ReadOnly = true;
            this.sCodigoPais.Width = 50;
            // 
            // sNombrePais
            // 
            this.sNombrePais.HeaderText = "País";
            this.sNombrePais.Name = "sNombrePais";
            this.sNombrePais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sNombrePais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sNombrePais.Visible = false;
            this.sNombrePais.Width = 130;
            // 
            // sNombreProvincia
            // 
            this.sNombreProvincia.DataPropertyName = "NombreProvincia";
            this.sNombreProvincia.HeaderText = "Provincia";
            this.sNombreProvincia.Name = "sNombreProvincia";
            this.sNombreProvincia.ReadOnly = true;
            this.sNombreProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sNombreProvincia.Width = 150;
            // 
            // sCodigoPostal
            // 
            this.sCodigoPostal.DataPropertyName = "CodigoPostal";
            this.sCodigoPostal.HeaderText = "C. Postal";
            this.sCodigoPostal.Name = "sCodigoPostal";
            this.sCodigoPostal.Width = 80;
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
            this.sRepresentante.Width = 160;
            // 
            // sCodigoTrabajo
            // 
            this.sCodigoTrabajo.DataPropertyName = "CodigoTrabajo";
            this.sCodigoTrabajo.HeaderText = "CodigoTrabajo";
            this.sCodigoTrabajo.Name = "sCodigoTrabajo";
            this.sCodigoTrabajo.ReadOnly = true;
            this.sCodigoTrabajo.Visible = false;
            // 
            // sCodigoEmpresa
            // 
            this.sCodigoEmpresa.DataPropertyName = "CodigoEmpresa";
            this.sCodigoEmpresa.HeaderText = "CodigoEmpresa";
            this.sCodigoEmpresa.Name = "sCodigoEmpresa";
            this.sCodigoEmpresa.ReadOnly = true;
            this.sCodigoEmpresa.Visible = false;
            // 
            // sCodigo
            // 
            this.sCodigo.DataPropertyName = "Codigo";
            this.sCodigo.HeaderText = "Codigo";
            this.sCodigo.Name = "sCodigo";
            this.sCodigo.ReadOnly = true;
            this.sCodigo.Visible = false;
            this.sCodigo.Width = 60;
            // 
            // bsClienteSucursal
            // 
            this.bsClienteSucursal.DataMember = "tbSucursalMiembro";
            this.bsClienteSucursal.DataSource = this.dsNeo;
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Controls.Add(this.bnClienteSucursal);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 0);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(910, 28);
            this.pnl11.TabIndex = 7;
            // 
            // bnClienteSucursal
            // 
            this.bnClienteSucursal.AddNewItem = null;
            this.bnClienteSucursal.BindingSource = this.bsClienteSucursal;
            this.bnClienteSucursal.CountItem = this.bindingNavigatorCountItem;
            this.bnClienteSucursal.DeleteItem = null;
            this.bnClienteSucursal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnClienteSucursal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnClienteSucursal.Location = new System.Drawing.Point(0, 0);
            this.bnClienteSucursal.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnClienteSucursal.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnClienteSucursal.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnClienteSucursal.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnClienteSucursal.Name = "bnClienteSucursal";
            this.bnClienteSucursal.PositionItem = this.bindingNavigatorPositionItem;
            this.bnClienteSucursal.Size = new System.Drawing.Size(908, 25);
            this.bnClienteSucursal.TabIndex = 5;
            this.bnClienteSucursal.Text = "bindingNavigator1";
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(912, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datos Generales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpIdentificacion
            // 
            this.tpIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpIdentificacion.Controls.Add(this.grdIdentificacion);
            this.tpIdentificacion.Location = new System.Drawing.Point(4, 22);
            this.tpIdentificacion.Name = "tpIdentificacion";
            this.tpIdentificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpIdentificacion.Size = new System.Drawing.Size(922, 389);
            this.tpIdentificacion.TabIndex = 2;
            this.tpIdentificacion.Text = "Identificaciones";
            this.tpIdentificacion.UseVisualStyleBackColor = true;
            // 
            // grdIdentificacion
            // 
            this.grdIdentificacion.AllowUserToAddRows = false;
            this.grdIdentificacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.grdIdentificacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdIdentificacion.AutoGenerateColumns = false;
            this.grdIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoIdentificacionDataGridViewTextBoxColumn,
            this.nombreNacionalidadDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn});
            this.grdIdentificacion.DataSource = this.bsIdentificacionMiembro;
            this.grdIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIdentificacion.Location = new System.Drawing.Point(3, 3);
            this.grdIdentificacion.Name = "grdIdentificacion";
            this.grdIdentificacion.Size = new System.Drawing.Size(914, 381);
            this.grdIdentificacion.TabIndex = 4;
            // 
            // codigoIdentificacionDataGridViewTextBoxColumn
            // 
            this.codigoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "CodigoIdentificacion";
            this.codigoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoIdentificacionDataGridViewTextBoxColumn.Name = "codigoIdentificacionDataGridViewTextBoxColumn";
            this.codigoIdentificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreNacionalidadDataGridViewTextBoxColumn
            // 
            this.nombreNacionalidadDataGridViewTextBoxColumn.DataPropertyName = "NombreNacionalidad";
            this.nombreNacionalidadDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreNacionalidadDataGridViewTextBoxColumn.Name = "nombreNacionalidadDataGridViewTextBoxColumn";
            this.nombreNacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreNacionalidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificación";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            // 
            // bsIdentificacionMiembro
            // 
            this.bsIdentificacionMiembro.DataMember = "fnIdentificacionMiembro";
            this.bsIdentificacionMiembro.DataSource = this.dsNeo;
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(283, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 417);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(278, 417);
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
            this.codigoClienteDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.nombreEstadoCivilDataGridViewTextBoxColumn,
            this.tipoEstadoDataGridViewTextBoxColumn,
            this.idUserWebDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cuentaContableDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.limiteCreditoDataGridViewTextBoxColumn,
            this.formatoFacturaDataGridViewTextBoxColumn,
            this.formatoReciboIngresoDataGridViewTextBoxColumn,
            this.formatoOrdenPedidoDataGridViewTextBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(276, 415);
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
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoSucursalDataGridViewTextBoxColumn
            // 
            this.codigoSucursalDataGridViewTextBoxColumn.DataPropertyName = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.HeaderText = "CodigoSucursal";
            this.codigoSucursalDataGridViewTextBoxColumn.Name = "codigoSucursalDataGridViewTextBoxColumn";
            this.codigoSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreEstadoCivilDataGridViewTextBoxColumn
            // 
            this.nombreEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "NombreEstadoCivil";
            this.nombreEstadoCivilDataGridViewTextBoxColumn.HeaderText = "NombreEstadoCivil";
            this.nombreEstadoCivilDataGridViewTextBoxColumn.Name = "nombreEstadoCivilDataGridViewTextBoxColumn";
            this.nombreEstadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEstadoCivilDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoEstadoDataGridViewTextBoxColumn
            // 
            this.tipoEstadoDataGridViewTextBoxColumn.DataPropertyName = "TipoEstado";
            this.tipoEstadoDataGridViewTextBoxColumn.HeaderText = "TipoEstado";
            this.tipoEstadoDataGridViewTextBoxColumn.Name = "tipoEstadoDataGridViewTextBoxColumn";
            this.tipoEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUserWebDataGridViewTextBoxColumn
            // 
            this.idUserWebDataGridViewTextBoxColumn.DataPropertyName = "IdUserWeb";
            this.idUserWebDataGridViewTextBoxColumn.HeaderText = "IdUserWeb";
            this.idUserWebDataGridViewTextBoxColumn.Name = "idUserWebDataGridViewTextBoxColumn";
            this.idUserWebDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUserWebDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idClienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 60;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 160;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Visible = false;
            // 
            // nacimientoDataGridViewTextBoxColumn
            // 
            this.nacimientoDataGridViewTextBoxColumn.DataPropertyName = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.Name = "nacimientoDataGridViewTextBoxColumn";
            this.nacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaContableDataGridViewTextBoxColumn
            // 
            this.cuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable";
            this.cuentaContableDataGridViewTextBoxColumn.HeaderText = "CuentaContable";
            this.cuentaContableDataGridViewTextBoxColumn.Name = "cuentaContableDataGridViewTextBoxColumn";
            this.cuentaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentaContableDataGridViewTextBoxColumn.Visible = false;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
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
            // limiteCreditoDataGridViewTextBoxColumn
            // 
            this.limiteCreditoDataGridViewTextBoxColumn.DataPropertyName = "LimiteCredito";
            this.limiteCreditoDataGridViewTextBoxColumn.HeaderText = "LimiteCredito";
            this.limiteCreditoDataGridViewTextBoxColumn.Name = "limiteCreditoDataGridViewTextBoxColumn";
            this.limiteCreditoDataGridViewTextBoxColumn.ReadOnly = true;
            this.limiteCreditoDataGridViewTextBoxColumn.Visible = false;
            // 
            // formatoFacturaDataGridViewTextBoxColumn
            // 
            this.formatoFacturaDataGridViewTextBoxColumn.DataPropertyName = "FormatoFactura";
            this.formatoFacturaDataGridViewTextBoxColumn.HeaderText = "FormatoFactura";
            this.formatoFacturaDataGridViewTextBoxColumn.Name = "formatoFacturaDataGridViewTextBoxColumn";
            this.formatoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatoFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // formatoReciboIngresoDataGridViewTextBoxColumn
            // 
            this.formatoReciboIngresoDataGridViewTextBoxColumn.DataPropertyName = "FormatoReciboIngreso";
            this.formatoReciboIngresoDataGridViewTextBoxColumn.HeaderText = "FormatoReciboIngreso";
            this.formatoReciboIngresoDataGridViewTextBoxColumn.Name = "formatoReciboIngresoDataGridViewTextBoxColumn";
            this.formatoReciboIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatoReciboIngresoDataGridViewTextBoxColumn.Visible = false;
            // 
            // formatoOrdenPedidoDataGridViewTextBoxColumn
            // 
            this.formatoOrdenPedidoDataGridViewTextBoxColumn.DataPropertyName = "FormatoOrdenPedido";
            this.formatoOrdenPedidoDataGridViewTextBoxColumn.HeaderText = "FormatoOrdenPedido";
            this.formatoOrdenPedidoDataGridViewTextBoxColumn.Name = "formatoOrdenPedidoDataGridViewTextBoxColumn";
            this.formatoOrdenPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatoOrdenPedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1232, 10);
            this.pnl2.TabIndex = 10;
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
            this.pnl1.Size = new System.Drawing.Size(1232, 28);
            this.pnl1.TabIndex = 9;
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
            this.bnMto.Size = new System.Drawing.Size(1230, 25);
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // taEstado
            // 
            this.taEstado.ClearBeforeFill = true;
            // 
            // taIdentificacionMiembro
            // 
            this.taIdentificacionMiembro.ClearBeforeFill = true;
            // 
            // taSucursal
            // 
            this.taSucursal.ClearBeforeFill = true;
            // 
            // taPais
            // 
            this.taPais.ClearBeforeFill = true;
            // 
            // taProvincia
            // 
            this.taProvincia.ClearBeforeFill = true;
            // 
            // taSucursalMiembro
            // 
            this.taSucursalMiembro.ClearBeforeFill = true;
            // 
            // taContacto
            // 
            this.taContacto.ClearBeforeFill = true;
            // 
            // taContactoMiembro
            // 
            this.taContactoMiembro.ClearBeforeFill = true;
            // 
            // taTipoContacto
            // 
            this.taTipoContacto.ClearBeforeFill = true;
            // 
            // pnlProvincia
            // 
            this.pnlProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProvincia.Controls.Add(this.btnAceptar);
            this.pnlProvincia.Controls.Add(this.btnProvinciaCancelar);
            this.pnlProvincia.Controls.Add(this.pnlProvinciaSub);
            this.pnlProvincia.Controls.Add(this.label7);
            this.pnlProvincia.Location = new System.Drawing.Point(558, 128);
            this.pnlProvincia.Name = "pnlProvincia";
            this.pnlProvincia.Size = new System.Drawing.Size(317, 282);
            this.pnlProvincia.TabIndex = 12;
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
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnProvinciaCancelar.Click += new System.EventHandler(this.btnProvinciaCancelar_Click);
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.grdProvincia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdProvincia.AutoGenerateColumns = false;
            this.grdProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pPais,
            this.pProvincia,
            this.codigoTrabajoDataGridViewTextBoxColumn1,
            this.codigoEmpresaDataGridViewTextBoxColumn1});
            this.grdProvincia.DataSource = this.bsProvincia;
            this.grdProvincia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProvincia.Location = new System.Drawing.Point(0, 0);
            this.grdProvincia.Name = "grdProvincia";
            this.grdProvincia.ReadOnly = true;
            this.grdProvincia.Size = new System.Drawing.Size(313, 227);
            this.grdProvincia.TabIndex = 4;
            this.grdProvincia.DoubleClick += new System.EventHandler(this.grdProvincia_DoubleClick);
            // 
            // pPais
            // 
            this.pPais.DataPropertyName = "CodigoPais";
            this.pPais.HeaderText = "País";
            this.pPais.Name = "pPais";
            this.pPais.ReadOnly = true;
            this.pPais.Width = 60;
            // 
            // pProvincia
            // 
            this.pProvincia.DataPropertyName = "NombreProvincia";
            this.pProvincia.HeaderText = "Provincia";
            this.pProvincia.Name = "pProvincia";
            this.pProvincia.ReadOnly = true;
            this.pProvincia.Width = 190;
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
            // bsProvincia
            // 
            this.bsProvincia.DataMember = "tbProvincia";
            this.bsProvincia.DataSource = this.dsNeo;
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
            // pnlTipoContacto
            // 
            this.pnlTipoContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoContacto.Controls.Add(this.btnTipoContactoAceptar);
            this.pnlTipoContacto.Controls.Add(this.btnTipoContactoCancelar);
            this.pnlTipoContacto.Controls.Add(this.pnlTipoContactoSub);
            this.pnlTipoContacto.Controls.Add(this.label8);
            this.pnlTipoContacto.Location = new System.Drawing.Point(387, 128);
            this.pnlTipoContacto.Name = "pnlTipoContacto";
            this.pnlTipoContacto.Size = new System.Drawing.Size(364, 282);
            this.pnlTipoContacto.TabIndex = 13;
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
            this.btnTipoContactoAceptar.Click += new System.EventHandler(this.btnTipoContactoAceptar_Click);
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
            this.btnTipoContactoCancelar.Click += new System.EventHandler(this.btnTipoContactoCancelar_Click);
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            this.grdTipoContacto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdTipoContacto.AutoGenerateColumns = false;
            this.grdTipoContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNombre,
            this.tcTipo,
            this.codigoTrabajoDataGridViewTextBoxColumn2,
            this.codigoEmpresaDataGridViewTextBoxColumn2});
            this.grdTipoContacto.DataSource = this.bsTipoContacto;
            this.grdTipoContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTipoContacto.Location = new System.Drawing.Point(0, 0);
            this.grdTipoContacto.Name = "grdTipoContacto";
            this.grdTipoContacto.ReadOnly = true;
            this.grdTipoContacto.Size = new System.Drawing.Size(360, 227);
            this.grdTipoContacto.TabIndex = 4;
            this.grdTipoContacto.DoubleClick += new System.EventHandler(this.grdTipoContacto_DoubleClick);
            // 
            // tcNombre
            // 
            this.tcNombre.DataPropertyName = "NombreContacto";
            this.tcNombre.HeaderText = "Nombre";
            this.tcNombre.Name = "tcNombre";
            this.tcNombre.ReadOnly = true;
            this.tcNombre.Width = 150;
            // 
            // tcTipo
            // 
            this.tcTipo.DataPropertyName = "NombreTipoContacto";
            this.tcTipo.HeaderText = "Tipo ";
            this.tcTipo.Name = "tcTipo";
            this.tcTipo.ReadOnly = true;
            this.tcTipo.Width = 150;
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
            // bsTipoContacto
            // 
            this.bsTipoContacto.DataMember = "tbTipoContacto";
            this.bsTipoContacto.DataSource = this.dsNeo;
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
            // FrmMtoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 467);
            this.Controls.Add(this.pnlTipoContacto);
            this.Controls.Add(this.pnlProvincia);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoCliente_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoCliente_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.tcMto.ResumeLayout(false);
            this.tpPerfil.ResumeLayout(false);
            this.tpPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            this.tpSucursal.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsClienteSucursal)).EndInit();
            this.pnl11.ResumeLayout(false);
            this.pnl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnClienteSucursal)).EndInit();
            this.bnClienteSucursal.ResumeLayout(false);
            this.bnClienteSucursal.PerformLayout();
            this.tpIdentificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIdentificacionMiembro)).EndInit();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).EndInit();
            this.bnMto.ResumeLayout(false);
            this.bnMto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnlProvincia.ResumeLayout(false);
            this.pnlProvinciaSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvincia)).EndInit();
            this.pnlTipoContacto.ResumeLayout(false);
            this.pnlTipoContactoSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator spd4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ToolStripButton btnSalir;
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
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.TabControl tcMto;
        private System.Windows.Forms.TabPage tpPerfil;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSucursal;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.ComboBox cboPedido;
        private System.Windows.Forms.ComboBox cboRecibo;
        private System.Windows.Forms.ComboBox cboFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCuentaContable;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.TextBox txtUserWeb;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoEstado;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteCreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoReciboIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoOrdenPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl12;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdSucursal;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.BindingNavigator bnClienteSucursal;
        private System.Windows.Forms.ToolStripButton btnNuevoSucursal;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsClienteSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl14;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdContacto;
        private System.Windows.Forms.Panel pnl13;
        private System.Windows.Forms.BindingNavigator bnContacto;
        private System.Windows.Forms.ToolStripButton btnNuevoContacto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEliminarContacto;
        private System.Windows.Forms.BindingSource bsContacto;
        private System.Windows.Forms.TabPage tpIdentificacion;
        private DsNeoTableAdapters.taCliente taCliente;
        private DsNeoTableAdapters.taEstado taEstado;
        private System.Windows.Forms.BindingSource bsEstado;
        private System.Windows.Forms.BindingSource bsIdentificacionMiembro;
        private DsNeoTableAdapters.taIdentificacionMiembro taIdentificacionMiembro;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdIdentificacion;
        private System.Windows.Forms.BindingSource bsSucursal;
        private DsNeoTableAdapters.taSucursal taSucursal;
        private System.Windows.Forms.TextBox txtCategoria;
        private DsNeoTableAdapters.taPais taPais;
        private DsNeoTableAdapters.taProvincia taProvincia;
        private DsNeoTableAdapters.taSucursalMiembro taSucursalMiembro;
        private DsNeoTableAdapters.taContacto taContacto;
        private DsNeoTableAdapters.taContactoMiembro taContactoMiembro;
        private DsNeoTableAdapters.taTipoContacto taTipoContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSecuenciaSucursal;
        private System.Windows.Forms.Panel pnlProvincia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnProvinciaCancelar;
        private System.Windows.Forms.Panel pnlProvinciaSub;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdProvincia;
        private System.Windows.Forms.BindingSource bsProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoPais;
        private System.Windows.Forms.DataGridViewComboBoxColumn sNombrePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn pProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlTipoContacto;
        private System.Windows.Forms.Button btnTipoContactoAceptar;
        private System.Windows.Forms.Button btnTipoContactoCancelar;
        private System.Windows.Forms.Panel pnlTipoContactoSub;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTipoContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bsTipoContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIdentificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreNacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
    }
}