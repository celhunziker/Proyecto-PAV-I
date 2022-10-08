using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Medio_Pago
    {
        private int id_medio_cobro;
        public int Id_medio_cobro
        {
            get { return id_medio_cobro; }
            set { id_medio_cobro = value; }
        }

        public string NombreMedioCobro { get; set; }
        public bool Borrado { get; set; }
    }
}
