using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IUsuarioService
    {
        //COMO IMPLEMENTAMOS ESTO?
        int encontrarUsuario(string nombreUsuario, string clave);
        List<Usuario> traerTodos();

        Usuario traerPorId(int idUsuario);

        // Y ESTO?

        object ObtenerUsuario(string nombre);

        bool CrearUsuario(Usuario usuario);
        IList<Usuario> ConsultarConFiltrosSinParametros(String condiciones);
        List<Usuario> RecuperarFiltrados(string nombreUsuario, string nombre, string apellido, string email, int? perfil);
        bool ModificarUsuario(Usuario usuario);
        bool ExisteNombreUsuario(string NombreUsuario, int? IdUsuario);

        bool Eliminar(int idUsuario);
    }
}
