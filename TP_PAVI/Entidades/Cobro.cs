using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Cobro
    {
        public int Id_cobro { get; set; }
        public Factura Id_factura { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Id_usuario_cajero { get; set; }
        public float Subtotal { get; set; }
    }
}
