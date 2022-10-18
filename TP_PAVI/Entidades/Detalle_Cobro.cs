using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Detalle_Cobro
    {
        public int Id_detalle_cobro { get; set; }
        public Medio_Pago Medio_pago { get; set; }
        public float Monto { get; set; }
        public int Cuotas { get; set; }
        public float Valor_couta { get; set; }
        public int Codigo_confirmacion { get; set; }
        public Marca_Tarjeta Id_marca_tarjeta { get; set; }
        public Marca_Banco Id_marca_banco { get; set; }
        public Factura Id_factura { get; set; }
        public bool Borrado { get; set; }
    }
}
