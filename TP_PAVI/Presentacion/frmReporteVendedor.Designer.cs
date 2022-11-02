namespace AppBTS.Presentacion
{
    partial class frmReporteVendedor
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
            this.rpvVendedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rpvVendedor
            // 
            this.rpvVendedor.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptVendedores.rdlc";
            this.rpvVendedor.Location = new System.Drawing.Point(23, 221);
            this.rpvVendedor.Name = "rpvVendedor";
            this.rpvVendedor.ServerReport.BearerToken = null;
            this.rpvVendedor.Size = new System.Drawing.Size(774, 246);
            this.rpvVendedor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "desde";
            // 
            // txtMontoMaximo
            // 
            this.txtMontoMaximo.Location = new System.Drawing.Point(375, 160);
            this.txtMontoMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoMaximo.Name = "txtMontoMaximo";
            this.txtMontoMaximo.Size = new System.Drawing.Size(132, 22);
            this.txtMontoMaximo.TabIndex = 29;
            this.txtMontoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMaximo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "hasta";
            // 
            // txtMontoMinimo
            // 
            this.txtMontoMinimo.Location = new System.Drawing.Point(148, 156);
            this.txtMontoMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoMinimo.Name = "txtMontoMinimo";
            this.txtMontoMinimo.Size = new System.Drawing.Size(132, 22);
            this.txtMontoMinimo.TabIndex = 27;
            this.txtMontoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMinimo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Monto:";
            // 
            // cboOrden
            // 
            this.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Items.AddRange(new object[] {
            "Id Vendedor",
            "Nombre Vendedor"});
            this.cboOrden.Location = new System.Drawing.Point(144, 117);
            this.cboOrden.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(160, 24);
            this.cboOrden.TabIndex = 25;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(52, 121);
            this.lblMedioPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(79, 16);
            this.lblMedioPago.TabIndex = 24;
            this.lblMedioPago.Text = "Ordenar por";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(578, 25);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(219, 71);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(52, 76);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(81, 16);
            this.lblFechaHasta.TabIndex = 22;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(48, 25);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(87, 16);
            this.lblFechaDesde.TabIndex = 21;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(148, 69);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaHasta.TabIndex = 20;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(148, 25);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaDesde.TabIndex = 19;
            // 
            // frmReporteVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrden);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rpvVendedor);
            this.Name = "frmReporteVendedor";
            this.Text = "frmReporteVendedor";
            this.Load += new System.EventHandler(this.frmReporteVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    }
}