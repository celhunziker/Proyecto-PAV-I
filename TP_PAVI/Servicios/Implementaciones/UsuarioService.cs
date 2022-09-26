using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class UsuarioService : IUsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }
        public int encontrarUsuario(string nombreUsuario, string clave)
        {
            return dao.validarUsuario(nombreUsuario, clave);
        }
        public List<Usuario> traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public Usuario traerPorId(int idUsuario)
        {
            return dao.RecuperarPorId(idUsuario);
        }

        public object ObtenerUsuario(string nombre)
        {
            //SIN PARAMETROS
            return dao.GetUserSinParametros(nombre);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        public bool CrearUsuario(Usuario usuario)
        {
            return dao.Create(usuario);
        }
        public IList<Usuario> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Usuario> RecuperarFiltrados(string nombreUsuario, string nombre, string apellido, string email, int? perfil)
        {
            return dao.RecuperarFiltrados(nombreUsuario, nombre, apellido, email, perfil);
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            return dao.Modificar(usuario);
        }

        public bool Eliminar(int idUsuario)
        {
            return dao.Eliminar(idUsuario);
        }
    }
}
