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
    public partial class frmClases : Form
    {
        enum Acciones 
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        IDisciplinaService oDisciplina = new DisciplinaService();
        IClaseService oClase = new ClaseService();
        private List<string> listaDiasSemana = new List<string>(new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" });

        public frmClases()
        {
            InitializeComponent();
        }

        private void frmClases_Load(object sender, EventArgs e)
        {
            CargarComboDisciplina(cboDisciplinas, oDisciplina.traerTodos());
            CargarComboDiaSemana(cboDiasSemana);
            miAccion = Acciones.Modificacion;
            grdClases.Enabled = true;
            habilitarEdicionYBorrado(false);
        }
        private void LimpiarCampos()
        {
            //ver lo de horario
            cboDisciplinas.SelectedIndex = -1;
            dtpHorario.Value = DateTime.Now;
            dtpHorario.Enabled = true;
            cboDiasSemana.SelectedIndex = -1;
            chkSinHorario.Checked = false;

        }
        private void LimpiarGrilla()
        {
            grdClases.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }
        private void CargarComboDisciplina(ComboBox combo, List<Disciplina> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreDisciplina";
            combo.ValueMember = "Id_disciplina";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboDiaSemana(ComboBox combo)
        {
            combo.DataSource = listaDiasSemana;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, List<Clase> lista)
        {
            grilla.Rows.Clear();

            foreach (Clase oClase in lista)
            {
                //ver lo de horario
                grilla.Rows.Add(oClase.Id_clase,
                                oClase.Horario.ToString("HH:mm"),
                                oClase.DiaSemana,
                                oClase.Id_disciplina.NombreDisciplina);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmClasesABM fabm = new frmClasesABM(miAccion.ToString(), null);
            fabm.ShowDialog();
            if (grdClases.Rows.Count != 0)
            {
                cargarConConsulta();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmClasesABM fabm = new frmClasesABM(miAccion.ToString(), (int)grdClases.CurrentRow.Cells[0].Value);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar esta clase?", "Eliminación de Clases",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oClase.Eliminar((int)grdClases.CurrentRow.Cells[0].Value);
                MessageBox.Show("Clase eliminada.", "Baja de Clase en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdClases, oClase.traerTodos());
            }
        }
        private void cargarConConsulta()
        {
            if (chkTodos.Checked)
            {
                List<Clase> lista = oClase.RecuperarFiltrados(DateTime.Today, null, null);
                CargarGrilla(grdClases, lista);
            }
            else
            {
                if (!chkSinHorario.Checked) {
                    if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue != null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, (string)cboDiasSemana.SelectedValue, (int)cboDisciplinas.SelectedValue);
                        CargarGrilla(grdClases, lista);
                    }
                    else if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue == null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, null, (int)cboDisciplinas.SelectedValue);
                        CargarGrilla(grdClases, lista);
                    }
                    else if (cboDiasSemana.SelectedValue != null && cboDisciplinas.SelectedValue == null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, (string)cboDiasSemana.SelectedValue, null);
                        CargarGrilla(grdClases, lista);
                    }
                    else if (cboDiasSemana.SelectedValue == null && cboDisciplinas.SelectedValue == null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, null, null);
                        CargarGrilla(grdClases, lista);
                    }
                }
                else
                {
                    if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue != null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(DateTime.Today, (string)cboDiasSemana.SelectedValue, (int)cboDisciplinas.SelectedValue);
                        CargarGrilla(grdClases, lista);
                    }
                    else if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue == null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(DateTime.Today, null, (int)cboDisciplinas.SelectedValue);
                        CargarGrilla(grdClases, lista);
                    }
                    else if (cboDiasSemana.SelectedValue != null && cboDisciplinas.SelectedValue == null)
                    {
                        List<Clase> lista = oClase.RecuperarFiltrados(DateTime.Today, (string)cboDiasSemana.SelectedValue, null);
                        CargarGrilla(grdClases, lista);
                    }
                    else
                    {
                        MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                
            }
            //if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue != null && !chkSinHorario.Checked)
            //{
            //    List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, (string)cboDiasSemana.SelectedValue, (int)cboDisciplinas.SelectedValue);
            //    CargarGrilla(grdClases, lista);
            //}
            //else if (cboDisciplinas.SelectedValue != null && cboDiasSemana.SelectedValue == null && !chkSinHorario.Checked)
            //{
            //    List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, null, (int)cboDisciplinas.SelectedValue);
            //    CargarGrilla(grdClases, lista);
            //}
            //else if (cboDiasSemana.SelectedValue != null && cboDisciplinas.SelectedValue == null && !chkSinHorario.Checked)
            //{
            //    List<Clase> lista = oClase.RecuperarFiltrados(dtpHorario.Value, (string)cboDiasSemana.SelectedValue, null);
            //    CargarGrilla(grdClases, lista);
            //}
            //else
            //{
            //    if ((chkTodos.Checked))
            //    {
            //        List<Clase> lista = oClase.RecuperarFiltrados(DateTime.Parse(null), null, null);
            //        CargarGrilla(grdClases, lista);
            //    }
            //    else
            //{
            //    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //}

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
        private void chkSinHorario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinHorario.Checked == true) {
                dtpHorario.Enabled = false;
            }
            else
            {
                dtpHorario.Enabled = true;
            }
            

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
            dtpHorario.Enabled = opcion;
            cboDisciplinas.Enabled = opcion;
            cboDiasSemana.Enabled = opcion;
            chkSinHorario.Enabled = opcion;
        }

        private void grdClases_SelectionChanged(object sender, EventArgs e)
        {
            if (grdClases.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }
    }
}
