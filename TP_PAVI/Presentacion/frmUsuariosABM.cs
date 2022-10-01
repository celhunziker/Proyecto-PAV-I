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
    public partial class frmUsuariosABM : Form
    {
        private string accion;
        private int? idUsuario;
        private IUsuarioService oUsuario = new UsuarioService();
        private IPerfilService oPerfil = new PerfilService();
        public frmUsuariosABM(string Accion, int? IdUsuario)
        {
            InitializeComponent();
            this.Text = Accion + " de usuario";
            accion = Accion;
            idUsuario = IdUsuario;

        }
        private void frmUsuariosABM_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            if (idUsuario != null)
            {
                CargarCampos((int)idUsuario);
            }

        }
        private void CargarCombo(ComboBox combo, List<Perfil> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdPerfil";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCampos(int idUsuario)
        {
            Usuario usuario = oUsuario.traerPorId(idUsuario);
            txtId.Text = usuario.Id_usuario.ToString();
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtPassword.Text = usuario.Password;
            txtEmail.Text = usuario.Email;
            cboPerfil.SelectedValue = usuario.Id_perfil.IdPerfil;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (validarCamposUsuario(txtNombreUsuario.Text, txtNombre.Text,
                txtApellido.Text, txtPassword.Text, txtEmail.Text,
                (int)cboPerfil.SelectedIndex))
            {
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Password = txtPassword.Text;
                usuario.Email = txtEmail.Text;
                usuario.Id_perfil = new Perfil();
                usuario.Id_perfil.IdPerfil = (int)cboPerfil.SelectedValue;
                usuario.Estado = "S"; 
                if (accion == "Alta")
                {
                    if (oUsuario.ExisteNombreUsuario(usuario.NombreUsuario, null)) 
                    {
                        MessageBox.Show("YA EXISTE UN USUARIO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreUsuario.Clear();
                        txtNombreUsuario.Focus();
                    }
                    else
                    {
                        oUsuario.CrearUsuario(usuario);
                        MessageBox.Show("Usuario creado.", "Alta de Usuario en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }   
                }
                else
                {
                    usuario.Id_usuario = (int)idUsuario;
                    if (oUsuario.ExisteNombreUsuario(usuario.NombreUsuario, usuario.Id_usuario))
                    {
                        MessageBox.Show("YA EXISTE OTRO USUARIO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreUsuario.Clear();
                        txtNombreUsuario.Focus();
                    }
                    else
                    {
                        oUsuario.ModificarUsuario(usuario);
                        MessageBox.Show("Usuario modificado.", "Modificación de Usuario en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }   
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marcarNoEscritoUsuario(txtNombreUsuario, txtNombre, txtApellido, txtPassword, txtEmail, cboPerfil);
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

        private bool validarCamposUsuario(string nombreUsuario, string nombre,
            string apellido, string password, string email, int perfil)
        {
            return validarCampo(nombreUsuario)&& validarCampo(nombre)
                && validarCampo(apellido) && validarCampo(password)
                && validarCampo(email) && validarCampo(perfil);
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
        public void marcarNoEscritoUsuario(TextBox nombreUsuario, TextBox nombre,
            TextBox apellido, TextBox password, TextBox email, ComboBox perfil)
        {
            marcarNoEscritoCampo(nombreUsuario); marcarNoEscritoCampo(nombre);
            marcarNoEscritoCampo(apellido); marcarNoEscritoCampo(password);
            marcarNoEscritoCampo(email); marcarNoEscritoCampo(perfil);

        }

   

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.BackColor = Color.White;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.BackColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void cboPerfil_Click(object sender, EventArgs e)
        {
            cboPerfil.BackColor = Color.White;
        }
    }
}
