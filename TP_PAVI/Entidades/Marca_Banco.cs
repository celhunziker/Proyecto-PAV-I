using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Marca_Banco
    {
        private int id_marca_banco;
        public int Id_marca_banco
        {
            get { return id_marca_banco; }
            set { id_marca_banco = value; }
        }

        public string NombreMarcaBanco { get; set; }
        public bool Borrado { get; set; }
    }
}
