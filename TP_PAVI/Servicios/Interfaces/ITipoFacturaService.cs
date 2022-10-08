using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface ITipoFacturaService
    {
        //nose si agregar lo demas por ser transaccion
        List<Tipo_Factura> traerTodos();
    }
}
