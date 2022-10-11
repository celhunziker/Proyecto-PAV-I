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
    internal class TipoClienteService : ITipoClienteService
    {
        private ITipoCliente dao;
        public TipoClienteService()
        {
            dao = new TipoClienteDao();
        }
        public List<Tipo_Cliente> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
