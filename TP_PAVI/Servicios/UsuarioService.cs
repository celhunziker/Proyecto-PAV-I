using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class UsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }
        public int encontrarUsuario(string nombre, string clave)
        {
            return dao.validarUsuario(nombre, clave);
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable traerPorId(int idUsuario)
        {
            return dao.RecuperarPorId(idUsuario);
        }

        internal object ObtenerUsuario(string usuario)
        {
            //SIN PARAMETROS
            return dao.GetUserSinParametros(usuario);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        internal bool CrearUsuario(Usuario usuario)
        {
            return dao.Create(usuario);
        }
        internal IList<Usuario> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public DataTable RecuperarFiltrados(string nombre, string email, int? perfil)
        {
            return dao.RecuperarFiltrados(nombre, email, perfil);
        }

        internal bool ModificarUsuario(Usuario usuario)
        {
            return dao.Modificar(usuario);
        }

        internal bool Eliminar(int idUsuario)
        {
            return dao.Eliminar(idUsuario);
        }
    }
}
