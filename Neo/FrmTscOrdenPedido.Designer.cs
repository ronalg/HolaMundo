namespace Neo
{
    partial class FrmTscOrdenPedido
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
            System.Windows.Forms.Label limiteCreditoLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label numeroOrdenPedidoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTscOrdenPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.bnOrdenPedido = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripDropDownButton();
            this.impresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImpresoraPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImpresoraEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPantallaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPantallaEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bsOrdenPedido = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.grdDetalle = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bsArticulo = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.lblTotalArticulo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSubTotalArticulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.bsSucursal = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.grdDomicilio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.representanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsDomicilio = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteCreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoReciboIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatoOrdenPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.taCliente = new Neo.DsNeoTableAdapters.taCliente();
            this.taClienteDomicilio = new Neo.DsNeoTableAdapters.taClienteDomicilio();
            this.taOrdenPedido = new Neo.DsNeoTableAdapters.taOrdenPedido();
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.grdArticulo = new System.Windows.Forms.DataGridView();
            this.aUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCaratula = new System.Windows.Forms.DataGridViewImageColumn();
            this.aPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBuscaArticulo = new System.Windows.Forms.BindingSource(this.components);
            this.taBuscaArticulo = new Neo.DsNeoTableAdapters.taBuscaArticulo();
            this.taOrdenPedidoArticulo = new Neo.DsNeoTableAdapters.taOrdenPedidoArticulo();
            this.taEstado = new Neo.DsNeoTableAdapters.taEstado();
            this.tableAdapterManager = new Neo.DsNeoTableAdapters.TableAdapterManager();
            this.dTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCodigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCoste4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesc = new System.Windows.Forms.TextBox();
            idClienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            limiteCreditoLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            numeroOrdenPedidoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrdenPedido)).BeginInit();
            this.bnOrdenPedido.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl9.SuspendLayout();
            this.pnl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).BeginInit();
            this.pnl7.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).BeginInit();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDomicilio)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuscaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(65, 56);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(21, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 80);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(13, 105);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 7;
            razonSocialLabel.Text = "Razón Social:";
            // 
            // limiteCreditoLabel
            // 
            limiteCreditoLabel.AutoSize = true;
            limiteCreditoLabel.Location = new System.Drawing.Point(11, 131);
            limiteCreditoLabel.Name = "limiteCreditoLabel";
            limiteCreditoLabel.Size = new System.Drawing.Size(75, 13);
            limiteCreditoLabel.TabIndex = 9;
            limiteCreditoLabel.Text = "Límite Crédito:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(11, 134);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 1;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(6, 159);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 3;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(6, 54);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 5;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // numeroOrdenPedidoLabel
            // 
            numeroOrdenPedidoLabel.AutoSize = true;
            numeroOrdenPedidoLabel.Location = new System.Drawing.Point(10, 28);
            numeroOrdenPedidoLabel.Name = "numeroOrdenPedidoLabel";
            numeroOrdenPedidoLabel.Size = new System.Drawing.Size(47, 13);
            numeroOrdenPedidoLabel.TabIndex = 7;
            numeroOrdenPedidoLabel.Text = "Número:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(17, 108);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descuentoLabel.Location = new System.Drawing.Point(8, 60);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(72, 13);
            descuentoLabel.TabIndex = 3;
            descuentoLabel.Text = "Descuento:";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnOrdenPedido);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1370, 28);
            this.pnl1.TabIndex = 0;
            // 
            // bnOrdenPedido
            // 
            this.bnOrdenPedido.AddNewItem = null;
            this.bnOrdenPedido.CountItem = this.bindingNavigatorCountItem;
            this.bnOrdenPedido.DeleteItem = null;
            this.bnOrdenPedido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnOrdenPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnGuardar,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnSalir});
            this.bnOrdenPedido.Location = new System.Drawing.Point(0, 0);
            this.bnOrdenPedido.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOrdenPedido.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOrdenPedido.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOrdenPedido.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOrdenPedido.Name = "bnOrdenPedido";
            this.bnOrdenPedido.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOrdenPedido.Size = new System.Drawing.Size(1368, 25);
            this.bnOrdenPedido.TabIndex = 2;
            this.bnOrdenPedido.Text = "bindingNavigator1";
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
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresoraToolStripMenuItem,
            this.pantallaToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // impresoraToolStripMenuItem
            // 
            this.impresoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImpresoraPersonal,
            this.mnuImpresoraEmpresa});
            this.impresoraToolStripMenuItem.Name = "impresoraToolStripMenuItem";
            this.impresoraToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.impresoraToolStripMenuItem.Text = "Impresora";
            // 
            // mnuImpresoraPersonal
            // 
            this.mnuImpresoraPersonal.Name = "mnuImpresoraPersonal";
            this.mnuImpresoraPersonal.Size = new System.Drawing.Size(119, 22);
            this.mnuImpresoraPersonal.Text = "Personal";
            // 
            // mnuImpresoraEmpresa
            // 
            this.mnuImpresoraEmpresa.Name = "mnuImpresoraEmpresa";
            this.mnuImpresoraEmpresa.Size = new System.Drawing.Size(119, 22);
            this.mnuImpresoraEmpresa.Text = "Empresa";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPantallaPersonal,
            this.mnuPantallaEmpresa});
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pantallaToolStripMenuItem.Text = "Pantalla";
            // 
            // mnuPantallaPersonal
            // 
            this.mnuPantallaPersonal.Name = "mnuPantallaPersonal";
            this.mnuPantallaPersonal.Size = new System.Drawing.Size(119, 22);
            this.mnuPantallaPersonal.Text = "Personal";
            // 
            // mnuPantallaEmpresa
            // 
            this.mnuPantallaEmpresa.Name = "mnuPantallaEmpresa";
            this.mnuPantallaEmpresa.Size = new System.Drawing.Size(119, 22);
            this.mnuPantallaEmpresa.Text = "Empresa";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.xMLToolStripMenuItem.Text = "XML";
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
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.pnl10);
            this.pnl2.Controls.Add(this.pnl9);
            this.pnl2.Controls.Add(this.panel4);
            this.pnl2.Controls.Add(this.pnl8);
            this.pnl2.Controls.Add(this.pnl7);
            this.pnl2.Controls.Add(this.panel1);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Padding = new System.Windows.Forms.Padding(5);
            this.pnl2.Size = new System.Drawing.Size(1370, 629);
            this.pnl2.TabIndex = 1;
            // 
            // pnl10
            // 
            this.pnl10.AutoScroll = true;
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Controls.Add(this.txtDesc);
            this.pnl10.Controls.Add(this.lblSubTotal);
            this.pnl10.Controls.Add(this.label18);
            this.pnl10.Controls.Add(descuentoLabel);
            this.pnl10.Controls.Add(this.lblTotal);
            this.pnl10.Controls.Add(this.label15);
            this.pnl10.Controls.Add(this.label10);
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl10.Location = new System.Drawing.Point(1165, 486);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(198, 136);
            this.pnl10.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(82, 33);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 20);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Sub Total:";
            // 
            // bsOrdenPedido
            // 
            this.bsOrdenPedido.DataMember = "tbOrdenPedido";
            this.bsOrdenPedido.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(82, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Total:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Resumen";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl9
            // 
            this.pnl9.AutoScroll = true;
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Controls.Add(this.txtNota);
            this.pnl9.Controls.Add(this.label23);
            this.pnl9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl9.Location = new System.Drawing.Point(5, 486);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(258, 136);
            this.pnl9.TabIndex = 5;
            // 
            // txtNota
            // 
            this.txtNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "Nota", true));
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.Location = new System.Drawing.Point(0, 18);
            this.txtNota.MaxLength = 300;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(256, 116);
            this.txtNota.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Gainsboro;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(256, 18);
            this.label23.TabIndex = 0;
            this.label23.Text = "Nota";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1358, 10);
            this.panel4.TabIndex = 4;
            // 
            // pnl8
            // 
            this.pnl8.AutoScroll = true;
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(this.grdDetalle);
            this.pnl8.Controls.Add(this.label13);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl8.Location = new System.Drawing.Point(5, 289);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(1358, 187);
            this.pnl8.TabIndex = 3;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.AliceBlue;
            this.grdDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grdDetalle.AutoGenerateColumns = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dTrabajo,
            this.dEmpresa,
            this.dSucursal,
            this.dNumero,
            this.dCodigoArticulo,
            this.dCodigoUnidad,
            this.dDescripcion,
            this.dCoste4,
            this.dCantidad,
            this.dPrecio,
            this.dDescuento,
            this.dImporte,
            this.dBeneficio});
            this.grdDetalle.DataSource = this.bsArticulo;
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.Location = new System.Drawing.Point(0, 18);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.Size = new System.Drawing.Size(1356, 167);
            this.grdDetalle.TabIndex = 4;
            this.grdDetalle.DoubleClick += new System.EventHandler(this.grdDetalle_DoubleClick);
            // 
            // bsArticulo
            // 
            this.bsArticulo.DataMember = "tbOrdenPedidoArticulo";
            this.bsArticulo.DataSource = this.dsNeo;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1356, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Detalle";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.White;
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Controls.Add(this.txtPrecio);
            this.pnl7.Controls.Add(this.txtDescuento);
            this.pnl7.Controls.Add(this.label14);
            this.pnl7.Controls.Add(this.btnMenos);
            this.pnl7.Controls.Add(this.btnMas);
            this.pnl7.Controls.Add(this.lblTotalArticulo);
            this.pnl7.Controls.Add(this.label11);
            this.pnl7.Controls.Add(this.lblSubTotalArticulo);
            this.pnl7.Controls.Add(this.label8);
            this.pnl7.Controls.Add(this.label7);
            this.pnl7.Controls.Add(this.txtDescripcion);
            this.pnl7.Controls.Add(this.label6);
            this.pnl7.Controls.Add(this.txtCantidad);
            this.pnl7.Controls.Add(this.label5);
            this.pnl7.Controls.Add(this.label4);
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl7.Location = new System.Drawing.Point(5, 213);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(1358, 76);
            this.pnl7.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(530, 42);
            this.txtPrecio.MaxLength = 25;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(613, 42);
            this.txtDescuento.MaxLength = 25;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(70, 20);
            this.txtDescuento.TabIndex = 15;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Validated += new System.EventHandler(this.txtDescuento_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(611, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Descuento:";
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(941, 40);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(26, 23);
            this.btnMenos.TabIndex = 13;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(909, 40);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(26, 23);
            this.btnMas.TabIndex = 12;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // lblTotalArticulo
            // 
            this.lblTotalArticulo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArticulo.Location = new System.Drawing.Point(799, 42);
            this.lblTotalArticulo.Name = "lblTotalArticulo";
            this.lblTotalArticulo.Size = new System.Drawing.Size(104, 20);
            this.lblTotalArticulo.TabIndex = 11;
            this.lblTotalArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(796, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total:";
            // 
            // lblSubTotalArticulo
            // 
            this.lblSubTotalArticulo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotalArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotalArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalArticulo.Location = new System.Drawing.Point(689, 43);
            this.lblSubTotalArticulo.Name = "lblSubTotalArticulo";
            this.lblSubTotalArticulo.Size = new System.Drawing.Size(104, 20);
            this.lblSubTotalArticulo.TabIndex = 9;
            this.lblSubTotalArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sub Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(69, 43);
            this.txtDescripcion.MaxLength = 25;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(455, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            this.txtDescripcion.Validated += new System.EventHandler(this.txtDescripcion_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripción:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(8, 43);
            this.txtCantidad.MaxLength = 25;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "1.00";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1356, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Artículo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 10);
            this.panel1.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.panel2);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.panel3);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(5, 5);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1358, 198);
            this.pnl3.TabIndex = 0;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.label9);
            this.pnl6.Controls.Add(this.cboEstado);
            this.pnl6.Controls.Add(fechaLabel);
            this.pnl6.Controls.Add(this.dtpFecha);
            this.pnl6.Controls.Add(numeroOrdenPedidoLabel);
            this.pnl6.Controls.Add(this.lblNumero);
            this.pnl6.Controls.Add(codigoSucursalLabel);
            this.pnl6.Controls.Add(this.cboSucursal);
            this.pnl6.Controls.Add(codigoEmpresaLabel);
            this.pnl6.Controls.Add(this.lblEmpresa);
            this.pnl6.Controls.Add(codigoTrabajoLabel);
            this.pnl6.Controls.Add(this.lblTrabajo);
            this.pnl6.Controls.Add(this.label3);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl6.Location = new System.Drawing.Point(960, 0);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(379, 196);
            this.pnl6.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DataSource = this.bsEstado;
            this.cboEstado.DisplayMember = "NombreEstado";
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(59, 77);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 11;
            this.cboEstado.ValueMember = "NombreEstado";
            // 
            // bsEstado
            // 
            this.bsEstado.DataMember = "tbEstado";
            this.bsEstado.DataSource = this.dsNeo;
            // 
            // dtpFecha
            // 
            this.dtpFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrdenPedido, "Fecha", true));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(59, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "NumeroOrdenPedido", true));
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(59, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(121, 20);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "CodigoSucursal", true));
            this.cboSucursal.DataSource = this.bsSucursal;
            this.cboSucursal.DisplayMember = "Nombre";
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(59, 50);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 21);
            this.cboSucursal.TabIndex = 6;
            this.cboSucursal.ValueMember = "CodigoSucursal";
            // 
            // bsSucursal
            // 
            this.bsSucursal.DataMember = "tbSucursal";
            this.bsSucursal.DataSource = this.dsNeo;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "CodigoEmpresa", true));
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(59, 156);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(121, 20);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "CodigoTrabajo", true));
            this.lblTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajo.Location = new System.Drawing.Point(59, 131);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(121, 20);
            this.lblTrabajo.TabIndex = 2;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orden Pedido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(950, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 196);
            this.panel2.TabIndex = 3;
            // 
            // pnl5
            // 
            this.pnl5.AutoScroll = true;
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Controls.Add(this.grdDomicilio);
            this.pnl5.Controls.Add(this.label12);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(396, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(554, 196);
            this.pnl5.TabIndex = 2;
            // 
            // grdDomicilio
            // 
            this.grdDomicilio.AllowUserToAddRows = false;
            this.grdDomicilio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.AliceBlue;
            this.grdDomicilio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.grdDomicilio.AutoGenerateColumns = false;
            this.grdDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn1,
            this.codigoEmpresaDataGridViewTextBoxColumn1,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.codigoClienteSucursalDataGridViewTextBoxColumn,
            this.nombrePaisDataGridViewTextBoxColumn,
            this.nombreProvinciaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.representanteDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.aplicaDataGridViewCheckBoxColumn});
            this.grdDomicilio.DataSource = this.bsDomicilio;
            this.grdDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDomicilio.Location = new System.Drawing.Point(0, 18);
            this.grdDomicilio.Name = "grdDomicilio";
            this.grdDomicilio.Size = new System.Drawing.Size(552, 176);
            this.grdDomicilio.TabIndex = 5;
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
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoClienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoClienteSucursalDataGridViewTextBoxColumn
            // 
            this.codigoClienteSucursalDataGridViewTextBoxColumn.DataPropertyName = "CodigoClienteSucursal";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoClienteSucursalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.codigoClienteSucursalDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoClienteSucursalDataGridViewTextBoxColumn.Name = "codigoClienteSucursalDataGridViewTextBoxColumn";
            this.codigoClienteSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteSucursalDataGridViewTextBoxColumn.Width = 55;
            // 
            // nombrePaisDataGridViewTextBoxColumn
            // 
            this.nombrePaisDataGridViewTextBoxColumn.DataPropertyName = "NombrePais";
            this.nombrePaisDataGridViewTextBoxColumn.HeaderText = "NombrePais";
            this.nombrePaisDataGridViewTextBoxColumn.Name = "nombrePaisDataGridViewTextBoxColumn";
            this.nombrePaisDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreProvinciaDataGridViewTextBoxColumn
            // 
            this.nombreProvinciaDataGridViewTextBoxColumn.DataPropertyName = "NombreProvincia";
            this.nombreProvinciaDataGridViewTextBoxColumn.HeaderText = "NombreProvincia";
            this.nombreProvinciaDataGridViewTextBoxColumn.Name = "nombreProvinciaDataGridViewTextBoxColumn";
            this.nombreProvinciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // representanteDataGridViewTextBoxColumn
            // 
            this.representanteDataGridViewTextBoxColumn.DataPropertyName = "Representante";
            this.representanteDataGridViewTextBoxColumn.HeaderText = "Representante";
            this.representanteDataGridViewTextBoxColumn.Name = "representanteDataGridViewTextBoxColumn";
            this.representanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 230;
            // 
            // aplicaDataGridViewCheckBoxColumn
            // 
            this.aplicaDataGridViewCheckBoxColumn.DataPropertyName = "Aplica";
            this.aplicaDataGridViewCheckBoxColumn.HeaderText = "Aplica";
            this.aplicaDataGridViewCheckBoxColumn.Name = "aplicaDataGridViewCheckBoxColumn";
            this.aplicaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // bsDomicilio
            // 
            this.bsDomicilio.DataMember = "tbClienteDomicilio";
            this.bsDomicilio.DataSource = this.dsNeo;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(552, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Entrega";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(386, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 196);
            this.panel3.TabIndex = 1;
            // 
            // pnl4
            // 
            this.pnl4.AutoScroll = true;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(limiteCreditoLabel);
            this.pnl4.Controls.Add(this.lblLimiteCredito);
            this.pnl4.Controls.Add(razonSocialLabel);
            this.pnl4.Controls.Add(this.lblRazonSocial);
            this.pnl4.Controls.Add(nombreLabel);
            this.pnl4.Controls.Add(this.lblNombre);
            this.pnl4.Controls.Add(idClienteLabel);
            this.pnl4.Controls.Add(this.lblId);
            this.pnl4.Controls.Add(this.txtNombre);
            this.pnl4.Controls.Add(this.label2);
            this.pnl4.Controls.Add(this.label1);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(386, 196);
            this.pnl4.TabIndex = 0;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCredito.Location = new System.Drawing.Point(88, 128);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(281, 20);
            this.lblLimiteCredito.TabIndex = 10;
            this.lblLimiteCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(88, 102);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(281, 20);
            this.lblRazonSocial.TabIndex = 8;
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(88, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(281, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(88, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(281, 20);
            this.lblId.TabIndex = 4;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 26);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AutoGenerateColumns = false;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.cCodigo,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.nombreEstadoCivilDataGridViewTextBoxColumn,
            this.tipoEstadoDataGridViewTextBoxColumn,
            this.idUserWebDataGridViewTextBoxColumn,
            this.cId,
            this.categoriaDataGridViewTextBoxColumn,
            this.cNombre,
            this.razonSocialDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cuentaContableDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.cActivo,
            this.usuarioDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.limiteCreditoDataGridViewTextBoxColumn,
            this.formatoFacturaDataGridViewTextBoxColumn,
            this.formatoReciboIngresoDataGridViewTextBoxColumn,
            this.formatoOrdenPedidoDataGridViewTextBoxColumn});
            this.grdCliente.DataSource = this.bsCliente;
            this.grdCliente.Location = new System.Drawing.Point(96, 82);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersVisible = false;
            this.grdCliente.Size = new System.Drawing.Size(422, 149);
            this.grdCliente.TabIndex = 6;
            this.grdCliente.Visible = false;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_DoubleClick);
            this.grdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCliente_KeyDown);
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
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "CodigoCliente";
            this.cCodigo.HeaderText = "CodigoCliente";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            this.cCodigo.Visible = false;
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
            // cId
            // 
            this.cId.DataPropertyName = "IdCliente";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cId.DefaultCellStyle = dataGridViewCellStyle26;
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Visible = false;
            this.cNombre.Width = 300;
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
            // cActivo
            // 
            this.cActivo.DataPropertyName = "Activo";
            this.cActivo.HeaderText = "Activo";
            this.cActivo.Name = "cActivo";
            this.cActivo.ReadOnly = true;
            this.cActivo.Visible = false;
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
            // bsCliente
            // 
            this.bsCliente.DataMember = "tbCliente";
            this.bsCliente.DataSource = this.dsNeo;
            // 
            // taCliente
            // 
            this.taCliente.ClearBeforeFill = true;
            // 
            // taClienteDomicilio
            // 
            this.taClienteDomicilio.ClearBeforeFill = true;
            // 
            // taOrdenPedido
            // 
            this.taOrdenPedido.ClearBeforeFill = true;
            // 
            // taSucursal
            // 
            this.taSucursal.ClearBeforeFill = true;
            // 
            // grdArticulo
            // 
            this.grdArticulo.AllowUserToAddRows = false;
            this.grdArticulo.AllowUserToDeleteRows = false;
            this.grdArticulo.AutoGenerateColumns = false;
            this.grdArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aUnidad,
            this.aCategoria,
            this.aDepartamento,
            this.aId,
            this.aDescripcion,
            this.aCaratula,
            this.aPrecioVenta,
            this.aPrecio,
            this.aCodigo});
            this.grdArticulo.DataSource = this.bsBuscaArticulo;
            this.grdArticulo.Location = new System.Drawing.Point(75, 307);
            this.grdArticulo.Name = "grdArticulo";
            this.grdArticulo.ReadOnly = true;
            this.grdArticulo.RowHeadersVisible = false;
            this.grdArticulo.Size = new System.Drawing.Size(459, 163);
            this.grdArticulo.TabIndex = 7;
            this.grdArticulo.Visible = false;
            this.grdArticulo.DoubleClick += new System.EventHandler(this.grdArticulo_DoubleClick);
            this.grdArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdArticulo_KeyDown);
            // 
            // aUnidad
            // 
            this.aUnidad.DataPropertyName = "CodigoUnidad";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aUnidad.DefaultCellStyle = dataGridViewCellStyle27;
            this.aUnidad.HeaderText = "UND";
            this.aUnidad.Name = "aUnidad";
            this.aUnidad.ReadOnly = true;
            this.aUnidad.Width = 50;
            // 
            // aCategoria
            // 
            this.aCategoria.DataPropertyName = "NombreCategoria";
            this.aCategoria.HeaderText = "NombreCategoria";
            this.aCategoria.Name = "aCategoria";
            this.aCategoria.ReadOnly = true;
            this.aCategoria.Visible = false;
            // 
            // aDepartamento
            // 
            this.aDepartamento.DataPropertyName = "NombreDepartamento";
            this.aDepartamento.HeaderText = "NombreDepartamento";
            this.aDepartamento.Name = "aDepartamento";
            this.aDepartamento.ReadOnly = true;
            this.aDepartamento.Visible = false;
            // 
            // aId
            // 
            this.aId.DataPropertyName = "IdArticulo";
            this.aId.HeaderText = "IdArticulo";
            this.aId.Name = "aId";
            this.aId.ReadOnly = true;
            this.aId.Visible = false;
            // 
            // aDescripcion
            // 
            this.aDescripcion.DataPropertyName = "Descripcion";
            this.aDescripcion.HeaderText = "Descripcion";
            this.aDescripcion.Name = "aDescripcion";
            this.aDescripcion.ReadOnly = true;
            this.aDescripcion.Width = 300;
            // 
            // aCaratula
            // 
            this.aCaratula.DataPropertyName = "Caratula";
            this.aCaratula.HeaderText = "Caratula";
            this.aCaratula.Name = "aCaratula";
            this.aCaratula.ReadOnly = true;
            this.aCaratula.Visible = false;
            // 
            // aPrecioVenta
            // 
            this.aPrecioVenta.DataPropertyName = "CodigoPrecioVenta";
            this.aPrecioVenta.HeaderText = "CodigoPrecioVenta";
            this.aPrecioVenta.Name = "aPrecioVenta";
            this.aPrecioVenta.ReadOnly = true;
            this.aPrecioVenta.Visible = false;
            // 
            // aPrecio
            // 
            this.aPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            this.aPrecio.DefaultCellStyle = dataGridViewCellStyle28;
            this.aPrecio.HeaderText = "Precio";
            this.aPrecio.Name = "aPrecio";
            this.aPrecio.ReadOnly = true;
            this.aPrecio.Width = 80;
            // 
            // aCodigo
            // 
            this.aCodigo.DataPropertyName = "CodigoArticulo";
            this.aCodigo.HeaderText = "CodigoArticulo";
            this.aCodigo.Name = "aCodigo";
            this.aCodigo.ReadOnly = true;
            this.aCodigo.Visible = false;
            // 
            // bsBuscaArticulo
            // 
            this.bsBuscaArticulo.DataMember = "tbBuscaArticulo";
            this.bsBuscaArticulo.DataSource = this.dsNeo;
            // 
            // taBuscaArticulo
            // 
            this.taBuscaArticulo.ClearBeforeFill = true;
            // 
            // taOrdenPedidoArticulo
            // 
            this.taOrdenPedidoArticulo.ClearBeforeFill = true;
            // 
            // taEstado
            // 
            this.taEstado.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taArticulo = null;
            this.tableAdapterManager.taArticuloMultimedia = null;
            this.tableAdapterManager.taCategoria = null;
            this.tableAdapterManager.taCliente = this.taCliente;
            this.tableAdapterManager.taClienteNacionalidad = null;
            this.tableAdapterManager.taClienteSucursal = null;
            this.tableAdapterManager.taClienteSucursalContacto = null;
            this.tableAdapterManager.taContacto = null;
            this.tableAdapterManager.taDepartamento = null;
            this.tableAdapterManager.taEmpresa = null;
            this.tableAdapterManager.taEstado = this.taEstado;
            this.tableAdapterManager.taFinanciera = null;
            this.tableAdapterManager.taFormaPago = null;
            this.tableAdapterManager.taFrecuencia = null;
            this.tableAdapterManager.taIdentificacion = null;
            this.tableAdapterManager.taMoneda = null;
            this.tableAdapterManager.taNacionalidad = null;
            this.tableAdapterManager.taOcupacion = null;
            this.tableAdapterManager.taOrdenPedido = this.taOrdenPedido;
            this.tableAdapterManager.taOrdenPedidoArticulo = this.taOrdenPedidoArticulo;
            this.tableAdapterManager.taPais = null;
            this.tableAdapterManager.taPrecioVenta = null;
            this.tableAdapterManager.taProveedor = null;
            this.tableAdapterManager.taProveedorSucursal = null;
            this.tableAdapterManager.taProveedorSucursalContacto = null;
            this.tableAdapterManager.taProvincia = null;
            this.tableAdapterManager.taSucursal = this.taSucursal;
            this.tableAdapterManager.taTipoContacto = null;
            this.tableAdapterManager.taTipoFinanciera = null;
            this.tableAdapterManager.taTipoTributo = null;
            this.tableAdapterManager.taTrabajo = null;
            this.tableAdapterManager.taTributo = null;
            this.tableAdapterManager.taUnidad = null;
            this.tableAdapterManager.taUsuario = null;
            this.tableAdapterManager.UpdateOrder = Neo.DsNeoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dTrabajo
            // 
            this.dTrabajo.DataPropertyName = "CodigoTrabajo";
            this.dTrabajo.HeaderText = "CodigoTrabajo";
            this.dTrabajo.Name = "dTrabajo";
            this.dTrabajo.ReadOnly = true;
            this.dTrabajo.Visible = false;
            // 
            // dEmpresa
            // 
            this.dEmpresa.DataPropertyName = "CodigoEmpresa";
            this.dEmpresa.HeaderText = "CodigoEmpresa";
            this.dEmpresa.Name = "dEmpresa";
            this.dEmpresa.ReadOnly = true;
            this.dEmpresa.Visible = false;
            // 
            // dSucursal
            // 
            this.dSucursal.DataPropertyName = "CodigoSucursal";
            this.dSucursal.HeaderText = "CodigoSucursal";
            this.dSucursal.Name = "dSucursal";
            this.dSucursal.ReadOnly = true;
            this.dSucursal.Visible = false;
            // 
            // dNumero
            // 
            this.dNumero.DataPropertyName = "NumeroOrdenPedido";
            this.dNumero.HeaderText = "NumeroOrdenPedido";
            this.dNumero.Name = "dNumero";
            this.dNumero.ReadOnly = true;
            this.dNumero.Visible = false;
            // 
            // dCodigoArticulo
            // 
            this.dCodigoArticulo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dCodigoArticulo.DefaultCellStyle = dataGridViewCellStyle16;
            this.dCodigoArticulo.HeaderText = "Código";
            this.dCodigoArticulo.Name = "dCodigoArticulo";
            this.dCodigoArticulo.ReadOnly = true;
            this.dCodigoArticulo.Visible = false;
            this.dCodigoArticulo.Width = 80;
            // 
            // dCodigoUnidad
            // 
            this.dCodigoUnidad.DataPropertyName = "CodigoUnidad";
            this.dCodigoUnidad.HeaderText = "Unidad";
            this.dCodigoUnidad.Name = "dCodigoUnidad";
            this.dCodigoUnidad.ReadOnly = true;
            this.dCodigoUnidad.Width = 60;
            // 
            // dDescripcion
            // 
            this.dDescripcion.DataPropertyName = "Descripcion";
            this.dDescripcion.HeaderText = "Descripción";
            this.dDescripcion.Name = "dDescripcion";
            this.dDescripcion.ReadOnly = true;
            this.dDescripcion.Width = 500;
            // 
            // dCoste4
            // 
            this.dCoste4.DataPropertyName = "Coste";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.dCoste4.DefaultCellStyle = dataGridViewCellStyle17;
            this.dCoste4.HeaderText = "Coste";
            this.dCoste4.Name = "dCoste4";
            this.dCoste4.ReadOnly = true;
            this.dCoste4.Visible = false;
            // 
            // dCantidad
            // 
            this.dCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "N2";
            this.dCantidad.DefaultCellStyle = dataGridViewCellStyle18;
            this.dCantidad.HeaderText = "Cantidad";
            this.dCantidad.Name = "dCantidad";
            this.dCantidad.ReadOnly = true;
            this.dCantidad.Width = 70;
            // 
            // dPrecio
            // 
            this.dPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            this.dPrecio.DefaultCellStyle = dataGridViewCellStyle19;
            this.dPrecio.HeaderText = "Precio";
            this.dPrecio.Name = "dPrecio";
            this.dPrecio.ReadOnly = true;
            this.dPrecio.Width = 70;
            // 
            // dDescuento
            // 
            this.dDescuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            this.dDescuento.DefaultCellStyle = dataGridViewCellStyle20;
            this.dDescuento.HeaderText = "Descuento";
            this.dDescuento.Name = "dDescuento";
            this.dDescuento.ReadOnly = true;
            this.dDescuento.Width = 70;
            // 
            // dImporte
            // 
            this.dImporte.DataPropertyName = "Importe";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            this.dImporte.DefaultCellStyle = dataGridViewCellStyle21;
            this.dImporte.HeaderText = "Importe";
            this.dImporte.Name = "dImporte";
            this.dImporte.ReadOnly = true;
            this.dImporte.Width = 70;
            // 
            // dBeneficio
            // 
            this.dBeneficio.DataPropertyName = "Beneficio";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.dBeneficio.DefaultCellStyle = dataGridViewCellStyle22;
            this.dBeneficio.HeaderText = "Beneficio";
            this.dBeneficio.Name = "dBeneficio";
            this.dBeneficio.ReadOnly = true;
            this.dBeneficio.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPedido, "Descuento", true));
            this.txtDesc.Location = new System.Drawing.Point(82, 57);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.Text = "0.00";
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesc.Validated += new System.EventHandler(this.txtDesc_Validated);
            // 
            // FrmTscOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.grdArticulo);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmTscOrdenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Orden Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTscOrdenPedido_FormClosed);
            this.Load += new System.EventHandler(this.FrmTscOrdenPedido_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOrdenPedido)).EndInit();
            this.bnOrdenPedido.ResumeLayout(false);
            this.bnOrdenPedido.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl10.ResumeLayout(false);
            this.pnl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.pnl9.ResumeLayout(false);
            this.pnl9.PerformLayout();
            this.pnl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).EndInit();
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSucursal)).EndInit();
            this.pnl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDomicilio)).EndInit();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuscaArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnOrdenPedido;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
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
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DsNeo dsNeo;
        private DsNeoTableAdapters.taCliente taCliente;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Label lblTotalArticulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubTotalArticulo;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdDetalle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteCreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoReciboIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatoOrdenPedidoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdDomicilio;
        private System.Windows.Forms.BindingSource bsDomicilio;
        private DsNeoTableAdapters.taClienteDomicilio taClienteDomicilio;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripDropDownButton btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem impresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProvinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource bsOrdenPedido;
        private DsNeoTableAdapters.taOrdenPedido taOrdenPedido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.BindingSource bsSucursal;
        private DsNeoTableAdapters.taSucursal taSucursal;
        private System.Windows.Forms.DataGridView grdArticulo;
        private System.Windows.Forms.BindingSource bsBuscaArticulo;
        private DsNeoTableAdapters.taBuscaArticulo taBuscaArticulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn aId;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn aCaratula;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCodigo;
        private System.Windows.Forms.BindingSource bsArticulo;
        private DsNeoTableAdapters.taOrdenPedidoArticulo taOrdenPedidoArticulo;
        private System.Windows.Forms.ToolStripMenuItem mnuImpresoraPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuImpresoraEmpresa;
        private System.Windows.Forms.ToolStripMenuItem mnuPantallaPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuPantallaEmpresa;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.BindingSource bsEstado;
        private DsNeoTableAdapters.taEstado taEstado;
        private DsNeoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCodigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCoste4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBeneficio;
        private System.Windows.Forms.TextBox txtDesc;
    }
}