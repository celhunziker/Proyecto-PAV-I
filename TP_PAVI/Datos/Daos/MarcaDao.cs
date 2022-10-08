using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class MarcaDao : IMarca
    {
        public List<Marca> RecuperarTodos()
        {
            List<Marca> lista = new List<Marca>();
            string consulta = "SELECT * FROM Marcas WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Marca oMarca = ObjectMapping(fila);
                //oMarca.Id_marca = (int)fila["id_marca"];
                //oMarca.NombreMarca = fila["nombre"].ToString();

                //EL OBJECT MAPPING NO SETEA BORRADO, QUE HACEMOS?
                //oMarca.Borrado = (bool)fila["borrado"];

                lista.Add(oMarca);
            }
            return lista;
        }

        public Marca RecuperarPorId(int idMarca)
        {
            string condicion = " AND id_marca =" + idMarca;
            String strSql = string.Concat(" SELECT id_marca, ",
                                              "        nombre ",
                                              "   FROM Marcas",
                                              " WHERE borrado = 0",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }



        public bool Create(Marca marca)
        {
            string consulta = "INSERT INTO Marcas (nombre, borrado)" +
                             " VALUES (" +
                             "'" + marca.NombreMarca + "'" + ",0)";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Marca GetProductoSinParametros(string nombreMarca)
        {
            String strSql = string.Concat(" SELECT id_marca, ",
                                              "        nombre ",
                                              "   FROM Marcas",
                                              " WHERE borrado = 0");

            strSql += " AND nombre " + "'" + nombreMarca + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Marca> GetByFiltersSinParametros(String condiciones)
        {

            List<Marca> lst = new List<Marca>();
            String strSql = string.Concat(" SELECT id_marca, ",
                                              "        nombre ",
                                              "   FROM Marcas",
                                              " WHERE borrado = 0");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Marca> RecuperarFiltrados(string nombreMarca)
        {
            List<Marca> lista = new List<Marca>();
            string strSql = string.Concat(" SELECT id_marca, ",
                                              "        nombre",
                                              "   FROM Marcas",
                                              " WHERE borrado = 0");
            if (nombreMarca != "")
            {
                strSql = strSql + " AND nombre LIKE '%" + nombreMarca + "%'";
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Marca oMarca = ObjectMapping(fila);
                lista.Add(oMarca);
            }
            return lista;
        }

        public bool Modificar(Marca marca)
        {
            string consulta = "UPDATE Marcas SET nombre='"
                + marca.NombreMarca + "' WHERE id_marca = " + marca.Id_marca;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idMarca)
        {
            string consulta = " UPDATE Marcas SET borrado = 1" +
                " WHERE id_marca = " + idMarca;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        //VER BIEN ESTO
        public Marca ObjectMapping(DataRow row)
        {
            Marca oMarca = new Marca
            {
                Id_marca = Convert.ToInt32(row["id_marca"].ToString()),
                NombreMarca = row["nombre"].ToString(),
            };

            return oMarca; ;
        }

        public bool ExisteNombreMarca(string NombreMarca, int? IdMarca)
        {
            string consulta = "SELECT * FROM Marcas WHERE nombre = '" +
                NombreMarca + "'";
            if (IdMarca != null)
            {
                consulta = consulta + " AND id_marca != " + IdMarca;
            }
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }
    }   
}
