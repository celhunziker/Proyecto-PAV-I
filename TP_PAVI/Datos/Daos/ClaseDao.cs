using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppBTS.Servicios.Interfaces;
using AppBTS.Servicios;
using AppBTS.Servicios.Implementaciones;

namespace AppBTS.Datos.Daos
{
    class ClaseDao : IClase
    {
        private IDisciplinaService oDisciplina = new DisciplinaService();
        public List<Clase> RecuperarTodos()
        {
            List<Clase> lista = new List<Clase>();
            //ver lo de horario
            String strSql = string.Concat(" SELECT id_clase, ",
                                              "        horario, ",
                                              "        diaSemana, ",
                                              "        d.id_disciplina, ",
                                              "        d.nombre as disciplina ",
                                              "   FROM Clases c ",
                                              "  INNER JOIN Disciplinas d ON c.id_disciplina= d.id_disciplina ",
                                              " WHERE c.borrado = 0");

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            //LLAMAMOS A LOS PERFILES Y LOS VAMOS ASIGNANDO CON RESPECTO A ID PERFIL?
            //List<Perfil> listaPerfil = oPerfil.traerTodos();
            foreach (DataRow fila in tabla.Rows)
            {
                Clase oClase = ObjectMapping(fila);
                lista.Add(oClase);
            }
            return lista;
        }

        public Clase RecuperarPorId(int idClase)
        {
            string condicion = "WHERE c.borrado = 0 AND id_clase = " + idClase;
            String strSql = string.Concat(" SELECT id_clase, ",
                                              "        horario, ",
                                              "        diaSemana, ",
                                              "        d.id_disciplina, ",
                                              "        d.nombre as disciplina ",
                                              "   FROM Clases c",
                                              "  INNER JOIN Disciplinas d ON c.id_disciplina = d.id_disciplina ",
                                              condicion);

            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            return ObjectMapping(tabla.Rows[0]);
        }



        bool IClase.Create(Clase clase)
        {
            //ver si funca el toString ese
            string consulta = "INSERT INTO Clases (horario, diaSemana, id_disciplina, borrado)" +
                            " VALUES (" +
                            "'" + clase.Horario.ToString("HH:mm") + "'" + "," +
                            "'" + clase.DiaSemana + "'" + "," +
                            clase.Id_disciplina.Id_disciplina + ",0)";


            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public IList<Clase> GetByFiltersSinParametros(String condiciones)
        {

            List<Clase> lst = new List<Clase>();
            String strSql = string.Concat(" SELECT id_clase, ",
                                              "        horario, ",
                                              "        diaSemana, ",
                                              "        d.id_disciplina, ",
                                              "        d.nombre as disciplina ",
                                              "   FROM Clases c",
                                              "  INNER JOIN Disciplinas d ON c.id_disciplina = d.id_disciplina ",
                                              "  WHERE c.borrado =0");
            strSql += condiciones;

            var resultado = BDHelper.obtenerInstancia().consultar(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public List<Clase> RecuperarFiltrados(DateTime horario, string diaSemana, int? disciplina)
        {
            List<Clase> lista = new List<Clase>();
            String strSql = string.Concat(" SELECT id_clase, ",
                                              "        horario, ",
                                              "        diaSemana, ",
                                              "        d.id_disciplina, ",
                                              "        d.nombre as disciplina ",
                                              "   FROM Clases c",
                                              "  INNER JOIN Disciplinas d ON c.id_disciplina = d.id_disciplina ",
                                              "  WHERE c.borrado =0");

            //ver si funca el horario
            if (horario != DateTime.Today)
            {
                strSql = strSql + " AND horario LIKE '%" + horario.ToString("HH:mm") + "%'";
            }
            if (diaSemana != "")
            {
                strSql = strSql + " AND diaSemana LIKE '%" + diaSemana + "%'";
            }
            if (disciplina != null)
            {
                strSql = strSql + " AND d.id_disciplina = " + disciplina;
            }


            DataTable tabla = BDHelper.obtenerInstancia().consultar(strSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Clase oClase = ObjectMapping(fila);
                lista.Add(oClase);
            }
            return lista;
        }

        public bool Modificar(Clase clase)
        {
            string consulta = "UPDATE Clases SET horario='"
                + clase.Horario.ToString("HH:mm") + "', diaSemana='" + clase.DiaSemana + "', id_disciplina = " +
                clase.Id_disciplina.Id_disciplina  +
                " WHERE id_clase = " + clase.Id_clase;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public bool Eliminar(int idClase)
        {
            string consulta = " UPDATE Clases SET borrado = 1" +
                " WHERE id_clase = " + idClase;
            return (BDHelper.obtenerInstancia().actualizar(consulta) == 1);
        }

        public Clase ObjectMapping(DataRow row)
        {
            Clase oClase = new Clase
            {
                //ver lo de horario
                Id_clase = Convert.ToInt32(row["id_clase"].ToString()),
                Horario = DateTime.Parse(row["horario"].ToString()),
                DiaSemana = row["diaSemana"].ToString(),
                Id_disciplina = new Disciplina()
                {
                    Id_disciplina = Convert.ToInt32(row["id_disciplina"].ToString()),
                    NombreDisciplina = row["disciplina"].ToString(),
                }
            };

            return oClase; 
        }


    }
}

