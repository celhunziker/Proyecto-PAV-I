using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    internal class TarjetaDao : ITarjeta
    {
        private IUsuario dao;

        public TarjetaDao()
        {
            dao = new UsuarioDao();
        }
        public bool Create(Tarjeta tarjeta)
        {
            string consulta = "SET IDENTITY_INSERT TARJETAS ON;INSERT INTO Tarjetas (id_marca_tarjeta, nro_tarjeta, fecha_venc, id_usuario, borrado)" +
                            " VALUES (" + 
                            tarjeta.Id_marca_tarjeta.Id_marca_tarjeta + "," +
                            tarjeta.Nro_tarjeta + ",'" +
                            tarjeta.Fecha_venc.ToString("yyyy-MM-dd") + "'," +
                            tarjeta.Id_usuario.Id_usuario + ",0); SET IDENTITY_INSERT TARJETAS OFF;";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(long nroTarjeta)
        {
            string consulta = " UPDATE Tarjetas SET borrado = 1" +
                " WHERE nro_tarjeta = " + nroTarjeta;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool ExisteTarjeta(long nro_tarjeta)
        {
            string consulta = "SELECT * FROM Tarjetas WHERE nro_tarjeta = " +
                nro_tarjeta.ToString() ;
            //if (nro_tarjeta != null)
            //{
            //    consulta = consulta + " AND id_usuario != " + IdUsuario;
            //}
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }

        public bool Modificar(Tarjeta tarjeta)
        {
            string consulta = "UPDATE Tarjetas SET id_marca_tarjeta="
                + tarjeta.Id_marca_tarjeta.Id_marca_tarjeta + ", nro_tarjeta=" + tarjeta.Nro_tarjeta + ", fecha_venc='" + tarjeta.Fecha_venc + "', id_usuario=" +
                tarjeta.Id_usuario.Id_usuario +
                " WHERE id_usuario = " + tarjeta.Nro_tarjeta;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Tarjeta ObjectMapping(DataRow row)
        {
            Tarjeta oTarjeta = new Tarjeta();
            oTarjeta.Id_usuario = dao.RecuperarPorId(Convert.ToInt32(row["id_usuario"].ToString()));
            oTarjeta.Nro_tarjeta = long.Parse(row["nro_tarjeta"].ToString());
            oTarjeta.Fecha_venc = DateTime.Parse(row["fecha_venc"].ToString());
            oTarjeta.Id_marca_tarjeta = new Marca_tarjeta();
            oTarjeta.Id_marca_tarjeta.Id_marca_tarjeta = Convert.ToInt32(row["id_marca_tarjeta"].ToString());
            oTarjeta.Id_marca_tarjeta.Nombre = row["nombre"].ToString();
            oTarjeta.Borrado = false;

            return oTarjeta;
        }

        public List<Tarjeta> RecuperarListaFiltrada(int idUsuario, int? id_marca_tarjeta, long? nro_tarjeta, string fecha_venc_mes, string fecha_venc_anio)
        {
            List<Tarjeta> lista = new List<Tarjeta>();
            String strSql = string.Concat(" SELECT t.id_marca_tarjeta, ",
                                              "        nro_tarjeta, ",
                                              "        fecha_venc, ",
                                              "        nombre, ",
                                              "        id_usuario",
                                              "   FROM Tarjetas t",
                                              "  INNER JOIN Marcas_Tarjetas m ON t.id_marca_tarjeta = m.id_marca_tarjeta ",
                                              " WHERE t.borrado = 0 AND id_usuario=", idUsuario.ToString());
           
            if (id_marca_tarjeta != null)
            {
                strSql = strSql + " AND t.id_marca_tarjeta=" + id_marca_tarjeta;

            }
            if (nro_tarjeta != -1)
            {
                strSql = strSql + " AND nro_tarjeta LIKE '" + nro_tarjeta + "%'";
            }
            if (fecha_venc_mes != "")
            {

                strSql = strSql + " AND MONTH(fecha_venc)=" + fecha_venc_mes;
            }
            if (fecha_venc_anio != "")
            {

                strSql = strSql + " AND YEAR(fecha_venc)=20" + fecha_venc_anio;
            }

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Tarjeta oTarjeta = ObjectMapping(fila);
                lista.Add(oTarjeta);
            }
            return lista;
        }

        public Tarjeta RecuperarPorNro(long nro_tarjeta)
        {
            String strSql = string.Concat(" SELECT t.id_marca_tarjeta, ",
                                              "        nro_tarjeta, ",
                                              "        fecha_venc, ",
                                              "        nombre, ",
                                              "        id_usuario",
                                              "   FROM Tarjetas t",
                                              "  INNER JOIN Marcas_Tarjetas m ON t.id_marca_tarjeta = m.id_marca_tarjeta ",
                                              " WHERE t.borrado = 0 AND nro_tarjeta=", (nro_tarjeta.ToString()));
            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            Tarjeta tarjeta = this.ObjectMapping(tabla.Rows[0]);
            return tarjeta;
        }

        public List<Tarjeta> RecuperarTodos(int idUsuario)
        {
            List<Tarjeta> lista = new List<Tarjeta>();
            String strSql = string.Concat(" SELECT t.id_marca_tarjeta, ",
                                              "        nro_tarjeta, ",
                                              "        fecha_venc, ",
                                              "        nombre, ",
                                              "        id_usuario",
                                              "   FROM Tarjetas t",
                                              "  INNER JOIN Marcas_Tarjetas m ON t.id_marca_tarjeta = m.id_marca_tarjeta ",
                                              " WHERE t.borrado = 0 AND id_usuario=", idUsuario.ToString());
            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Tarjeta oTarjeta = ObjectMapping(fila);
                lista.Add(oTarjeta);
            }
            return lista;
        }
    }
}
