using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using AppBTS.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Servicios.Implementaciones;

namespace AppBTS.Datos.Daos
{
    class ProductoDao : IProducto
    {
        //ESTO ESTA BIEN? DEBERIA SER DE ESTA MANERA U OTRA? BOTTA NO MOSTRO TODAVIA
        //TAMBIEN LA CARGA DE COMBOS Y GRILLAS TIRO UNAS IDEAS
        //PERO NO TERMINO DE IMPLEMENTAR
        private ITipoProductoService oTipoProducto = new TipoProductoService();
        private IMarcaService oMarca = new MarcaService();
        private IUnidadMedidaService oUnidadMedida = new UnidadMedidaService();

        public List<Producto> RecuperarTodos()
        {
            List<Producto> lista = new List<Producto>();
            String strSql = string.Concat(" SELECT id_producto, ",
                                              "        marca, ",
                                              "        contenido, ",
                                              "        unidad_de_medida, ",
                                              "        tipo_producto, ",
                                              "        pr.descripcion, " +
                                              "        stock ," +
                                              "        precio, ",
                                              "        pr.nombre, ",
                                              "        pr.borrado, ",
                                              "        m.id_marca, ",
                                              "        tp.id_tipo_producto, ",
                                              "        um.id_unidad_medida, ",
                                              "        m.nombre as nombreMarca, ",
                                              "        tp.nombre as nombreTipoProducto, ",
                                              "        um.nombre as nombreUnidadMedida ",
                                              "   FROM Productos pr",
                                              "  INNER JOIN Marcas m ON pr.marca= m.id_marca ",
                                              "  INNER JOIN Tipos_Productos tp ON pr.tipo_producto= tp.id_tipo_producto ",
                                              "  INNER JOIN Unidades_de_medida um ON pr.unidad_de_medida= um.id_unidad_medida ",
                                              " WHERE pr.borrado = 0");

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            //LLAMAMOS A LOS PERFILES Y LOS VAMOS ASIGNANDO CON RESPECTO A ID PERFIL?
            //List<Perfil> listaPerfil = oPerfil.traerTodos();
            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = ObjectMapping(fila);
                lista.Add(oProducto);
            }
            return lista;
        }

        public Producto RecuperarPorId(int idProducto)
        {
            string condicion = " AND id_producto =" + idProducto;
            String strSql = string.Concat(" SELECT id_producto, ",
                                              "        marca, ",
                                              "        contenido, ",
                                              "        unidad_de_medida, ",
                                              "        tipo_producto, ",
                                              "        pr.descripcion, " +
                                              "        stock ," +
                                              "        precio, ",
                                              "        pr.nombre, ",
                                              "        pr.borrado, ",
                                              "        m.id_marca, ",
                                              "        tp.id_tipo_producto, ",
                                              "        um.id_unidad_medida, ",
                                              "        m.nombre as nombreMarca, ",
                                              "        tp.nombre as nombreTipoProducto, ",
                                              "        um.nombre as nombreUnidadMedida ",
                                              "   FROM Productos pr",
                                              "  INNER JOIN Marcas m ON pr.marca= m.id_marca ",
                                              "  INNER JOIN Tipos_Productos tp ON pr.tipo_producto= tp.id_tipo_producto ",
                                              "  INNER JOIN Unidades_de_medida um ON pr.unidad_de_medida= um.id_unidad_medida ",
                                              " WHERE pr.borrado = 0",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }



        public bool Create(Producto producto)
        {
            string consulta = "INSERT INTO Productos (pr.nombre, marca, contenido, unidad_de_medida, tipo_producto, pr.descripcion, borrado, precio, stock)" +
                            " VALUES (" +
                            "'" + producto.NombreProducto + "'" + "," +
                            producto.Id_Marca.Id_marca +
                            "," + producto.Contenido + "," +
                            producto.Id_Unidad_Medida.Id_Unidad_Medida + "," +
                            producto.Id_Tipo_Producto.Id_Tipo_Producto +
                            "," + "'" + producto.Descripcion + "'" + ",0, " + producto.Precio + "," +
                            producto.Stock + ")";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Producto GetProductoSinParametros(string nombreProducto)
        {
            String strSql = string.Concat(" SELECT id_producto, ",
                                              "        marca, ",
                                              "        contenido, ",
                                              "        unidad_de_medida, ",
                                              "        tipo_producto, ",
                                              "        pr.descripcion, " +
                                              "        stock ," +
                                              "        precio, ",
                                              "        pr.nombre, ",
                                              "        pr.borrado, ",
                                              "        m.id_marca, ",
                                              "        tp.id_tipo_producto, ",
                                              "        um.id_unidad_medida, ",
                                              "        m.nombre as nombreMarca, ",
                                              "        tp.nombre as nombreTipoProducto, ",
                                              "        um.nombre as nombreUnidadMedida ",
                                              "   FROM Productos pr",
                                              "  INNER JOIN Marcas m ON pr.marca= m.id_marca ",
                                              "  INNER JOIN Tipos_Productos tp ON pr.tipo_producto= tp.id_tipo_producto ",
                                              "  INNER JOIN Unidades_de_medida um ON pr.unidad_de_medida= um.id_unidad_medida ",
                                              " WHERE pr.borrado = 0");

            strSql += " AND pr.nombre " + "'" + nombreProducto + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Producto> GetByFiltersSinParametros(String condiciones)
        {

            List<Producto> lst = new List<Producto>();
            String strSql = string.Concat(" SELECT id_producto, ",
                                              "        marca, ",
                                              "        contenido, ",
                                              "        unidad_de_medida, ",
                                              "        tipo_producto, ",
                                              "        pr.descripcion, " +
                                              "        stock ," +
                                              "        precio, ",
                                              "        pr.nombre, ",
                                              "        pr.borrado, ",
                                              "        m.id_marca, ",
                                              "        tp.id_tipo_producto, ",
                                              "        um.id_unidad_medida, ",
                                              "        m.nombre as nombreMarca, ",
                                              "        tp.nombre as nombreTipoProducto, ",
                                              "        um.nombre as nombreUnidadMedida ",
                                              "   FROM Productos pr",
                                              "  JOIN Marcas m ON pr.marca= m.id_marca ",
                                              "  JOIN Tipos_Productos tp ON pr.tipo_producto= tp.id_tipo_producto ",
                                              "  JOIN Unidades_de_medida um ON pr.unidad_de_medida= um.id_unidad_medida ",
                                              " WHERE pr.borrado = 0");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Producto> RecuperarFiltrados(string nombreProducto, int? marca, int? tipo_Producto)
        {
            List<Producto> lista = new List<Producto>();
            string strSql = string.Concat(" SELECT id_producto, ",
                                              "        marca, ",
                                              "        contenido, ",
                                              "        unidad_de_medida, ",
                                              "        tipo_producto, ",
                                              "        pr.descripcion, " +
                                              "        stock ," +
                                              "        precio, ",
                                              "        pr.nombre, ",
                                              "        pr.borrado, ",
                                              "        m.id_marca, ",
                                              "        tp.id_tipo_producto, ",
                                              "        um.id_unidad_medida, ",
                                              "        m.nombre as nombreMarca, ",
                                              "        tp.nombre as nombreTipoProducto, ",
                                              "        um.nombre as nombreUnidadMedida ",
                                              "   FROM Productos pr",
                                              "  INNER JOIN Marcas m ON pr.marca= m.id_marca ",
                                              "  INNER JOIN Tipos_Productos tp ON pr.tipo_producto= tp.id_tipo_producto ",
                                              "  INNER JOIN Unidades_de_medida um ON pr.unidad_de_medida= um.id_unidad_medida ",
                                              " WHERE pr.borrado = 0");
            if (nombreProducto != "")
            {
                strSql = strSql + " AND pr.nombre LIKE '%" + nombreProducto + "%'";
            }
            if (marca != null)
            {
                strSql = strSql + " AND marca = " + marca;
            }
            if (tipo_Producto != null)
            {
                strSql = strSql + " AND tipo_producto = " + tipo_Producto;
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Producto oProducto = ObjectMapping(fila);
                lista.Add(oProducto);
            }
            return lista;
        }

        public bool Modificar(Producto producto)
        {
            string consulta = "UPDATE Productos SET nombre='"
                + producto.NombreProducto + "', marca = " +
                producto.Id_Marca.Id_marca + ", contenido=" + producto.Contenido + ", unidad_de_medida = " +
                producto.Id_Unidad_Medida.Id_Unidad_Medida + ", tipo_producto = " +
                producto.Id_Tipo_Producto.Id_Tipo_Producto + ", descripcion='" + producto.Descripcion +
                "', precio=" + producto.Precio + ", stock=" + producto.Stock+
                " WHERE id_producto = " + producto.Id_producto;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idProducto)
        {
            string consulta = " UPDATE Productos SET borrado = 1" +
                " WHERE id_producto = " + idProducto;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        //VER BIEN ESTO
        public Producto ObjectMapping(DataRow row)
        {
            Producto oProducto = new Producto
            {
                Id_producto = Convert.ToInt32(row["id_producto"].ToString()),
                NombreProducto = row["nombre"].ToString(),
                Id_Marca = new Marca()
                {
                    Id_marca = Convert.ToInt32(row["marca"].ToString()),
                    NombreMarca = row["nombreMarca"].ToString(),
                },
                Contenido = (float)Convert.ToDouble(row["contenido"].ToString()), //ver
                Id_Unidad_Medida = new Unidad_Medida()
                {
                    Id_Unidad_Medida = Convert.ToInt32(row["id_unidad_medida"].ToString()),
                    Nombre = row["nombreUnidadMedida"].ToString(),
                },
                Id_Tipo_Producto = new Tipo_Producto()
                {
                    Id_Tipo_Producto = Convert.ToInt32(row["id_tipo_producto"].ToString()),
                    NombreTipoProducto = row["nombreTipoProducto"].ToString(),
                },
                Descripcion = row["descripcion"].ToString(),
                Stock = Convert.ToInt32(row["stock"].ToString()),
                Precio = (float)Convert.ToDouble(row["precio"].ToString()),
            };

            return oProducto; ;
        }

        public bool ExisteNombreProducto(string NombreProducto, int? IdProducto)
        {
            string consulta = "SELECT * FROM Productos WHERE nombre = '" +
                NombreProducto + "'";
            if (IdProducto != null)
            {
                consulta = consulta + " AND id_producto != " + IdProducto;
            }
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }

    }
}
