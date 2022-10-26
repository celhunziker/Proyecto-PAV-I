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
    public partial class frmReporteVentaMedioPago : Form
    {
        private IFacturaService oFactura;
        public frmReporteVentaMedioPago()
        {
            InitializeComponent();
            oFactura = new FacturaService();
        }

        private void frmReporteProductosVendidos_Load(object sender, EventArgs e)
        {
            //this.dsReporteProductosVendidosBindingSource.DataSource = this.dsReporteProductosVendidos;
            //this.rpvProductosVendidos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value <= dtpFechaHasta.Value) 
            {
                float monto_minimo = string.IsNullOrEmpty(txtMontoMinimo.Text) ? (float)-1 : float.Parse(txtMontoMinimo.Text);
                float monto_maximo = string.IsNullOrEmpty(txtMontoMaximo.Text) ? (float)-1 : float.Parse(txtMontoMaximo.Text);
                rpvVentaMedioPago.LocalReport.SetParameters(new ReportParameter[]
                                   { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                     new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")),
                                     new ReportParameter("prOrden", cboMedioPago.SelectedItem.ToString()),
                                     new ReportParameter("prMontoMinimo", monto_minimo.ToString()),
                                     new ReportParameter("prMontoMaximo", monto_maximo.ToString())});
                rpvVentaMedioPago.LocalReport.DataSources.Clear();
                
                rpvVentaMedioPago.LocalReport.DataSources.Add(new ReportDataSource("DSReporteVentaMedioPago", oFactura.RecuperarMediosPagoAgrupados(dtpFechaDesde.Value.ToString("yyyy-MM-dd"), dtpFechaHasta.Value.ToString("yyyy-MM-dd"), cboMedioPago.SelectedIndex, monto_minimo, monto_maximo)));
                rpvVentaMedioPago.RefreshReport();
            }
        }

        private void txtMontoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ver
        }
    }
}
