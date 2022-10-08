using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IDetalleFacturaService
    {
        //nose si agregar lo demas por ser transaccion
        List<Detalle_Factura> traerTodos();
    }
}
