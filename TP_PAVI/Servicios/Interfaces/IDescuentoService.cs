using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IDescuentoService
    {
        List<Descuento> traerTodos();
        Descuento traerPorCodigo(string codigo);
    }
}
