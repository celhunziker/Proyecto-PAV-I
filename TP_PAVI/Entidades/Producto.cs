using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Entidades
{
    internal class Producto
    {
        private int id_producto;
        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        public string NombreProducto { get; set; }
        public Marca Id_Marca { get; set; }
        public float Contenido { get; set; }
        public Unidad_Medida Id_Unidad_Medida { get; set; }
        public Tipo_Producto Id_Tipo_Producto { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
    }
}
