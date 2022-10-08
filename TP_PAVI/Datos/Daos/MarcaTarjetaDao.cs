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
    internal class MarcaTarjetaDao : IMarcaTarjeta
    {
        public List<Marca_Tarjeta> RecuperarTodos()
        {
            List<Marca_Tarjeta> lista = new List<Marca_Tarjeta>();
            string consulta = "SELECT * FROM Marcas_Tarjetas WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Marca_Tarjeta oMarcaTarjeta = ObjectMapping(fila);
                lista.Add(oMarcaTarjeta);
            }
            return lista;
        }

        public Marca_Tarjeta ObjectMapping(DataRow row)
        {
            Marca_Tarjeta oMarcaTarjeta = new Marca_Tarjeta
            {
                Id_Marca_Tarjeta = Convert.ToInt32(row["id_marca_tarjeta"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oMarcaTarjeta;
        }        
    }
}
