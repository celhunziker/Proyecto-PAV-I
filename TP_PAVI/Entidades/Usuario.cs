using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Datos;
using AppBTS.Entidades;

namespace AppBTS.Negocio
{
    public class Usuario
    {
        private int id_usuario;
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Perfil Id_perfil { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }
        public long CUIT { get; set; }
        public string Direccion { get; set; }

    }
}
