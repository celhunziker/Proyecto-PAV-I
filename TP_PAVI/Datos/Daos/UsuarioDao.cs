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
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              " WHERE u.borrado = 0 AND estado = 'S'");

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            //LLAMAMOS A LOS PERFILES Y LOS VAMOS ASIGNANDO CON RESPECTO A ID PERFIL?
            List<Perfil> listaPerfil = oPerfil.traerTodos();
            foreach(DataRow fila in tabla.Rows)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Id_usuario = (int)fila["id_usuario"];
                oUsuario.NombreUsuario = fila["nombreUsuario"].ToString();
                oUsuario.Nombre = fila["nombre"].ToString();
                oUsuario.Apellido = fila["apellido"].ToString();
                oUsuario.Password = fila["password"].ToString();
                oUsuario.Email = fila["estado"].ToString();
                oUsuario.Borrado = false;
                //PATRON O DIRECTAMENTE PONEMOS UN IF?
                foreach(Perfil perfil in listaPerfil)
                {
                    if (perfil.IdPerfil == (int)fila["id_perfil"])
                    {
                        oUsuario.Id_perfil = perfil;
                        break;
                    }
                }
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
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            //IMPLEMENTACION TOSCA -> PODRIAMOS TRAER SOLO UNO O SACARLO DIRECTO DESDE COMBOBOX?
            
            Usuario usuario = new Usuario();
            usuario.Id_usuario = (int)tabla.Rows[0]["id_usuario"];
            usuario.NombreUsuario = tabla.Rows[0]["nombreUsuario"].ToString();
            usuario.Nombre = tabla.Rows[0]["nombre"].ToString();
            usuario.Apellido = tabla.Rows[0]["apellido"].ToString();
            usuario.Password = tabla.Rows[0]["password"].ToString();
            usuario.Email = tabla.Rows[0]["estado"].ToString();
            usuario.Borrado = false;

            List<Perfil> lista = oPerfil.traerTodos();
            foreach (Perfil perfil in lista)
            {
                if (perfil.IdPerfil == (int)tabla.Rows[0]["id_perfil"])
                {
                    usuario.Id_perfil = perfil;
                    break;
                }
            }
            return usuario;
        }

 

        bool IUsuario.Create(Usuario usuario)
        {
            string consulta = "INSERT INTO Usuarios (nombreUsuario, u.nombre, apellido, password, email, estado, id_perfil, borrado)" +
                            " VALUES (" +
                            "'" + usuario.NombreUsuario + "'" + "," +
                            "'" + usuario.Nombre + "'" + "," +
                            "'" + usuario.Apellido + "'" + "," +
                            "'" + usuario.Password + "'" + "," +
                            "'" + usuario.Email + "'" + "," +
                            "'" + usuario.Estado + "'" + "," +
                            usuario.Id_perfil.IdPerfil + ",0)";


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
                                          "        p.id_perfil, ",
                                          "        p.nombre ",
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

        public List<Usuario> RecuperarFiltrados(string nombreUsuario, string nombre, string apellido, string email, int? perfil)
        {
            List<Usuario> lista = new List<Usuario>();
            string strSql = string.Concat(" SELECT id_usuario, ",
                                              "        nombreUsuario, ",
                                              "        u.nombre as nombre, ",
                                              "        apellido, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre ",
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


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            List<Perfil> listaPerfil = oPerfil.traerTodos();
            foreach (DataRow fila in tabla.Rows)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.Id_usuario = (int)fila["id_usuario"];
                oUsuario.NombreUsuario = fila["nombreUsuario"].ToString();
                oUsuario.Nombre = fila["nombre"].ToString();
                oUsuario.Apellido = fila["apellido"].ToString();
                oUsuario.Password = fila["password"].ToString();
                oUsuario.Email = fila["estado"].ToString();
                oUsuario.Borrado = false;
                //PATRON O DIRECTAMENTE PONEMOS UN IF?
                foreach (Perfil oPerfil in listaPerfil)
                {
                    if (oPerfil.IdPerfil == (int)fila["id_perfil"])
                    {
                        oUsuario.Id_perfil = oPerfil;
                        break;
                    }
                }
                lista.Add(oUsuario);
            }
            return lista;
        }

        public bool Modificar(Usuario usuario)
        {
            string consulta = "UPDATE Usuarios SET nombreUsuario='" 
                + usuario.NombreUsuario + "', nombre='" + usuario.Nombre + "', apellido='" + usuario.Apellido + "', password='" +
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
                }
            };

            return oUsuario; ;
        }
    }
}

