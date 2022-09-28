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

namespace AppBTS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0)
                this.Close();
            else
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;

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
    }
}
