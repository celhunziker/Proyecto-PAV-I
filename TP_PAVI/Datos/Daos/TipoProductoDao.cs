using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class TipoProductoDao : ITipoProducto
    {
        public List<Tipo_Producto> RecuperarTodos()
        {
            List<Tipo_Producto> lista = new List<Tipo_Producto>();
            string consulta = "SELECT * FROM Tipos_Productos WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Tipo_Producto oTipoProducto = new Tipo_Producto();
                oTipoProducto.Id_Tipo_Producto = (int)fila["id_tipo_producto"];
                oTipoProducto.NombreTipoProducto = fila["nombre"].ToString();
                oTipoProducto.Borrado = (bool)fila["borrado"];

                lista.Add(oTipoProducto);
            }
            return lista;
        }
    }
}
