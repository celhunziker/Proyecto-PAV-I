using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Marca
    {
        private int id_marca;
        public int Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string NombreMarca { get; set; }
        public bool Borrado { get; set; }
    }
}
