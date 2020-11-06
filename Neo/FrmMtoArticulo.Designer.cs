namespace Neo
{
    partial class FrmMtoArticulo
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
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label codigoUnidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label caratulaLabel;
            System.Windows.Forms.Label nombreCategoriaLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoArticuloLabel;
            System.Windows.Forms.Label aperturaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label nombreDepartamentoLabel;
            System.Windows.Forms.Label equipoLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label inventarioLabel;
            System.Windows.Forms.Label aplica_Orden_PedidoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoArticulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label aplicaInscripcionLabel;
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.tcProveedor = new System.Windows.Forms.TabControl();
            this.tpPerfil = new System.Windows.Forms.TabPage();
            this.chkOrdenPedido = new System.Windows.Forms.CheckBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pbCaratula = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPrecios = new System.Windows.Forms.TabPage();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.grdPrecio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoPrecioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPrecioVenta = new System.Windows.Forms.BindingSource(this.components);
            this.pnl9 = new System.Windows.Forms.Panel();
            this.bnPrecioVenta = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tpProveedor = new System.Windows.Forms.TabPage();
            this.grdProveedor = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pActual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.tpMultimedia = new System.Windows.Forms.TabPage();
            this.grdMultimedia = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticuloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsMultimedia = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnmultimedia = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNuevoMultimedia = new System.Windows.Forms.ToolStripButton();
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
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caratulaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
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
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.taArticulo = new Neo.DsNeoTableAdapters.taArticulo();
            this.tableAdapterManager = new Neo.DsNeoTableAdapters.TableAdapterManager();
            this.taUnidad = new Neo.DsNeoTableAdapters.taUnidad();
            this.taArticuloPrecioVenta = new Neo.DsNeoTableAdapters.taArticuloPrecioVenta();
            this.taArticuloMultimedia = new Neo.DsNeoTableAdapters.taArticuloMultimedia();
            this.taDepartamento = new Neo.DsNeoTableAdapters.taDepartamento();
            this.taCategoria = new Neo.DsNeoTableAdapters.taCategoria();
            this.taArticuloProveedor = new Neo.DsNeoTableAdapters.taArticuloProveedor();
            this.label3 = new System.Windows.Forms.Label();
            this.chkInscripcion = new System.Windows.Forms.CheckBox();
            idArticuloLabel = new System.Windows.Forms.Label();
            codigoUnidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            caratulaLabel = new System.Windows.Forms.Label();
            nombreCategoriaLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoArticuloLabel = new System.Windows.Forms.Label();
            aperturaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            nombreDepartamentoLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            aplica_Orden_PedidoLabel = new System.Windows.Forms.Label();
            aplicaInscripcionLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.tcProveedor.SuspendLayout();
            this.tpPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).BeginInit();
            this.tpPrecios.SuspendLayout();
            this.pnl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecioVenta)).BeginInit();
            this.pnl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnPrecioVenta)).BeginInit();
            this.bnPrecioVenta.SuspendLayout();
            this.tpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).BeginInit();
            this.tpMultimedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMultimedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMultimedia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnmultimedia)).BeginInit();
            this.bnmultimedia.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(48, 29);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(24, 13);
            idArticuloLabel.TabIndex = 1;
            idArticuloLabel.Text = " ID:";
            // 
            // codigoUnidadLabel
            // 
            codigoUnidadLabel.AutoSize = true;
            codigoUnidadLabel.Location = new System.Drawing.Point(28, 55);
            codigoUnidadLabel.Name = "codigoUnidadLabel";
            codigoUnidadLabel.Size = new System.Drawing.Size(44, 13);
            codigoUnidadLabel.TabIndex = 3;
            codigoUnidadLabel.Text = "Unidad:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(6, 82);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripción:";
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Location = new System.Drawing.Point(23, 108);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(49, 13);
            caratulaLabel.TabIndex = 7;
            caratulaLabel.Text = "Caratula:";
            // 
            // nombreCategoriaLabel
            // 
            nombreCategoriaLabel.AutoSize = true;
            nombreCategoriaLabel.Location = new System.Drawing.Point(285, 59);
            nombreCategoriaLabel.Name = "nombreCategoriaLabel";
            nombreCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            nombreCategoriaLabel.TabIndex = 14;
            nombreCategoriaLabel.Text = "Categoria:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(294, 169);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 16;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(289, 195);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 18;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoArticuloLabel
            // 
            codigoArticuloLabel.AutoSize = true;
            codigoArticuloLabel.Location = new System.Drawing.Point(297, 221);
            codigoArticuloLabel.Name = "codigoArticuloLabel";
            codigoArticuloLabel.Size = new System.Drawing.Size(43, 13);
            codigoArticuloLabel.TabIndex = 20;
            codigoArticuloLabel.Text = "Código:";
            // 
            // aperturaLabel
            // 
            aperturaLabel.AutoSize = true;
            aperturaLabel.Location = new System.Drawing.Point(289, 248);
            aperturaLabel.Name = "aperturaLabel";
            aperturaLabel.Size = new System.Drawing.Size(50, 13);
            aperturaLabel.TabIndex = 24;
            aperturaLabel.Text = "Apertura:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(293, 274);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 26;
            usuarioLabel.Text = "Usuario:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(300, 141);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 28;
            activoLabel.Text = "Activo:";
            // 
            // nombreDepartamentoLabel
            // 
            nombreDepartamentoLabel.AutoSize = true;
            nombreDepartamentoLabel.Location = new System.Drawing.Point(263, 32);
            nombreDepartamentoLabel.Name = "nombreDepartamentoLabel";
            nombreDepartamentoLabel.Size = new System.Drawing.Size(77, 13);
            nombreDepartamentoLabel.TabIndex = 30;
            nombreDepartamentoLabel.Text = "Departamento:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(296, 301);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 31;
            equipoLabel.Text = "Equipo:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(278, 114);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 32;
            existenciaLabel.Text = "Existencia:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Location = new System.Drawing.Point(279, 88);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(57, 13);
            inventarioLabel.TabIndex = 33;
            inventarioLabel.Text = "Inventario:";
            // 
            // aplica_Orden_PedidoLabel
            // 
            aplica_Orden_PedidoLabel.AutoSize = true;
            aplica_Orden_PedidoLabel.Location = new System.Drawing.Point(530, 33);
            aplica_Orden_PedidoLabel.Name = "aplica_Orden_PedidoLabel";
            aplica_Orden_PedidoLabel.Size = new System.Drawing.Size(107, 13);
            aplica_Orden_PedidoLabel.TabIndex = 34;
            aplica_Orden_PedidoLabel.Text = "Aplica Orden Pedido:";
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
            this.pnl3.Size = new System.Drawing.Size(1105, 410);
            this.pnl3.TabIndex = 7;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.tcProveedor);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(380, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(718, 398);
            this.pnl6.TabIndex = 6;
            // 
            // tcProveedor
            // 
            this.tcProveedor.Controls.Add(this.tpPerfil);
            this.tcProveedor.Controls.Add(this.tpPrecios);
            this.tcProveedor.Controls.Add(this.tpProveedor);
            this.tcProveedor.Controls.Add(this.tpMultimedia);
            this.tcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProveedor.Location = new System.Drawing.Point(0, 0);
            this.tcProveedor.Name = "tcProveedor";
            this.tcProveedor.SelectedIndex = 0;
            this.tcProveedor.Size = new System.Drawing.Size(716, 396);
            this.tcProveedor.TabIndex = 0;
            // 
            // tpPerfil
            // 
            this.tpPerfil.AutoScroll = true;
            this.tpPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPerfil.Controls.Add(aplicaInscripcionLabel);
            this.tpPerfil.Controls.Add(this.chkInscripcion);
            this.tpPerfil.Controls.Add(this.label3);
            this.tpPerfil.Controls.Add(aplica_Orden_PedidoLabel);
            this.tpPerfil.Controls.Add(this.chkOrdenPedido);
            this.tpPerfil.Controls.Add(inventarioLabel);
            this.tpPerfil.Controls.Add(this.chkInventario);
            this.tpPerfil.Controls.Add(existenciaLabel);
            this.tpPerfil.Controls.Add(this.txtExistencia);
            this.tpPerfil.Controls.Add(equipoLabel);
            this.tpPerfil.Controls.Add(this.lblEquipo);
            this.tpPerfil.Controls.Add(nombreDepartamentoLabel);
            this.tpPerfil.Controls.Add(this.cboDepartamento);
            this.tpPerfil.Controls.Add(activoLabel);
            this.tpPerfil.Controls.Add(this.chkActivo);
            this.tpPerfil.Controls.Add(usuarioLabel);
            this.tpPerfil.Controls.Add(this.lblUsuario);
            this.tpPerfil.Controls.Add(aperturaLabel);
            this.tpPerfil.Controls.Add(this.lblApertura);
            this.tpPerfil.Controls.Add(codigoArticuloLabel);
            this.tpPerfil.Controls.Add(this.lblCodigo);
            this.tpPerfil.Controls.Add(codigoEmpresaLabel);
            this.tpPerfil.Controls.Add(this.lblEmpresa);
            this.tpPerfil.Controls.Add(codigoTrabajoLabel);
            this.tpPerfil.Controls.Add(this.lblTrabajo);
            this.tpPerfil.Controls.Add(nombreCategoriaLabel);
            this.tpPerfil.Controls.Add(this.cboCategoria);
            this.tpPerfil.Controls.Add(this.label2);
            this.tpPerfil.Controls.Add(this.btnQuitar);
            this.tpPerfil.Controls.Add(this.btnCargar);
            this.tpPerfil.Controls.Add(caratulaLabel);
            this.tpPerfil.Controls.Add(this.pbCaratula);
            this.tpPerfil.Controls.Add(descripcionLabel);
            this.tpPerfil.Controls.Add(this.txtDescripcion);
            this.tpPerfil.Controls.Add(codigoUnidadLabel);
            this.tpPerfil.Controls.Add(this.cboUnidad);
            this.tpPerfil.Controls.Add(idArticuloLabel);
            this.tpPerfil.Controls.Add(this.txtId);
            this.tpPerfil.Controls.Add(this.label1);
            this.tpPerfil.Location = new System.Drawing.Point(4, 22);
            this.tpPerfil.Name = "tpPerfil";
            this.tpPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerfil.Size = new System.Drawing.Size(708, 370);
            this.tpPerfil.TabIndex = 0;
            this.tpPerfil.Text = "Perfil";
            this.tpPerfil.UseVisualStyleBackColor = true;
            // 
            // chkOrdenPedido
            // 
            this.chkOrdenPedido.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Aplica Orden Pedido", true));
            this.chkOrdenPedido.Location = new System.Drawing.Point(643, 28);
            this.chkOrdenPedido.Name = "chkOrdenPedido";
            this.chkOrdenPedido.Size = new System.Drawing.Size(16, 24);
            this.chkOrdenPedido.TabIndex = 35;
            this.chkOrdenPedido.UseVisualStyleBackColor = true;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbArticulo";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkInventario
            // 
            this.chkInventario.Location = new System.Drawing.Point(342, 83);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(13, 24);
            this.chkInventario.TabIndex = 34;
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // txtExistencia
            // 
            this.txtExistencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Existencia", true));
            this.txtExistencia.Location = new System.Drawing.Point(342, 111);
            this.txtExistencia.MaxLength = 15;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(168, 20);
            this.txtExistencia.TabIndex = 33;
            this.txtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(341, 298);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(166, 20);
            this.lblEquipo.TabIndex = 32;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreDepartamento", true));
            this.cboDepartamento.DataSource = this.dsNeo;
            this.cboDepartamento.DisplayMember = "tbDepartamento.Nombre";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(342, 29);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(166, 21);
            this.cboDepartamento.TabIndex = 31;
            this.cboDepartamento.ValueMember = "tbDepartamento.Nombre";
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(342, 136);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(26, 24);
            this.chkActivo.TabIndex = 29;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(341, 271);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(166, 20);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApertura
            // 
            this.lblApertura.BackColor = System.Drawing.Color.Gainsboro;
            this.lblApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApertura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Apertura", true));
            this.lblApertura.Location = new System.Drawing.Point(341, 245);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(166, 20);
            this.lblApertura.TabIndex = 25;
            this.lblApertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoArticulo", true));
            this.lblCodigo.Location = new System.Drawing.Point(342, 218);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(166, 20);
            this.lblCodigo.TabIndex = 21;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(342, 192);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(166, 20);
            this.lblEmpresa.TabIndex = 19;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(342, 166);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(166, 20);
            this.lblTrabajo.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreCategoria", true));
            this.cboCategoria.DataSource = this.dsNeo;
            this.cboCategoria.DisplayMember = "tbCategoria.NombreCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(342, 56);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(167, 21);
            this.cboCategoria.TabIndex = 15;
            this.cboCategoria.ValueMember = "tbCategoria.NombreCategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sistema";
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(165, 277);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(74, 277);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pbCaratula
            // 
            this.pbCaratula.BackColor = System.Drawing.Color.Gainsboro;
            this.pbCaratula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaratula.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsMto, "Caratula", true));
            this.pbCaratula.Location = new System.Drawing.Point(74, 105);
            this.pbCaratula.Name = "pbCaratula";
            this.pbCaratula.Size = new System.Drawing.Size(166, 166);
            this.pbCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaratula.TabIndex = 8;
            this.pbCaratula.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(74, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(166, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // cboUnidad
            // 
            this.cboUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoUnidad", true));
            this.cboUnidad.DataSource = this.dsNeo;
            this.cboUnidad.DisplayMember = "tbUnidad.CodigoUnidad";
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(74, 52);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(166, 21);
            this.cboUnidad.TabIndex = 4;
            this.cboUnidad.ValueMember = "tbUnidad.CodigoUnidad";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "IdArticulo", true));
            this.txtId.Location = new System.Drawing.Point(74, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(166, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Generales";
            // 
            // tpPrecios
            // 
            this.tpPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPrecios.Controls.Add(this.pnl8);
            this.tpPrecios.Location = new System.Drawing.Point(4, 22);
            this.tpPrecios.Name = "tpPrecios";
            this.tpPrecios.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrecios.Size = new System.Drawing.Size(531, 370);
            this.tpPrecios.TabIndex = 1;
            this.tpPrecios.Text = "Precios";
            this.tpPrecios.UseVisualStyleBackColor = true;
            // 
            // pnl8
            // 
            this.pnl8.Controls.Add(this.grdPrecio);
            this.pnl8.Controls.Add(this.pnl9);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl8.Location = new System.Drawing.Point(3, 3);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(523, 362);
            this.pnl8.TabIndex = 1;
            // 
            // grdPrecio
            // 
            this.grdPrecio.AllowUserToAddRows = false;
            this.grdPrecio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.grdPrecio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPrecio.AutoGenerateColumns = false;
            this.grdPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPrecioVentaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.grdPrecio.DataSource = this.bsPrecioVenta;
            this.grdPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrecio.Location = new System.Drawing.Point(0, 27);
            this.grdPrecio.Name = "grdPrecio";
            this.grdPrecio.Size = new System.Drawing.Size(523, 335);
            this.grdPrecio.TabIndex = 5;
            // 
            // codigoPrecioVentaDataGridViewTextBoxColumn
            // 
            this.codigoPrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "CodigoPrecioVenta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoPrecioVentaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoPrecioVentaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoPrecioVentaDataGridViewTextBoxColumn.Name = "codigoPrecioVentaDataGridViewTextBoxColumn";
            this.codigoPrecioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // bsPrecioVenta
            // 
            this.bsPrecioVenta.DataMember = "tbArticuloPrecioVenta";
            this.bsPrecioVenta.DataSource = this.dsNeo;
            // 
            // pnl9
            // 
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Controls.Add(this.bnPrecioVenta);
            this.pnl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl9.Location = new System.Drawing.Point(0, 0);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(523, 27);
            this.pnl9.TabIndex = 0;
            // 
            // bnPrecioVenta
            // 
            this.bnPrecioVenta.AddNewItem = null;
            this.bnPrecioVenta.BindingSource = this.bsPrecioVenta;
            this.bnPrecioVenta.CountItem = this.toolStripLabel1;
            this.bnPrecioVenta.DeleteItem = null;
            this.bnPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnPrecioVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3});
            this.bnPrecioVenta.Location = new System.Drawing.Point(0, 0);
            this.bnPrecioVenta.MoveFirstItem = this.toolStripButton2;
            this.bnPrecioVenta.MoveLastItem = this.toolStripButton5;
            this.bnPrecioVenta.MoveNextItem = this.toolStripButton4;
            this.bnPrecioVenta.MovePreviousItem = this.toolStripButton3;
            this.bnPrecioVenta.Name = "bnPrecioVenta";
            this.bnPrecioVenta.PositionItem = this.toolStripTextBox1;
            this.bnPrecioVenta.Size = new System.Drawing.Size(521, 25);
            this.bnPrecioVenta.TabIndex = 9;
            this.bnPrecioVenta.Text = "bindingNavigator1";
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
            this.toolStripButton2.Text = "Mover primero";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover anterior";
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover siguiente";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tpProveedor
            // 
            this.tpProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpProveedor.Controls.Add(this.grdProveedor);
            this.tpProveedor.Location = new System.Drawing.Point(4, 22);
            this.tpProveedor.Name = "tpProveedor";
            this.tpProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpProveedor.Size = new System.Drawing.Size(531, 370);
            this.tpProveedor.TabIndex = 3;
            this.tpProveedor.Text = "Proveedores";
            this.tpProveedor.UseVisualStyleBackColor = true;
            // 
            // grdProveedor
            // 
            this.grdProveedor.AllowUserToAddRows = false;
            this.grdProveedor.AllowUserToDeleteRows = false;
            this.grdProveedor.AutoGenerateColumns = false;
            this.grdProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.codigoProveedorDataGridViewTextBoxColumn,
            this.pActual});
            this.grdProveedor.DataSource = this.bsProveedor;
            this.grdProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProveedor.Location = new System.Drawing.Point(3, 3);
            this.grdProveedor.Name = "grdProveedor";
            this.grdProveedor.Size = new System.Drawing.Size(523, 362);
            this.grdProveedor.TabIndex = 0;
            this.grdProveedor.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProveedor_CellValidated);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.costoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.Width = 70;
            // 
            // codigoProveedorDataGridViewTextBoxColumn
            // 
            this.codigoProveedorDataGridViewTextBoxColumn.DataPropertyName = "CodigoProveedor";
            this.codigoProveedorDataGridViewTextBoxColumn.HeaderText = "CodigoProveedor";
            this.codigoProveedorDataGridViewTextBoxColumn.Name = "codigoProveedorDataGridViewTextBoxColumn";
            this.codigoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // pActual
            // 
            this.pActual.DataPropertyName = "Actual";
            this.pActual.HeaderText = "Actual";
            this.pActual.Name = "pActual";
            this.pActual.Width = 50;
            // 
            // bsProveedor
            // 
            this.bsProveedor.DataMember = "tbArticuloProveedor";
            this.bsProveedor.DataSource = this.dsNeo;
            // 
            // tpMultimedia
            // 
            this.tpMultimedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpMultimedia.Controls.Add(this.grdMultimedia);
            this.tpMultimedia.Controls.Add(this.panel1);
            this.tpMultimedia.Location = new System.Drawing.Point(4, 22);
            this.tpMultimedia.Name = "tpMultimedia";
            this.tpMultimedia.Padding = new System.Windows.Forms.Padding(3);
            this.tpMultimedia.Size = new System.Drawing.Size(531, 370);
            this.tpMultimedia.TabIndex = 2;
            this.tpMultimedia.Text = "Multimedia";
            this.tpMultimedia.UseVisualStyleBackColor = true;
            // 
            // grdMultimedia
            // 
            this.grdMultimedia.AllowUserToAddRows = false;
            this.grdMultimedia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMultimedia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMultimedia.AutoGenerateColumns = false;
            this.grdMultimedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMultimedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn1,
            this.codigoEmpresaDataGridViewTextBoxColumn1,
            this.codigoArticuloDataGridViewTextBoxColumn1,
            this.mCodigo,
            this.mImagen});
            this.grdMultimedia.DataSource = this.bsMultimedia;
            this.grdMultimedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMultimedia.Location = new System.Drawing.Point(3, 31);
            this.grdMultimedia.Name = "grdMultimedia";
            this.grdMultimedia.ReadOnly = true;
            this.grdMultimedia.Size = new System.Drawing.Size(523, 334);
            this.grdMultimedia.TabIndex = 7;
            this.grdMultimedia.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdMultimedia_DataError);
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
            // codigoArticuloDataGridViewTextBoxColumn1
            // 
            this.codigoArticuloDataGridViewTextBoxColumn1.DataPropertyName = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn1.HeaderText = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn1.Name = "codigoArticuloDataGridViewTextBoxColumn1";
            this.codigoArticuloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn1.Visible = false;
            // 
            // mCodigo
            // 
            this.mCodigo.DataPropertyName = "CodigoMultimedia";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mCodigo.DefaultCellStyle = dataGridViewCellStyle6;
            this.mCodigo.HeaderText = "Código";
            this.mCodigo.Name = "mCodigo";
            this.mCodigo.ReadOnly = true;
            this.mCodigo.Visible = false;
            this.mCodigo.Width = 60;
            // 
            // mImagen
            // 
            this.mImagen.DataPropertyName = "Imagen";
            this.mImagen.HeaderText = "Imagen";
            this.mImagen.Name = "mImagen";
            this.mImagen.ReadOnly = true;
            this.mImagen.Width = 150;
            // 
            // bsMultimedia
            // 
            this.bsMultimedia.DataMember = "tbArticuloMultimedia";
            this.bsMultimedia.DataSource = this.dsNeo;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bnmultimedia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 28);
            this.panel1.TabIndex = 6;
            // 
            // bnmultimedia
            // 
            this.bnmultimedia.AddNewItem = this.btnNuevoMultimedia;
            this.bnmultimedia.BindingSource = this.bsMultimedia;
            this.bnmultimedia.CountItem = this.bindingNavigatorCountItem;
            this.bnmultimedia.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnmultimedia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnmultimedia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNuevoMultimedia,
            this.bindingNavigatorDeleteItem});
            this.bnmultimedia.Location = new System.Drawing.Point(0, 0);
            this.bnmultimedia.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnmultimedia.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnmultimedia.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnmultimedia.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnmultimedia.Name = "bnmultimedia";
            this.bnmultimedia.PositionItem = this.bindingNavigatorPositionItem;
            this.bnmultimedia.Size = new System.Drawing.Size(521, 25);
            this.bnmultimedia.TabIndex = 0;
            this.bnmultimedia.Text = "bindingNavigator1";
            // 
            // btnNuevoMultimedia
            // 
            this.btnNuevoMultimedia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevoMultimedia.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoMultimedia.Image")));
            this.btnNuevoMultimedia.Name = "btnNuevoMultimedia";
            this.btnNuevoMultimedia.RightToLeftAutoMirrorImage = true;
            this.btnNuevoMultimedia.Size = new System.Drawing.Size(23, 22);
            this.btnNuevoMultimedia.Text = "Agregar nuevo";
            this.btnNuevoMultimedia.Click += new System.EventHandler(this.btnNuevoMultimedia_Click);
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
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
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
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(370, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 398);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(365, 398);
            this.pnl4.TabIndex = 4;
            // 
            // grdMto
            // 
            this.grdMto.AllowUserToAddRows = false;
            this.grdMto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoArticuloDataGridViewTextBoxColumn,
            this.codigoUnidadDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.aId,
            this.descripcionDataGridViewTextBoxColumn,
            this.caratulaDataGridViewImageColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(363, 396);
            this.grdMto.TabIndex = 3;
            this.grdMto.SelectionChanged += new System.EventHandler(this.grdMto_SelectionChanged);
            // 
            // codigoTrabajoDataGridViewTextBoxColumn
            // 
            this.codigoTrabajoDataGridViewTextBoxColumn.DataPropertyName = "CodigoTrabajo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoTrabajoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
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
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "CodigoArticulo";
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            this.codigoArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoArticuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoUnidadDataGridViewTextBoxColumn
            // 
            this.codigoUnidadDataGridViewTextBoxColumn.DataPropertyName = "CodigoUnidad";
            this.codigoUnidadDataGridViewTextBoxColumn.HeaderText = "CodigoUnidad";
            this.codigoUnidadDataGridViewTextBoxColumn.Name = "codigoUnidadDataGridViewTextBoxColumn";
            this.codigoUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoUnidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // aId
            // 
            this.aId.DataPropertyName = "IdArticulo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aId.DefaultCellStyle = dataGridViewCellStyle9;
            this.aId.HeaderText = "ID";
            this.aId.Name = "aId";
            this.aId.ReadOnly = true;
            this.aId.Width = 60;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 240;
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
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1105, 10);
            this.pnl2.TabIndex = 6;
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
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnMto);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1105, 28);
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
            this.bnMto.Size = new System.Drawing.Size(1103, 25);
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
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // spd4
            // 
            this.spd4.Name = "spd4";
            this.spd4.Size = new System.Drawing.Size(6, 25);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // taArticulo
            // 
            this.taArticulo.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taArticulo = this.taArticulo;
            this.tableAdapterManager.taArticuloMultimedia = null;
            this.tableAdapterManager.taCategoria = null;
            this.tableAdapterManager.taCliente = null;
            this.tableAdapterManager.taClienteNacionalidad = null;
            this.tableAdapterManager.taClienteSucursalContacto = null;
            this.tableAdapterManager.taContacto = null;
            this.tableAdapterManager.taContactoMiembro = null;
            this.tableAdapterManager.taDepartamento = null;
            this.tableAdapterManager.taEmpresa = null;
            this.tableAdapterManager.taEstado = null;
            this.tableAdapterManager.taFinanciera = null;
            this.tableAdapterManager.taFormaPago = null;
            this.tableAdapterManager.taFrecuencia = null;
            this.tableAdapterManager.taIdentificacion = null;
            this.tableAdapterManager.taMoneda = null;
            this.tableAdapterManager.taNacionalidad = null;
            this.tableAdapterManager.taOcupacion = null;
            this.tableAdapterManager.taOrdenPedido = null;
            this.tableAdapterManager.taOrdenPedidoArticulo = null;
            this.tableAdapterManager.taOrdenPedidoEstado = null;
            this.tableAdapterManager.taPais = null;
            this.tableAdapterManager.taPrecioVenta = null;
            this.tableAdapterManager.taProveedor = null;
            this.tableAdapterManager.taProveedorSucursal = null;
            this.tableAdapterManager.taProveedorSucursalContacto = null;
            this.tableAdapterManager.taProvincia = null;
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
            // taUnidad
            // 
            this.taUnidad.ClearBeforeFill = true;
            // 
            // taArticuloPrecioVenta
            // 
            this.taArticuloPrecioVenta.ClearBeforeFill = true;
            // 
            // taArticuloMultimedia
            // 
            this.taArticuloMultimedia.ClearBeforeFill = true;
            // 
            // taDepartamento
            // 
            this.taDepartamento.ClearBeforeFill = true;
            // 
            // taCategoria
            // 
            this.taCategoria.ClearBeforeFill = true;
            // 
            // taArticuloProveedor
            // 
            this.taArticuloProveedor.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Aplicativo";
            // 
            // aplicaInscripcionLabel
            // 
            aplicaInscripcionLabel.AutoSize = true;
            aplicaInscripcionLabel.Location = new System.Drawing.Point(544, 59);
            aplicaInscripcionLabel.Name = "aplicaInscripcionLabel";
            aplicaInscripcionLabel.Size = new System.Drawing.Size(93, 13);
            aplicaInscripcionLabel.TabIndex = 37;
            aplicaInscripcionLabel.Text = "Aplica Inscripción:";
            // 
            // chkInscripcion
            // 
            this.chkInscripcion.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "AplicaInscripcion", true));
            this.chkInscripcion.Location = new System.Drawing.Point(643, 54);
            this.chkInscripcion.Name = "chkInscripcion";
            this.chkInscripcion.Size = new System.Drawing.Size(16, 24);
            this.chkInscripcion.TabIndex = 38;
            this.chkInscripcion.UseVisualStyleBackColor = true;
            // 
            // FrmMtoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 448);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoArticulo_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoArticulo_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.tcProveedor.ResumeLayout(false);
            this.tpPerfil.ResumeLayout(false);
            this.tpPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratula)).EndInit();
            this.tpPrecios.ResumeLayout(false);
            this.pnl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecioVenta)).EndInit();
            this.pnl9.ResumeLayout(false);
            this.pnl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnPrecioVenta)).EndInit();
            this.bnPrecioVenta.ResumeLayout(false);
            this.bnPrecioVenta.PerformLayout();
            this.tpProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).EndInit();
            this.tpMultimedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMultimedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMultimedia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnmultimedia)).EndInit();
            this.bnmultimedia.ResumeLayout(false);
            this.bnmultimedia.PerformLayout();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).EndInit();
            this.bnMto.ResumeLayout(false);
            this.bnMto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ToolStripButton btnSalir;
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
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator spd4;
        private System.Windows.Forms.TabControl tcProveedor;
        private System.Windows.Forms.TabPage tpPerfil;
        private System.Windows.Forms.TabPage tpPrecios;
        private System.Windows.Forms.TabPage tpMultimedia;
        private DsNeoTableAdapters.taArticulo taArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pbCaratula;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.TextBox txtId;
        private DsNeoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl9;
        private DsNeoTableAdapters.taUnidad taUnidad;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdPrecio;
        private System.Windows.Forms.BindingSource bsPrecioVenta;
        private DsNeoTableAdapters.taArticuloPrecioVenta taArticuloPrecioVenta;
        private System.Windows.Forms.BindingNavigator bnPrecioVenta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource bsMultimedia;
        private DsNeoTableAdapters.taArticuloMultimedia taArticuloMultimedia;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private DsNeoTableAdapters.taDepartamento taDepartamento;
        private DsNeoTableAdapters.taCategoria taCategoria;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aId;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn caratulaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tpProveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdProveedor;
        private System.Windows.Forms.BindingSource bsProveedor;
        private DsNeoTableAdapters.taArticuloProveedor taArticuloProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPrecioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMultimedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bnmultimedia;
        private System.Windows.Forms.ToolStripButton btnNuevoMultimedia;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCodigo;
        private System.Windows.Forms.DataGridViewImageColumn mImagen;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.CheckBox chkOrdenPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pActual;
        private System.Windows.Forms.CheckBox chkInscripcion;
        private System.Windows.Forms.Label label3;
    }
}