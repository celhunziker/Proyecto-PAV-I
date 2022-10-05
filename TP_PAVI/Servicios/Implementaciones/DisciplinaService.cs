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
        public Disciplina traerPorId(int idDisciplina)
        {
            return dao.RecuperarPorId(idDisciplina);
        }

        public object ObtenerDisciplina(string nombreDisciplina)
        {
            //SIN PARAMETROS
            return dao.GetProductoSinParametros(nombreDisciplina);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        public bool CrearDisciplina(Disciplina disciplina)
        {
            return dao.Create(disciplina);
        }
        public IList<Disciplina> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Disciplina> RecuperarFiltrados(string nombreDisciplina)
        {
            return dao.RecuperarFiltrados(nombreDisciplina);
        }

        public bool ModificarDisciplina(Disciplina disciplina)
        {
            return dao.Modificar(disciplina);
        }

        public bool Eliminar(int idDisciplina)
        {
            return dao.Eliminar(idDisciplina);
        }
        public bool ExisteNombreDisciplina(string NombreDisciplina, int? IdDisciplina)
        {
            return dao.ExisteNombreDisciplina(NombreDisciplina, IdDisciplina);
        }
    }
}

