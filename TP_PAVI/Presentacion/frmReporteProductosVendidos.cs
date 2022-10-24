using AppBTS.Servicios.Implementaciones;
using AppBTS.Servicios.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmReporteProductosVendidos : Form
    {
        private IFacturaService oFactura;
        public frmReporteProductosVendidos()
        {
            InitializeComponent();
            oFactura = new FacturaService();
        }

        private void frmReporteProductosVendidos_Load(object sender, EventArgs e)
        {
            this.dsReporteProductosVendidosBindingSource.DataSource = this.dsReporteProductosVendidos;
            this.rpvProductosVendidos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value <= dtpFechaHasta.Value) 
            {
                rpvProductosVendidos.LocalReport.SetParameters(new ReportParameter[]
                                   { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                     new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy"))});
                this.dsReporteProductosVendidosBindingSource.DataSource = oFactura.RecuperarProductosAgrupados(dtpFechaDesde.Value.ToString("yyyy-MM-dd"),dtpFechaHasta.Value.ToString("yyyy-MM-dd"));
            }
        }

        
    }
}
