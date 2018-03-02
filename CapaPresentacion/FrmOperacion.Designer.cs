﻿namespace CapaPresentacion
{
    partial class FrmOperacion
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
            this.TabUsuario = new System.Windows.Forms.TabControl();
            this.TabGral = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.gbxMembresia = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbProductos = new System.Windows.Forms.ComboBox();
            this.cbbMembresiaLockers = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbLockers = new System.Windows.Forms.ComboBox();
            this.DTPLockerVence = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimientoViajero = new System.Windows.Forms.DateTimePicker();
            this.txtDiasViajero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMembresia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktCelular = new System.Windows.Forms.TextBox();
            this.btnCancelarCamara = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cboDispositivos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            this.mktFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDireccion2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RDmasculino = new System.Windows.Forms.RadioButton();
            this.RDsexoFem = new System.Windows.Forms.RadioButton();
            this.TxtDireccion1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdSocio = new System.Windows.Forms.TextBox();
            this.LblSocio = new System.Windows.Forms.Label();
            this.TabHistorial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TStOpciones = new System.Windows.Forms.ToolStrip();
            this.TstCmdAgrefarUsr = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSTxtBuscaSocio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscarPorNombre = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TsLimpiaForm = new System.Windows.Forms.ToolStripButton();
            this.TabUsuario.SuspendLayout();
            this.TabGral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.gbxMembresia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
            this.TabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TStOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabUsuario
            // 
            this.TabUsuario.Controls.Add(this.TabGral);
            this.TabUsuario.Controls.Add(this.TabHistorial);
            this.TabUsuario.Location = new System.Drawing.Point(0, 34);
            this.TabUsuario.Name = "TabUsuario";
            this.TabUsuario.SelectedIndex = 0;
            this.TabUsuario.Size = new System.Drawing.Size(764, 703);
            this.TabUsuario.TabIndex = 2;
            // 
            // TabGral
            // 
            this.TabGral.Controls.Add(this.button1);
            this.TabGral.Controls.Add(this.button4);
            this.TabGral.Controls.Add(this.dtgVentas);
            this.TabGral.Controls.Add(this.button3);
            this.TabGral.Controls.Add(this.gbxMembresia);
            this.TabGral.Controls.Add(this.groupBox1);
            this.TabGral.Location = new System.Drawing.Point(4, 22);
            this.TabGral.Name = "TabGral";
            this.TabGral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGral.Size = new System.Drawing.Size(756, 677);
            this.TabGral.TabIndex = 0;
            this.TabGral.Text = "Generales";
            this.TabGral.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cerrar venta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToOrderColumns = true;
            this.dtgVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.Monto});
            this.dtgVentas.Location = new System.Drawing.Point(6, 518);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.Size = new System.Drawing.Size(617, 153);
            this.dtgVentas.TabIndex = 25;
            this.dtgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dtgVentas.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dtgVentas_CellContextMenuStripNeeded);
            this.dtgVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVentas_CellDoubleClick);
            this.dtgVentas.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Descuento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbxMembresia
            // 
            this.gbxMembresia.Controls.Add(this.label10);
            this.gbxMembresia.Controls.Add(this.cbbProductos);
            this.gbxMembresia.Controls.Add(this.cbbMembresiaLockers);
            this.gbxMembresia.Controls.Add(this.label11);
            this.gbxMembresia.Controls.Add(this.label7);
            this.gbxMembresia.Controls.Add(this.label12);
            this.gbxMembresia.Controls.Add(this.cbbLockers);
            this.gbxMembresia.Controls.Add(this.DTPLockerVence);
            this.gbxMembresia.Controls.Add(this.dtpVencimientoViajero);
            this.gbxMembresia.Controls.Add(this.txtDiasViajero);
            this.gbxMembresia.Controls.Add(this.label8);
            this.gbxMembresia.Controls.Add(this.cbbMembresia);
            this.gbxMembresia.Enabled = false;
            this.gbxMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMembresia.Location = new System.Drawing.Point(6, 307);
            this.gbxMembresia.Name = "gbxMembresia";
            this.gbxMembresia.Size = new System.Drawing.Size(454, 171);
            this.gbxMembresia.TabIndex = 20;
            this.gbxMembresia.TabStop = false;
            this.gbxMembresia.Text = "Membresia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Producto";
            // 
            // cbbProductos
            // 
            this.cbbProductos.FormattingEnabled = true;
            this.cbbProductos.Location = new System.Drawing.Point(94, 127);
            this.cbbProductos.Name = "cbbProductos";
            this.cbbProductos.Size = new System.Drawing.Size(133, 21);
            this.cbbProductos.TabIndex = 51;
            this.cbbProductos.SelectionChangeCommitted += new System.EventHandler(this.cbbProductos_SelectionChangeCommitted);
            // 
            // cbbMembresiaLockers
            // 
            this.cbbMembresiaLockers.FormattingEnabled = true;
            this.cbbMembresiaLockers.Location = new System.Drawing.Point(211, 96);
            this.cbbMembresiaLockers.Name = "cbbMembresiaLockers";
            this.cbbMembresiaLockers.Size = new System.Drawing.Size(125, 21);
            this.cbbMembresiaLockers.TabIndex = 49;
            this.cbbMembresiaLockers.SelectedIndexChanged += new System.EventHandler(this.cbbMembresiaLockers_SelectedIndexChanged);
            this.cbbMembresiaLockers.SelectionChangeCommitted += new System.EventHandler(this.cbbMembresiaLockers_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Dias Viajero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Tipo Membresia";
            // 
            // cbbLockers
            // 
            this.cbbLockers.FormattingEnabled = true;
            this.cbbLockers.Location = new System.Drawing.Point(94, 96);
            this.cbbLockers.Name = "cbbLockers";
            this.cbbLockers.Size = new System.Drawing.Size(100, 21);
            this.cbbLockers.TabIndex = 47;
            this.cbbLockers.SelectedIndexChanged += new System.EventHandler(this.cbbLockers_SelectedIndexChanged);
            // 
            // DTPLockerVence
            // 
            this.DTPLockerVence.Enabled = false;
            this.DTPLockerVence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPLockerVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPLockerVence.Location = new System.Drawing.Point(342, 97);
            this.DTPLockerVence.Name = "DTPLockerVence";
            this.DTPLockerVence.Size = new System.Drawing.Size(79, 20);
            this.DTPLockerVence.TabIndex = 41;
            // 
            // dtpVencimientoViajero
            // 
            this.dtpVencimientoViajero.Enabled = false;
            this.dtpVencimientoViajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimientoViajero.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoViajero.Location = new System.Drawing.Point(314, 60);
            this.dtpVencimientoViajero.Name = "dtpVencimientoViajero";
            this.dtpVencimientoViajero.Size = new System.Drawing.Size(123, 20);
            this.dtpVencimientoViajero.TabIndex = 44;
            // 
            // txtDiasViajero
            // 
            this.txtDiasViajero.Enabled = false;
            this.txtDiasViajero.Location = new System.Drawing.Point(94, 60);
            this.txtDiasViajero.Name = "txtDiasViajero";
            this.txtDiasViajero.Size = new System.Drawing.Size(123, 20);
            this.txtDiasViajero.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Lockers";
            // 
            // cbbMembresia
            // 
            this.cbbMembresia.FormattingEnabled = true;
            this.cbbMembresia.Location = new System.Drawing.Point(94, 21);
            this.cbbMembresia.Name = "cbbMembresia";
            this.cbbMembresia.Size = new System.Drawing.Size(133, 21);
            this.cbbMembresia.TabIndex = 42;
            this.cbbMembresia.SelectedIndexChanged += new System.EventHandler(this.cbbMembresia_SelectedIndexChanged);
            this.cbbMembresia.SelectionChangeCommitted += new System.EventHandler(this.cbbMembresia_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktCelular);
            this.groupBox1.Controls.Add(this.btnCancelarCamara);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cboDispositivos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.pbFotoUser);
            this.groupBox1.Controls.Add(this.mktFechaNacimiento);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtDireccion2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RDmasculino);
            this.groupBox1.Controls.Add(this.RDsexoFem);
            this.groupBox1.Controls.Add(this.TxtDireccion1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombreSocio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtIdSocio);
            this.groupBox1.Controls.Add(this.LblSocio);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 295);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del socio";
            // 
            // mktCelular
            // 
            this.mktCelular.Enabled = false;
            this.mktCelular.Location = new System.Drawing.Point(75, 130);
            this.mktCelular.Name = "mktCelular";
            this.mktCelular.Size = new System.Drawing.Size(131, 20);
            this.mktCelular.TabIndex = 49;
            // 
            // btnCancelarCamara
            // 
            this.btnCancelarCamara.Enabled = false;
            this.btnCancelarCamara.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCamara.Image = global::CapaPresentacion.Properties.Resources.cancelar1;
            this.btnCancelarCamara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCamara.Location = new System.Drawing.Point(594, 244);
            this.btnCancelarCamara.Name = "btnCancelarCamara";
            this.btnCancelarCamara.Size = new System.Drawing.Size(97, 35);
            this.btnCancelarCamara.TabIndex = 48;
            this.btnCancelarCamara.Text = "Cancelar";
            this.btnCancelarCamara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCamara.UseVisualStyleBackColor = true;
            this.btnCancelarCamara.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::CapaPresentacion.Properties.Resources.iniciar1;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(480, 244);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(81, 35);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cboDispositivos
            // 
            this.cboDispositivos.FormattingEnabled = true;
            this.cboDispositivos.Location = new System.Drawing.Point(480, 266);
            this.cboDispositivos.Name = "cboDispositivos";
            this.cboDispositivos.Size = new System.Drawing.Size(200, 21);
            this.cboDispositivos.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(75, 256);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 44;
            // 
            // pbFotoUser
            // 
            this.pbFotoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoUser.Location = new System.Drawing.Point(397, 11);
            this.pbFotoUser.Name = "pbFotoUser";
            this.pbFotoUser.Size = new System.Drawing.Size(341, 224);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 4;
            this.pbFotoUser.TabStop = false;
            // 
            // mktFechaNacimiento
            // 
            this.mktFechaNacimiento.Enabled = false;
            this.mktFechaNacimiento.Location = new System.Drawing.Point(75, 228);
            this.mktFechaNacimiento.Mask = "00/00/0000";
            this.mktFechaNacimiento.Name = "mktFechaNacimiento";
            this.mktFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.mktFechaNacimiento.TabIndex = 43;
            this.mktFechaNacimiento.ValidatingType = typeof(System.DateTime);
            this.mktFechaNacimiento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktFechaNacimiento_MaskInputRejected);
            this.mktFechaNacimiento.Click += new System.EventHandler(this.mktFechaNacimiento_Click);
            this.mktFechaNacimiento.TextChanged += new System.EventHandler(this.mktFechaNacimiento_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(75, 156);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(244, 20);
            this.TxtEmail.TabIndex = 36;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Email";
            // 
            // TxtDireccion2
            // 
            this.TxtDireccion2.Enabled = false;
            this.TxtDireccion2.Location = new System.Drawing.Point(75, 104);
            this.TxtDireccion2.Name = "TxtDireccion2";
            this.TxtDireccion2.Size = new System.Drawing.Size(244, 20);
            this.TxtDireccion2.TabIndex = 34;
            this.TxtDireccion2.TextChanged += new System.EventHandler(this.TxtDireccion2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Dirección2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha Nac.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sexo";
            // 
            // RDmasculino
            // 
            this.RDmasculino.AutoSize = true;
            this.RDmasculino.Enabled = false;
            this.RDmasculino.Location = new System.Drawing.Point(166, 181);
            this.RDmasculino.Name = "RDmasculino";
            this.RDmasculino.Size = new System.Drawing.Size(73, 17);
            this.RDmasculino.TabIndex = 26;
            this.RDmasculino.TabStop = true;
            this.RDmasculino.Text = "Masculino";
            this.RDmasculino.UseVisualStyleBackColor = true;
            this.RDmasculino.CheckedChanged += new System.EventHandler(this.RDmasculino_CheckedChanged);
            // 
            // RDsexoFem
            // 
            this.RDsexoFem.AutoSize = true;
            this.RDsexoFem.Enabled = false;
            this.RDsexoFem.Location = new System.Drawing.Point(75, 181);
            this.RDsexoFem.Name = "RDsexoFem";
            this.RDsexoFem.Size = new System.Drawing.Size(71, 17);
            this.RDsexoFem.TabIndex = 25;
            this.RDsexoFem.TabStop = true;
            this.RDsexoFem.Text = "Femenino";
            this.RDsexoFem.UseVisualStyleBackColor = true;
            this.RDsexoFem.CheckedChanged += new System.EventHandler(this.RDsexoFem_CheckedChanged);
            // 
            // TxtDireccion1
            // 
            this.TxtDireccion1.Enabled = false;
            this.TxtDireccion1.Location = new System.Drawing.Point(75, 78);
            this.TxtDireccion1.Name = "TxtDireccion1";
            this.TxtDireccion1.Size = new System.Drawing.Size(244, 20);
            this.TxtDireccion1.TabIndex = 24;
            this.TxtDireccion1.TextChanged += new System.EventHandler(this.TxtDireccion1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dirección";
            // 
            // TxtNombreSocio
            // 
            this.TxtNombreSocio.Enabled = false;
            this.TxtNombreSocio.Location = new System.Drawing.Point(75, 48);
            this.TxtNombreSocio.Name = "TxtNombreSocio";
            this.TxtNombreSocio.Size = new System.Drawing.Size(244, 20);
            this.TxtNombreSocio.TabIndex = 22;
            this.TxtNombreSocio.TextChanged += new System.EventHandler(this.TxtNombreSocio_TextChanged);
            this.TxtNombreSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // TxtIdSocio
            // 
            this.TxtIdSocio.Enabled = false;
            this.TxtIdSocio.Location = new System.Drawing.Point(75, 22);
            this.TxtIdSocio.Name = "TxtIdSocio";
            this.TxtIdSocio.Size = new System.Drawing.Size(100, 20);
            this.TxtIdSocio.TabIndex = 20;
            // 
            // LblSocio
            // 
            this.LblSocio.AutoSize = true;
            this.LblSocio.Location = new System.Drawing.Point(6, 25);
            this.LblSocio.Name = "LblSocio";
            this.LblSocio.Size = new System.Drawing.Size(40, 13);
            this.LblSocio.TabIndex = 19;
            this.LblSocio.Text = "Código";
            // 
            // TabHistorial
            // 
            this.TabHistorial.Controls.Add(this.dataGridView1);
            this.TabHistorial.Location = new System.Drawing.Point(4, 22);
            this.TabHistorial.Name = "TabHistorial";
            this.TabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.TabHistorial.Size = new System.Drawing.Size(756, 677);
            this.TabHistorial.TabIndex = 1;
            this.TabHistorial.Text = "Historial";
            this.TabHistorial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // TStOpciones
            // 
            this.TStOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TStOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstCmdAgrefarUsr,
            this.toolStripLabel1,
            this.TSTxtBuscaSocio,
            this.toolStripLabel2,
            this.txtBuscarPorNombre,
            this.toolStripButton1,
            this.TsLimpiaForm});
            this.TStOpciones.Location = new System.Drawing.Point(0, 0);
            this.TStOpciones.Name = "TStOpciones";
            this.TStOpciones.Size = new System.Drawing.Size(779, 31);
            this.TStOpciones.TabIndex = 3;
            this.TStOpciones.Text = "toolStrip1";
            // 
            // TstCmdAgrefarUsr
            // 
            this.TstCmdAgrefarUsr.Image = global::CapaPresentacion.Properties.Resources.user_2;
            this.TstCmdAgrefarUsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstCmdAgrefarUsr.Name = "TstCmdAgrefarUsr";
            this.TstCmdAgrefarUsr.Size = new System.Drawing.Size(94, 28);
            this.TstCmdAgrefarUsr.Text = "Crear socio";
            this.TstCmdAgrefarUsr.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 28);
            this.toolStripLabel1.Text = "Buscar por id>";
            // 
            // TSTxtBuscaSocio
            // 
            this.TSTxtBuscaSocio.Name = "TSTxtBuscaSocio";
            this.TSTxtBuscaSocio.Size = new System.Drawing.Size(100, 31);
            this.TSTxtBuscaSocio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTxtBuscaSocio_KeyDown);
            this.TSTxtBuscaSocio.Click += new System.EventHandler(this.TSTxtBuscaSocio_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(119, 28);
            this.toolStripLabel2.Text = "Buscar por nombre >";
            // 
            // txtBuscarPorNombre
            // 
            this.txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            this.txtBuscarPorNombre.Size = new System.Drawing.Size(100, 31);
            this.txtBuscarPorNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPorNombre_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CapaPresentacion.Properties.Resources.connection_1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 28);
            this.toolStripButton1.Text = "Limpiar";
            this.toolStripButton1.ToolTipText = "Limpia el formulario actual";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // TsLimpiaForm
            // 
            this.TsLimpiaForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsLimpiaForm.Name = "TsLimpiaForm";
            this.TsLimpiaForm.Size = new System.Drawing.Size(57, 28);
            this.TsLimpiaForm.Text = "Cancelar";
            this.TsLimpiaForm.ToolTipText = "Limpia el formulario actual";
            this.TsLimpiaForm.Click += new System.EventHandler(this.TsLimpiaForm_Click);
            // 
            // FrmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(779, 749);
            this.Controls.Add(this.TStOpciones);
            this.Controls.Add(this.TabUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmOperacion";
            this.Text = "FrmOperacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOperacion_Load);
            this.TabUsuario.ResumeLayout(false);
            this.TabGral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.gbxMembresia.ResumeLayout(false);
            this.gbxMembresia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.TabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TStOpciones.ResumeLayout(false);
            this.TStOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabUsuario;
        private System.Windows.Forms.TabPage TabGral;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbxMembresia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDireccion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RDmasculino;
        private System.Windows.Forms.RadioButton RDsexoFem;
        private System.Windows.Forms.TextBox TxtDireccion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdSocio;
        private System.Windows.Forms.Label LblSocio;
        private System.Windows.Forms.TabPage TabHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cboDispositivos;
        private System.Windows.Forms.PictureBox pbFotoUser;
        private System.Windows.Forms.ToolStrip TStOpciones;
        private System.Windows.Forms.ToolStripButton TstCmdAgrefarUsr;
        private System.Windows.Forms.ToolStripTextBox TSTxtBuscaSocio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton TsLimpiaForm;
        private System.Windows.Forms.DateTimePicker DTPLockerVence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.MaskedTextBox mktFechaNacimiento;
        private System.Windows.Forms.ComboBox cbbLockers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMembresia;
        private System.Windows.Forms.TextBox txtDiasViajero;
        private System.Windows.Forms.Button btnCancelarCamara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpVencimientoViajero;
        private System.Windows.Forms.ComboBox cbbMembresiaLockers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtBuscarPorNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbProductos;
        private System.Windows.Forms.TextBox mktCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}