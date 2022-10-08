using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    internal interface ITipoFactura
    {
        List<Tipo_Factura> RecuperarTodos();        
    }
}
