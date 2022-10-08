using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Descuento
    {
        public int Id_descuento { get; set; }
        public string Codigo { get; set; }
        public float Porcentaje { get; set; }
    }
}
