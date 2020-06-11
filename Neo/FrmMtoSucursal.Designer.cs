namespace Neo
{
    partial class FrmMtoSucursal
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
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label grabadaLabel;
            System.Windows.Forms.Label equipoLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoPaisLabel;
            System.Windows.Forms.Label nombreProvinciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoSucursal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblGrabada = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grabadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.taPais = new Neo.DsNeoTableAdapters.taPais();
            this.taProvincia = new Neo.DsNeoTableAdapters.taProvincia();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            grabadaLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            codigoPaisLabel = new System.Windows.Forms.Label();
            nombreProvinciaLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(43, 222);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 6;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(38, 247);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 7;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(46, 273);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(43, 13);
            codigoSucursalLabel.TabIndex = 8;
            codigoSucursalLabel.Text = "Código:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(40, 27);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(32, 72);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "Dirección:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(12, 98);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 12;
            codigoPostalLabel.Text = "Código Postal:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(43, 299);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 16;
            usuarioLabel.Text = "Usuario:";
            // 
            // grabadaLabel
            // 
            grabadaLabel.AutoSize = true;
            grabadaLabel.Location = new System.Drawing.Point(38, 325);
            grabadaLabel.Name = "grabadaLabel";
            grabadaLabel.Size = new System.Drawing.Size(51, 13);
            grabadaLabel.TabIndex = 17;
            grabadaLabel.Text = "Grabada:";
            grabadaLabel.Click += new System.EventHandler(this.grabadaLabel_Click);
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(46, 350);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 19;
            equipoLabel.Text = "Equipo:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(45, 197);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 21;
            activoLabel.Text = "Activo:";
            // 
            // codigoPaisLabel
            // 
            codigoPaisLabel.AutoSize = true;
            codigoPaisLabel.Location = new System.Drawing.Point(54, 125);
            codigoPaisLabel.Name = "codigoPaisLabel";
            codigoPaisLabel.Size = new System.Drawing.Size(32, 13);
            codigoPaisLabel.TabIndex = 23;
            codigoPaisLabel.Text = "País:";
            // 
            // nombreProvinciaLabel
            // 
            nombreProvinciaLabel.AutoSize = true;
            nombreProvinciaLabel.Location = new System.Drawing.Point(33, 151);
            nombreProvinciaLabel.Name = "nombreProvinciaLabel";
            nombreProvinciaLabel.Size = new System.Drawing.Size(54, 13);
            nombreProvinciaLabel.TabIndex = 25;
            nombreProvinciaLabel.Text = "Provincia:";
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
            this.pnl3.Size = new System.Drawing.Size(611, 393);
            this.pnl3.TabIndex = 7;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(nombreProvinciaLabel);
            this.pnl6.Controls.Add(this.cboProvincia);
            this.pnl6.Controls.Add(codigoPaisLabel);
            this.pnl6.Controls.Add(this.cboPais);
            this.pnl6.Controls.Add(activoLabel);
            this.pnl6.Controls.Add(this.chkActivo);
            this.pnl6.Controls.Add(equipoLabel);
            this.pnl6.Controls.Add(this.lblEquipo);
            this.pnl6.Controls.Add(grabadaLabel);
            this.pnl6.Controls.Add(this.lblGrabada);
            this.pnl6.Controls.Add(usuarioLabel);
            this.pnl6.Controls.Add(this.lblUsuario);
            this.pnl6.Controls.Add(this.label3);
            this.pnl6.Controls.Add(codigoPostalLabel);
            this.pnl6.Controls.Add(this.txtCodigoPostal);
            this.pnl6.Controls.Add(direccionLabel);
            this.pnl6.Controls.Add(this.txtDireccion);
            this.pnl6.Controls.Add(nombreLabel);
            this.pnl6.Controls.Add(this.txtNombre);
            this.pnl6.Controls.Add(codigoSucursalLabel);
            this.pnl6.Controls.Add(this.lblCodigo);
            this.pnl6.Controls.Add(codigoEmpresaLabel);
            this.pnl6.Controls.Add(this.lblEmpresa);
            this.pnl6.Controls.Add(codigoTrabajoLabel);
            this.pnl6.Controls.Add(this.lblTrabajo);
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Controls.Add(this.label1);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(293, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(311, 381);
            this.pnl6.TabIndex = 6;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreProvincia", true));
            this.cboProvincia.DataSource = this.dsNeo;
            this.cboProvincia.DisplayMember = "tbProvincia.NombreProvincia";
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(89, 148);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(191, 21);
            this.cboProvincia.TabIndex = 26;
            this.cboProvincia.ValueMember = "tbProvincia.NombreProvincia";
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbSucursal";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboPais
            // 
            this.cboPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoPais", true));
            this.cboPais.DataSource = this.dsNeo;
            this.cboPais.DisplayMember = "tbPais.CodigoPais";
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(89, 121);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(191, 21);
            this.cboPais.TabIndex = 24;
            this.cboPais.ValueMember = "tbPais.CodigoPais";
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(91, 192);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(104, 24);
            this.chkActivo.TabIndex = 22;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(91, 347);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(189, 20);
            this.lblEquipo.TabIndex = 20;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrabada
            // 
            this.lblGrabada.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrabada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrabada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Grabada", true));
            this.lblGrabada.Location = new System.Drawing.Point(91, 321);
            this.lblGrabada.Name = "lblGrabada";
            this.lblGrabada.Size = new System.Drawing.Size(189, 20);
            this.lblGrabada.TabIndex = 18;
            this.lblGrabada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(91, 296);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(189, 20);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Domicilio";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoPostal", true));
            this.txtCodigoPostal.Location = new System.Drawing.Point(89, 95);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(191, 20);
            this.txtCodigoPostal.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Direccion", true));
            this.txtDireccion.Location = new System.Drawing.Point(89, 69);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(191, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(89, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoSucursal", true));
            this.lblCodigo.Location = new System.Drawing.Point(91, 270);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(189, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(91, 244);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(189, 20);
            this.lblEmpresa.TabIndex = 8;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(91, 219);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(189, 20);
            this.lblTrabajo.TabIndex = 7;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(283, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 381);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(278, 381);
            this.pnl4.TabIndex = 4;
            // 
            // grdMto
            // 
            this.grdMto.AllowUserToAddRows = false;
            this.grdMto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.codigoSucursalDataGridViewTextBoxColumn,
            this.codigoPaisDataGridViewTextBoxColumn,
            this.sProvincia,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.grabadaDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(276, 379);
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
            // codigoSucursalDataGridViewTextBoxColumn
            // 
            this.codigoSucursalDataGridViewTextBoxColumn.DataPropertyName = "CodigoSucursal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoSucursalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoSucursalDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoSucursalDataGridViewTextBoxColumn.Name = "codigoSucursalDataGridViewTextBoxColumn";
            this.codigoSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoSucursalDataGridViewTextBoxColumn.Width = 50;
            // 
            // codigoPaisDataGridViewTextBoxColumn
            // 
            this.codigoPaisDataGridViewTextBoxColumn.DataPropertyName = "CodigoPais";
            this.codigoPaisDataGridViewTextBoxColumn.HeaderText = "CodigoPais";
            this.codigoPaisDataGridViewTextBoxColumn.Name = "codigoPaisDataGridViewTextBoxColumn";
            this.codigoPaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPaisDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProvincia
            // 
            this.sProvincia.DataPropertyName = "NombreProvincia";
            this.sProvincia.HeaderText = "NombreProvincia";
            this.sProvincia.Name = "sProvincia";
            this.sProvincia.ReadOnly = true;
            this.sProvincia.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 160;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // grabadaDataGridViewTextBoxColumn
            // 
            this.grabadaDataGridViewTextBoxColumn.DataPropertyName = "Grabada";
            this.grabadaDataGridViewTextBoxColumn.HeaderText = "Grabada";
            this.grabadaDataGridViewTextBoxColumn.Name = "grabadaDataGridViewTextBoxColumn";
            this.grabadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.grabadaDataGridViewTextBoxColumn.Visible = false;
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
            this.pnl2.Size = new System.Drawing.Size(611, 10);
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
            this.pnl1.Size = new System.Drawing.Size(611, 28);
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
            this.bnMto.Size = new System.Drawing.Size(609, 25);
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
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FrmMtoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 431);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoSucursal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoSucursal_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
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

        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.BindingSource bsMto;
        private DsNeo dsNeo;
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
        private DsNeoTableAdapters.taSucursal taSucursal;
        private DsNeoTableAdapters.taPais taPais;
        private DsNeoTableAdapters.taProvincia taProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblGrabada;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grabadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ErrorProvider ep;
    }
}