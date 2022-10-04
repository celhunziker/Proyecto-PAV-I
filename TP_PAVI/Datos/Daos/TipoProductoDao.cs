using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Implementaciones;
using AppBTS.Servicios.Interfaces;
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
                oTipoProducto.Descripcion = fila["descripcion"].ToString();
                oTipoProducto.Borrado = (bool)fila["borrado"];

                lista.Add(oTipoProducto);
            }
            return lista;
        }

        public Tipo_Producto RecuperarPorId(int idTipoProducto)
        {
            string condicion = " AND id_tipo_producto =" + idTipoProducto;
            String strSql = string.Concat(" SELECT id_tipo_producto, ",
                                              "        nombre, ",
                                              "        descripcion",
                                              "   FROM Tipos_Productos",
                                              " WHERE borrado = 0",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }



        public bool Create(Tipo_Producto tipoProducto)
        {
            string consulta = "INSERT INTO Tipos_Productos (nombre, descripcion, borrado)" +
                            " VALUES (" +
                            "'" + tipoProducto.NombreTipoProducto + "'" + "," +
                            "'" + tipoProducto.Descripcion + "'" + ",0)";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Tipo_Producto GetProductoSinParametros(string nombreTipoProducto)
        {
            String strSql = string.Concat(" SELECT id_tipo_producto, ",
                                              "        descripcion, ",
                                              "        nombre",
                                              "   FROM Tipos_Productos",
                                              " WHERE borrado = 0");

            strSql += " AND nombre " + "'" + nombreTipoProducto + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Tipo_Producto> GetByFiltersSinParametros(String condiciones)
        {

            List<Tipo_Producto> lst = new List<Tipo_Producto>();
            String strSql = string.Concat(" SELECT id_tipo_producto, ",
                                              "        descripcion, ",
                                              "        nombre",
                                              "   FROM Tipos_Productos",
                                              " WHERE borrado = 0");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Tipo_Producto> RecuperarFiltrados(string nombreTipoProducto)
        {
            List<Tipo_Producto> lista = new List<Tipo_Producto>();
            string strSql = string.Concat(" SELECT id_tipo_producto, ",
                                              "        descripcion, ",
                                              "        nombre",
                                              "   FROM Tipos_Productos",
                                              " WHERE borrado = 0");
            if (nombreTipoProducto != "")
            {
                strSql = strSql + " AND nombre LIKE '%" + nombreTipoProducto + "%'";
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Tipo_Producto oTipoProducto = ObjectMapping(fila);
                lista.Add(oTipoProducto);
            }
            return lista;
        }

        public bool Modificar(Tipo_Producto tipoProducto)
        {
            string consulta = "UPDATE Tipos_Productos SET nombre='"
                + tipoProducto.NombreTipoProducto +  "', descripcion='" + tipoProducto.Descripcion +
                "' WHERE id_tipo_producto = " + tipoProducto.Id_Tipo_Producto;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idTipoProducto)
        {
            string consulta = " UPDATE Tipos_Productos SET borrado = 1" +
                " WHERE id_tipo_producto = " + idTipoProducto;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        //VER BIEN ESTO
        public Tipo_Producto ObjectMapping(DataRow row)
        {
            Tipo_Producto oTipoProducto = new Tipo_Producto
            {
                Id_Tipo_Producto = Convert.ToInt32(row["id_tipo_producto"].ToString()),
                NombreTipoProducto = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
            };

            return oTipoProducto; ;
        }

        public bool ExisteNombreTipoProducto(string NombreTipoProducto, int? IdTipoProducto)
        {
            string consulta = "SELECT * FROM Tipos_Productos WHERE nombre = '" +
                NombreTipoProducto + "'";
            if (IdTipoProducto != null)
            {
                consulta = consulta + " AND id_tipo_producto != " + IdTipoProducto;
            }
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }
    }
}
