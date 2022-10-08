using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Detalle_Factura
    {
        public int Id_detalle_factura { get; set; }
        public Factura Id_factura { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        public Producto Id_producto { get; set; }
        public bool Borrado { get; set; }
    }
}
