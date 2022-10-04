using AppBTS.Entidades;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IClase
    {
        List<Clase> RecuperarTodos();
        Clase RecuperarPorId(int idClase);
        Clase ObjectMapping(DataRow row);
        bool Create(Clase clase);
        IList<Clase> GetByFiltersSinParametros(string condiciones);

        List<Clase> RecuperarFiltrados(DateTime horario, string diaSemana, int? disciplina);
        bool Modificar(Clase clase);
        bool Eliminar(int idClase);
    }
}
