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
    class DescuentoService : IDescuentoService
    {
        private IDescuento dao;
        public DescuentoService()
        {
            dao = new DescuentoDao();
        }

        public Descuento traerPorCodigo(string codigo)
        {
            return dao.recuperarPorCodigo(codigo);
        }

        public List<Descuento> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
