using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class PerfilService : IPerfilService
    {
        private IPerfil dao;
        public PerfilService()
        {
            dao = new PerfilDao();
        }
        public List<Perfil> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
