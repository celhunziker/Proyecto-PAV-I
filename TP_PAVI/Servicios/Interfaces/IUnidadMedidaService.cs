using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    interface IUnidadMedidaService
    {
        List<Unidad_Medida> traerTodos();
    }
}
