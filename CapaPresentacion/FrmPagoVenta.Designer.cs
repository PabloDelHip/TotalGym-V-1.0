﻿namespace CapaPresentacion
{
    partial class FrmPagoVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.recibio = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total A Pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(93, 46);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(128, 31);
            this.txtTotalAPagar.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(82, 114);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 31);
            this.txtCantidad.TabIndex = 3;
            // 
            // recibio
            // 
            this.recibio.AutoSize = true;
            this.recibio.Location = new System.Drawing.Point(129, 98);
            this.recibio.Name = "recibio";
            this.recibio.Size = new System.Drawing.Size(38, 13);
            this.recibio.TabIndex = 2;
            this.recibio.Text = "recibio";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "",
            "Efectivo",
            "Tarjeta"});
            this.cmbTipoPago.Location = new System.Drawing.Point(93, 186);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPago.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Pago";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPagoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.recibio);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagoVenta";
            this.Text = "FrmPagoVenta";
            this.Load += new System.EventHandler(this.FrmPagoVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label recibio;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}