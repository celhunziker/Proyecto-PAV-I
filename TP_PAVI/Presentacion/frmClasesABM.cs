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
    public partial class frmClasesABM : Form
    {
        private string accion;
        private int? id_clase;
        private List<string> listaDiasSemana = new List<string>(new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" });
        private IClaseService oClase = new ClaseService();
        private IDisciplinaService oDisciplina = new DisciplinaService();
        public frmClasesABM(string Accion, int? IdClase)
        {
            InitializeComponent();
            this.Text = Accion + " de clase";
            accion = Accion;
            id_clase = IdClase;
        }

        private void frmClasesABM_Load(object sender, EventArgs e)
        {
            CargarComboDisciplinas(cboDisciplinas, oDisciplina.traerTodos());
            CargarComboDiasSemana(cboDiasSemana);
            if (id_clase != null)
            {
                CargarCampos((int)id_clase);
            }
        }
        private void CargarComboDisciplinas(ComboBox combo, List<Disciplina> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreDisciplina";
            combo.ValueMember = "Id_disciplina";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboDiasSemana(ComboBox combo)
        {
            combo.DataSource = listaDiasSemana;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCampos(int idClase)
        {
            Clase clase = oClase.traerPorId(idClase);
            txtId.Text = clase.Id_clase.ToString();
            cboDisciplinas.SelectedValue = clase.Id_disciplina.Id_disciplina;
            //VER ESTO
            cboDiasSemana.SelectedIndex = encontrarIndice(clase.DiaSemana);
            //ver lo de horario
            dtpHorario.Value = clase.Horario;
        }

        private int encontrarIndice(string diaSemana)
        {
            for (int i = 0; i <= 6; i++)
            {
                if (listaDiasSemana[i] == diaSemana) 
                {
                    return i;
                };
            };
            return -1;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase();
            if (validarCamposClase(dtpHorario.Value, (int)cboDisciplinas.SelectedIndex, (int)cboDiasSemana.SelectedIndex))
            {
                clase.Id_disciplina = new Disciplina();
                clase.Id_disciplina.Id_disciplina = (int)cboDisciplinas.SelectedValue;
                clase.DiaSemana = (string)cboDiasSemana.SelectedValue;
                //verrrr
                clase.Horario = dtpHorario.Value;
                if (accion == "Alta")
                {
                    oClase.CrearClase(clase);
                    MessageBox.Show("Clase creada.", "Alta de Clase en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                else
                {
                    clase.Id_clase = (int)id_clase;
                    
                        oClase.ModificarClase(clase);
                        MessageBox.Show("Clase modificada.", "Modificación de Clase en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    
                }
            }
            else
            {
                //FALTA LO DE LOS COSOS ROJOS
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarCampo(int campo)
        {
            return campo != -1;
        }
        private bool validarCampo(DateTime horario)
        {
            return true;
        }
        private bool validarCamposClase(DateTime horario, int disciplina, int diaSemana)
        {
            return validarCampo(horario) && validarCampo(disciplina)
                && validarCampo(diaSemana);
        }
    }
}
