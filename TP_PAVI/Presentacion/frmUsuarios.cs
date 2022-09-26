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
                                tabla.Rows[i]["nombreUsuario"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
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
                DataTable dt = oUsuario.RecuperarFiltrados(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, (int)cboPerfil.SelectedValue);
                CargarGrilla(grdUsuarios, dt);


            }
            else
            {
                    if (validarCamposUsuario(txtNombreUsuario.Text, txtNombre.Text,
                txtApellido.Text, txtEmail.Text) || (chkTodos.Checked))
                {
                    DataTable dt = oUsuario.RecuperarFiltrados(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, null);
                    CargarGrilla(grdUsuarios, dt);
                }
                else
                {
                    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }


            }
        
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarGrilla();
            chkTodos.Checked = false;
        }

<<<<<<< HEAD
        private void grdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
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

>>>>>>> 78c76ba06bed7854e671a904dee162a16e97f909
    }
}


