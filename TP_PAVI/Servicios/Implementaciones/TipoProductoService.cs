using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    class TipoProductoService : ITipoProductoService
    {
        private ITipoProducto dao;
        public TipoProductoService()
        {
            dao = new TipoProductoDao();
        }
        public List<Tipo_Producto> traerTodos()
        {
            return dao.RecuperarTodos();
        }

        public Tipo_Producto traerPorId(int idTipoProducto)
        {
            return dao.RecuperarPorId(idTipoProducto);
        }

        public object ObtenerTipoProducto(string nombreTipoProducto)
        {
            //SIN PARAMETROS
            return dao.GetProductoSinParametros(nombreTipoProducto);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        public bool CrearTipoProducto(Tipo_Producto tipoProducto)
        {
            return dao.Create(tipoProducto);
        }
        public IList<Tipo_Producto> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Tipo_Producto> RecuperarFiltrados(string nombreTipoProducto)
        {
            return dao.RecuperarFiltrados(nombreTipoProducto);
        }

        public bool ModificarTipoProducto(Tipo_Producto tipoProducto)
        {
            return dao.Modificar(tipoProducto);
        }

        public bool Eliminar(int idTipoProducto)
        {
            return dao.Eliminar(idTipoProducto);
        }
        public bool ExisteNombreTipoProducto(string NombreTipoProducto, int? IdTipoProducto)
        {
            return dao.ExisteNombreTipoProducto(NombreTipoProducto, IdTipoProducto);
        }
    }
}
