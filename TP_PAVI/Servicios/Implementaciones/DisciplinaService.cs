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
    class DisciplinaService : IDisciplinaService
    {
        private IDisciplina dao;
        public DisciplinaService()
        {
            dao = new DisciplinaDao();
        }
        public List<Disciplina> traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}

