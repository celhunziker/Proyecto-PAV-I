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
    class UnidadMedidaService : IUnidadMedidaService
    {
        private IUnidadMedida dao;
        public UnidadMedidaService()
        {
            dao = new UnidadMedidaDao();
        }
        public List<Unidad_Medida> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}

