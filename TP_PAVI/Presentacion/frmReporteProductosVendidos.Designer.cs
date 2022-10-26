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
            this.cboOrden = new System.Windows.Forms.ComboBox();
            this.lblOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.rpvProductosVendidos.Location = new System.Drawing.Point(12, 188);
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
            // cboOrden
            // 
            this.cboOrden.AllowDrop = true;
            this.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Items.AddRange(new object[] {
            "Id producto",
            "Nombre producto",
            "Unidades Vendidas",
            "Dinero generado"});
            this.cboOrden.Location = new System.Drawing.Point(172, 88);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(200, 21);
            this.cboOrden.TabIndex = 12;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(97, 91);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(66, 13);
            this.lblOrden.TabIndex = 13;
            this.lblOrden.Text = "Ordenar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "desde";
            // 
            // txtMontoMaximo
            // 
            this.txtMontoMaximo.Location = new System.Drawing.Point(319, 124);
            this.txtMontoMaximo.Name = "txtMontoMaximo";
            this.txtMontoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMaximo.TabIndex = 22;
            this.txtMontoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMaximo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "hasta";
            // 
            // txtMontoMinimo
            // 
            this.txtMontoMinimo.Location = new System.Drawing.Point(171, 124);
            this.txtMontoMinimo.Name = "txtMontoMinimo";
            this.txtMontoMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMinimo.TabIndex = 20;
            this.txtMontoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMinimo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Monto:";
            // 
            // frmReporteProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.cboOrden);
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
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoMinimo;
        private System.Windows.Forms.Label label1;
    }
}