namespace Neo
{
    partial class FrmTscCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTscCita));
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label dueñoLabel;
            System.Windows.Forms.Label grupoLabel;
            System.Windows.Forms.Label razaLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label numeroCitaLabel;
            System.Windows.Forms.Label codigoSucursalLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label tipoLabel;
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.pnl13 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.dsNeo = new Neo.DsNeo();
            this.bsCita = new System.Windows.Forms.BindingSource(this.components);
            this.taCita = new Neo.DsNeoTableAdapters.taCita();
            this.bnCita = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.tbCitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtBuscaMascota = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.dueñoLabel1 = new System.Windows.Forms.Label();
            this.grupoLabel1 = new System.Windows.Forms.Label();
            this.razaLabel1 = new System.Windows.Forms.Label();
            this.sexoLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroCitaLabel1 = new System.Windows.Forms.Label();
            this.codigoSucursalLabel1 = new System.Windows.Forms.Label();
            this.fechaKryptonDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tipoKryptonComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            nombreLabel = new System.Windows.Forms.Label();
            dueñoLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            razaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            numeroCitaLabel = new System.Windows.Forms.Label();
            codigoSucursalLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl10.SuspendLayout();
            this.pnl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).BeginInit();
            this.bnCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoKryptonComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.bnCita);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1132, 28);
            this.pnl1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.pnl12);
            this.pnl2.Controls.Add(this.pnl11);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 28);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1132, 642);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.pnl10);
            this.pnl3.Controls.Add(this.pnl9);
            this.pnl3.Controls.Add(this.pnl8);
            this.pnl3.Controls.Add(this.pnl7);
            this.pnl3.Controls.Add(this.pnl6);
            this.pnl3.Controls.Add(this.pnl5);
            this.pnl3.Controls.Add(this.pnl4);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1128, 180);
            this.pnl3.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.AutoScroll = true;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Controls.Add(sexoLabel);
            this.pnl4.Controls.Add(this.sexoLabel1);
            this.pnl4.Controls.Add(razaLabel);
            this.pnl4.Controls.Add(this.razaLabel1);
            this.pnl4.Controls.Add(grupoLabel);
            this.pnl4.Controls.Add(this.grupoLabel1);
            this.pnl4.Controls.Add(dueñoLabel);
            this.pnl4.Controls.Add(this.dueñoLabel1);
            this.pnl4.Controls.Add(nombreLabel);
            this.pnl4.Controls.Add(this.nombreLabel1);
            this.pnl4.Controls.Add(this.txtBuscaMascota);
            this.pnl4.Controls.Add(this.kryptonLabel1);
            this.pnl4.Controls.Add(this.label1);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(316, 180);
            this.pnl4.TabIndex = 0;
            // 
            // pnl5
            // 
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl5.Location = new System.Drawing.Point(316, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(10, 180);
            this.pnl5.TabIndex = 1;
            // 
            // pnl6
            // 
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Controls.Add(this.label2);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl6.Location = new System.Drawing.Point(326, 0);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(314, 180);
            this.pnl6.TabIndex = 2;
            // 
            // pnl7
            // 
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl7.Location = new System.Drawing.Point(640, 0);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(10, 180);
            this.pnl7.TabIndex = 3;
            // 
            // pnl8
            // 
            this.pnl8.AutoScroll = true;
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(tipoLabel);
            this.pnl8.Controls.Add(this.tipoKryptonComboBox);
            this.pnl8.Controls.Add(usuarioLabel);
            this.pnl8.Controls.Add(this.lblUsuario);
            this.pnl8.Controls.Add(fechaLabel);
            this.pnl8.Controls.Add(this.fechaKryptonDateTimePicker);
            this.pnl8.Controls.Add(codigoSucursalLabel);
            this.pnl8.Controls.Add(this.codigoSucursalLabel1);
            this.pnl8.Controls.Add(numeroCitaLabel);
            this.pnl8.Controls.Add(this.numeroCitaLabel1);
            this.pnl8.Controls.Add(this.label3);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl8.Location = new System.Drawing.Point(650, 0);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(371, 180);
            this.pnl8.TabIndex = 4;
            // 
            // pnl9
            // 
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl9.Location = new System.Drawing.Point(1021, 0);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(10, 180);
            this.pnl9.TabIndex = 5;
            // 
            // pnl10
            // 
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Controls.Add(this.label4);
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl10.Location = new System.Drawing.Point(1031, 0);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(235, 180);
            this.pnl10.TabIndex = 6;
            // 
            // pnl11
            // 
            this.pnl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl11.Location = new System.Drawing.Point(0, 180);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(1128, 10);
            this.pnl11.TabIndex = 1;
            // 
            // pnl12
            // 
            this.pnl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl12.Controls.Add(this.pnl14);
            this.pnl12.Controls.Add(this.pnl13);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl12.Location = new System.Drawing.Point(0, 190);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(1128, 257);
            this.pnl12.TabIndex = 2;
            // 
            // pnl13
            // 
            this.pnl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl13.Location = new System.Drawing.Point(0, 0);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(1126, 28);
            this.pnl13.TabIndex = 2;
            // 
            // pnl14
            // 
            this.pnl14.AutoScroll = true;
            this.pnl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl14.Location = new System.Drawing.Point(0, 28);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(1126, 227);
            this.pnl14.TabIndex = 3;
            // 
            // dsNeo
            // 
            this.dsNeo.DataSetName = "DsNeo";
            this.dsNeo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCita
            // 
            this.bsCita.DataMember = "tbCita";
            this.bsCita.DataSource = this.dsNeo;
            // 
            // taCita
            // 
            this.taCita.ClearBeforeFill = true;
            // 
            // bnCita
            // 
            this.bnCita.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnCita.BindingSource = this.bsCita;
            this.bnCita.CountItem = this.bindingNavigatorCountItem;
            this.bnCita.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnCita.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbCitaBindingNavigatorSaveItem});
            this.bnCita.Location = new System.Drawing.Point(0, 0);
            this.bnCita.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCita.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCita.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCita.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCita.Name = "bnCita";
            this.bnCita.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCita.Size = new System.Drawing.Size(1130, 25);
            this.bnCita.TabIndex = 3;
            this.bnCita.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // tbCitaBindingNavigatorSaveItem
            // 
            this.tbCitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbCitaBindingNavigatorSaveItem.Image")));
            this.tbCitaBindingNavigatorSaveItem.Name = "tbCitaBindingNavigatorSaveItem";
            this.tbCitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbCitaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 27);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Buscar:";
            // 
            // txtBuscaMascota
            // 
            this.txtBuscaMascota.Location = new System.Drawing.Point(63, 26);
            this.txtBuscaMascota.Name = "txtBuscaMascota";
            this.txtBuscaMascota.Size = new System.Drawing.Size(235, 23);
            this.txtBuscaMascota.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(14, 57);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.nombreLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Nombre", true));
            this.nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel1.Location = new System.Drawing.Point(63, 54);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(235, 20);
            this.nombreLabel1.TabIndex = 4;
            // 
            // dueñoLabel
            // 
            dueñoLabel.AutoSize = true;
            dueñoLabel.Location = new System.Drawing.Point(19, 80);
            dueñoLabel.Name = "dueñoLabel";
            dueñoLabel.Size = new System.Drawing.Size(42, 13);
            dueñoLabel.TabIndex = 5;
            dueñoLabel.Text = "Dueño:";
            // 
            // dueñoLabel1
            // 
            this.dueñoLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.dueñoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dueñoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Dueño", true));
            this.dueñoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueñoLabel1.Location = new System.Drawing.Point(63, 77);
            this.dueñoLabel1.Name = "dueñoLabel1";
            this.dueñoLabel1.Size = new System.Drawing.Size(235, 20);
            this.dueñoLabel1.TabIndex = 6;
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Location = new System.Drawing.Point(22, 103);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(39, 13);
            grupoLabel.TabIndex = 7;
            grupoLabel.Text = "Grupo:";
            // 
            // grupoLabel1
            // 
            this.grupoLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.grupoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grupoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Grupo", true));
            this.grupoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoLabel1.Location = new System.Drawing.Point(63, 100);
            this.grupoLabel1.Name = "grupoLabel1";
            this.grupoLabel1.Size = new System.Drawing.Size(235, 20);
            this.grupoLabel1.TabIndex = 8;
            // 
            // razaLabel
            // 
            razaLabel.AutoSize = true;
            razaLabel.Location = new System.Drawing.Point(26, 126);
            razaLabel.Name = "razaLabel";
            razaLabel.Size = new System.Drawing.Size(35, 13);
            razaLabel.TabIndex = 9;
            razaLabel.Text = "Raza:";
            // 
            // razaLabel1
            // 
            this.razaLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.razaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.razaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Raza", true));
            this.razaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaLabel1.Location = new System.Drawing.Point(63, 123);
            this.razaLabel1.Name = "razaLabel1";
            this.razaLabel1.Size = new System.Drawing.Size(235, 20);
            this.razaLabel1.TabIndex = 10;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(27, 150);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoLabel1
            // 
            this.sexoLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.sexoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sexoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Sexo", true));
            this.sexoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoLabel1.Location = new System.Drawing.Point(63, 146);
            this.sexoLabel1.Name = "sexoLabel1";
            this.sexoLabel1.Size = new System.Drawing.Size(235, 20);
            this.sexoLabel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contactos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cita";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propiedades";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeroCitaLabel
            // 
            numeroCitaLabel.AutoSize = true;
            numeroCitaLabel.Location = new System.Drawing.Point(13, 29);
            numeroCitaLabel.Name = "numeroCitaLabel";
            numeroCitaLabel.Size = new System.Drawing.Size(47, 13);
            numeroCitaLabel.TabIndex = 2;
            numeroCitaLabel.Text = "Número:";
            numeroCitaLabel.Click += new System.EventHandler(this.numeroCitaLabel_Click);
            // 
            // numeroCitaLabel1
            // 
            this.numeroCitaLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.numeroCitaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroCitaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "NumeroCita", true));
            this.numeroCitaLabel1.Location = new System.Drawing.Point(62, 26);
            this.numeroCitaLabel1.Name = "numeroCitaLabel1";
            this.numeroCitaLabel1.Size = new System.Drawing.Size(100, 20);
            this.numeroCitaLabel1.TabIndex = 3;
            this.numeroCitaLabel1.Click += new System.EventHandler(this.numeroCitaLabel1_Click);
            // 
            // codigoSucursalLabel
            // 
            codigoSucursalLabel.AutoSize = true;
            codigoSucursalLabel.Location = new System.Drawing.Point(9, 54);
            codigoSucursalLabel.Name = "codigoSucursalLabel";
            codigoSucursalLabel.Size = new System.Drawing.Size(51, 13);
            codigoSucursalLabel.TabIndex = 3;
            codigoSucursalLabel.Text = "Sucursal:";
            // 
            // codigoSucursalLabel1
            // 
            this.codigoSucursalLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.codigoSucursalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoSucursalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "CodigoSucursal", true));
            this.codigoSucursalLabel1.Location = new System.Drawing.Point(62, 51);
            this.codigoSucursalLabel1.Name = "codigoSucursalLabel1";
            this.codigoSucursalLabel1.Size = new System.Drawing.Size(100, 20);
            this.codigoSucursalLabel1.TabIndex = 4;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(20, 107);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaKryptonDateTimePicker
            // 
            this.fechaKryptonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCita, "Fecha", true));
            this.fechaKryptonDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaKryptonDateTimePicker.Location = new System.Drawing.Point(62, 103);
            this.fechaKryptonDateTimePicker.Name = "fechaKryptonDateTimePicker";
            this.fechaKryptonDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.fechaKryptonDateTimePicker.Size = new System.Drawing.Size(103, 21);
            this.fechaKryptonDateTimePicker.TabIndex = 6;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(14, 80);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 7;
            usuarioLabel.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Usuario", true));
            this.lblUsuario.Location = new System.Drawing.Point(62, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 20);
            this.lblUsuario.TabIndex = 8;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(25, 133);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "Tipo:";
            // 
            // tipoKryptonComboBox
            // 
            this.tipoKryptonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCita, "Tipo", true));
            this.tipoKryptonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoKryptonComboBox.DropDownWidth = 103;
            this.tipoKryptonComboBox.Items.AddRange(new object[] {
            "Local",
            "Dominicilio"});
            this.tipoKryptonComboBox.Location = new System.Drawing.Point(62, 130);
            this.tipoKryptonComboBox.Name = "tipoKryptonComboBox";
            this.tipoKryptonComboBox.Size = new System.Drawing.Size(103, 21);
            this.tipoKryptonComboBox.TabIndex = 10;
            // 
            // FrmTscCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 670);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmTscCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl6.ResumeLayout(false);
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            this.pnl10.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCita)).EndInit();
            this.bnCita.ResumeLayout(false);
            this.bnCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoKryptonComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl12;
        private System.Windows.Forms.Panel pnl14;
        private System.Windows.Forms.Panel pnl13;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private DsNeo dsNeo;
        private System.Windows.Forms.BindingSource bsCita;
        private DsNeoTableAdapters.taCita taCita;
        private System.Windows.Forms.BindingNavigator bnCita;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton tbCitaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sexoLabel1;
        private System.Windows.Forms.Label razaLabel1;
        private System.Windows.Forms.Label grupoLabel1;
        private System.Windows.Forms.Label dueñoLabel1;
        private System.Windows.Forms.Label nombreLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBuscaMascota;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeroCitaLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox tipoKryptonComboBox;
        private System.Windows.Forms.Label lblUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker fechaKryptonDateTimePicker;
        private System.Windows.Forms.Label codigoSucursalLabel1;
    }
}