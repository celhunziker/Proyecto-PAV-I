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
        public Cobro Id_cobro { get; set; }
        public Medio_Pago Medio_pago { get; set; }
        public float Monto { get; set; }
        public int Codigo_confirmacion { get; set; }
        public Marca_Tarjeta Codigo_tarjeta { get; set; }
        public Marca_Banco Id_banco { get; set; }
    }
}
