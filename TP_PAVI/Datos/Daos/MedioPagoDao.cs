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
    internal class MedioPagoDao : IMedioPago
    {
        public List<Medio_Pago> RecuperarTodos()
        {
            List<Medio_Pago> lista = new List<Medio_Pago>();
            string consulta = "SELECT * FROM Medios_Pagos WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Medio_Pago oMedioPago = ObjectMapping(fila);
                lista.Add(oMedioPago);
            }
            return lista;
        }

        public Medio_Pago ObjectMapping(DataRow row)
        {
            Medio_Pago oMedioPago = new Medio_Pago
            {
                Id_medio_cobro = Convert.ToInt32(row["id_medio_cobro"].ToString()),
                NombreMedioCobro = row["nombre"].ToString(),
            };

            return oMedioPago;
        }
    }
}
