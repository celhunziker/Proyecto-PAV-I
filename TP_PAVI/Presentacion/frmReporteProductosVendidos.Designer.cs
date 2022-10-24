namespace AppBTS.Presentacion
{
    partial class frmReporteProductosVendidos
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
            this.rpvProductosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReporteProductosVendidos = new AppBTS.Reportes.DSReporteProductosVendidos();
            this.dsReporteProductosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // rpvProductosVendidos
            // 
            this.rpvProductosVendidos.LocalReport.ReportEmbeddedResource = "AppBTS.Reportes.rptProductosVendidos.rdlc";
            this.rpvProductosVendidos.Location = new System.Drawing.Point(21, 101);
            this.rpvProductosVendidos.Name = "rpvProductosVendidos";
            this.rpvProductosVendidos.ServerReport.BearerToken = null;
            this.rpvProductosVendidos.Size = new System.Drawing.Size(767, 337);
            this.rpvProductosVendidos.TabIndex = 11;
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
            // frmReporteProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvProductosVendidos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmReporteProductosVendidos";
            this.Text = "Reporte de Productos Vendidos";
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
        private Microsoft.Reporting.WinForms.ReportViewer rpvProductosVendidos;
        private Reportes.DSReporteProductosVendidos dsReporteProductosVendidos;
        private System.Windows.Forms.BindingSource dsReporteProductosVendidosBindingSource;
    }
}