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
    internal class MarcaTarjetaService : IMarcaTarjetaService
    {
        private IMarcaTarjeta dao;
        public MarcaTarjetaService()
        {
            dao = new MarcaTarjetaDao();
        }
        public List<Marca_Tarjeta> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
