using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IMarcaBancoService
    {
        List<Marca_Banco> traerTodos();
        //Marca_Banco traerPorId(int idMarcaBanco);

        // Y ESTO?

        //object ObtenerMarcaBanco(string nombreMarcaBanco);

        //bool CrearMarcaBanco(Marca_Banco marcaBanco);
        //IList<Marca_Banco> ConsultarConFiltrosSinParametros(String condiciones);
        //List<Marca_Banco> RecuperarFiltrados(string nombreMarcaBanco);
        //bool ModificarMarcaBanco(Marca_Banco marcaBanco);

        //bool ExisteNombreMarcaBanco(string nombreMarcaBanco, int? idMarcaBanco);
        //bool Eliminar(int idMarcaBanco);
    }
}
