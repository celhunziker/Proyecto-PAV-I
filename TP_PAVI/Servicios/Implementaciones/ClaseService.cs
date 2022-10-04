using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    class ClaseService : IClaseService
    {
        private IClase dao;

        public ClaseService()
        {
            dao = new ClaseDao();
        }
        public List<Clase> traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public Clase traerPorId(int idClase)
        {
            return dao.RecuperarPorId(idClase);
        }

        //public object ObtenerProducto(string nombreProducto)
        //{
        //    //SIN PARAMETROS
        //    return dao.GetProductoSinParametros(nombreProducto);

        //    //CON PARAMETROS
        //    //return dao.GetUserConParametros(usuario);
        //}
        public bool CrearClase(Clase clase)
        {
            return dao.Create(clase);
        }
        public IList<Clase> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Clase> RecuperarFiltrados(DateTime horario, string diaSemana, int? disciplina)
        {
            return dao.RecuperarFiltrados(horario, diaSemana, disciplina);
        }

        public bool ModificarClase(Clase clase)
        {
            return dao.Modificar(clase);
        }

        public bool Eliminar(int idClase)
        {
            return dao.Eliminar(idClase);
        }
    }
}