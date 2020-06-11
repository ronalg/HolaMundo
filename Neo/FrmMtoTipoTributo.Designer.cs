namespace Neo
{
    partial class FrmMtoTipoTributo
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
            System.Windows.Forms.Label codigoTipoTributoLabel;
            System.Windows.Forms.Label nombreTributoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label tasaLabel;
            System.Windows.Forms.Label desdeLabel;
            System.Windows.Forms.Label hastaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoTipoTributo));
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTributo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.taTipoTributo = new Neo.DsNeoTableAdapters.taTipoTributo();
            this.taTributo = new Neo.DsNeoTableAdapters.taTributo();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTributoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            codigoTipoTributoLabel = new System.Windows.Forms.Label();
            nombreTributoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            tasaLabel = new System.Windows.Forms.Label();
            desdeLabel = new System.Windows.Forms.Label();
            hastaLabel = new System.Windows.Forms.Label();
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
            codigoTrabajoLabel.Location = new System.Drawing.Point(24, 188);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 6;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(19, 217);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 7;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // codigoTipoTributoLabel
            // 
            codigoTipoTributoLabel.AutoSize = true;
            codigoTipoTributoLabel.Location = new System.Drawing.Point(32, 30);
            codigoTipoTributoLabel.Name = "codigoTipoTributoLabel";
            codigoTipoTributoLabel.Size = new System.Drawing.Size(43, 13);
            codigoTipoTributoLabel.TabIndex = 8;
            codigoTipoTributoLabel.Text = "Código:";
            // 
            // nombreTributoLabel
            // 
            nombreTributoLabel.AutoSize = true;
            nombreTributoLabel.Location = new System.Drawing.Point(32, 56);
            nombreTributoLabel.Name = "nombreTributoLabel";
            nombreTributoLabel.Size = new System.Drawing.Size(43, 13);
            nombreTributoLabel.TabIndex = 9;
            nombreTributoLabel.Text = "Tributo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(9, 83);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 10;
            descripcionLabel.Text = "Descripcion:";
            // 
            // tasaLabel
            // 
            tasaLabel.AutoSize = true;
            tasaLabel.Location = new System.Drawing.Point(24, 109);
            tasaLabel.Name = "tasaLabel";
            tasaLabel.Size = new System.Drawing.Size(51, 13);
            tasaLabel.TabIndex = 12;
            tasaLabel.Text = "Tasa (%):";
            // 
            // desdeLabel
            // 
            desdeLabel.AutoSize = true;
            desdeLabel.Location = new System.Drawing.Point(34, 136);
            desdeLabel.Name = "desdeLabel";
            desdeLabel.Size = new System.Drawing.Size(41, 13);
            desdeLabel.TabIndex = 14;
            desdeLabel.Text = "Desde:";
            // 
            // hastaLabel
            // 
            hastaLabel.AutoSize = true;
            hastaLabel.Location = new System.Drawing.Point(187, 136);
            hastaLabel.Name = "hastaLabel";
            hastaLabel.Size = new System.Drawing.Size(38, 13);
            hastaLabel.TabIndex = 16;
            hastaLabel.Text = "Hasta:";
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
            this.pnl3.Size = new System.Drawing.Size(689, 412);
            this.pnl3.TabIndex = 11;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(hastaLabel);
            this.pnl6.Controls.Add(this.dtpHasta);
            this.pnl6.Controls.Add(desdeLabel);
            this.pnl6.Controls.Add(this.dtpDesde);
            this.pnl6.Controls.Add(tasaLabel);
            this.pnl6.Controls.Add(this.txtTasa);
            this.pnl6.Controls.Add(descripcionLabel);
            this.pnl6.Controls.Add(this.txtDescripcion);
            this.pnl6.Controls.Add(nombreTributoLabel);
            this.pnl6.Controls.Add(this.cboTributo);
            this.pnl6.Controls.Add(codigoTipoTributoLabel);
            this.pnl6.Controls.Add(this.txtCodigo);
            this.pnl6.Controls.Add(codigoEmpresaLabel);
            this.pnl6.Controls.Add(this.lblEmpresa);
            this.pnl6.Controls.Add(codigoTrabajoLabel);
            this.pnl6.Controls.Add(this.lblTrabajo);
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Controls.Add(this.label1);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(293, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(389, 400);
            this.pnl6.TabIndex = 6;
            // 
            // dtpHasta
            // 
            this.dtpHasta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMto, "Hasta", true));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(227, 132);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpHasta.TabIndex = 17;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbTipoTributo";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDesde
            // 
            this.dtpDesde.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMto, "Desde", true));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(77, 132);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpDesde.TabIndex = 15;
            // 
            // txtTasa
            // 
            this.txtTasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Tasa", true));
            this.txtTasa.Location = new System.Drawing.Point(77, 106);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(247, 20);
            this.txtTasa.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(77, 80);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(247, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // cboTributo
            // 
            this.cboTributo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreTributo", true));
            this.cboTributo.DataSource = this.dsNeo;
            this.cboTributo.DisplayMember = "tbTributo.NombreTributo";
            this.cboTributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTributo.FormattingEnabled = true;
            this.cboTributo.Location = new System.Drawing.Point(77, 53);
            this.cboTributo.Name = "cboTributo";
            this.cboTributo.Size = new System.Drawing.Size(247, 21);
            this.cboTributo.TabIndex = 10;
            this.cboTributo.ValueMember = "tbTributo.NombreTributo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTipoTributo", true));
            this.txtCodigo.Location = new System.Drawing.Point(77, 27);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(247, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(72, 214);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(73, 20);
            this.lblEmpresa.TabIndex = 8;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(72, 185);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(73, 20);
            this.lblTrabajo.TabIndex = 7;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 163);
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
            this.pnl5.Size = new System.Drawing.Size(10, 400);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(278, 400);
            this.pnl4.TabIndex = 4;
            // 
            // grdMto
            // 
            this.grdMto.AllowUserToAddRows = false;
            this.grdMto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.grdMto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMto.AutoGenerateColumns = false;
            this.grdMto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTrabajoDataGridViewTextBoxColumn,
            this.codigoEmpresaDataGridViewTextBoxColumn,
            this.tbCodigo,
            this.nombreTributoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tasaDataGridViewTextBoxColumn,
            this.desdeDataGridViewTextBoxColumn,
            this.hastaDataGridViewTextBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(276, 398);
            this.grdMto.TabIndex = 3;
            this.grdMto.SelectionChanged += new System.EventHandler(this.grdMto_SelectionChanged);
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(689, 10);
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
            this.pnl1.Size = new System.Drawing.Size(689, 28);
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
            this.bnMto.Size = new System.Drawing.Size(687, 25);
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
            // taTipoTributo
            // 
            this.taTipoTributo.ClearBeforeFill = true;
            // 
            // taTributo
            // 
            this.taTributo.ClearBeforeFill = true;
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
            // tbCodigo
            // 
            this.tbCodigo.DataPropertyName = "CodigoTipoTributo";
            this.tbCodigo.HeaderText = "Código";
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Width = 210;
            // 
            // nombreTributoDataGridViewTextBoxColumn
            // 
            this.nombreTributoDataGridViewTextBoxColumn.DataPropertyName = "NombreTributo";
            this.nombreTributoDataGridViewTextBoxColumn.HeaderText = "NombreTributo";
            this.nombreTributoDataGridViewTextBoxColumn.Name = "nombreTributoDataGridViewTextBoxColumn";
            this.nombreTributoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTributoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // tasaDataGridViewTextBoxColumn
            // 
            this.tasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa";
            this.tasaDataGridViewTextBoxColumn.HeaderText = "Tasa";
            this.tasaDataGridViewTextBoxColumn.Name = "tasaDataGridViewTextBoxColumn";
            this.tasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tasaDataGridViewTextBoxColumn.Visible = false;
            // 
            // desdeDataGridViewTextBoxColumn
            // 
            this.desdeDataGridViewTextBoxColumn.DataPropertyName = "Desde";
            this.desdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.desdeDataGridViewTextBoxColumn.Name = "desdeDataGridViewTextBoxColumn";
            this.desdeDataGridViewTextBoxColumn.ReadOnly = true;
            this.desdeDataGridViewTextBoxColumn.Visible = false;
            // 
            // hastaDataGridViewTextBoxColumn
            // 
            this.hastaDataGridViewTextBoxColumn.DataPropertyName = "Hasta";
            this.hastaDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.hastaDataGridViewTextBoxColumn.Name = "hastaDataGridViewTextBoxColumn";
            this.hastaDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmMtoTipoTributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoTipoTributo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Tributo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoTipoTributo_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoTipoTributo_Load);
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

        private System.Windows.Forms.ToolStripSeparator spd4;
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
        private DsNeoTableAdapters.taTipoTributo taTipoTributo;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboTributo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private DsNeoTableAdapters.taTributo taTributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTributoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDataGridViewTextBoxColumn;
    }
}