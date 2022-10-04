using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Clase
    {
        private int id_clase;
        public int Id_clase
        {
            get { return id_clase; }
            set { id_clase = value; }
        }

        public Disciplina Id_disciplina { get; set; }
        public DateTime Horario { get; set; }
        public string DiaSemana { get; set; }
        public bool Borrado { get; set; }
    }
}
