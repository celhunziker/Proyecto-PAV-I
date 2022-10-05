using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IMarca
    {
        List<Marca> RecuperarTodos();
        Marca RecuperarPorId(int idMarca);
        Marca ObjectMapping(DataRow row);
        bool Create(Marca marca);
        Marca GetProductoSinParametros(string nombreMarca);
        IList<Marca> GetByFiltersSinParametros(string condiciones);

        List<Marca> RecuperarFiltrados(string nombreMarca);
        bool Modificar(Marca marca);
        bool Eliminar(int idMarca);
        bool ExisteNombreMarca(string NombreMarca, int? IdMarca);
    }
}
