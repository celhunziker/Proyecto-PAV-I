using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IFacturaService
    {
        bool ValidarDatos(Factura factura);
        bool CrearFactura(Factura factura);
    }
}
