namespace Neo
{
    partial class FrmPrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrm));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoPerfilArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrecioVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoUnidad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoPerfilCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoEstadoCivil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoNacionalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoGeografia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoPais = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoOcupacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoIdentificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoPerfilContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoTipoContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoFormaPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoMoneda = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoTributos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMtoSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoFinanciera = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoPerfilFinanciera = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMtoTipoFinanciera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cboEmpresa = new System.Windows.Forms.ToolStripComboBox();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.taTrabajo = new Neo.DsNeoTableAdapters.taTrabajo();
            this.dsNeo = new Neo.DsNeo();
            this.taEmpresa = new Neo.DsNeoTableAdapters.taEmpresa();
            this.mnuTransacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTscOrdenPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimiento,
            this.mnuTransacion});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1119, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "MenuStrip";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoArticulo,
            this.toolStripSeparator4,
            this.mnuMtoCliente,
            this.mnuMtoProveedor,
            this.toolStripSeparator5,
            this.mnuMtoGeografia,
            this.toolStripSeparator6,
            this.mnuMtoCategoria,
            this.mnuMtoDepartamento,
            this.mnuMtoOcupacion,
            this.mnuMtoEstado,
            this.toolStripSeparator1,
            this.mnuMtoIdentificacion,
            this.mnuMtoContacto,
            this.toolStripSeparator2,
            this.mnuMtoFormaPago,
            this.mnuMtoMoneda,
            this.clientesToolStripMenuItem,
            this.toolStripSeparator7,
            this.mnuMtoSucursal,
            this.mnuMtoEmpresa,
            this.mnuMtoFinanciera});
            this.mnuMantenimiento.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(106, 20);
            this.mnuMantenimiento.Text = "Mantenimientos";
            // 
            // mnuMtoArticulo
            // 
            this.mnuMtoArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoPerfilArticulo,
            this.toolStripSeparator3,
            this.mnuPrecioVenta,
            this.mnuMtoUnidad});
            this.mnuMtoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoArticulo.Image")));
            this.mnuMtoArticulo.Name = "mnuMtoArticulo";
            this.mnuMtoArticulo.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoArticulo.Text = "Artículos";
            // 
            // mnuMtoPerfilArticulo
            // 
            this.mnuMtoPerfilArticulo.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoPerfilArticulo.Image")));
            this.mnuMtoPerfilArticulo.Name = "mnuMtoPerfilArticulo";
            this.mnuMtoPerfilArticulo.Size = new System.Drawing.Size(165, 22);
            this.mnuMtoPerfilArticulo.Text = "Perfil";
            this.mnuMtoPerfilArticulo.Click += new System.EventHandler(this.mnuMtoPerfilArticulo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuPrecioVenta
            // 
            this.mnuPrecioVenta.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrecioVenta.Image")));
            this.mnuPrecioVenta.Name = "mnuPrecioVenta";
            this.mnuPrecioVenta.Size = new System.Drawing.Size(165, 22);
            this.mnuPrecioVenta.Text = "Precios de Ventas";
            this.mnuPrecioVenta.Click += new System.EventHandler(this.mnuPrecioVenta_Click);
            // 
            // mnuMtoUnidad
            // 
            this.mnuMtoUnidad.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoUnidad.Image")));
            this.mnuMtoUnidad.Name = "mnuMtoUnidad";
            this.mnuMtoUnidad.Size = new System.Drawing.Size(165, 22);
            this.mnuMtoUnidad.Text = "Unidades";
            this.mnuMtoUnidad.Click += new System.EventHandler(this.mnuMtoUnidad_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoCliente
            // 
            this.mnuMtoCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoPerfilCliente,
            this.toolStripSeparator9,
            this.mnuMtoEstadoCivil,
            this.mnuMtoNacionalidad});
            this.mnuMtoCliente.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoCliente.Image")));
            this.mnuMtoCliente.Name = "mnuMtoCliente";
            this.mnuMtoCliente.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoCliente.Text = "Clientes";
            // 
            // mnuMtoPerfilCliente
            // 
            this.mnuMtoPerfilCliente.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoPerfilCliente.Image")));
            this.mnuMtoPerfilCliente.Name = "mnuMtoPerfilCliente";
            this.mnuMtoPerfilCliente.Size = new System.Drawing.Size(155, 22);
            this.mnuMtoPerfilCliente.Text = "Perfil";
            this.mnuMtoPerfilCliente.Click += new System.EventHandler(this.mnuMtoPerfilCliente_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuMtoEstadoCivil
            // 
            this.mnuMtoEstadoCivil.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoEstadoCivil.Image")));
            this.mnuMtoEstadoCivil.Name = "mnuMtoEstadoCivil";
            this.mnuMtoEstadoCivil.Size = new System.Drawing.Size(155, 22);
            this.mnuMtoEstadoCivil.Text = "Estado Civil";
            // 
            // mnuMtoNacionalidad
            // 
            this.mnuMtoNacionalidad.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoNacionalidad.Image")));
            this.mnuMtoNacionalidad.Name = "mnuMtoNacionalidad";
            this.mnuMtoNacionalidad.Size = new System.Drawing.Size(155, 22);
            this.mnuMtoNacionalidad.Text = "Nacionalidades";
            this.mnuMtoNacionalidad.Click += new System.EventHandler(this.mnuMtoNacionalidad_Click);
            // 
            // mnuMtoProveedor
            // 
            this.mnuMtoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoProveedor.Image")));
            this.mnuMtoProveedor.Name = "mnuMtoProveedor";
            this.mnuMtoProveedor.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoProveedor.Text = "Proveedores";
            this.mnuMtoProveedor.Click += new System.EventHandler(this.mnuMtoProveedor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoGeografia
            // 
            this.mnuMtoGeografia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoProvincia,
            this.mnuMtoPais});
            this.mnuMtoGeografia.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoGeografia.Image")));
            this.mnuMtoGeografia.Name = "mnuMtoGeografia";
            this.mnuMtoGeografia.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoGeografia.Text = "Geografías";
            // 
            // mnuMtoProvincia
            // 
            this.mnuMtoProvincia.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoProvincia.Image")));
            this.mnuMtoProvincia.Name = "mnuMtoProvincia";
            this.mnuMtoProvincia.Size = new System.Drawing.Size(128, 22);
            this.mnuMtoProvincia.Text = "Provincias";
            this.mnuMtoProvincia.Click += new System.EventHandler(this.mnuMtoProvincia_Click);
            // 
            // mnuMtoPais
            // 
            this.mnuMtoPais.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoPais.Image")));
            this.mnuMtoPais.Name = "mnuMtoPais";
            this.mnuMtoPais.Size = new System.Drawing.Size(128, 22);
            this.mnuMtoPais.Text = "Paises";
            this.mnuMtoPais.Click += new System.EventHandler(this.mnuMtoPais_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoCategoria
            // 
            this.mnuMtoCategoria.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoCategoria.Image")));
            this.mnuMtoCategoria.Name = "mnuMtoCategoria";
            this.mnuMtoCategoria.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoCategoria.Text = "Categorias";
            this.mnuMtoCategoria.Click += new System.EventHandler(this.mnuMtoCategoria_Click);
            // 
            // mnuMtoDepartamento
            // 
            this.mnuMtoDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoDepartamento.Image")));
            this.mnuMtoDepartamento.Name = "mnuMtoDepartamento";
            this.mnuMtoDepartamento.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoDepartamento.Text = "Departamentos";
            this.mnuMtoDepartamento.Click += new System.EventHandler(this.mnuMtoDepartamento_Click);
            // 
            // mnuMtoOcupacion
            // 
            this.mnuMtoOcupacion.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoOcupacion.Image")));
            this.mnuMtoOcupacion.Name = "mnuMtoOcupacion";
            this.mnuMtoOcupacion.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoOcupacion.Text = "Ocupaciones";
            this.mnuMtoOcupacion.Click += new System.EventHandler(this.mnuMtoOcupacion_Click);
            // 
            // mnuMtoEstado
            // 
            this.mnuMtoEstado.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoEstado.Image")));
            this.mnuMtoEstado.Name = "mnuMtoEstado";
            this.mnuMtoEstado.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoEstado.Text = "Estados";
            this.mnuMtoEstado.Click += new System.EventHandler(this.mnuMtoEstado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoIdentificacion
            // 
            this.mnuMtoIdentificacion.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoIdentificacion.Image")));
            this.mnuMtoIdentificacion.Name = "mnuMtoIdentificacion";
            this.mnuMtoIdentificacion.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoIdentificacion.Text = "Identificaciones";
            this.mnuMtoIdentificacion.Click += new System.EventHandler(this.mnuMtoIdentificacion_Click);
            // 
            // mnuMtoContacto
            // 
            this.mnuMtoContacto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoPerfilContacto,
            this.toolStripSeparator8,
            this.mnuMtoTipoContacto});
            this.mnuMtoContacto.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoContacto.Image")));
            this.mnuMtoContacto.Name = "mnuMtoContacto";
            this.mnuMtoContacto.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoContacto.Text = "Contactos";
            // 
            // mnuMtoPerfilContacto
            // 
            this.mnuMtoPerfilContacto.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoPerfilContacto.Image")));
            this.mnuMtoPerfilContacto.Name = "mnuMtoPerfilContacto";
            this.mnuMtoPerfilContacto.Size = new System.Drawing.Size(102, 22);
            this.mnuMtoPerfilContacto.Text = "Perfil";
            this.mnuMtoPerfilContacto.Click += new System.EventHandler(this.mnuMtoPerfilContacto_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(99, 6);
            // 
            // mnuMtoTipoContacto
            // 
            this.mnuMtoTipoContacto.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoTipoContacto.Image")));
            this.mnuMtoTipoContacto.Name = "mnuMtoTipoContacto";
            this.mnuMtoTipoContacto.Size = new System.Drawing.Size(102, 22);
            this.mnuMtoTipoContacto.Text = "Tipos";
            this.mnuMtoTipoContacto.Click += new System.EventHandler(this.mnuMtoTipoContacto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoFormaPago
            // 
            this.mnuMtoFormaPago.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoFormaPago.Image")));
            this.mnuMtoFormaPago.Name = "mnuMtoFormaPago";
            this.mnuMtoFormaPago.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoFormaPago.Text = "Formas de Pagos";
            this.mnuMtoFormaPago.Click += new System.EventHandler(this.mnuMtoFormaPago_Click);
            // 
            // mnuMtoMoneda
            // 
            this.mnuMtoMoneda.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoMoneda.Image")));
            this.mnuMtoMoneda.Name = "mnuMtoMoneda";
            this.mnuMtoMoneda.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoMoneda.Text = "Monedas";
            this.mnuMtoMoneda.Click += new System.EventHandler(this.mnuMtoMoneda_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoTipo,
            this.mnuMtoTributos});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Tributos";
            // 
            // mnuMtoTipo
            // 
            this.mnuMtoTipo.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoTipo.Image")));
            this.mnuMtoTipo.Name = "mnuMtoTipo";
            this.mnuMtoTipo.Size = new System.Drawing.Size(116, 22);
            this.mnuMtoTipo.Text = "Tipos";
            this.mnuMtoTipo.Click += new System.EventHandler(this.mnuMtoTipo_Click);
            // 
            // mnuMtoTributos
            // 
            this.mnuMtoTributos.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoTributos.Image")));
            this.mnuMtoTributos.Name = "mnuMtoTributos";
            this.mnuMtoTributos.Size = new System.Drawing.Size(116, 22);
            this.mnuMtoTributos.Text = "Tributos";
            this.mnuMtoTributos.Click += new System.EventHandler(this.mnuMtoTributos_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuMtoSucursal
            // 
            this.mnuMtoSucursal.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoSucursal.Image")));
            this.mnuMtoSucursal.Name = "mnuMtoSucursal";
            this.mnuMtoSucursal.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoSucursal.Text = "Sucursales";
            this.mnuMtoSucursal.Click += new System.EventHandler(this.mnuMtoSucursal_Click);
            // 
            // mnuMtoEmpresa
            // 
            this.mnuMtoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoEmpresa.Image")));
            this.mnuMtoEmpresa.Name = "mnuMtoEmpresa";
            this.mnuMtoEmpresa.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoEmpresa.Text = "Empresas";
            this.mnuMtoEmpresa.Click += new System.EventHandler(this.mnuMtoEmpresa_Click);
            // 
            // mnuMtoFinanciera
            // 
            this.mnuMtoFinanciera.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMtoPerfilFinanciera,
            this.mnuMtoTipoFinanciera});
            this.mnuMtoFinanciera.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoFinanciera.Image")));
            this.mnuMtoFinanciera.Name = "mnuMtoFinanciera";
            this.mnuMtoFinanciera.Size = new System.Drawing.Size(180, 22);
            this.mnuMtoFinanciera.Text = "Financieras";
            // 
            // mnuMtoPerfilFinanciera
            // 
            this.mnuMtoPerfilFinanciera.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoPerfilFinanciera.Image")));
            this.mnuMtoPerfilFinanciera.Name = "mnuMtoPerfilFinanciera";
            this.mnuMtoPerfilFinanciera.Size = new System.Drawing.Size(102, 22);
            this.mnuMtoPerfilFinanciera.Text = "Perfil";
            this.mnuMtoPerfilFinanciera.Click += new System.EventHandler(this.mnuMtoPerfilFinanciera_Click);
            // 
            // mnuMtoTipoFinanciera
            // 
            this.mnuMtoTipoFinanciera.Image = ((System.Drawing.Image)(resources.GetObject("mnuMtoTipoFinanciera.Image")));
            this.mnuMtoTipoFinanciera.Name = "mnuMtoTipoFinanciera";
            this.mnuMtoTipoFinanciera.Size = new System.Drawing.Size(102, 22);
            this.mnuMtoTipoFinanciera.Text = "Tipos";
            this.mnuMtoTipoFinanciera.Click += new System.EventHandler(this.mnuMtoTipoFinanciera_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboEmpresa,
            this.btnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1119, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(200, 25);
            this.cboEmpresa.DropDownClosed += new System.EventHandler(this.cboEmpresa_DropDownClosed);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // taTrabajo
            // 
            this.taTrabajo.ClearBeforeFill = true;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taEmpresa
            // 
            this.taEmpresa.ClearBeforeFill = true;
            // 
            // mnuTransacion
            // 
            this.mnuTransacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTscOrdenPedido});
            this.mnuTransacion.Name = "mnuTransacion";
            this.mnuTransacion.Size = new System.Drawing.Size(92, 20);
            this.mnuTransacion.Text = "Transacciones";
            // 
            // mnuTscOrdenPedido
            // 
            this.mnuTscOrdenPedido.Name = "mnuTscOrdenPedido";
            this.mnuTscOrdenPedido.Size = new System.Drawing.Size(180, 22);
            this.mnuTscOrdenPedido.Text = "Ordenes de Pedidos";
            // 
            // FrmPrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrm";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrm_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoArticulo;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoPerfilArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuPrecioVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoUnidad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoProveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoGeografia;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoProvincia;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoPais;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoCategoria;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoIdentificacion;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoContacto;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoPerfilContacto;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoTipoContacto;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoMoneda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoSucursal;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoEmpresa;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoDepartamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoFormaPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripComboBox cboEmpresa;
        private DsNeoTableAdapters.taTrabajo taTrabajo;
        private DsNeo dsNeo;
        private DsNeoTableAdapters.taEmpresa taEmpresa;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoEstado;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoPerfilCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoEstadoCivil;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoNacionalidad;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoTipo;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoTributos;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoOcupacion;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoFinanciera;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoPerfilFinanciera;
        private System.Windows.Forms.ToolStripMenuItem mnuMtoTipoFinanciera;
        private System.Windows.Forms.ToolStripMenuItem mnuTransacion;
        private System.Windows.Forms.ToolStripMenuItem mnuTscOrdenPedido;
    }
}



