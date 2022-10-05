using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    class MarcaService : IMarcaService
    {
        private IMarca dao;
        public MarcaService()
        {
            dao = new MarcaDao();
        }

        public List<Marca> traerTodos()
        {
            return dao.RecuperarTodos();
        }

        public Marca traerPorId(int idMarca)
        {
            return dao.RecuperarPorId(idMarca);
        }

        public object ObtenerMarca(string nombreMarca)
        {
            //SIN PARAMETROS
            return dao.GetProductoSinParametros(nombreMarca);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        public bool CrearMarca(Marca marca)
        {
            return dao.Create(marca);
        }
        public IList<Marca> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Marca> RecuperarFiltrados(string nombreMarca)
        {
            return dao.RecuperarFiltrados(nombreMarca);
        }

        public bool ModificarMarca(Marca marca)
        {
            return dao.Modificar(marca);
        }

        public bool Eliminar(int idMarca)
        {
            return dao.Eliminar(idMarca);
        }
        public bool ExisteNombreMarca(string NombreMarca, int? IdMarca)
        {
            return dao.ExisteNombreMarca(NombreMarca, IdMarca);
        }
    }
}

