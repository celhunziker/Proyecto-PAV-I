using AppBTS.Datos.Daos;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    internal class FacturaService : IFacturaService
    {
        private FacturaDao dao;
        public FacturaService()
        {
            dao = new FacturaDao();
        }
        public bool ValidarDatos(Factura factura)
        {
            if (factura.FacturaDetalle.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de factura.");
            }

            return true;
        }
        public bool CrearFacturaConDetalle(Factura factura, Detalle_Factura detalle)
        {
            return dao.InsertarFacturaConDetalle(factura, detalle);
        }
        public bool Create(Factura factura)
        {
            return dao.Create(factura);
        }

        public DataTable RecuperarProductosAgrupados(string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarProductosAgrupados(fechaDesde, fechaHasta);
        }

        public DataTable RecuperarMediosPagoAgrupados(string fechaDesde, string fechaHasta, int orden, float monto_minimo, float monto_maximo)
        {
            return dao.RecuperarMediosPagoAgrupados(fechaDesde, fechaHasta, orden, monto_minimo, monto_maximo);
        }
    }
}
