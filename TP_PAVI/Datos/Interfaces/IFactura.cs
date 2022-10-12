using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IFactura
    {
        bool InsertarFacturaConDetalle(Factura oFactura, Detalle_Factura oDetalle);
    }
}