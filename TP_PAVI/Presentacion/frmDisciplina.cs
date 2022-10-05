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
    public partial class frmDisciplina : Form
    {
        enum Acciones //enumeración, similar a una bandera
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        IDisciplinaService oDisciplina = new DisciplinaService();
        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            grdDisciplina.Enabled = true;
            habilitarEdicionYBorrado(false);
        }
        private void LimpiarCampos()
        {
            txtDisciplina.Text = String.Empty;
        }
        private void LimpiarGrilla()
        {
            grdDisciplina.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }
        private void CargarGrilla(DataGridView grilla, List<Disciplina> lista)
        {
            grilla.Rows.Clear();

            foreach (Disciplina oDisciplina in lista)
            {
                grilla.Rows.Add(oDisciplina.Id_disciplina,
                                oDisciplina.NombreDisciplina);
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
            frmDisciplinasABM fabm = new frmDisciplinasABM(miAccion.ToString(), null);
            fabm.ShowDialog();
            if (grdDisciplina.Rows.Count != 0)
            {
                cargarConConsulta();
            }

        }
        private void cargarConConsulta()
        {
            {
                if (validarCampoDisciplina(txtDisciplina.Text) || (chkTodos.Checked))
                {
                    List<Disciplina> lista = oDisciplina.RecuperarFiltrados(txtDisciplina.Text);
                    CargarGrilla(grdDisciplina, lista);
                }
                else
                {
                    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
        private bool validarCampoDisciplina(string nombreDisciplina)
        {
            return nombreDisciplina != "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmDisciplinasABM fabm = new frmDisciplinasABM(miAccion.ToString(), (int)grdDisciplina.CurrentRow.Cells[0].Value);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar esta disciplina?", "Eliminación de Disciplina",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oDisciplina.Eliminar((int)grdDisciplina.CurrentRow.Cells[0].Value);
                MessageBox.Show("Disciplina eliminada.", "Baja de Disciplina en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdDisciplina, oDisciplina.traerTodos());
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
            txtDisciplina.Enabled = v;
        }

        private void grdDisciplina_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDisciplina.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }
    }
}
