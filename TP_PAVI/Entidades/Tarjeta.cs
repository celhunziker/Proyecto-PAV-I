using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    public class Tarjeta
    {
        public Marca_tarjeta Id_marca_tarjeta { get; set; }
        public long Nro_tarjeta { get; set;}
        public DateTime Fecha_venc { get; set; }
        public Usuario Id_usuario { get; set; }
        public bool Borrado { get; set; }
    }
}
