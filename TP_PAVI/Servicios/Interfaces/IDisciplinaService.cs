using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IDisciplinaService
    {
        List<Disciplina> traerTodos();
        Disciplina traerPorId(int idDisciplina);

        // Y ESTO?

        object ObtenerDisciplina(string nombreDisciplina);

        bool CrearDisciplina(Disciplina disciplina);
        IList<Disciplina> ConsultarConFiltrosSinParametros(String condiciones);
        List<Disciplina> RecuperarFiltrados(string nombreDisciplina);
        bool ModificarDisciplina(Disciplina disciplina);

        bool ExisteNombreDisciplina(string nombreDisciplina, int? idDisciplina);
        bool Eliminar(int idDisciplina);
    
}
}
