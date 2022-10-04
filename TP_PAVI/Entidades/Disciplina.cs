using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Disciplina
    {
        private int id_disciplina;
        public int Id_disciplina
        {
            get { return id_disciplina; }
            set { id_disciplina = value; }
        }

        public string NombreDisciplina { get; set; }
        public bool Borrado { get; set; }
    }
}
