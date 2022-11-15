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
    public partial class frmDisciplinasABM : Form
    {
        private string accion;
        private int? id_disciplina;
        private IDisciplinaService oDisciplina= new DisciplinaService();

        public frmDisciplinasABM(string Accion, int? IdDisciplina)
        {
            InitializeComponent();
            this.Text = Accion + " de disciplina";
            accion = Accion;
            id_disciplina = IdDisciplina;
        }
        private void frmDisciplinasABM_Load(object sender, EventArgs e)
        {
            if (id_disciplina != null)
            {
                CargarCampos((int)id_disciplina);
            }
        }

        private void CargarCampos(int idDisciplina)
        {
            Disciplina disciplina = oDisciplina.traerPorId(idDisciplina);
            txtId.Text = disciplina.Id_disciplina.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            if (validarCamposDisciplina(txtDisciplina.Text))
            {
                disciplina.NombreDisciplina = txtDisciplina.Text;
                if (accion == "Alta")
                {
                    if (oDisciplina.ExisteNombreDisciplina(disciplina.NombreDisciplina, null))
                    {
                        MessageBox.Show("YA EXISTE UNA DISCIPLINA CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisciplina.Clear();
                        txtDisciplina.Focus();
                    }
                    else
                    {
                        oDisciplina.CrearDisciplina(disciplina);
                        MessageBox.Show("Disciplina creada.", "Alta de Disciplina en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    disciplina.Id_disciplina = (int)id_disciplina;
                    if (oDisciplina.ExisteNombreDisciplina(disciplina.NombreDisciplina, disciplina.Id_disciplina))
                    {
                        MessageBox.Show("YA EXISTE OTRA DISCIPLINA CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisciplina.Clear();
                        txtDisciplina.Focus();
                    }
                    else
                    {
                        oDisciplina.ModificarDisciplina(disciplina);
                        MessageBox.Show("Disciplina modificado.", "Modificación de Disciplina en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marcarNoEscritoDisciplina(txtDisciplina);
            }
        }

        private bool validarCamposDisciplina(string nombreDisciplina)
        {
            return validarCampo(nombreDisciplina);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarCampo(string campo)
        {
            return campo != "";
        }

        public void marcarNoEscritoCampo(TextBox textBox)
        {
            if (!validarCampo(textBox.Text))
            {
                textBox.BackColor = Color.Red;
            }
        }
        public void marcarNoEscritoDisciplina(TextBox nombreDisciplina)
        {
            marcarNoEscritoCampo(nombreDisciplina);

        }

        private void txtDisciplina_Click(object sender, EventArgs e)
        {
            txtDisciplina.BackColor = Color.White;
        }
    }
}
