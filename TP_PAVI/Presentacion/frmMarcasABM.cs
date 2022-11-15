using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
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
    public partial class frmMarcasABM : Form
    {
        private string accion;
        private int? id_marca;
        private IMarcaService oMarca = new MarcaService();
        //private object idMarca;

        public frmMarcasABM(string Accion, int? IdMarca)
        {
            InitializeComponent();
            this.Text = Accion + " de marca";
            accion = Accion;
            id_marca = IdMarca;
        }
        private void frmMarcasABM_Load(object sender, EventArgs e)
        {
            if (id_marca != null)
            {
                CargarCampos((int)id_marca);
            }
        }

        private void CargarCampos(int idMarca)
        {
            Marca marca = oMarca.traerPorId(idMarca);
            txtId.Text = marca.Id_marca.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            if (validarCamposMarca(txtNombreMarca.Text))
            {
                marca.NombreMarca = txtNombreMarca.Text;
                if (accion == "Alta")
                {
                    if (oMarca.ExisteNombreMarca(marca.NombreMarca, null))
                    {
                        MessageBox.Show("YA EXISTE UNA MARCA CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreMarca.Clear();
                        txtNombreMarca.Focus();
                    }
                    else
                    {
                        oMarca.CrearMarca(marca);
                        MessageBox.Show("Marca creada.", "Alta de Marca en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    marca.Id_marca = (int)id_marca;
                    if (oMarca.ExisteNombreMarca(marca.NombreMarca, marca.Id_marca))
                    {
                        MessageBox.Show("YA EXISTE OTRA MARCA CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreMarca.Clear();
                        txtNombreMarca.Focus();
                    }
                    else
                    {
                        oMarca.ModificarMarca(marca);
                        MessageBox.Show("Marca modificado.", "Modificación de Marca en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marcarNoEscritoMarca(txtNombreMarca);
            }
        }

        private bool validarCamposMarca(string nombreMarca)
        {
            return validarCampo(nombreMarca);
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
        public void marcarNoEscritoMarca(TextBox nombreMarca)
        {
            marcarNoEscritoCampo(nombreMarca);

        }

        private void txtNombreMarca_Click(object sender, EventArgs e)
        {
            txtNombreMarca.BackColor = Color.White;
        }
    }
}
