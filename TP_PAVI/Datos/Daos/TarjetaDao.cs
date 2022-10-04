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
    internal class TarjetaDao : ITarjeta
    {
        public bool Create(Tarjeta tarjeta)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(long nroTarjeta)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Tarjeta tarjeta)
        {
            throw new NotImplementedException();
        }

        public Tarjeta ObjectMapping(DataRow row)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> RecuperarListaFiltrada(int idUsuario, int? id_marca_tarjeta, long? nro_tarjeta, string fecha_venc_mes, string fecha_venc_año)
        {
            List<Tarjeta> lista = new List<Tarjeta>();
            String strSql = string.Concat(" SELECT id_marca_tarjeta, ",
                                              "        nro_tarjeta, ",
                                              "        fecha_venc, ",
                                              "        nombre ",
                                              "   FROM Tarjetas t",
                                              "  INNER JOIN Marcas_Tarjetas m ON t.id_marca_tarjeta = m.id_marca_tarjeta ",
                                              " WHERE u.borrado = 0 AND estado = 'S' AND id_usuario=", idUsuario.ToString());
            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            if (id_marca_tarjeta != null)
            {
                strSql = strSql + " AND id_marca_tarjeta=" + id_marca_tarjeta;

            }
            if (nro_tarjeta != null)
            {
                strSql = strSql + " AND nro_tarjeta LIKE '" + nro_tarjeta + "%'";
            }
            if (fecha_venc_mes != "")
            {

                strSql = strSql + " MONTH(fecha_venc)=" + fecha_venc_mes;
            }
            if (fecha_venc_año != "")
            {

                strSql = strSql + " AND YEAR(fecha_venc)=20" + fecha_venc_año;
            }


            foreach (DataRow fila in tabla.Rows)
            {
                Tarjeta oTarjeta = ObjectMapping(fila);
                lista.Add(oTarjeta);
            }
            return lista;
        }

        public List<Tarjeta> RecuperarTodos(int idUsuario)
        {
            List<Tarjeta> lista = new List<Tarjeta>();
            String strSql = string.Concat(" SELECT id_marca_tarjeta, ",
                                              "        nro_tarjeta, ",
                                              "        fecha_venc, ",
                                              "        nombre ",
                                              "   FROM Tarjetas t",
                                              "  INNER JOIN Marcas_Tarjetas m ON t.id_marca_tarjeta = m.id_marca_tarjeta ",
                                              " WHERE u.borrado = 0 AND estado = 'S' AND id_usuario=", idUsuario.ToString());
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
