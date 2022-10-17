using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
   interface IProducto
    {
        List<Producto> RecuperarTodos();
        Producto RecuperarPorId(int idProducto);
        Producto ObjectMapping(DataRow row);
        bool Create(Producto producto);
        Producto GetProductoSinParametros(string nombreProducto);
        IList<Producto> GetByFiltersSinParametros(string condiciones);

        List<Producto> RecuperarFiltrados(string nombreProducto, int? marca, int? tipo_Producto);
        bool Modificar(Producto producto);
        bool Eliminar(int idProducto);
        bool ExisteNombreProducto(string NombreProducto, int? IdProducto);
        bool ReducirStock(int idProducto, int cantidad);
    }
}
