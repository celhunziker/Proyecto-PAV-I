using AppBTS.Datos.Daos;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    internal class FacturaService : IFacturaService
    {
        private FacturaDao dao;
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

    }
}
