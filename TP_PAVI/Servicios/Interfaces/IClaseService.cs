using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IClaseService
    {
        List<Clase> traerTodos();

        Clase traerPorId(int idClase);
        //object ObtenerProducto(string nombreProducto);

        bool CrearClase(Clase clase);
        IList<Clase> ConsultarConFiltrosSinParametros(String condiciones);
        List<Clase> RecuperarFiltrados(DateTime horario, string diaSemana, int? disciplina);
        bool ModificarClase(Clase clase);

        //bool ExisteNombreProducto(string nombreProducto, int? idUsuario);
        bool Eliminar(int idClase);
    }
}
