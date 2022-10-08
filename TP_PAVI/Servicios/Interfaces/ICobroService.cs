using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface ICobroService
    {
        //no se si hace falta lo demas 
        List<Cobro> traerTodos();
    }
}
