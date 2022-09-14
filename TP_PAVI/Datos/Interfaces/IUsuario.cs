using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IUsuario
    {
        int validarUsuario(string nombreUsuario, string clave);
        DataTable RecuperarTodos();
        DataTable RecuperarPorId(int idUsuario);
        Usuario ObjectMapping(DataRow row);
        bool Create(Usuario usuario);
        Usuario GetUserSinParametros(string nombreUsuario);
        IList<Usuario> GetByFiltersSinParametros(string condiciones);

        DataTable RecuperarFiltrados(string nombreUsuario, string nombre, string apellido, string email, int? perfil);
        bool Modificar(Usuario usuario);
        bool Eliminar(int idUsuario);
    }
}
