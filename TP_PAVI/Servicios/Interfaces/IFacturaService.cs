using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IFacturaService
    {
        bool ValidarDatos(Factura factura);
        bool CrearFacturaConDetalle(Factura factura, Detalle_Factura detalle);
        bool Create(Factura factura);
        DataTable RecuperarProductosAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo);
        DataTable RecuperarMediosPagoAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo);
        DataTable RecuperarTipoProductosAgrupados(string fechaDesde, string fechaHasta, int orden);
    }
}
