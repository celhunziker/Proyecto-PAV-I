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
        PerfilService oPerfil = new PerfilService();
        UsuarioService oUsuario = new UsuarioService();
 
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            miAccion = Acciones.Modificacion;
            grdUsuarios.Enabled = true;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = String.Empty;
            txtEmail.Text = String.Empty;
            cboPerfil.SelectedIndex = -1;
        }
       

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["email"],
                                tabla.Rows[i]["nombre"]);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmUsuariosABM fabm = new frmUsuariosABM(miAccion.ToString(),null);
            fabm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmUsuariosABM fabm = new frmUsuariosABM(miAccion.ToString(), (int) grdUsuarios.CurrentRow.Cells[0].Value);
            fabm.Show();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboPerfil.SelectedValue != null)
            {
                DataTable dt = oUsuario.RecuperarFiltrados(txtNombre.Text, txtEmail.Text, (int)cboPerfil.SelectedValue);
                CargarGrilla(grdUsuarios, dt);
                

            }
            else
            {
                DataTable dt = oUsuario.RecuperarFiltrados(txtNombre.Text, txtEmail.Text, null);
                CargarGrilla(grdUsuarios, dt);
            }
        
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGrilla(grdUsuarios, oUsuario.traerTodos());
        }
    }
}


