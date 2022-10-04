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
    class MarcaTarjetaDao : IMarcaTarjeta
    {
        public List<Marca_tarjeta> RecuperarTodos()
        {
            List<Marca_tarjeta> lista = new List<Marca_tarjeta>();
            string consulta = "SELECT * FROM SELECT * FROM Marcas_Tarjetas WHERE borrado = 0;";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Marca_tarjeta oMarcaTarjeta = new Marca_tarjeta();
                oMarcaTarjeta.Id_marca_tarjeta = (int)fila["id_marca_tarjeta"];
                oMarcaTarjeta.Nombre = fila["nombre"].ToString();
                oMarcaTarjeta.Borrado = (bool)fila["borrado"];

                lista.Add(oMarcaTarjeta);
            }
            return lista;

        }
    }
}
