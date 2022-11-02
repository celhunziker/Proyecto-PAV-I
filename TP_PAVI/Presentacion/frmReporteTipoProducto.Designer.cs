namespace AppBTS.Presentacion
{
    partial class frmReporteTipoProducto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.rpvTipoProducto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "desde";
            // 
            // txtMontoMaximo
            // 
            //this.txtMontoMaximo.Location = new System.Drawing.Point(291, 131);
            //this.txtMontoMaximo.Name = "txtMontoMaximo";
            //this.txtMontoMaximo.Size = new System.Drawing.Size(100, 20);
            //this.txtMontoMaximo.TabIndex = 29;
            //this.txtMontoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMaximo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "hasta";
            // 
            // txtMontoMinimo
            // 
            //this.txtMontoMinimo.Location = new System.Drawing.Point(121, 128);
            //this.txtMontoMinimo.Name = "txtMontoMinimo";
            //this.txtMontoMinimo.Size = new System.Drawing.Size(100, 20);
            //this.txtMontoMinimo.TabIndex = 27;
            //this.txtMontoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMinimo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Monto:";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Items.AddRange(new object[] {
            "id tipo producto",
            "nombre",
            "cantidad"});
            this.cboTipoProducto.Location = new System.Drawing.Point(118, 96);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cboTipoProducto.TabIndex = 25;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(49, 99);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(63, 13);
            this.lblMedioPago.TabIndex = 24;
            this.lblMedioPago.Text = "Ordenar por";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(443, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(164, 58);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(49, 63);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(66, 13);
            this.lblFechaHasta.TabIndex = 22;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(46, 21);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lblFechaDesde.TabIndex = 21;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(121, 57);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 20;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(121, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 19;
            // 
            // rpvTipoProducto
            // 
            this.rpvTipoProducto.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptTipoProducto.rdlc";
            this.rpvTipoProducto.Location = new System.Drawing.Point(49, 175);
            this.rpvTipoProducto.Name = "rpvTipoProducto";
            this.rpvTipoProducto.ServerReport.BearerToken = null;
            this.rpvTipoProducto.Size = new System.Drawing.Size(682, 246);
            this.rpvTipoProducto.TabIndex = 31;
            // 
            // frmReporteTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvTipoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmReporteTipoProducto";
            this.Text = "frmReporteTipoProducto";
            this.Load += new System.EventHandler(this.frmReporteTipoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTipoProducto;
    }
}