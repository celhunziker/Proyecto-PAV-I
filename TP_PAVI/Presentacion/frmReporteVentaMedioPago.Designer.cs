namespace AppBTS.Presentacion
{
    partial class frmReporteVentaMedioPago
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.rpvVentaMedioPago = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReporteProductosVendidos = new AppBTS.Reportes.DSReporteProductosVendidos();
            this.dsReporteProductosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.cboMedioPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoMinimo = new System.Windows.Forms.TextBox();
            this.txtMontoMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteProductosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteProductosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(494, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(164, 58);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(100, 54);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(66, 13);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(97, 12);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lblFechaDesde.TabIndex = 8;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(172, 48);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(172, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // rpvVentaMedioPago
            // 
            this.rpvVentaMedioPago.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptVentaMedioPago.rdlc";
            this.rpvVentaMedioPago.Location = new System.Drawing.Point(21, 184);
            this.rpvVentaMedioPago.Name = "rpvVentaMedioPago";
            this.rpvVentaMedioPago.ServerReport.BearerToken = null;
            this.rpvVentaMedioPago.Size = new System.Drawing.Size(767, 254);
            this.rpvVentaMedioPago.TabIndex = 11;
            // 
            // dsReporteProductosVendidos
            // 
            this.dsReporteProductosVendidos.DataSetName = "DSReporteProductosVendidos";
            this.dsReporteProductosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsReporteProductosVendidosBindingSource
            // 
            this.dsReporteProductosVendidosBindingSource.DataSource = this.dsReporteProductosVendidos;
            this.dsReporteProductosVendidosBindingSource.Position = 0;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(100, 90);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(63, 13);
            this.lblMedioPago.TabIndex = 12;
            this.lblMedioPago.Text = "Ordenar por";
            // 
            // cboMedioPago
            // 
            this.cboMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioPago.FormattingEnabled = true;
            this.cboMedioPago.Items.AddRange(new object[] {
            "Id medio de pago",
            "Nombre de medio de pago"});
            this.cboMedioPago.Location = new System.Drawing.Point(169, 87);
            this.cboMedioPago.Name = "cboMedioPago";
            this.cboMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cboMedioPago.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Monto:";
            // 
            // txtMontoMinimo
            // 
            this.txtMontoMinimo.Location = new System.Drawing.Point(172, 119);
            this.txtMontoMinimo.Name = "txtMontoMinimo";
            this.txtMontoMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMinimo.TabIndex = 15;
            this.txtMontoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMinimo_KeyPress);
            // 
            // txtMontoMaximo
            // 
            this.txtMontoMaximo.Location = new System.Drawing.Point(342, 122);
            this.txtMontoMaximo.Name = "txtMontoMaximo";
            this.txtMontoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMaximo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "desde";
            // 
            // frmReporteVentaMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMedioPago);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.rpvVentaMedioPago);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmReporteVentaMedioPago";
            this.Text = "Reporte de Medios de Pago";
            this.Load += new System.EventHandler(this.frmReporteProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteProductosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteProductosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentaMedioPago;
        private Reportes.DSReporteProductosVendidos dsReporteProductosVendidos;
        private System.Windows.Forms.BindingSource dsReporteProductosVendidosBindingSource;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cboMedioPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoMinimo;
        private System.Windows.Forms.TextBox txtMontoMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}