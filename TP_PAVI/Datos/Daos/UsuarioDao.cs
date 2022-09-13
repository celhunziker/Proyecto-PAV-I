using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppBTS.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        public int validarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND password='" + clave + "'  AND borrado = 0 AND estado = 'S'";
            //ACA NO DEBERIA HABER CONDICION PARA borrado=0 y habilitado=S?

            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              " WHERE u.borrado = 0 AND estado = 'S'");

            return BDHelper.obtenerInstancia().consultar(strSql);
        }

        public DataTable RecuperarPorId(int idUsuario)
        {
            string condicion = "WHERE u.borrado = 0  AND estado = 'S' AND id_usuario =" + idUsuario;
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              condicion);

            return BDHelper.obtenerInstancia().consultar(strSql);
        }

 

        bool IUsuario.Create(Usuario usuario)
        {
            string consulta = "INSERT INTO Usuarios (usuario, password, email, estado, id_perfil, borrado)" +
                            " VALUES (" +
                            "'" + usuario.Nombre + "'" + "," +
                            "'" + usuario.Password + "'" + "," +
                            "'" + usuario.Email + "'" + "," +
                            "'" + usuario.Estado + "'" + "," +
                            usuario.Id_perfil.IdPerfil + ",0)";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Usuario GetUserSinParametros(string nombreUsuario)
        {
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        estado, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE u.borrado =0  AND estado = 'S'");

            strSql += " AND usuario=" + "'" + nombreUsuario + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Usuario> GetByFiltersSinParametros(String condiciones)
        {

            List<Usuario> lst = new List<Usuario>();
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              "  WHERE u.borrado =0 AND estado = 'S'");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public DataTable RecuperarFiltrados(string nombre, string email, int? perfil)
        {
            List<Usuario> lst = new List<Usuario>();
            string strSql = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              "  WHERE u.borrado =0 AND u.estado = 'S'");
            if (nombre != "")
            {
                strSql = strSql + " AND usuario LIKE '" + nombre + "%'";
            } 
            if (email != "")
            {
                strSql = strSql + " AND email LIKE '" + email + "%'";
            }
            if (perfil != null)
            {
                strSql = strSql + " AND p.id_perfil = " + perfil ;
            }
            return BDHelper.obtenerInstancia().consultar(strSql);
        }

        public bool Modificar(Usuario usuario)
        {
            string consulta = "UPDATE Usuarios SET usuario='" 
                + usuario.Nombre + "', password='" +
                usuario.Password + "', id_perfil = " + 
                usuario.Id_perfil.IdPerfil + ", email = '" +usuario.Email + "' , estado = 'S' " + 
                " WHERE id_usuario = " + usuario.Id_usuario;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idUsuario)
        {
            string consulta = " UPDATE Usuarios SET borrado = 1" +
                " WHERE id_usuario = " + idUsuario ;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                Id_usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                Nombre = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Id_perfil = new Perfil()
                {
                    IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["perfil"].ToString(),
                }
            };

            return oUsuario; ;
        }
    }
}

