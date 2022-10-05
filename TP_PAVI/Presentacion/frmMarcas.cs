using AppBTS.Datos.Interfaces;
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
    public partial class frmMarcas : Form
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
        public frmMarcas()
        {
            InitializeComponent();
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            //CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            miAccion = Acciones.Modificacion;
            grdMarcas.Enabled = true;
            habilitarEdicionYBorrado(false);
        }
        private void LimpiarCampos()
        {
            txtNombreMarca.Text = String.Empty;
        }
        private void LimpiarGrilla()
        {
            grdMarcas.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }
        private void CargarGrilla(DataGridView grilla, List<Marca> lista)
        {
            grilla.Rows.Clear();

            foreach (Marca oMarca in lista)
            {
                grilla.Rows.Add(oMarca.Id_marca,
                                oMarca.NombreMarca);
            }
        }

        private void habilitarEdicionYBorrado(bool v)
        {
            btnEditar.Enabled = v;
            btnBorrar.Enabled = v;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmMarcasABM fabm = new frmMarcasABM(miAccion.ToString(), null);
            fabm.ShowDialog();
            if (grdMarcas.Rows.Count != 0)
            {
                cargarConConsulta();
            }
        }

        private void cargarConConsulta()
        {
            {
                if (validarCampoMarca(txtNombreMarca.Text) || (chkTodos.Checked))
                {
                    List<Marca> lista = oMarca.RecuperarFiltrados(txtNombreMarca.Text);
                    CargarGrilla(grdMarcas, lista);
                }
                else
                {
                    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private bool validarCampoMarca(string nombreMarca)
        {
            return nombreMarca != "";
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmMarcasABM fabm = new frmMarcasABM(miAccion.ToString(), (int)grdMarcas.CurrentRow.Cells[0].Value);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar esta marca?", "Eliminación de Marcas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oMarca.Eliminar((int)grdMarcas.CurrentRow.Cells[0].Value);
                MessageBox.Show("Marca eliminada.", "Baja de Marca en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdMarcas, oMarca.traerTodos());
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

        private void habilitarCampos(bool v)
        {
            txtNombreMarca.Enabled = v;
        }
        private void grdMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMarcas.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }
    }
}
