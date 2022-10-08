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
  class TipoFacturaDao : ITipoFactura
        {
            public List<Tipo_Factura> RecuperarTodos()
            {
                List<Tipo_Factura> lista = new List<Tipo_Factura>();
                string consulta = "SELECT * FROM Tipos_Facturas WHERE borrado = 0 order by 2";
                DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
                foreach (DataRow fila in tabla.Rows)
                {
                    Tipo_Factura oTipoFactura = ObjectMapping(fila);
                    lista.Add(oTipoFactura);
                }
                return lista;
            }

            public Tipo_Factura ObjectMapping(DataRow row)
            {
                Tipo_Factura oTipoFactura = new Tipo_Factura
                {
                    Id_tipo_factura = Convert.ToInt32(row["id_tipo_factura"].ToString()),
                    Nombre = row["nombre"].ToString(),
                };

                return oTipoFactura;
            }

        }
    }


