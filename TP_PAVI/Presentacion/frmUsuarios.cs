using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios;
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
    public partial class frmUsuarios : Form
    {
        enum Acciones //enumeración, similar a una bandera
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        IPerfilService oPerfil = new PerfilService();
        //CAMBIAR CUANDO IMPLEMENTE TODO A INTERFAZ
        IUsuarioService oUsuario = new UsuarioService();

        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            //CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            miAccion = Acciones.Modificacion;
            grdUsuarios.Enabled = true;
            habilitarEdicionYBorrado(false);
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtApellido.Text = String.Empty;
            cboPerfil.SelectedIndex = -1;
        }
        private void LimpiarGrilla()
        {
            grdUsuarios.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }


        private void CargarCombo(ComboBox combo, List<Perfil> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdPerfil";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, List<Usuario> lista)
        {
            grilla.Rows.Clear();

            foreach (Usuario oUsuario in lista)
            {
                grilla.Rows.Add(oUsuario.Id_usuario,
                                oUsuario.NombreUsuario,
                                oUsuario.Nombre,
                                oUsuario.Apellido,
                                oUsuario.Email,
                                oUsuario.Id_perfil.Nombre);
            }
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmUsuariosABM fabm = new frmUsuariosABM(miAccion.ToString(),null);
            fabm.ShowDialog();
            cargarConConsulta();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmUsuariosABM fabm = new frmUsuariosABM(miAccion.ToString(), (int) grdUsuarios.CurrentRow.Cells[0].Value);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este usuario?", "Eliminación de Usuarios", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oUsuario.Eliminar((int) grdUsuarios.CurrentRow.Cells[0].Value);
                MessageBox.Show("Usuario eliminado.", "Baja de Usuario en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            }

        }
        private void cargarConConsulta()
        {
            if (cboPerfil.SelectedValue != null)
            {
                List<Usuario> lista = oUsuario.RecuperarFiltrados(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, (int)cboPerfil.SelectedValue);
                CargarGrilla(grdUsuarios, lista);
            }
            else
            {
                if (validarCamposUsuario(txtNombreUsuario.Text, txtNombre.Text,
            txtApellido.Text, txtEmail.Text) || (chkTodos.Checked))
                {
                    List<Usuario> lista = oUsuario.RecuperarFiltrados(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, null);
                    CargarGrilla(grdUsuarios, lista);
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

        private bool validarCampo(string campo)
        {
            return campo != "";
        }

        private bool validarCamposUsuario(string nombreUsuario, string nombre,
            string apellido, string email)
        {
            return ((validarCampo(nombreUsuario) || validarCampo(nombre)
                || validarCampo(apellido) || validarCampo(email))) ;
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
            txtNombreUsuario.Enabled = opcion;
            txtNombre.Enabled = opcion;
            txtApellido.Enabled = opcion;
            txtEmail.Enabled = opcion;
            cboPerfil.Enabled = opcion;
        }

        private void grdUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }

        
    }
}


