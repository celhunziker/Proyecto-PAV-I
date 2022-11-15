﻿using AppBTS.Servicios.Implementaciones;
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
            //this.dsReporteProductosVendidosBindingSource.DataSource = this.dsReporteProductosVendidos;
            //this.rpvProductosVendidos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            float monto_minimo = string.IsNullOrEmpty(txtMontoMinimo.Text) ? (float)0 : float.Parse(txtMontoMinimo.Text);
            float monto_maximo = string.IsNullOrEmpty(txtMontoMaximo.Text) ? (float)float.MaxValue : float.Parse(txtMontoMaximo.Text);
            if (monto_minimo<monto_maximo && monto_minimo >= 0 && monto_maximo >= 0)
            {
                if (dtpFechaDesde.Value <= dtpFechaHasta.Value)
                {
                    rpvProductosVendidos.LocalReport.SetParameters(new ReportParameter[]
                                       { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy")),
                                         new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy")),
                                         new ReportParameter("prOrden", cboOrden.SelectedItem.ToString()),
                                         new ReportParameter("prMontoMinimo", monto_minimo.ToString()),
                                         new ReportParameter("prMontoMaximo", monto_maximo.ToString())});
                    rpvProductosVendidos.LocalReport.DataSources.Clear();
                    rpvProductosVendidos.LocalReport.DataSources.Add(new ReportDataSource("DSReporteProductosVendidos", oFactura.RecuperarProductosAgrupados(dtpFechaDesde.Value.ToString("yyyy-MM-dd"), dtpFechaHasta.Value.ToString("yyyy-MM-dd"), cboOrden.SelectedIndex, monto_minimo, monto_maximo)));
                    rpvProductosVendidos.RefreshReport();
                }
            }
            
        }
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            return false;
        }
        private void txtMontoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                   && !char.IsDigit(e.KeyChar)
                   && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.')
            {
                // check if it's in the beginning of text not accept
                if (txtMontoMinimo.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtMontoMinimo.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtMontoMinimo.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtMontoMinimo.SelectionStart != txtMontoMinimo.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtMontoMinimo.Text.Substring(txtMontoMinimo.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtMontoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                   && !char.IsDigit(e.KeyChar)
                   && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.')
            {
                // check if it's in the beginning of text not accept
                if (txtMontoMaximo.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtMontoMaximo.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtMontoMaximo.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtMontoMaximo.SelectionStart != txtMontoMaximo.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtMontoMaximo.Text.Substring(txtMontoMaximo.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
