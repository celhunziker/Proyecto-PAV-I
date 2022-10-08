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
        class TipoClienteDao : ITipoCliente
        {
            public List<Tipo_Cliente> RecuperarTodos()
            {
                List<Tipo_Cliente> lista = new List<Tipo_Cliente>();
                string consulta = "SELECT * FROM Tipos_Clientes WHERE borrado = 0 order by 2";
                DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
                foreach (DataRow fila in tabla.Rows)
                {
                    Tipo_Cliente oTipoCliente = ObjectMapping(fila);
                    lista.Add(oTipoCliente);
                }
                return lista;
            }

            public Tipo_Cliente ObjectMapping(DataRow row)
            {
                Tipo_Cliente oTipoCliente = new Tipo_Cliente
                {
                    Id_tipo_cliente = Convert.ToInt32(row["id_tipo_cliente"].ToString()),
                    Nombre = row["nombre"].ToString(),
                };

                return oTipoCliente;
            }
        }
             
    }

