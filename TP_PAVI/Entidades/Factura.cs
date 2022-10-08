using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Factura
    {
        public int Id_factura { get; set; }
        public Usuario Id_usuario_vendedor { get; set; }
        public Tipo_Factura Tipo_factura { get; set; }
        public float Total { get; set; }
        public Descuento Id_descuento { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Id_cliente { get; set; }
        public bool Borrado { get; set; }
    }
}
