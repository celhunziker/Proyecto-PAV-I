using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    internal class TipoFacturaService : ITipoFacturaService
    {
        private ITipoFactura dao;
        public TipoFacturaService()
        {
            dao = new TipoFacturaDao();
        }
        public List<Tipo_Factura> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
