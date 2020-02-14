namespace Neo
{
    partial class FrmMtoEmpresa
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
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label abreviaturaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label lemaPublicitarioLabel;
            System.Windows.Forms.Label sitioWebLabel;
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label grabadaLabel;
            System.Windows.Forms.Label equipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoEmpresa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.lblGrabada = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.btnBorrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBuscar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.txtLemaPublicitario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cboIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCodigoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreviaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lemaPublicitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.taEmpresa = new Neo.DsNeoTableAdapters.taEmpresa();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.taIdentificacion = new Neo.DsNeoTableAdapters.taIdentificacion();
            this.tableAdapterManager = new Neo.DsNeoTableAdapters.TableAdapterManager();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            abreviaturaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            lemaPublicitarioLabel = new System.Windows.Forms.Label();
            sitioWebLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            grabadaLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(73, 28);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(43, 13);
            codigoEmpresaLabel.TabIndex = 2;
            codigoEmpresaLabel.Text = "Código:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(69, 54);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(43, 80);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 6;
            razonSocialLabel.Text = "Razón Social:";
            // 
            // abreviaturaLabel
            // 
            abreviaturaLabel.AutoSize = true;
            abreviaturaLabel.Location = new System.Drawing.Point(52, 106);
            abreviaturaLabel.Name = "abreviaturaLabel";
            abreviaturaLabel.Size = new System.Drawing.Size(64, 13);
            abreviaturaLabel.TabIndex = 8;
            abreviaturaLabel.Text = "Abreviatura:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(50, 162);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 12;
            descripcionLabel.Text = "Descripción:";
            // 
            // lemaPublicitarioLabel
            // 
            lemaPublicitarioLabel.AutoSize = true;
            lemaPublicitarioLabel.Location = new System.Drawing.Point(26, 188);
            lemaPublicitarioLabel.Name = "lemaPublicitarioLabel";
            lemaPublicitarioLabel.Size = new System.Drawing.Size(90, 13);
            lemaPublicitarioLabel.TabIndex = 14;
            lemaPublicitarioLabel.Text = "Lema Publicitario:";
            // 
            // sitioWebLabel
            // 
            sitioWebLabel.AutoSize = true;
            sitioWebLabel.Location = new System.Drawing.Point(60, 214);
            sitioWebLabel.Name = "sitioWebLabel";
            sitioWebLabel.Size = new System.Drawing.Size(56, 13);
            sitioWebLabel.TabIndex = 16;
            sitioWebLabel.Text = "Sitio Web:";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(355, 28);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(34, 13);
            logoLabel.TabIndex = 18;
            logoLabel.Text = "Logo:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(72, 366);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 24;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(71, 287);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 26;
            usuarioLabel.Text = "Usuario:";
            // 
            // grabadaLabel
            // 
            grabadaLabel.AutoSize = true;
            grabadaLabel.Location = new System.Drawing.Point(65, 313);
            grabadaLabel.Name = "grabadaLabel";
            grabadaLabel.Size = new System.Drawing.Size(51, 13);
            grabadaLabel.TabIndex = 28;
            grabadaLabel.Text = "Grabada:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(74, 340);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 30;
            equipoLabel.Text = "Equipo:";
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
            this.pnl3.Size = new System.Drawing.Size(916, 420);
            this.pnl3.TabIndex = 7;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(equipoLabel);
            this.pnl6.Controls.Add(this.lblEquipo);
            this.pnl6.Controls.Add(grabadaLabel);
            this.pnl6.Controls.Add(this.lblGrabada);
            this.pnl6.Controls.Add(usuarioLabel);
            this.pnl6.Controls.Add(this.lblUsuario);
            this.pnl6.Controls.Add(codigoTrabajoLabel);
            this.pnl6.Controls.Add(this.lblTrabajo);
            this.pnl6.Controls.Add(this.btnBorrar);
            this.pnl6.Controls.Add(this.btnBuscar);
            this.pnl6.Controls.Add(this.label3);
            this.pnl6.Controls.Add(this.chkActivo);
            this.pnl6.Controls.Add(logoLabel);
            this.pnl6.Controls.Add(this.pbLogo);
            this.pnl6.Controls.Add(sitioWebLabel);
            this.pnl6.Controls.Add(this.txtSitioWeb);
            this.pnl6.Controls.Add(lemaPublicitarioLabel);
            this.pnl6.Controls.Add(this.txtLemaPublicitario);
            this.pnl6.Controls.Add(descripcionLabel);
            this.pnl6.Controls.Add(this.txtDescripcion);
            this.pnl6.Controls.Add(this.txtIdentificacion);
            this.pnl6.Controls.Add(this.cboIdentificacion);
            this.pnl6.Controls.Add(abreviaturaLabel);
            this.pnl6.Controls.Add(this.txtAbreviatura);
            this.pnl6.Controls.Add(razonSocialLabel);
            this.pnl6.Controls.Add(this.txtRazonSocial);
            this.pnl6.Controls.Add(nombreLabel);
            this.pnl6.Controls.Add(this.txtNombre);
            this.pnl6.Controls.Add(codigoEmpresaLabel);
            this.pnl6.Controls.Add(this.lblCodigo);
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Controls.Add(this.label1);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(332, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(577, 408);
            this.pnl6.TabIndex = 6;
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(119, 337);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(207, 20);
            this.lblEquipo.TabIndex = 31;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbEmpresa";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGrabada
            // 
            this.lblGrabada.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrabada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrabada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Grabada", true));
            this.lblGrabada.Location = new System.Drawing.Point(119, 310);
            this.lblGrabada.Name = "lblGrabada";
            this.lblGrabada.Size = new System.Drawing.Size(207, 20);
            this.lblGrabada.TabIndex = 29;
            this.lblGrabada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(119, 284);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(207, 20);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(120, 363);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(206, 20);
            this.lblTrabajo.TabIndex = 25;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(395, 202);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(54, 25);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Values.Text = "Eliminar";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(508, 202);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 25);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Values.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Otros";
            // 
            // chkActivo
            // 
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Activo", true));
            this.chkActivo.Location = new System.Drawing.Point(67, 257);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(64, 24);
            this.chkActivo.TabIndex = 21;
            this.chkActivo.Text = "Activo:";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsMto, "Logo", true));
            this.pbLogo.Location = new System.Drawing.Point(395, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(167, 168);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 19;
            this.pbLogo.TabStop = false;
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "SitioWeb", true));
            this.txtSitioWeb.Location = new System.Drawing.Point(118, 211);
            this.txtSitioWeb.MaxLength = 100;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(206, 20);
            this.txtSitioWeb.TabIndex = 17;
            // 
            // txtLemaPublicitario
            // 
            this.txtLemaPublicitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "LemaPublicitario", true));
            this.txtLemaPublicitario.Location = new System.Drawing.Point(118, 185);
            this.txtLemaPublicitario.MaxLength = 200;
            this.txtLemaPublicitario.Name = "txtLemaPublicitario";
            this.txtLemaPublicitario.Size = new System.Drawing.Size(206, 20);
            this.txtLemaPublicitario.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(118, 159);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Identificacion", true));
            this.txtIdentificacion.Location = new System.Drawing.Point(118, 132);
            this.txtIdentificacion.MaxLength = 30;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(206, 20);
            this.txtIdentificacion.TabIndex = 12;
            // 
            // cboIdentificacion
            // 
            this.cboIdentificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoIdentificacion", true));
            this.cboIdentificacion.DataSource = this.dsNeo;
            this.cboIdentificacion.DisplayMember = "tbIdentificacion.CodigoIdentificacion";
            this.cboIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdentificacion.FormattingEnabled = true;
            this.cboIdentificacion.Location = new System.Drawing.Point(14, 132);
            this.cboIdentificacion.Name = "cboIdentificacion";
            this.cboIdentificacion.Size = new System.Drawing.Size(96, 21);
            this.cboIdentificacion.TabIndex = 11;
            this.cboIdentificacion.ValueMember = "tbIdentificacion.CodigoIdentificacion";
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Abreviatura", true));
            this.txtAbreviatura.Location = new System.Drawing.Point(118, 103);
            this.txtAbreviatura.MaxLength = 20;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(206, 20);
            this.txtAbreviatura.TabIndex = 9;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "RazonSocial", true));
            this.txtRazonSocial.Location = new System.Drawing.Point(118, 77);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(206, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(118, 51);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(118, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(206, 20);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
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
            this.pnl5.Location = new System.Drawing.Point(322, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 408);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(317, 408);
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
            this.eCodigo,
            this.eCodigoIdentificacion,
            this.eNombre,
            this.razonSocialDataGridViewTextBoxColumn,
            this.abreviaturaDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.lemaPublicitarioDataGridViewTextBoxColumn,
            this.sitioWebDataGridViewTextBoxColumn,
            this.logoDataGridViewImageColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.grabadaDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(315, 406);
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
            // eCodigo
            // 
            this.eCodigo.DataPropertyName = "CodigoEmpresa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.eCodigo.HeaderText = "Código";
            this.eCodigo.Name = "eCodigo";
            this.eCodigo.ReadOnly = true;
            this.eCodigo.Width = 50;
            // 
            // eCodigoIdentificacion
            // 
            this.eCodigoIdentificacion.DataPropertyName = "CodigoIdentificacion";
            this.eCodigoIdentificacion.HeaderText = "CodigoIdentificacion";
            this.eCodigoIdentificacion.Name = "eCodigoIdentificacion";
            this.eCodigoIdentificacion.ReadOnly = true;
            this.eCodigoIdentificacion.Visible = false;
            // 
            // eNombre
            // 
            this.eNombre.DataPropertyName = "Nombre";
            this.eNombre.HeaderText = "Nombre";
            this.eNombre.Name = "eNombre";
            this.eNombre.ReadOnly = true;
            this.eNombre.Width = 200;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Visible = false;
            // 
            // abreviaturaDataGridViewTextBoxColumn
            // 
            this.abreviaturaDataGridViewTextBoxColumn.DataPropertyName = "Abreviatura";
            this.abreviaturaDataGridViewTextBoxColumn.HeaderText = "Abreviatura";
            this.abreviaturaDataGridViewTextBoxColumn.Name = "abreviaturaDataGridViewTextBoxColumn";
            this.abreviaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.abreviaturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // lemaPublicitarioDataGridViewTextBoxColumn
            // 
            this.lemaPublicitarioDataGridViewTextBoxColumn.DataPropertyName = "LemaPublicitario";
            this.lemaPublicitarioDataGridViewTextBoxColumn.HeaderText = "LemaPublicitario";
            this.lemaPublicitarioDataGridViewTextBoxColumn.Name = "lemaPublicitarioDataGridViewTextBoxColumn";
            this.lemaPublicitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.lemaPublicitarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // sitioWebDataGridViewTextBoxColumn
            // 
            this.sitioWebDataGridViewTextBoxColumn.DataPropertyName = "SitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.HeaderText = "SitioWeb";
            this.sitioWebDataGridViewTextBoxColumn.Name = "sitioWebDataGridViewTextBoxColumn";
            this.sitioWebDataGridViewTextBoxColumn.ReadOnly = true;
            this.sitioWebDataGridViewTextBoxColumn.Visible = false;
            // 
            // logoDataGridViewImageColumn
            // 
            this.logoDataGridViewImageColumn.DataPropertyName = "Logo";
            this.logoDataGridViewImageColumn.HeaderText = "Logo";
            this.logoDataGridViewImageColumn.Name = "logoDataGridViewImageColumn";
            this.logoDataGridViewImageColumn.ReadOnly = true;
            this.logoDataGridViewImageColumn.Visible = false;
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
            this.pnl2.Size = new System.Drawing.Size(916, 10);
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
            this.pnl1.Size = new System.Drawing.Size(916, 28);
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
            this.bnMto.Size = new System.Drawing.Size(914, 25);
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
            this.btnAnterior.Text = "0";
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
            // taEmpresa
            // 
            this.taEmpresa.ClearBeforeFill = true;
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            // 
            // taIdentificacion
            // 
            this.taIdentificacion.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taEmpresa = this.taEmpresa;
            this.tableAdapterManager.taIdentificacion = this.taIdentificacion;
            this.tableAdapterManager.taPais = null;
            this.tableAdapterManager.taTrabajo = null;
            this.tableAdapterManager.UpdateOrder = Neo.DsNeoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmMtoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 458);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoEmpresa_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdMto;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ToolStripSeparator spd4;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.BindingNavigator bnMto;
        private System.Windows.Forms.ToolStripLabel lblRegistro;
        private System.Windows.Forms.ToolStripButton btnPrimero;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripSeparator spd1;
        private System.Windows.Forms.ToolStripTextBox txtPosicion;
        private System.Windows.Forms.ToolStripSeparator spd2;
        private System.Windows.Forms.ToolStripButton btnSiguiente;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator spd3;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private DsNeoTableAdapters.taEmpresa taEmpresa;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBorrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.TextBox txtLemaPublicitario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cboIdentificacion;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private DsNeoTableAdapters.taIdentificacion taIdentificacion;
        private DsNeoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblGrabada;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCodigoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lemaPublicitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grabadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}