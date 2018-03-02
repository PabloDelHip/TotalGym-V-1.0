namespace CapaPresentacion
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoDeEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialCortesCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortesDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeObservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbImagenSocio = new System.Windows.Forms.PictureBox();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.cancelarTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.instructoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.configuracionesToolStripMenuItem,
            this.historialCortesCajaToolStripMenuItem,
            this.historialDeObservacionesToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteToolStripMenuItem,
            this.observacionToolStripMenuItem,
            this.membresiasToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // corteToolStripMenuItem
            // 
            this.corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            this.corteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.corteToolStripMenuItem.Text = "Corte";
            this.corteToolStripMenuItem.Click += new System.EventHandler(this.corteToolStripMenuItem_Click);
            // 
            // observacionToolStripMenuItem
            // 
            this.observacionToolStripMenuItem.Name = "observacionToolStripMenuItem";
            this.observacionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.observacionToolStripMenuItem.Text = "Observacion";
            this.observacionToolStripMenuItem.Click += new System.EventHandler(this.observacionToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            this.membresiasToolStripMenuItem.Click += new System.EventHandler(this.membresiasToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deudasToolStripMenuItem,
            this.deudasToolStripMenuItem1,
            this.entradasToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // deudasToolStripMenuItem
            // 
            this.deudasToolStripMenuItem.Name = "deudasToolStripMenuItem";
            this.deudasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deudasToolStripMenuItem.Text = "Operaciones";
            this.deudasToolStripMenuItem.Click += new System.EventHandler(this.deudasToolStripMenuItem_Click);
            // 
            // deudasToolStripMenuItem1
            // 
            this.deudasToolStripMenuItem1.Name = "deudasToolStripMenuItem1";
            this.deudasToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.deudasToolStripMenuItem1.Text = "Pagos y adeudos";
            this.deudasToolStripMenuItem1.Click += new System.EventHandler(this.deudasToolStripMenuItem1_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // instructoresToolStripMenuItem
            // 
            this.instructoresToolStripMenuItem.Name = "instructoresToolStripMenuItem";
            this.instructoresToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructoresToolStripMenuItem.Text = "Instructores";
            this.instructoresToolStripMenuItem.Click += new System.EventHandler(this.instructoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoDeEmailsToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // textoDeEmailsToolStripMenuItem
            // 
            this.textoDeEmailsToolStripMenuItem.Name = "textoDeEmailsToolStripMenuItem";
            this.textoDeEmailsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.textoDeEmailsToolStripMenuItem.Text = "Texto de Emails";
            this.textoDeEmailsToolStripMenuItem.Click += new System.EventHandler(this.textoDeEmailsToolStripMenuItem_Click);
            // 
            // historialCortesCajaToolStripMenuItem
            // 
            this.historialCortesCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortesDeCajaToolStripMenuItem});
            this.historialCortesCajaToolStripMenuItem.Name = "historialCortesCajaToolStripMenuItem";
            this.historialCortesCajaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.historialCortesCajaToolStripMenuItem.Text = "Historial Cortes Caja";
            // 
            // cortesDeCajaToolStripMenuItem
            // 
            this.cortesDeCajaToolStripMenuItem.Name = "cortesDeCajaToolStripMenuItem";
            this.cortesDeCajaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cortesDeCajaToolStripMenuItem.Text = "Cortes de Caja";
            this.cortesDeCajaToolStripMenuItem.Click += new System.EventHandler(this.cortesDeCajaToolStripMenuItem_Click);
            // 
            // historialDeObservacionesToolStripMenuItem
            // 
            this.historialDeObservacionesToolStripMenuItem.Name = "historialDeObservacionesToolStripMenuItem";
            this.historialDeObservacionesToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.historialDeObservacionesToolStripMenuItem.Text = "Historial de Observaciones";
            this.historialDeObservacionesToolStripMenuItem.Click += new System.EventHandler(this.historialDeObservacionesToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.retirarToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.cancelarTicketToolStripMenuItem,
            this.cerrarCajaToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // retirarToolStripMenuItem
            // 
            this.retirarToolStripMenuItem.Name = "retirarToolStripMenuItem";
            this.retirarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retirarToolStripMenuItem.Text = "Retirar";
            this.retirarToolStripMenuItem.Click += new System.EventHandler(this.retirarToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // cerrarCajaToolStripMenuItem
            // 
            this.cerrarCajaToolStripMenuItem.Name = "cerrarCajaToolStripMenuItem";
            this.cerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarCajaToolStripMenuItem.Text = "Cerrar caja";
            this.cerrarCajaToolStripMenuItem.Click += new System.EventHandler(this.cerrarCajaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFechaVencimiento);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptbImagenSocio);
            this.panel1.Location = new System.Drawing.Point(829, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 1121);
            this.panel1.TabIndex = 9;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(22, 392);
            this.txtFechaVencimiento.Multiline = true;
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(500, 42);
            this.txtFechaVencimiento.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 311);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(500, 42);
            this.txtNombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE";
            // 
            // ptbImagenSocio
            // 
            this.ptbImagenSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagenSocio.Location = new System.Drawing.Point(20, 10);
            this.ptbImagenSocio.Name = "ptbImagenSocio";
            this.ptbImagenSocio.Size = new System.Drawing.Size(315, 264);
            this.ptbImagenSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenSocio.TabIndex = 8;
            this.ptbImagenSocio.TabStop = false;
            this.ptbImagenSocio.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pPrincipal.BackColor = System.Drawing.Color.White;
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Location = new System.Drawing.Point(12, 27);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(811, 448);
            this.pPrincipal.TabIndex = 10;
            // 
            // cancelarTicketToolStripMenuItem
            // 
            this.cancelarTicketToolStripMenuItem.Name = "cancelarTicketToolStripMenuItem";
            this.cancelarTicketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelarTicketToolStripMenuItem.Text = "Cancelar ticket";
            this.cancelarTicketToolStripMenuItem.Click += new System.EventHandler(this.cancelarTicketToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmSocios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmSocios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox ptbImagenSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instructoresToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoDeEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialCortesCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortesDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeObservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarTicketToolStripMenuItem;
    }
}