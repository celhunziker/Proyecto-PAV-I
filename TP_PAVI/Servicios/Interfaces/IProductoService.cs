using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IProductoService
    {
        //COMO IMPLEMENTAMOS ESTO?
        List<Producto> traerTodos();

        Producto traerPorId(int idProducto);

        // Y ESTO?

        object ObtenerProducto(string nombreProducto);

        bool CrearProducto(Producto producto);
        IList<Producto> ConsultarConFiltrosSinParametros(String condiciones);
        List<Producto> RecuperarFiltrados(string nombreProducto, int? marca, int? tipo_Producto);
        bool ModificarProducto(Producto producto);

        bool ExisteNombreProducto(string nombreProducto, int? idUsuario);
        bool Eliminar(int idProducto);
    }
}
