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
    }
}