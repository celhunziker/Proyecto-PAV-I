using AppBTS.Entidades;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Presentacion
{
    public partial class frmProductosABM : Form
    {
        private string accion;
        private int? id_producto;
        private IProductoService oProducto = new ProductoService();
        private IMarcaService oMarca = new MarcaService();
        private ITipoProductoService oTipoProducto = new TipoProductoService();
        private IUnidadDeMedida oUnidadMedida = new UnidadMedidaService();
        public frmProductosABM(string Accion, int? IdProducto)
        {
            InitializeComponent();
            this.Text = Accion + " de producto";
            accion = Accion;
            id_producto = IdProducto;
        }

        private void frmProductosABM_Load(object sender, EventArgs e)
        {
            CargarComboMarca(cboMarca, oMarca.traerTodos());
            if (id_producto != null)
            {
                CargarCampos((int)id_producto);
            }
        }
        private void CargarComboMarca(ComboBox combo, List<Marca> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreMarca";
            combo.ValueMember = "Id_marca";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboTipoProducto(ComboBox combo, List<Tipo_Producto> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreTipoProducto";
            combo.ValueMember = "Id_Tipo_Producto";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboUnidadMedida(ComboBox combo, List<Unidad_Medida> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_Unidad_Medida";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCampos(int idProducto)
        {
            Producto producto = oProducto.traerPorId(idProducto);
            txtId.Text = producto.Id_producto.ToString();
            txtNombre.Text = producto.NombreProducto;
            cboTipoProducto.SelectedValue = producto.Id_Tipo_Producto.Id_Tipo_Producto;
            cboMarca.SelectedValue = producto.Id_Marca.Id_marca;
            txtContenido.Text = producto.Contenido.ToString();
            cboUnidadDeMedida.SelectedValue = producto.Id_Unidad_Medida.Id_Unidad_Medida;
            txtDescripcion.Text = producto.Descripcion;
        }
    }
}
