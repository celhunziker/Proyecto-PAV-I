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
using AppBTS.Servicios.Interfaces;
using AppBTS.Servicios;

namespace AppBTS.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        //ESTO ESTA BIEN? DEBERIA SER DE ESTA MANERA U OTRA? BOTTA NO MOSTRO TODAVIA
        //TAMBIEN LA CARGA DE COMBOS Y GRILLAS TIRO UNAS IDEAS
        //PERO NO TERMINO DE IMPLEMENTAR
        private IPerfilService oPerfil = new PerfilService();
        public int validarUsuario(string nombreUsuario, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE nombreUsuario='" + nombreUsuario + "' AND password='" + clave + "'  AND borrado = 0 AND estado = 'S'";
            //ACA NO DEBERIA HABER CONDICION PARA borrado=0 y habilitado=S?

            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public List<Usuario> RecuperarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        nombreUsuario, ",
                                              "        u.nombre, ",
                                              "        apellido, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        direccion, ",
                                              "        CUIT, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre as perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              " WHERE u.borrado = 0 AND estado = 'S'");

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            //LLAMAMOS A LOS PERFILES Y LOS VAMOS ASIGNANDO CON RESPECTO A ID PERFIL?
            //List<Perfil> listaPerfil = oPerfil.traerTodos();
            foreach(DataRow fila in tabla.Rows)
            {
                Usuario oUsuario = ObjectMapping(fila);
                lista.Add(oUsuario);
            }
            return lista;
        }

        public Usuario RecuperarPorId(int idUsuario)
        {
            string condicion = "WHERE u.borrado = 0  AND estado = 'S' AND id_usuario =" + idUsuario;
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        nombreUsuario, ",
                                              "        u.nombre, ",
                                              "        apellido, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        direccion, ",
                                              "        CUIT, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre as perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }

 

        bool IUsuario.Create(Usuario usuario)
        {
            string consulta = "INSERT INTO Usuarios (nombreUsuario, u.nombre, apellido, password, email, estado, id_perfil, borrado, direccion, CUIT)" +
                            " VALUES (" +
                            "'" + usuario.NombreUsuario + "'" + "," +
                            "'" + usuario.Nombre + "'" + "," +
                            "'" + usuario.Apellido + "'" + "," +
                            "'" + usuario.Password + "'" + "," +
                            "'" + usuario.Email + "'" + "," +
                            "'" + usuario.Estado + "'" + "," +
                            usuario.Id_perfil.IdPerfil + ",0," +",'" +
                            usuario.CUIT + "', '"+ usuario.Direccion + "')";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Usuario GetUserSinParametros(string nombre)
        {
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        nombreUsuario, ",
                                          "        u.nombre, ",
                                          "        apellido, ",
                                          "        email, ",
                                          "        estado, ",
                                          "        password, ",
                                              "        direccion, ",
                                              "        CUIT, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre as perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE u.borrado =0  AND estado = 'S'");

            strSql += " AND u.nombre " + "'" + nombre + "'";


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
                                              "        nombreUsuario, ",
                                              "        u.nombre as nombre, ",
                                              "        apellido, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        direccion, ",
                                              "        CUIT, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre as perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              "  WHERE u.borrado =0 AND estado = 'S'");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Usuario> RecuperarFiltrados(string nombreUsuario, string nombre, string apellido, string email, int? perfil, long cuit)
        {
            List<Usuario> lista = new List<Usuario>();
            string strSql = string.Concat(" SELECT id_usuario, ",
                                              "        nombreUsuario, ",
                                              "        u.nombre as nombre, ",
                                              "        apellido, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        direccion, ",
                                              "        CUIT, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre as perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              "  WHERE u.borrado =0 AND u.estado = 'S'");
            if (nombreUsuario != "")
            {
                strSql = strSql + " AND nombreUsuario LIKE '%" + nombreUsuario + "%'";
            }
            if (nombre != "")
            {
                strSql = strSql + " AND u.nombre LIKE '%" + nombre + "%'";
            }
            if (apellido != "")
            {
                strSql = strSql + " AND apellido LIKE '%" + apellido + "%'";
            }
            if (email != "")
            {
                strSql = strSql + " AND email LIKE '%" + email + "%'";
            }
            if (perfil != null)
            {
                strSql = strSql + " AND p.id_perfil = " + perfil ;
            }
            if (cuit != 0)
            {
                strSql = strSql + " AND CUIT = " + cuit;
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Usuario oUsuario = ObjectMapping(fila);
                lista.Add(oUsuario);
            }
            return lista;
        }

        public bool Modificar(Usuario usuario)
        {
            string consulta = "UPDATE Usuarios SET nombreUsuario='" 
                + usuario.NombreUsuario + "', nombre='" + usuario.Nombre + "', apellido='" + usuario.Apellido + "', password='" +
                usuario.Password + "', id_perfil = " + 
                usuario.Id_perfil.IdPerfil + ", email = '" +usuario.Email + "' , estado = 'S', CUIT = " + usuario.CUIT
                + "direccion = '"+ usuario.Direccion + "' WHERE id_usuario = " + usuario.Id_usuario;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idUsuario)
        {
            string consulta = " UPDATE Usuarios SET borrado = 1" +
                " WHERE id_usuario = " + idUsuario ;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        //VER BIEN ESTO
        public Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                Id_usuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["nombreUsuario"].ToString(),
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Id_perfil = new Perfil()
                {
                    IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["perfil"].ToString(),
                },
                CUIT = Convert.ToInt64(row["CUIT"].ToString()),
                Direccion = row["direccion"].ToString()
            };

            return oUsuario; 
        }

        public bool ExisteNombreUsuario(string NombreUsuario, int? IdUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE nombreUsuario = '" +
                NombreUsuario + "'";
            if (IdUsuario != null)
            {
                consulta = consulta + " AND id_usuario != " + IdUsuario;
            }
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }

    }
}

