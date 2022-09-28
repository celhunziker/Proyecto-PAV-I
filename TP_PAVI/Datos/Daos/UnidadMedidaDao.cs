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
    class UnidadMedidaDao : IUnidadMedida
    {
        public List<Unidad_Medida> RecuperarTodos()
        {
            List<Unidad_Medida> lista = new List<Unidad_Medida>();
            string consulta = "SELECT * FROM Unidades_de_medida WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Unidad_Medida oUnidadMedida = new Unidad_Medida();
                oUnidadMedida.Id_Unidad_Medida = (int)fila["Id_unidad_medida"];
                oUnidadMedida.Nombre = fila["Nombre"].ToString();
                oUnidadMedida.Borrado = (bool)fila["borrado"];

                lista.Add(oUnidadMedida);
            }
            return lista;
        }
    }
}
