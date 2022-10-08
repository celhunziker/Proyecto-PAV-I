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
    class DescuentoDao : IDescuento
    {
        public List<Descuento> RecuperarTodos()
        {
            List<Descuento> lista = new List<Descuento>();
            string consulta = "SELECT * FROM Descuentos WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Descuento oDescuento = ObjectMapping(fila);
                lista.Add(oDescuento);
            }
            return lista;
        }
        public Descuento ObjectMapping(DataRow row)
        {
            Descuento oDescuento = new Descuento
            {
                Id_descuento = Convert.ToInt32(row["id_descuento"].ToString()),
                Codigo = row["codigo"].ToString(),
                Porcentaje = (float)Convert.ToDouble(row["porcentaje"].ToString())

            };

            return oDescuento;
        }
    }
}
