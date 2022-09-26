using AppBTS.Entidades;
using System.Collections.Generic;
using System.Data;

namespace AppBTS.Datos.Interfaces
{
    interface IPerfil
    {
        List<Perfil> RecuperarTodos();
    }
}