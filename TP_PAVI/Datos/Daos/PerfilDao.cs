using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class PerfilDao : IPerfil
    {
        public List<Perfil> RecuperarTodos()
        {
            List<Perfil> lista = new List<Perfil>();
            string consulta = "SELECT * FROM Perfiles WHERE borrado = 0 order by 2";
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            foreach(DataRow fila in tabla.Rows)
            {
                Perfil oPerfil = new Perfil();
                oPerfil.IdPerfil = (int)fila["id_perfil"];
                oPerfil.Nombre = fila["nombre"].ToString();
                oPerfil.Borrado = (bool)fila["borrado"];

                lista.Add(oPerfil);
            }
            return lista;
        }
    }
}
