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
    class TipoProductoService : ITipoProductoService
    {
        private ITipoProducto dao;
        public TipoProductoService()
        {
            dao = new TipoProductoDao();
        }
        public List<Tipo_Producto> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
