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
        class MarcaBancoDao : IMarcaBanco
        {
            public List<Marca_Banco> RecuperarTodos()
            {
                List<Marca_Banco> lista = new List<Marca_Banco>();
                string consulta = "SELECT * FROM Marcas_Bancos WHERE borrado = 0 order by 2";
                DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
                foreach (DataRow fila in tabla.Rows)
                {
                    Marca_Banco oMarcaBanco = ObjectMapping(fila);
                    lista.Add(oMarcaBanco);
                }
                return lista;
            }

            public Marca_Banco ObjectMapping(DataRow row)
            {
                Marca_Banco oMarcaBanco = new Marca_Banco
                {
                    Id_marca_banco = Convert.ToInt32(row["id_marca_banco"].ToString()),
                    NombreMarcaBanco = row["nombre"].ToString(),
                };

                return oMarcaBanco;
            }

        }
    }

