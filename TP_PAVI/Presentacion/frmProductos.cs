using AppBTS.Entidades;
using AppBTS.Servicios.Implementaciones;
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
    public partial class frmProductos : Form
    {
        enum Acciones //enumeración, similar a una bandera
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        IMarcaService oMarca = new MarcaService();
        ITipoProductoService oTipoProducto = new TipoProductoService();
        IUnidadMedidaService oUnidadMedida = new UnidadMedidaService();
        //CAMBIAR CUANDO IMPLEMENTE TODO A INTERFAZ
        IProductoService oProducto = new ProductoService();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarComboTipoProducto(cboTipoProducto, oTipoProducto.traerTodos());
            CargarComboMarca(cboMarcas, oMarca.traerTodos());
            //CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            miAccion = Acciones.Modificacion;
            grdProductos.Enabled = true;
            habilitarEdicionYBorrado(false);
        }
        private void LimpiarCampos()
        {
            txtNombreProducto.Text = String.Empty;
            cboMarcas.SelectedIndex = -1;
            cboTipoProducto.SelectedIndex = -1;
        }
        private void LimpiarGrilla()
        {
            grdProductos.Rows.Clear();
            habilitarEdicionYBorrado(false);
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
        private void CargarGrilla(DataGridView grilla, List<Producto> lista)
        {
            grilla.Rows.Clear();

            foreach (Producto oProducto in lista)
            {
                grilla.Rows.Add(oProducto.Id_producto,
                                oProducto.NombreProducto,
                                oProducto.Id_Tipo_Producto.NombreTipoProducto,
                                oProducto.Id_Marca.NombreMarca,
                                oProducto.Contenido,
                                oProducto.Id_Unidad_Medida.Nombre,
                                oProducto.Descripcion,
                                oProducto.Precio,
                                oProducto.Stock);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmProductosABM fabm = new frmProductosABM(miAccion.ToString(), null);
            fabm.ShowDialog();
            if (grdProductos.Rows.Count != 0)
            {
                cargarConConsulta();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmProductosABM fabm = new frmProductosABM(miAccion.ToString(), (int)grdProductos.CurrentRow.Cells[0].Value);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este producto?", "Eliminación de Productos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oProducto.Eliminar((int)grdProductos.CurrentRow.Cells[0].Value);
                MessageBox.Show("Producto eliminado.", "Baja de Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdProductos, oProducto.traerTodos());
            }
        }
        private void cargarConConsulta()
        {
            if (cboMarcas.SelectedValue != null && cboTipoProducto.SelectedValue != null)
            { //string nombreProducto, int? marca, int? tipo_Producto
                List<Producto> lista = oProducto.RecuperarFiltrados(txtNombreProducto.Text, (int)cboTipoProducto.SelectedValue, (int)cboMarcas.SelectedValue);
                CargarGrilla(grdProductos, lista);
            }
            else if (cboMarcas.SelectedValue != null && cboTipoProducto.SelectedValue == null)
            { //string nombreProducto, int? marca, int? tipo_Producto
                List<Producto> lista = oProducto.RecuperarFiltrados(txtNombreProducto.Text, null, (int)cboMarcas.SelectedValue);
                CargarGrilla(grdProductos, lista);
            }
            else if (cboTipoProducto.SelectedValue != null && cboMarcas.SelectedValue == null)
            { //string nombreProducto, int? marca, int? tipo_Producto
                List<Producto> lista = oProducto.RecuperarFiltrados(txtNombreProducto.Text, (int)cboTipoProducto.SelectedValue, null);
                CargarGrilla(grdProductos, lista);
            }
            else
            {
                if (validarCampoProducto(txtNombreProducto.Text) || (chkTodos.Checked))
                {
                    List<Producto> lista = oProducto.RecuperarFiltrados(txtNombreProducto.Text, null, null);
                    CargarGrilla(grdProductos, lista);
                }
                else
                {
                    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarConConsulta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarGrilla();
            chkTodos.Checked = false;
        } 
        //es como el validarCamposUsuario solo que solo tenemos un campo
        private bool validarCampoProducto(string nombreProducto)
        {
            return nombreProducto != "";
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                LimpiarCampos();
                habilitarCampos(false);
            }
            else
            {
                habilitarCampos(true);
            }
        }

        private void habilitarEdicionYBorrado(bool opcion)
        {
            btnEditar.Enabled = opcion;
            btnBorrar.Enabled = opcion;
        }
        private void habilitarCampos(bool opcion)
        {
            txtNombreProducto.Enabled = opcion;
            cboMarcas.Enabled = opcion;
            cboTipoProducto.Enabled = opcion;
        }

        private void grdProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdProductos.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }
    }
}
