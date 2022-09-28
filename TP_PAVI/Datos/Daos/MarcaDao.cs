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
    class MarcaDao : IMarca
    {
        public List<Marca> RecuperarTodos()
        {
            List<Marca> lista = new List<Marca>();
            string consulta = "SELECT * FROM Marcas WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Marca oMarca = new Marca();
                oMarca.Id_marca = (int)fila["id_marca"];
                oMarca.NombreMarca = fila["nombre"].ToString();
                oMarca.Borrado = (bool)fila["borrado"];

                lista.Add(oMarca);
            }
            return lista;
        }
    }
}
