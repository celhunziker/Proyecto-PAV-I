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
    internal class MedioPagoService : IMedioPagoService
    {
        private IMedioPago dao;
        public MedioPagoService()
        {
            dao = new MedioPagoDao();
        }
        public List<Medio_Pago> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
