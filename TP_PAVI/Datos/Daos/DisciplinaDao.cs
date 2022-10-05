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
    class DisciplinaDao : IDisciplina
    {
        public List<Disciplina> RecuperarTodos()
        {
            List<Disciplina> lista = new List<Disciplina>();
            string consulta = "SELECT * FROM Disciplinas WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Disciplina oDisciplina = new Disciplina();
                oDisciplina.Id_disciplina= (int)fila["id_disciplina"];
                oDisciplina.NombreDisciplina = fila["nombre"].ToString();
                oDisciplina.Borrado = (bool)fila["borrado"];

                lista.Add(oDisciplina);
            }
            return lista;
        }


        public Disciplina RecuperarPorId(int idDisciplina)
        {
            string condicion = " AND id_disciplina =" + idDisciplina;
            String strSql = string.Concat(" SELECT id_disciplina, ",
                                              "        nombre ",
                                              "   FROM Disciplinas",
                                              " WHERE borrado = 0",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }



        public bool Create(Disciplina disciplina)
        {
            string consulta = "INSERT INTO Disciplinas (nombre, borrado)" +
                             " VALUES (" +
                             "'" + disciplina.NombreDisciplina + "'" + ",0)";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Disciplina GetProductoSinParametros(string disciplina)
        {
            String strSql = string.Concat(" SELECT id_disciplina, ",
                                              "        nombre ",
                                              "   FROM Disciplinas",
                                              " WHERE borrado = 0");

            strSql += " AND nombre " + "'" + disciplina + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Disciplina> GetByFiltersSinParametros(String condiciones)
        {

            List<Disciplina> lst = new List<Disciplina>();
            String strSql = string.Concat(" SELECT id_disciplina, ",
                                              "        nombre ",
                                              "   FROM Disciplinas",
                                              " WHERE borrado = 0");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Disciplina> RecuperarFiltrados(string nombreDisciplina)
        {
            List<Disciplina> lista = new List<Disciplina>();
            string strSql = string.Concat(" SELECT id_disciplina, ",
                                              "        nombre",
                                              "   FROM Disciplinas",
                                              " WHERE borrado = 0");
            if (nombreDisciplina != "")
            {
                strSql = strSql + " AND nombre LIKE '%" + nombreDisciplina + "%'";
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Disciplina oDisciplina = ObjectMapping(fila);
                lista.Add(oDisciplina);
            }
            return lista;
        }

        public bool Modificar(Disciplina disciplina)
        {
            string consulta = "UPDATE Disciplinas SET nombre='"
                + disciplina.NombreDisciplina + "' WHERE id_disciplina = " + disciplina.Id_disciplina;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idDisciplina)
        {
            string consulta = " UPDATE Disciplinas SET borrado = 1" +
                " WHERE id_disciplina = " + idDisciplina;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        //VER BIEN ESTO
        public Disciplina ObjectMapping(DataRow row)
        {
            Disciplina oDisciplina = new Disciplina
            {
                Id_disciplina = Convert.ToInt32(row["id_disciplina"].ToString()),
                NombreDisciplina = row["nombre"].ToString(),
            };

            return oDisciplina; ;
        }

        public bool ExisteNombreDisciplina(string NombreDisciplina, int? IdDisciplina)
        {
            string consulta = "SELECT * FROM Disciplinas WHERE nombre = '" +
                NombreDisciplina + "'";
            if (IdDisciplina != null)
            {
                consulta = consulta + " AND id_disciplina != " + IdDisciplina;
            }
            return (BDHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }
    }
}