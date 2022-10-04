using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface ITipoProductoService
    {
         List<Tipo_Producto> traerTodos();
        Tipo_Producto traerPorId(int idTipoProducto);

        // Y ESTO?

        object ObtenerTipoProducto(string nombreTipoProducto);

        bool CrearTipoProducto(Tipo_Producto tipoProducto);
        IList<Tipo_Producto> ConsultarConFiltrosSinParametros(String condiciones);
        List<Tipo_Producto> RecuperarFiltrados(string nombreTipoProducto);
        bool ModificarTipoProducto(Tipo_Producto tipoProducto);

        bool ExisteNombreTipoProducto(string nombreTipoProducto, int? idTipoProducto);
        bool Eliminar(int idTipoProducto);
    }
}
