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
    public partial class frmTipoProducto : Form
    {
        enum Acciones //enumeración, similar a una bandera
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        ITipoProductoService oTipoProducto = new TipoProductoService();
        public frmTipoProducto()
        {
            InitializeComponent();
        }

        private void frmTipoProducto_Load(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            grdTipoProducto.Enabled = true;
            habilitarEdicionYBorrado(false);
        }
        private void LimpiarCampos()
        {
            txtNombreTipoProducto.Text = String.Empty;
        }
        private void LimpiarGrilla()
        {
            grdTipoProducto.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }
        private void CargarGrilla(DataGridView grilla, List<Tipo_Producto> lista)
        {
            grilla.Rows.Clear();

            foreach (Tipo_Producto oTipoProducto in lista)
            {
                grilla.Rows.Add(oTipoProducto.Id_Tipo_Producto,
                                oTipoProducto.NombreTipoProducto,
                                oTipoProducto.Descripcion);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmTipoProductoABM fabm = new frmTipoProductoABM(miAccion.ToString(), null);
            fabm.ShowDialog();
            if (grdTipoProducto.Rows.Count != 0)
            {
                cargarConConsulta();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmTipoProductoABM fabm = new frmTipoProductoABM(miAccion.ToString(), (int)grdTipoProducto.CurrentRow.Cells[0].Value);
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
                oTipoProducto.Eliminar((int)grdTipoProducto.CurrentRow.Cells[0].Value);
                MessageBox.Show("Producto eliminado.", "Baja de Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdTipoProducto, oTipoProducto.traerTodos());
            }
        }
        private void cargarConConsulta()
        {
            {
                if (validarCampoTipoProducto(txtNombreTipoProducto.Text) || (chkTodos.Checked))
                {
                    List<Tipo_Producto> lista = oTipoProducto.RecuperarFiltrados(txtNombreTipoProducto.Text);
                    CargarGrilla(grdTipoProducto, lista);
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
        private bool validarCampoTipoProducto(string nombreTipoProducto)
        {
            return nombreTipoProducto != "";
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
            txtNombreTipoProducto.Enabled = opcion;
        }

        private void grdTipoProducto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTipoProducto.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }
    }
}
