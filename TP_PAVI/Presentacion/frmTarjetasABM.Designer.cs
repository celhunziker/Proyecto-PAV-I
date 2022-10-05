namespace AppBTS.Presentacion
{
    partial class frmTarjetasABM
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFechaVencDivisor = new System.Windows.Forms.Label();
            this.txtFechaVencAnio = new System.Windows.Forms.TextBox();
            this.txtFechaVencMes = new System.Windows.Forms.TextBox();
            this.cboMarcaTarjeta = new System.Windows.Forms.ComboBox();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblMarcaTarjeta = new System.Windows.Forms.Label();
            this.lblNroTarjeta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 45);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(68, 152);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 45);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFechaVencDivisor
            // 
            this.lblFechaVencDivisor.AutoSize = true;
            this.lblFechaVencDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencDivisor.Location = new System.Drawing.Point(190, 98);
            this.lblFechaVencDivisor.Name = "lblFechaVencDivisor";
            this.lblFechaVencDivisor.Size = new System.Drawing.Size(15, 24);
            this.lblFechaVencDivisor.TabIndex = 64;
            this.lblFechaVencDivisor.Text = "/";
            // 
            // txtFechaVencAnio
            // 
            this.txtFechaVencAnio.Location = new System.Drawing.Point(211, 102);
            this.txtFechaVencAnio.MaxLength = 2;
            this.txtFechaVencAnio.Name = "txtFechaVencAnio";
            this.txtFechaVencAnio.Size = new System.Drawing.Size(41, 20);
            this.txtFechaVencAnio.TabIndex = 63;
            this.txtFechaVencAnio.TextChanged += new System.EventHandler(this.txtFechaVencAnio_TextChanged);
            this.txtFechaVencAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // txtFechaVencMes
            // 
            this.txtFechaVencMes.Location = new System.Drawing.Point(146, 102);
            this.txtFechaVencMes.MaxLength = 2;
            this.txtFechaVencMes.Name = "txtFechaVencMes";
            this.txtFechaVencMes.Size = new System.Drawing.Size(41, 20);
            this.txtFechaVencMes.TabIndex = 62;
            this.txtFechaVencMes.TextChanged += new System.EventHandler(this.txtFechaVencMes_TextChanged);
            this.txtFechaVencMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // cboMarcaTarjeta
            // 
            this.cboMarcaTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaTarjeta.FormattingEnabled = true;
            this.cboMarcaTarjeta.Location = new System.Drawing.Point(146, 70);
            this.cboMarcaTarjeta.Name = "cboMarcaTarjeta";
            this.cboMarcaTarjeta.Size = new System.Drawing.Size(283, 21);
            this.cboMarcaTarjeta.TabIndex = 61;
            this.cboMarcaTarjeta.SelectedIndexChanged += new System.EventHandler(this.cboMarcaTarjeta_SelectedIndexChanged);
            // 
            // lblFechaVenc
            // 
            this.lblFechaVenc.AutoSize = true;
            this.lblFechaVenc.Location = new System.Drawing.Point(17, 105);
            this.lblFechaVenc.Name = "lblFechaVenc";
            this.lblFechaVenc.Size = new System.Drawing.Size(126, 13);
            this.lblFechaVenc.TabIndex = 60;
            this.lblFechaVenc.Text = "Fecha de Vencimiento (*)";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(146, 39);
            this.txtNumeroTarjeta.MaxLength = 16;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(283, 20);
            this.txtNumeroTarjeta.TabIndex = 58;
            this.txtNumeroTarjeta.TextChanged += new System.EventHandler(this.txtNumeroTarjeta_TextChanged);
            this.txtNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // lblMarcaTarjeta
            // 
            this.lblMarcaTarjeta.AutoSize = true;
            this.lblMarcaTarjeta.Location = new System.Drawing.Point(46, 73);
            this.lblMarcaTarjeta.Name = "lblMarcaTarjeta";
            this.lblMarcaTarjeta.Size = new System.Drawing.Size(97, 13);
            this.lblMarcaTarjeta.TabIndex = 59;
            this.lblMarcaTarjeta.Text = "Marca de tarjeta (*)";
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.lblNroTarjeta.Location = new System.Drawing.Point(36, 42);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(104, 13);
            this.lblNroTarjeta.TabIndex = 57;
            this.lblNroTarjeta.Text = "Número de tarjeta (*)";
            // 
            // frmTarjetasABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 225);
            this.Controls.Add(this.lblFechaVencDivisor);
            this.Controls.Add(this.txtFechaVencAnio);
            this.Controls.Add(this.txtFechaVencMes);
            this.Controls.Add(this.cboMarcaTarjeta);
            this.Controls.Add(this.lblFechaVenc);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblMarcaTarjeta);
            this.Controls.Add(this.lblNroTarjeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmTarjetasABM";
            this.Text = "Tarjetas ABM";
            this.Load += new System.EventHandler(this.frmTarjetasABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFechaVencDivisor;
        private System.Windows.Forms.TextBox txtFechaVencAnio;
        private System.Windows.Forms.TextBox txtFechaVencMes;
        private System.Windows.Forms.ComboBox cboMarcaTarjeta;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblMarcaTarjeta;
        private System.Windows.Forms.Label lblNroTarjeta;
    }
}