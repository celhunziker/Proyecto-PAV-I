using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface ITipoProducto
    {
        List<Tipo_Producto> RecuperarTodos();
        Tipo_Producto RecuperarPorId(int idTipoProducto);
        Tipo_Producto ObjectMapping(DataRow row);
        bool Create(Tipo_Producto tipoProducto);
        Tipo_Producto GetProductoSinParametros(string nombreTipoProducto);
        IList<Tipo_Producto> GetByFiltersSinParametros(string condiciones);

        List<Tipo_Producto> RecuperarFiltrados(string nombreTipoProducto);
        bool Modificar(Tipo_Producto tipoProducto);
        bool Eliminar(int idTipoProducto);
        bool ExisteNombreTipoProducto(string NombreTipoProducto, int? IdTipoProducto);
    }
}
