using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IDisciplina
    {
        List<Disciplina> RecuperarTodos();
        Disciplina RecuperarPorId(int idDisciplina);
        Disciplina ObjectMapping(DataRow row);
        bool Create(Disciplina disciplina);
        Disciplina GetProductoSinParametros(string nombreDisciplina);
        IList<Disciplina> GetByFiltersSinParametros(string condiciones);

        List<Disciplina> RecuperarFiltrados(string nombreDisciplina);
        bool Modificar(Disciplina disciplina);
        bool Eliminar(int idDisciplina);
        bool ExisteNombreDisciplina(string NombreDisciplinina, int? IdDisciplina);
    }
}
