using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    class ProductoService : IProductoService
    {
        private IProducto dao;

        public ProductoService()
        {
            dao = new ProductoDao();
        }
        public List<Producto> traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public Producto traerPorId(int idProducto)
        {
            return dao.RecuperarPorId(idProducto);
        }

        public object ObtenerProducto(string nombreProducto)
        {
            //SIN PARAMETROS
            return dao.GetProductoSinParametros(nombreProducto);

            //CON PARAMETROS
            //return dao.GetUserConParametros(usuario);
        }
        public bool CrearProducto(Producto producto)
        {
            return dao.Create(producto);
        }
        public IList<Producto> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return dao.GetByFiltersSinParametros(condiciones);
        }

        public List<Producto> RecuperarFiltrados(string nombreProducto, int? marca, int? tipo_Producto)
        {
            return dao.RecuperarFiltrados(nombreProducto, tipo_Producto, marca);
        }

        public bool ModificarProducto(Producto producto)
        {
            return dao.Modificar(producto);
        }

        public bool Eliminar(int idProducto)
        {
            return dao.Eliminar(idProducto);
        }
        public bool ExisteNombreProducto(string NombreProducto, int? IdProducto)
        {
            return dao.ExisteNombreProducto(NombreProducto, IdProducto);
        }
    }
}
