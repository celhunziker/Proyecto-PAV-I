using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios;
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
        UsuarioService oUsuario = new UsuarioService();
        PerfilService oPerfil = new PerfilService();
        public frmUsuariosABM(string Accion, int? IdUsuario)
        {
            InitializeComponent();
            this.Text = Accion + " de usuario";
            accion = Accion;
            idUsuario =  IdUsuario;

        }
        private void frmUsuariosABM_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            if (idUsuario != null)
            {
                CargarCampos((int)idUsuario);
            }
            
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCampos(int idUsuario)
        {
            DataTable tabla = oUsuario.traerPorId(idUsuario);
            txtId.Text = tabla.Rows[0]["id_usuario"].ToString();
            txtNombreUsuario.Text = tabla.Rows[0]["nombreUsuario"].ToString();
            txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
            txtPassword.Text = tabla.Rows[0]["password"].ToString();
            txtEmail.Text = tabla.Rows[0]["email"].ToString();
            cboPerfil.SelectedValue = tabla.Rows[0]["id_perfil"];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
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
                oUsuario.CrearUsuario(usuario);
                MessageBox.Show("Usuario creado.", "Alta de Usuario en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                usuario.Id_usuario = (int) idUsuario;
                oUsuario.ModificarUsuario(usuario);
                MessageBox.Show("Usuario modificado.", "Modificación de Usuario en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
