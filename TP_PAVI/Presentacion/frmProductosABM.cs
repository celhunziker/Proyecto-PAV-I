using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios.Implementaciones;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private IUnidadMedidaService oUnidadMedida = new UnidadMedidaService();
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
            CargarComboTipoProducto(cboTipoProducto, oTipoProducto.traerTodos());
            CargarComboUnidadMedida(cboUnidadDeMedida, oUnidadMedida.traerTodos());
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
            combo.ValueMember = "id_tipo_producto";
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
            txtNombreProducto.Text = producto.NombreProducto;
            cboTipoProducto.SelectedValue = producto.Id_Tipo_Producto.Id_Tipo_Producto;
            cboMarca.SelectedValue = producto.Id_Marca.Id_marca;
            txtContenido.Text = producto.Contenido.ToString();
            cboUnidadDeMedida.SelectedValue = producto.Id_Unidad_Medida.Id_Unidad_Medida;
            txtDescripcion.Text = producto.Descripcion;
            txtStock.Text = producto.Stock.ToString();
            txtPrecio.Text = producto.Precio.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            float contenido = string.IsNullOrEmpty(txtContenido.Text)?(float)-1:float.Parse(txtContenido.Text);
            float precio = string.IsNullOrEmpty(txtPrecio.Text) ? (float)-1 : float.Parse(txtPrecio.Text);
            int stock = string.IsNullOrEmpty(txtStock.Text) ? (int)-1 : int.Parse(txtStock.Text);
            if (validarCamposProducto(txtNombreProducto.Text, (int)cboTipoProducto.SelectedIndex, (int)cboMarca.SelectedIndex, contenido,
                (int)cboUnidadDeMedida.SelectedIndex, stock, precio))
            {
                producto.NombreProducto = txtNombreProducto.Text;
                producto.Id_Tipo_Producto = new Tipo_Producto();
                producto.Id_Tipo_Producto.Id_Tipo_Producto = (int)cboTipoProducto.SelectedValue;
                producto.Id_Marca = new Marca();
                producto.Id_Marca.Id_marca = (int)cboMarca.SelectedValue;
                producto.Contenido = contenido;
                producto.Id_Unidad_Medida = new Unidad_Medida();    
                producto.Id_Unidad_Medida.Id_Unidad_Medida = (int)cboUnidadDeMedida.SelectedValue;
                producto.Descripcion = txtDescripcion.Text;
                producto.Stock = stock;
                producto.Precio = precio;

                if (accion == "Alta")
                {
                    if (oProducto.ExisteNombreProducto(producto.NombreProducto, null))
                    {
                        MessageBox.Show("YA EXISTE UN PRODUCTO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreProducto.Clear();
                        txtNombreProducto.Focus();
                    }
                    else
                    {
                        oProducto.CrearProducto(producto);
                        MessageBox.Show("Producto creado.", "Alta de Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    producto.Id_producto = (int)id_producto;
                    if (oProducto.ExisteNombreProducto(producto.NombreProducto, producto.Id_producto))
                    {
                        MessageBox.Show("YA EXISTE OTRO PRODUCTO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreProducto.Clear();
                        txtNombreProducto.Focus();
                    }
                    else
                    {
                        oProducto.ModificarProducto(producto);
                        MessageBox.Show("Producto modificado.", "Modificación de Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marcarNoEscritoProducto(txtNombreProducto, cboTipoProducto, cboMarca, txtContenido, cboUnidadDeMedida, txtPrecio, txtStock);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampo(string campo)
        {
            return campo != "";
        }

        private bool validarCampo(int campo)
        {
            return campo != -1;
        }

        private bool validarCampo(float campo)
        {
            return campo != -1;
        }

        private bool validarCamposProducto(string nombreProducto, int tipoProducto, int marca, float contenido,
            int unidadMedida, int stock, float precio)
        {
            return validarCampo(nombreProducto) && validarCampo(marca)
                && validarCampo(tipoProducto) && validarCampo(contenido)
                && validarCampo(unidadMedida) && validarCampo(stock) && 
                validarCampo(precio);
        }
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            return false;
        }

        private void txtContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.')
            {
                // check if it's in the beginning of text not accept
                if (txtContenido.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtContenido.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtContenido.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtContenido.SelectionStart != txtContenido.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtContenido.Text.Substring(txtContenido.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(txtContenido.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtContenido.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtContenido.Text.Substring(sepratorPosition + 1);
                    if (txtContenido.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        public void marcarNoEscritoCampo(TextBox textBox)
        {
            if (!validarCampo(textBox.Text))
            {
                textBox.BackColor = Color.Red;
            }
        }
        public void marcarNoEscritoCampo(ComboBox comboBox)
        {
            if (!validarCampo(comboBox.SelectedIndex))
            {
                comboBox.BackColor = Color.Red;
            }
        }
        public void marcarNoEscritoProducto(TextBox nombreProducto, ComboBox tipoProducto, ComboBox marca, TextBox contenido, ComboBox unidadDeMedida, TextBox precio, TextBox stock)
        {
            marcarNoEscritoCampo(nombreProducto); marcarNoEscritoCampo(tipoProducto);
            marcarNoEscritoCampo(marca); marcarNoEscritoCampo(contenido);
            marcarNoEscritoCampo(unidadDeMedida); marcarNoEscritoCampo(precio);
            marcarNoEscritoCampo(stock);

        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.')
            {
                // check if it's in the beginning of text not accept
                if (txtContenido.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtContenido.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtContenido.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtContenido.SelectionStart != txtContenido.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtContenido.Text.Substring(txtContenido.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(txtContenido.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtContenido.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtContenido.Text.Substring(sepratorPosition + 1);
                    if (txtContenido.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void txtNombreProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.BackColor = Color.White;
        }

        private void cboTipoProducto_Click(object sender, EventArgs e)
        {
            cboTipoProducto.BackColor = Color.White;
        }

        private void cboMarca_Click(object sender, EventArgs e)
        {
            cboMarca.BackColor = Color.White;
        }

        private void txtContenido_Click(object sender, EventArgs e)
        {
            txtContenido.BackColor = Color.White;
        }

        private void cboUnidadDeMedida_Click(object sender, EventArgs e)
        {
            cboUnidadDeMedida.BackColor = Color.White;
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.BackColor = Color.White;
        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            txtStock.BackColor = Color.White;
        }
    }
}
