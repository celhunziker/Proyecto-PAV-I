using AppBTS.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using AppBTS.Servicios;

namespace AppBTS
{
    public partial class frmPrincipal : Form
    {
        Usuario usuario_logueado = new Usuario();
        IUsuarioService oUsuarioService = new UsuarioService();
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0)
            { this.Close(); }
            else {
                this.Show();
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
                usuario_logueado = oUsuarioService.traerPorId(fl.MiUsuario.Id_usuario);
            }
                

            fl.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de abandonar la aplicación...",
                "SALIENDO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fu;
            fu = new frmUsuarios();
            fu.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos fu;
            fu = new frmProductos();
            fu.ShowDialog();
        }

        private void tipoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProducto fu;
            fu = new frmTipoProducto();
            fu.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas fu;
            fu = new frmMarcas();
            fu.ShowDialog();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClases fc;
            fc = new frmClases();
            fc.ShowDialog();
        }

        

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplina fd;
            fd = new frmDisciplina();
            fd.ShowDialog();
        }

        private void cOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(usuario_logueado.Id_perfil.IdPerfil == 12)
            {
                frmFacturas ff;
                ff = new frmFacturas(usuario_logueado);
                ff.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se tiene acceso.");
            }
            
        }

        private void reporteProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario_logueado.Id_perfil.IdPerfil == 12)
            {
                frmReporteProductosVendidos frpv;
                frpv = new frmReporteProductosVendidos();
                frpv.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se tiene acceso.");
            }
        }
    }
}
