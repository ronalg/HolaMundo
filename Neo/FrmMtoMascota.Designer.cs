namespace Neo
{
    partial class FrmMtoMascota
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
            System.Windows.Forms.Label nombreGrupoLabel;
            System.Windows.Forms.Label nombreRazaLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label nombreEstadoLabel;
            System.Windows.Forms.Label nombreCaracterLabel;
            System.Windows.Forms.Label nombrePelajeLabel;
            System.Windows.Forms.Label nombreGrupoSanguineoLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label nacimientoLabel;
            System.Windows.Forms.Label corteOrejaLabel;
            System.Windows.Forms.Label corteColaLabel;
            System.Windows.Forms.Label castradoLabel;
            System.Windows.Forms.Label exhibicionLabel;
            System.Windows.Forms.Label dietaLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label nombreDuenoLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label aperturaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label equipoLabel;
            System.Windows.Forms.Label codigoMascotaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label codigoTrabajoLabel;
            System.Windows.Forms.Label codigoEmpresaLabel;
            System.Windows.Forms.Label pedigriLabel;
            System.Windows.Forms.Label peluqueriaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMtoMascota));
            this.spd4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.tcMascota = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.tpMascota = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.chkPeluqueria = new System.Windows.Forms.CheckBox();
            this.bsMto = new System.Windows.Forms.BindingSource(this.components);
            this.dsNeo = new Neo.DsNeo();
            this.txtPedigri = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtApertura = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnQuitar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDueno = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtBusca = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtDieta = new System.Windows.Forms.TextBox();
            this.chkExhibicion = new System.Windows.Forms.CheckBox();
            this.chkCastrado = new System.Windows.Forms.CheckBox();
            this.chkCorteCola = new System.Windows.Forms.CheckBox();
            this.chkCorteOreja = new System.Windows.Forms.CheckBox();
            this.txtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cboSanguineo = new System.Windows.Forms.ComboBox();
            this.cboPelaje = new System.Windows.Forms.ComboBox();
            this.cboCaracter = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpCita = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tpHistorial = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.grdMto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigoTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDuenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVeterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCaracterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePelajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedigriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corteOrejaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.corteColaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.castradoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.peluqueriaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exhibicionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dietaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.taMascota = new Neo.DsNeoTableAdapters.taMascota();
            this.taGrupo = new Neo.DsNeoTableAdapters.taGrupo();
            this.taRaza = new Neo.DsNeoTableAdapters.taRaza();
            this.taCaracter = new Neo.DsNeoTableAdapters.taCaracter();
            this.taPelaje = new Neo.DsNeoTableAdapters.taPelaje();
            this.taGrupoSanguineo = new Neo.DsNeoTableAdapters.taGrupoSanguineo();
            this.taSucursal = new Neo.DsNeoTableAdapters.taSucursal();
            this.tableAdapterManager = new Neo.DsNeoTableAdapters.TableAdapterManager();
            nombreLabel = new System.Windows.Forms.Label();
            nombreGrupoLabel = new System.Windows.Forms.Label();
            nombreRazaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            nombreEstadoLabel = new System.Windows.Forms.Label();
            nombreCaracterLabel = new System.Windows.Forms.Label();
            nombrePelajeLabel = new System.Windows.Forms.Label();
            nombreGrupoSanguineoLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            nacimientoLabel = new System.Windows.Forms.Label();
            corteOrejaLabel = new System.Windows.Forms.Label();
            corteColaLabel = new System.Windows.Forms.Label();
            castradoLabel = new System.Windows.Forms.Label();
            exhibicionLabel = new System.Windows.Forms.Label();
            dietaLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            codigoClienteLabel = new System.Windows.Forms.Label();
            nombreDuenoLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            aperturaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            codigoMascotaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            codigoTrabajoLabel = new System.Windows.Forms.Label();
            codigoEmpresaLabel = new System.Windows.Forms.Label();
            pedigriLabel = new System.Windows.Forms.Label();
            peluqueriaLabel = new System.Windows.Forms.Label();
            this.pnl3.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMascota)).BeginInit();
            this.tcMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpMascota)).BeginInit();
            this.tpMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpHistorial)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMto)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMto)).BeginInit();
            this.bnMto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(60, 31);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreGrupoLabel
            // 
            nombreGrupoLabel.AutoSize = true;
            nombreGrupoLabel.Location = new System.Drawing.Point(68, 57);
            nombreGrupoLabel.Name = "nombreGrupoLabel";
            nombreGrupoLabel.Size = new System.Drawing.Size(39, 13);
            nombreGrupoLabel.TabIndex = 3;
            nombreGrupoLabel.Text = "Grupo:";
            // 
            // nombreRazaLabel
            // 
            nombreRazaLabel.AutoSize = true;
            nombreRazaLabel.Location = new System.Drawing.Point(72, 84);
            nombreRazaLabel.Name = "nombreRazaLabel";
            nombreRazaLabel.Size = new System.Drawing.Size(35, 13);
            nombreRazaLabel.TabIndex = 5;
            nombreRazaLabel.Text = "Raza:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(73, 111);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 7;
            sexoLabel.Text = "Sexo:";
            // 
            // nombreEstadoLabel
            // 
            nombreEstadoLabel.AutoSize = true;
            nombreEstadoLabel.Location = new System.Drawing.Point(64, 164);
            nombreEstadoLabel.Name = "nombreEstadoLabel";
            nombreEstadoLabel.Size = new System.Drawing.Size(43, 13);
            nombreEstadoLabel.TabIndex = 9;
            nombreEstadoLabel.Text = "Estado:";
            // 
            // nombreCaracterLabel
            // 
            nombreCaracterLabel.AutoSize = true;
            nombreCaracterLabel.Location = new System.Drawing.Point(57, 191);
            nombreCaracterLabel.Name = "nombreCaracterLabel";
            nombreCaracterLabel.Size = new System.Drawing.Size(50, 13);
            nombreCaracterLabel.TabIndex = 11;
            nombreCaracterLabel.Text = "Caracter:";
            // 
            // nombrePelajeLabel
            // 
            nombrePelajeLabel.AutoSize = true;
            nombrePelajeLabel.Location = new System.Drawing.Point(68, 218);
            nombrePelajeLabel.Name = "nombrePelajeLabel";
            nombrePelajeLabel.Size = new System.Drawing.Size(39, 13);
            nombrePelajeLabel.TabIndex = 13;
            nombrePelajeLabel.Text = "Pelaje:";
            // 
            // nombreGrupoSanguineoLabel
            // 
            nombreGrupoSanguineoLabel.AutoSize = true;
            nombreGrupoSanguineoLabel.Location = new System.Drawing.Point(14, 245);
            nombreGrupoSanguineoLabel.Name = "nombreGrupoSanguineoLabel";
            nombreGrupoSanguineoLabel.Size = new System.Drawing.Size(93, 13);
            nombreGrupoSanguineoLabel.TabIndex = 15;
            nombreGrupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(73, 272);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 17;
            colorLabel.Text = "Color:";
            // 
            // nacimientoLabel
            // 
            nacimientoLabel.AutoSize = true;
            nacimientoLabel.Location = new System.Drawing.Point(44, 138);
            nacimientoLabel.Name = "nacimientoLabel";
            nacimientoLabel.Size = new System.Drawing.Size(63, 13);
            nacimientoLabel.TabIndex = 19;
            nacimientoLabel.Text = "Nacimiento:";
            // 
            // corteOrejaLabel
            // 
            corteOrejaLabel.AutoSize = true;
            corteOrejaLabel.Location = new System.Drawing.Point(44, 325);
            corteOrejaLabel.Name = "corteOrejaLabel";
            corteOrejaLabel.Size = new System.Drawing.Size(63, 13);
            corteOrejaLabel.TabIndex = 21;
            corteOrejaLabel.Text = "Corte Oreja:";
            // 
            // corteColaLabel
            // 
            corteColaLabel.AutoSize = true;
            corteColaLabel.Location = new System.Drawing.Point(174, 325);
            corteColaLabel.Name = "corteColaLabel";
            corteColaLabel.Size = new System.Drawing.Size(59, 13);
            corteColaLabel.TabIndex = 23;
            corteColaLabel.Text = "Corte Cola:";
            // 
            // castradoLabel
            // 
            castradoLabel.AutoSize = true;
            castradoLabel.Location = new System.Drawing.Point(55, 352);
            castradoLabel.Name = "castradoLabel";
            castradoLabel.Size = new System.Drawing.Size(52, 13);
            castradoLabel.TabIndex = 25;
            castradoLabel.Text = "Castrado:";
            // 
            // exhibicionLabel
            // 
            exhibicionLabel.AutoSize = true;
            exhibicionLabel.Location = new System.Drawing.Point(174, 352);
            exhibicionLabel.Name = "exhibicionLabel";
            exhibicionLabel.Size = new System.Drawing.Size(58, 13);
            exhibicionLabel.TabIndex = 27;
            exhibicionLabel.Text = "Exhibición:";
            // 
            // dietaLabel
            // 
            dietaLabel.AutoSize = true;
            dietaLabel.Location = new System.Drawing.Point(72, 376);
            dietaLabel.Name = "dietaLabel";
            dietaLabel.Size = new System.Drawing.Size(35, 13);
            dietaLabel.TabIndex = 29;
            dietaLabel.Text = "Dieta:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(74, 402);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(33, 13);
            notaLabel.TabIndex = 31;
            notaLabel.Text = "Nota:";
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(286, 60);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(43, 13);
            codigoClienteLabel.TabIndex = 36;
            codigoClienteLabel.Text = "Código:";
            // 
            // nombreDuenoLabel
            // 
            nombreDuenoLabel.AutoSize = true;
            nombreDuenoLabel.Location = new System.Drawing.Point(285, 88);
            nombreDuenoLabel.Name = "nombreDuenoLabel";
            nombreDuenoLabel.Size = new System.Drawing.Size(47, 13);
            nombreDuenoLabel.TabIndex = 38;
            nombreDuenoLabel.Text = "Nombre:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(539, 31);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(45, 13);
            imagenLabel.TabIndex = 41;
            imagenLabel.Text = "Imagen:";
            // 
            // aperturaLabel
            // 
            aperturaLabel.AutoSize = true;
            aperturaLabel.Location = new System.Drawing.Point(534, 278);
            aperturaLabel.Name = "aperturaLabel";
            aperturaLabel.Size = new System.Drawing.Size(50, 13);
            aperturaLabel.TabIndex = 46;
            aperturaLabel.Text = "Apertura:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(538, 306);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 48;
            usuarioLabel.Text = "Usuario:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(541, 332);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 50;
            equipoLabel.Text = "Equipo:";
            // 
            // codigoMascotaLabel
            // 
            codigoMascotaLabel.AutoSize = true;
            codigoMascotaLabel.Location = new System.Drawing.Point(541, 358);
            codigoMascotaLabel.Name = "codigoMascotaLabel";
            codigoMascotaLabel.Size = new System.Drawing.Size(43, 13);
            codigoMascotaLabel.TabIndex = 52;
            codigoMascotaLabel.Text = "Código:";
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(535, 251);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 54;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // codigoTrabajoLabel
            // 
            codigoTrabajoLabel.AutoSize = true;
            codigoTrabajoLabel.Location = new System.Drawing.Point(538, 386);
            codigoTrabajoLabel.Name = "codigoTrabajoLabel";
            codigoTrabajoLabel.Size = new System.Drawing.Size(46, 13);
            codigoTrabajoLabel.TabIndex = 57;
            codigoTrabajoLabel.Text = "Trabajo:";
            // 
            // codigoEmpresaLabel
            // 
            codigoEmpresaLabel.AutoSize = true;
            codigoEmpresaLabel.Location = new System.Drawing.Point(640, 386);
            codigoEmpresaLabel.Name = "codigoEmpresaLabel";
            codigoEmpresaLabel.Size = new System.Drawing.Size(51, 13);
            codigoEmpresaLabel.TabIndex = 59;
            codigoEmpresaLabel.Text = "Empresa:";
            // 
            // pedigriLabel
            // 
            pedigriLabel.AutoSize = true;
            pedigriLabel.Location = new System.Drawing.Point(63, 298);
            pedigriLabel.Name = "pedigriLabel";
            pedigriLabel.Size = new System.Drawing.Size(44, 13);
            pedigriLabel.TabIndex = 61;
            pedigriLabel.Text = "Pedigrí:";
            // 
            // peluqueriaLabel
            // 
            peluqueriaLabel.AutoSize = true;
            peluqueriaLabel.Location = new System.Drawing.Point(522, 223);
            peluqueriaLabel.Name = "peluqueriaLabel";
            peluqueriaLabel.Size = new System.Drawing.Size(62, 13);
            peluqueriaLabel.TabIndex = 63;
            peluqueriaLabel.Text = "Peluquería:";
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
            this.pnl3.Size = new System.Drawing.Size(1235, 463);
            this.pnl3.TabIndex = 11;
            // 
            // pnl6
            // 
            this.pnl6.AutoScroll = true;
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.tcMascota);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(466, 5);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(762, 451);
            this.pnl6.TabIndex = 6;
            // 
            // tcMascota
            // 
            this.tcMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMascota.Location = new System.Drawing.Point(0, 0);
            this.tcMascota.Name = "tcMascota";
            this.tcMascota.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.tpMascota,
            this.tpCita,
            this.tpHistorial});
            this.tcMascota.SelectedIndex = 0;
            this.tcMascota.Size = new System.Drawing.Size(760, 449);
            this.tcMascota.TabIndex = 0;
            this.tcMascota.Text = "kryptonNavigator1";
            // 
            // tpMascota
            // 
            this.tpMascota.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpMascota.AutoScroll = true;
            this.tpMascota.Controls.Add(peluqueriaLabel);
            this.tpMascota.Controls.Add(this.chkPeluqueria);
            this.tpMascota.Controls.Add(pedigriLabel);
            this.tpMascota.Controls.Add(this.txtPedigri);
            this.tpMascota.Controls.Add(codigoEmpresaLabel);
            this.tpMascota.Controls.Add(this.lblEmpresa);
            this.tpMascota.Controls.Add(codigoTrabajoLabel);
            this.tpMascota.Controls.Add(this.lblTrabajo);
            this.tpMascota.Controls.Add(this.cboSucursal);
            this.tpMascota.Controls.Add(codigoSucursalLabel);
            this.tpMascota.Controls.Add(this.lblSucursal);
            this.tpMascota.Controls.Add(codigoMascotaLabel);
            this.tpMascota.Controls.Add(this.lblCodigo);
            this.tpMascota.Controls.Add(equipoLabel);
            this.tpMascota.Controls.Add(this.lblEquipo);
            this.tpMascota.Controls.Add(usuarioLabel);
            this.tpMascota.Controls.Add(this.lblUsuario);
            this.tpMascota.Controls.Add(aperturaLabel);
            this.tpMascota.Controls.Add(this.txtApertura);
            this.tpMascota.Controls.Add(this.label4);
            this.tpMascota.Controls.Add(this.btnBuscar);
            this.tpMascota.Controls.Add(this.btnQuitar);
            this.tpMascota.Controls.Add(imagenLabel);
            this.tpMascota.Controls.Add(this.pbImagen);
            this.tpMascota.Controls.Add(this.label3);
            this.tpMascota.Controls.Add(nombreDuenoLabel);
            this.tpMascota.Controls.Add(this.lblDueno);
            this.tpMascota.Controls.Add(codigoClienteLabel);
            this.tpMascota.Controls.Add(this.lblCliente);
            this.tpMascota.Controls.Add(this.txtBusca);
            this.tpMascota.Controls.Add(this.kryptonLabel1);
            this.tpMascota.Controls.Add(this.label2);
            this.tpMascota.Controls.Add(notaLabel);
            this.tpMascota.Controls.Add(this.txtNota);
            this.tpMascota.Controls.Add(dietaLabel);
            this.tpMascota.Controls.Add(this.txtDieta);
            this.tpMascota.Controls.Add(exhibicionLabel);
            this.tpMascota.Controls.Add(this.chkExhibicion);
            this.tpMascota.Controls.Add(castradoLabel);
            this.tpMascota.Controls.Add(this.chkCastrado);
            this.tpMascota.Controls.Add(corteColaLabel);
            this.tpMascota.Controls.Add(this.chkCorteCola);
            this.tpMascota.Controls.Add(corteOrejaLabel);
            this.tpMascota.Controls.Add(this.chkCorteOreja);
            this.tpMascota.Controls.Add(nacimientoLabel);
            this.tpMascota.Controls.Add(this.txtNacimiento);
            this.tpMascota.Controls.Add(colorLabel);
            this.tpMascota.Controls.Add(this.txtColor);
            this.tpMascota.Controls.Add(nombreGrupoSanguineoLabel);
            this.tpMascota.Controls.Add(this.cboSanguineo);
            this.tpMascota.Controls.Add(nombrePelajeLabel);
            this.tpMascota.Controls.Add(this.cboPelaje);
            this.tpMascota.Controls.Add(nombreCaracterLabel);
            this.tpMascota.Controls.Add(this.cboCaracter);
            this.tpMascota.Controls.Add(nombreEstadoLabel);
            this.tpMascota.Controls.Add(this.cboEstado);
            this.tpMascota.Controls.Add(sexoLabel);
            this.tpMascota.Controls.Add(this.cboSexo);
            this.tpMascota.Controls.Add(nombreRazaLabel);
            this.tpMascota.Controls.Add(this.cboRaza);
            this.tpMascota.Controls.Add(nombreGrupoLabel);
            this.tpMascota.Controls.Add(this.cboGrupo);
            this.tpMascota.Controls.Add(nombreLabel);
            this.tpMascota.Controls.Add(this.txtNombre);
            this.tpMascota.Controls.Add(this.label1);
            this.tpMascota.Flags = 65534;
            this.tpMascota.LastVisibleSet = true;
            this.tpMascota.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpMascota.Name = "tpMascota";
            this.tpMascota.Size = new System.Drawing.Size(758, 422);
            this.tpMascota.Text = "Mascota";
            this.tpMascota.ToolTipTitle = "Page ToolTip";
            this.tpMascota.UniqueName = "F1252336AC8144A62AA5D1393A2B66F2";
            this.tpMascota.Click += new System.EventHandler(this.tpMascota_Click);
            // 
            // chkPeluqueria
            // 
            this.chkPeluqueria.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Peluqueria", true));
            this.chkPeluqueria.Location = new System.Drawing.Point(590, 218);
            this.chkPeluqueria.Name = "chkPeluqueria";
            this.chkPeluqueria.Size = new System.Drawing.Size(104, 24);
            this.chkPeluqueria.TabIndex = 64;
            this.chkPeluqueria.UseVisualStyleBackColor = true;
            // 
            // bsMto
            // 
            this.bsMto.DataMember = "tbMascota";
            this.bsMto.DataSource = this.dsNeo;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPedigri
            // 
            this.txtPedigri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Pedigri", true));
            this.txtPedigri.Location = new System.Drawing.Point(113, 295);
            this.txtPedigri.Name = "txtPedigri";
            this.txtPedigri.Size = new System.Drawing.Size(143, 20);
            this.txtPedigri.TabIndex = 62;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoEmpresa", true));
            this.lblEmpresa.Location = new System.Drawing.Point(697, 383);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(42, 20);
            this.lblEmpresa.TabIndex = 60;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoTrabajo", true));
            this.lblTrabajo.Location = new System.Drawing.Point(590, 383);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(42, 20);
            this.lblTrabajo.TabIndex = 58;
            this.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DataSource = this.dsNeo;
            this.cboSucursal.DisplayMember = "tbSucursal.Nombre";
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(590, 248);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 21);
            this.cboSucursal.TabIndex = 47;
            this.cboSucursal.ValueMember = "tbSucursal.CodigoSucursal";
            this.cboSucursal.SelectedIndexChanged += new System.EventHandler(this.cboSucursal_SelectedIndexChanged);
            // 
            // lblSucursal
            // 
            this.lblSucursal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoSucursal", true));
            this.lblSucursal.Location = new System.Drawing.Point(717, 248);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(20, 20);
            this.lblSucursal.TabIndex = 55;
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoMascota", true));
            this.lblCodigo.Location = new System.Drawing.Point(590, 355);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(149, 20);
            this.lblCodigo.TabIndex = 53;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Equipo", true));
            this.lblEquipo.Location = new System.Drawing.Point(590, 328);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(149, 20);
            this.lblEquipo.TabIndex = 51;
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(590, 302);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(149, 20);
            this.lblUsuario.TabIndex = 49;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApertura
            // 
            this.txtApertura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Apertura", true));
            this.txtApertura.Location = new System.Drawing.Point(590, 275);
            this.txtApertura.Mask = "00/00/0000";
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(149, 20);
            this.txtApertura.TabIndex = 48;
            this.txtApertura.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Sistema";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(679, 171);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 25);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Values.Text = "Buscar";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(590, 171);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(60, 25);
            this.btnQuitar.TabIndex = 43;
            this.btnQuitar.Values.Text = "Eliminar";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsMto, "Imagen", true));
            this.pbImagen.Location = new System.Drawing.Point(590, 31);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(149, 133);
            this.pbImagen.TabIndex = 42;
            this.pbImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Multimedia";
            // 
            // lblDueno
            // 
            this.lblDueno.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDueno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "nombreDueno", true));
            this.lblDueno.Location = new System.Drawing.Point(337, 84);
            this.lblDueno.Name = "lblDueno";
            this.lblDueno.Size = new System.Drawing.Size(168, 20);
            this.lblDueno.TabIndex = 39;
            this.lblDueno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "CodigoCliente", true));
            this.lblCliente.Location = new System.Drawing.Point(337, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(168, 20);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(337, 26);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(168, 23);
            this.txtBusca.TabIndex = 35;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(281, 27);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Dueño";
            // 
            // txtNota
            // 
            this.txtNota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nota", true));
            this.txtNota.Location = new System.Drawing.Point(113, 399);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(143, 20);
            this.txtNota.TabIndex = 32;
            // 
            // txtDieta
            // 
            this.txtDieta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Dieta", true));
            this.txtDieta.Location = new System.Drawing.Point(113, 373);
            this.txtDieta.Name = "txtDieta";
            this.txtDieta.Size = new System.Drawing.Size(143, 20);
            this.txtDieta.TabIndex = 30;
            // 
            // chkExhibicion
            // 
            this.chkExhibicion.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Exhibicion", true));
            this.chkExhibicion.Location = new System.Drawing.Point(238, 347);
            this.chkExhibicion.Name = "chkExhibicion";
            this.chkExhibicion.Size = new System.Drawing.Size(25, 24);
            this.chkExhibicion.TabIndex = 28;
            this.chkExhibicion.UseVisualStyleBackColor = true;
            // 
            // chkCastrado
            // 
            this.chkCastrado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "Castrado", true));
            this.chkCastrado.Location = new System.Drawing.Point(113, 347);
            this.chkCastrado.Name = "chkCastrado";
            this.chkCastrado.Size = new System.Drawing.Size(24, 24);
            this.chkCastrado.TabIndex = 26;
            this.chkCastrado.UseVisualStyleBackColor = true;
            // 
            // chkCorteCola
            // 
            this.chkCorteCola.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "CorteCola", true));
            this.chkCorteCola.Location = new System.Drawing.Point(239, 320);
            this.chkCorteCola.Name = "chkCorteCola";
            this.chkCorteCola.Size = new System.Drawing.Size(24, 24);
            this.chkCorteCola.TabIndex = 24;
            this.chkCorteCola.UseVisualStyleBackColor = true;
            // 
            // chkCorteOreja
            // 
            this.chkCorteOreja.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMto, "CorteOreja", true));
            this.chkCorteOreja.Location = new System.Drawing.Point(113, 320);
            this.chkCorteOreja.Name = "chkCorteOreja";
            this.chkCorteOreja.Size = new System.Drawing.Size(24, 24);
            this.chkCorteOreja.TabIndex = 22;
            this.chkCorteOreja.UseVisualStyleBackColor = true;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nacimiento", true));
            this.txtNacimiento.Location = new System.Drawing.Point(113, 135);
            this.txtNacimiento.Mask = "00/00/0000";
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(143, 20);
            this.txtNacimiento.TabIndex = 20;
            this.txtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Color", true));
            this.txtColor.Location = new System.Drawing.Point(113, 269);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(143, 20);
            this.txtColor.TabIndex = 13;
            // 
            // cboSanguineo
            // 
            this.cboSanguineo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreGrupoSanguineo", true));
            this.cboSanguineo.DataSource = this.dsNeo;
            this.cboSanguineo.DisplayMember = "tbGrupoSanguineo.NombreGrupoSanguineo";
            this.cboSanguineo.FormattingEnabled = true;
            this.cboSanguineo.Location = new System.Drawing.Point(113, 242);
            this.cboSanguineo.Name = "cboSanguineo";
            this.cboSanguineo.Size = new System.Drawing.Size(143, 21);
            this.cboSanguineo.TabIndex = 12;
            this.cboSanguineo.ValueMember = "tbGrupoSanguineo.NombreGrupoSanguineo";
            // 
            // cboPelaje
            // 
            this.cboPelaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombrePelaje", true));
            this.cboPelaje.DataSource = this.dsNeo;
            this.cboPelaje.DisplayMember = "tbPelaje.NombrePelaje";
            this.cboPelaje.FormattingEnabled = true;
            this.cboPelaje.Location = new System.Drawing.Point(113, 215);
            this.cboPelaje.Name = "cboPelaje";
            this.cboPelaje.Size = new System.Drawing.Size(143, 21);
            this.cboPelaje.TabIndex = 11;
            this.cboPelaje.ValueMember = "tbPelaje.NombrePelaje";
            // 
            // cboCaracter
            // 
            this.cboCaracter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreCaracter", true));
            this.cboCaracter.DataSource = this.dsNeo;
            this.cboCaracter.DisplayMember = "tbCaracter.NombreCaracter";
            this.cboCaracter.FormattingEnabled = true;
            this.cboCaracter.Location = new System.Drawing.Point(113, 188);
            this.cboCaracter.Name = "cboCaracter";
            this.cboCaracter.Size = new System.Drawing.Size(143, 21);
            this.cboCaracter.TabIndex = 10;
            this.cboCaracter.ValueMember = "tbCaracter.NombreCaracter";
            // 
            // cboEstado
            // 
            this.cboEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreEstado", true));
            this.cboEstado.DataSource = this.dsNeo;
            this.cboEstado.DisplayMember = "tbEstado.NombreEstado";
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(113, 161);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(143, 21);
            this.cboEstado.TabIndex = 9;
            this.cboEstado.ValueMember = "tbEstado.NombreEstado";
            // 
            // cboSexo
            // 
            this.cboSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Sexo", true));
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(113, 108);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(143, 21);
            this.cboSexo.TabIndex = 8;
            // 
            // cboRaza
            // 
            this.cboRaza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreRaza", true));
            this.cboRaza.DataSource = this.dsNeo;
            this.cboRaza.DisplayMember = "tbRaza.NombreRaza";
            this.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(113, 81);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(143, 21);
            this.cboRaza.TabIndex = 6;
            this.cboRaza.ValueMember = "tbRaza.NombreRaza";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "NombreGrupo", true));
            this.cboGrupo.DataSource = this.dsNeo;
            this.cboGrupo.DisplayMember = "tbGrupo.NombreGrupo";
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(113, 54);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(143, 21);
            this.cboGrupo.TabIndex = 4;
            this.cboGrupo.ValueMember = "tbGrupo.NombreGrupo";
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMto, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(113, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // tpCita
            // 
            this.tpCita.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpCita.Flags = 65534;
            this.tpCita.LastVisibleSet = true;
            this.tpCita.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpCita.Name = "tpCita";
            this.tpCita.Size = new System.Drawing.Size(758, 422);
            this.tpCita.Text = "Citas";
            this.tpCita.ToolTipTitle = "Page ToolTip";
            this.tpCita.UniqueName = "DC4D00F6658B484A8F95A88EF790512C";
            // 
            // tpHistorial
            // 
            this.tpHistorial.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.tpHistorial.Flags = 65534;
            this.tpHistorial.LastVisibleSet = true;
            this.tpHistorial.MinimumSize = new System.Drawing.Size(50, 50);
            this.tpHistorial.Name = "tpHistorial";
            this.tpHistorial.Size = new System.Drawing.Size(507, 371);
            this.tpHistorial.Text = "Historial";
            this.tpHistorial.ToolTipTitle = "Page ToolTip";
            this.tpHistorial.UniqueName = "F5F31AA7389842CBA5AABFB152DC280B";
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(456, 5);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 451);
            this.pnl5.TabIndex = 5;
            // 
            // pnl4
            // 
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(this.grdMto);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(5, 5);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(451, 451);
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
            this.codigoMascotaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.nombreDuenoDataGridViewTextBoxColumn,
            this.nombreGrupoDataGridViewTextBoxColumn,
            this.nombreRazaDataGridViewTextBoxColumn,
            this.nombreEstadoDataGridViewTextBoxColumn,
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.nombreVeterinarioDataGridViewTextBoxColumn,
            this.nombreCaracterDataGridViewTextBoxColumn,
            this.nombrePelajeDataGridViewTextBoxColumn,
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.pedigriDataGridViewTextBoxColumn,
            this.corteOrejaDataGridViewCheckBoxColumn,
            this.corteColaDataGridViewCheckBoxColumn,
            this.castradoDataGridViewCheckBoxColumn,
            this.peluqueriaDataGridViewCheckBoxColumn,
            this.exhibicionDataGridViewCheckBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.dietaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn});
            this.grdMto.DataSource = this.bsMto;
            this.grdMto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMto.Location = new System.Drawing.Point(0, 0);
            this.grdMto.Name = "grdMto";
            this.grdMto.ReadOnly = true;
            this.grdMto.Size = new System.Drawing.Size(449, 449);
            this.grdMto.TabIndex = 3;
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
            // codigoMascotaDataGridViewTextBoxColumn
            // 
            this.codigoMascotaDataGridViewTextBoxColumn.DataPropertyName = "CodigoMascota";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoMascotaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoMascotaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoMascotaDataGridViewTextBoxColumn.Name = "codigoMascotaDataGridViewTextBoxColumn";
            this.codigoMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoMascotaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDuenoDataGridViewTextBoxColumn
            // 
            this.nombreDuenoDataGridViewTextBoxColumn.DataPropertyName = "nombreDueno";
            this.nombreDuenoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.nombreDuenoDataGridViewTextBoxColumn.Name = "nombreDuenoDataGridViewTextBoxColumn";
            this.nombreDuenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDuenoDataGridViewTextBoxColumn.Width = 240;
            // 
            // nombreGrupoDataGridViewTextBoxColumn
            // 
            this.nombreGrupoDataGridViewTextBoxColumn.DataPropertyName = "NombreGrupo";
            this.nombreGrupoDataGridViewTextBoxColumn.HeaderText = "NombreGrupo";
            this.nombreGrupoDataGridViewTextBoxColumn.Name = "nombreGrupoDataGridViewTextBoxColumn";
            this.nombreGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreGrupoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreRazaDataGridViewTextBoxColumn
            // 
            this.nombreRazaDataGridViewTextBoxColumn.DataPropertyName = "NombreRaza";
            this.nombreRazaDataGridViewTextBoxColumn.HeaderText = "NombreRaza";
            this.nombreRazaDataGridViewTextBoxColumn.Name = "nombreRazaDataGridViewTextBoxColumn";
            this.nombreRazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRazaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreEstadoDataGridViewTextBoxColumn
            // 
            this.nombreEstadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEstado";
            this.nombreEstadoDataGridViewTextBoxColumn.HeaderText = "NombreEstado";
            this.nombreEstadoDataGridViewTextBoxColumn.Name = "nombreEstadoDataGridViewTextBoxColumn";
            this.nombreEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "CodigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            this.codigoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreVeterinarioDataGridViewTextBoxColumn
            // 
            this.nombreVeterinarioDataGridViewTextBoxColumn.DataPropertyName = "nombreVeterinario";
            this.nombreVeterinarioDataGridViewTextBoxColumn.HeaderText = "nombreVeterinario";
            this.nombreVeterinarioDataGridViewTextBoxColumn.Name = "nombreVeterinarioDataGridViewTextBoxColumn";
            this.nombreVeterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreVeterinarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCaracterDataGridViewTextBoxColumn
            // 
            this.nombreCaracterDataGridViewTextBoxColumn.DataPropertyName = "NombreCaracter";
            this.nombreCaracterDataGridViewTextBoxColumn.HeaderText = "NombreCaracter";
            this.nombreCaracterDataGridViewTextBoxColumn.Name = "nombreCaracterDataGridViewTextBoxColumn";
            this.nombreCaracterDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCaracterDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombrePelajeDataGridViewTextBoxColumn
            // 
            this.nombrePelajeDataGridViewTextBoxColumn.DataPropertyName = "NombrePelaje";
            this.nombrePelajeDataGridViewTextBoxColumn.HeaderText = "NombrePelaje";
            this.nombrePelajeDataGridViewTextBoxColumn.Name = "nombrePelajeDataGridViewTextBoxColumn";
            this.nombrePelajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePelajeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreGrupoSanguineoDataGridViewTextBoxColumn
            // 
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "NombreGrupoSanguineo";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.HeaderText = "NombreGrupoSanguineo";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.Name = "nombreGrupoSanguineoDataGridViewTextBoxColumn";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aperturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nacimientoDataGridViewTextBoxColumn
            // 
            this.nacimientoDataGridViewTextBoxColumn.DataPropertyName = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.nacimientoDataGridViewTextBoxColumn.Name = "nacimientoDataGridViewTextBoxColumn";
            this.nacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Visible = false;
            // 
            // pedigriDataGridViewTextBoxColumn
            // 
            this.pedigriDataGridViewTextBoxColumn.DataPropertyName = "Pedigri";
            this.pedigriDataGridViewTextBoxColumn.HeaderText = "Pedigri";
            this.pedigriDataGridViewTextBoxColumn.Name = "pedigriDataGridViewTextBoxColumn";
            this.pedigriDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedigriDataGridViewTextBoxColumn.Visible = false;
            // 
            // corteOrejaDataGridViewCheckBoxColumn
            // 
            this.corteOrejaDataGridViewCheckBoxColumn.DataPropertyName = "CorteOreja";
            this.corteOrejaDataGridViewCheckBoxColumn.HeaderText = "CorteOreja";
            this.corteOrejaDataGridViewCheckBoxColumn.Name = "corteOrejaDataGridViewCheckBoxColumn";
            this.corteOrejaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.corteOrejaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // corteColaDataGridViewCheckBoxColumn
            // 
            this.corteColaDataGridViewCheckBoxColumn.DataPropertyName = "CorteCola";
            this.corteColaDataGridViewCheckBoxColumn.HeaderText = "CorteCola";
            this.corteColaDataGridViewCheckBoxColumn.Name = "corteColaDataGridViewCheckBoxColumn";
            this.corteColaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.corteColaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // castradoDataGridViewCheckBoxColumn
            // 
            this.castradoDataGridViewCheckBoxColumn.DataPropertyName = "Castrado";
            this.castradoDataGridViewCheckBoxColumn.HeaderText = "Castrado";
            this.castradoDataGridViewCheckBoxColumn.Name = "castradoDataGridViewCheckBoxColumn";
            this.castradoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.castradoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // peluqueriaDataGridViewCheckBoxColumn
            // 
            this.peluqueriaDataGridViewCheckBoxColumn.DataPropertyName = "Peluqueria";
            this.peluqueriaDataGridViewCheckBoxColumn.HeaderText = "Peluqueria";
            this.peluqueriaDataGridViewCheckBoxColumn.Name = "peluqueriaDataGridViewCheckBoxColumn";
            this.peluqueriaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.peluqueriaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // exhibicionDataGridViewCheckBoxColumn
            // 
            this.exhibicionDataGridViewCheckBoxColumn.DataPropertyName = "Exhibicion";
            this.exhibicionDataGridViewCheckBoxColumn.HeaderText = "Exhibicion";
            this.exhibicionDataGridViewCheckBoxColumn.Name = "exhibicionDataGridViewCheckBoxColumn";
            this.exhibicionDataGridViewCheckBoxColumn.ReadOnly = true;
            this.exhibicionDataGridViewCheckBoxColumn.Visible = false;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            this.imagenDataGridViewImageColumn.Visible = false;
            // 
            // dietaDataGridViewTextBoxColumn
            // 
            this.dietaDataGridViewTextBoxColumn.DataPropertyName = "Dieta";
            this.dietaDataGridViewTextBoxColumn.HeaderText = "Dieta";
            this.dietaDataGridViewTextBoxColumn.Name = "dietaDataGridViewTextBoxColumn";
            this.dietaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dietaDataGridViewTextBoxColumn.Visible = false;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1235, 10);
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
            this.pnl1.Size = new System.Drawing.Size(1235, 28);
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
            this.bnMto.Size = new System.Drawing.Size(1233, 25);
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
            // taMascota
            // 
            this.taMascota.ClearBeforeFill = true;
            // 
            // taGrupo
            // 
            this.taGrupo.ClearBeforeFill = true;
            // 
            // taRaza
            // 
            this.taRaza.ClearBeforeFill = true;
            // 
            // taCaracter
            // 
            this.taCaracter.ClearBeforeFill = true;
            // 
            // taPelaje
            // 
            this.taPelaje.ClearBeforeFill = true;
            // 
            // taGrupoSanguineo
            // 
            this.taGrupoSanguineo.ClearBeforeFill = true;
            // 
            // taSucursal
            // 
            this.taSucursal.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.taArticulo = null;
            this.tableAdapterManager.taArticuloMultimedia = null;
            this.tableAdapterManager.taCaracter = this.taCaracter;
            this.tableAdapterManager.taCategoria = null;
            this.tableAdapterManager.taCliente = null;
            this.tableAdapterManager.taClienteNacionalidad = null;
            this.tableAdapterManager.taClienteSucursalContacto = null;
            this.tableAdapterManager.taContacto = null;
            this.tableAdapterManager.taContactoMiembro = null;
            this.tableAdapterManager.taDepartamento = null;
            this.tableAdapterManager.taEmpleado = null;
            this.tableAdapterManager.taEmpresa = null;
            this.tableAdapterManager.taEstado = null;
            this.tableAdapterManager.taFinanciera = null;
            this.tableAdapterManager.taFormaPago = null;
            this.tableAdapterManager.taFrecuencia = null;
            this.tableAdapterManager.taGrupo = null;
            this.tableAdapterManager.taGrupoSanguineo = this.taGrupoSanguineo;
            this.tableAdapterManager.taIdentificacion = null;
            this.tableAdapterManager.taMoneda = null;
            this.tableAdapterManager.taNacionalidad = null;
            this.tableAdapterManager.taOcupacion = null;
            this.tableAdapterManager.taOrdenPedido = null;
            this.tableAdapterManager.taOrdenPedidoArticulo = null;
            this.tableAdapterManager.taOrdenPedidoEstado = null;
            this.tableAdapterManager.taPais = null;
            this.tableAdapterManager.taPelaje = this.taPelaje;
            this.tableAdapterManager.taPrecioVenta = null;
            this.tableAdapterManager.taProveedor = null;
            this.tableAdapterManager.taProveedorSucursal = null;
            this.tableAdapterManager.taProveedorSucursalContacto = null;
            this.tableAdapterManager.taProvincia = null;
            this.tableAdapterManager.taPuesto = null;
            this.tableAdapterManager.taRaza = this.taRaza;
            this.tableAdapterManager.taSucursal = this.taSucursal;
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
            // FrmMtoMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 501);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmMtoMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMtoMascota_FormClosed);
            this.Load += new System.EventHandler(this.FrmMtoMascota_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMascota)).EndInit();
            this.tcMascota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpMascota)).EndInit();
            this.tpMascota.ResumeLayout(false);
            this.tpMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpHistorial)).EndInit();
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
        private ComponentFactory.Krypton.Navigator.KryptonNavigator tcMascota;
        private ComponentFactory.Krypton.Navigator.KryptonPage tpMascota;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MaskedTextBox txtApertura;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnQuitar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDueno;
        private System.Windows.Forms.Label lblCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBusca;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtDieta;
        private System.Windows.Forms.CheckBox chkExhibicion;
        private System.Windows.Forms.CheckBox chkCastrado;
        private System.Windows.Forms.CheckBox chkCorteCola;
        private System.Windows.Forms.CheckBox chkCorteOreja;
        private System.Windows.Forms.MaskedTextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cboSanguineo;
        private System.Windows.Forms.ComboBox cboPelaje;
        private System.Windows.Forms.ComboBox cboCaracter;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Navigator.KryptonPage tpCita;
        private ComponentFactory.Krypton.Navigator.KryptonPage tpHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDuenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVeterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCaracterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePelajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupoSanguineoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedigriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn corteOrejaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn corteColaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn castradoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn peluqueriaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exhibicionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private DsNeoTableAdapters.taMascota taMascota;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTrabajo;
        private DsNeoTableAdapters.taGrupo taGrupo;
        private DsNeoTableAdapters.taRaza taRaza;
        private DsNeoTableAdapters.taCaracter taCaracter;
        private DsNeoTableAdapters.taPelaje taPelaje;
        private DsNeoTableAdapters.taGrupoSanguineo taGrupoSanguineo;
        private DsNeoTableAdapters.taSucursal taSucursal;
        private System.Windows.Forms.TextBox txtPedigri;
        private DsNeoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkPeluqueria;
    }
}