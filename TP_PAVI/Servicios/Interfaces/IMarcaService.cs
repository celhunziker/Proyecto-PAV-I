using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IMarcaService
    {
        List<Marca> traerTodos();
        Marca traerPorId(int idMarca);

        // Y ESTO?

        object ObtenerMarca(string nombreMarca);

        bool CrearMarca(Marca marca);
        IList<Marca> ConsultarConFiltrosSinParametros(String condiciones);
        List<Marca> RecuperarFiltrados(string nombreMarca);
        bool ModificarMarca(Marca marca);

        bool ExisteNombreMarca(string nombreMarca, int? idMarca);
        bool Eliminar(int idMarca);
    }
}
