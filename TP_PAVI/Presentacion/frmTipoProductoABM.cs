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
    public partial class frmTipoProductoABM : Form
    {
        private string accion;
        private int? Id_Tipo_Producto;
        private ITipoProductoService oTipoProducto = new TipoProductoService();
        public frmTipoProductoABM(string Accion, int? IdTipoProducto)
        {
            InitializeComponent();
            this.Text = Accion + " de Tipo Producto";
            accion = Accion;
            Id_Tipo_Producto = IdTipoProducto;
        }

        private void frmTipoProductoABM_Load(object sender, EventArgs e)
        {
            if (Id_Tipo_Producto != null)
            {
                CargarCampos((int)Id_Tipo_Producto);
            }
        }
        
        private void CargarCampos(int idTipoProducto)
        {
            Tipo_Producto tipoProducto = oTipoProducto.traerPorId(idTipoProducto);
            txtId.Text = tipoProducto.Id_Tipo_Producto.ToString();
            txtNombreTipoProducto.Text = tipoProducto.NombreTipoProducto;
            txtDescripcion.Text = tipoProducto.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tipo_Producto tipoProducto = new Tipo_Producto();
            if (validarCamposTipoProducto(txtNombreTipoProducto.Text))
            {
                tipoProducto.NombreTipoProducto = txtNombreTipoProducto.Text;
                tipoProducto.Descripcion = txtDescripcion.Text;
                if (accion == "Alta")
                {
                    if (oTipoProducto.ExisteNombreTipoProducto(tipoProducto.NombreTipoProducto, null))
                    {
                        MessageBox.Show("YA EXISTE UN TIPO PRODUCTO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreTipoProducto.Clear();
                        txtNombreTipoProducto.Focus();
                    }
                    else
                    {
                        oTipoProducto.CrearTipoProducto(tipoProducto);
                        MessageBox.Show("Producto creado.", "Alta de Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    tipoProducto.Id_Tipo_Producto = (int)Id_Tipo_Producto;
                    if (oTipoProducto.ExisteNombreTipoProducto(tipoProducto.NombreTipoProducto, tipoProducto.Id_Tipo_Producto))
                    {
                        MessageBox.Show("YA EXISTE OTRO TIPO PRODUCTO CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombreTipoProducto.Clear();
                        txtNombreTipoProducto.Focus();
                    }
                    else
                    {
                        oTipoProducto.ModificarTipoProducto(tipoProducto);
                        MessageBox.Show("Tipo Producto modificado.", "Modificación de Tipo Producto en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool validarCamposTipoProducto(string nombreTipoProducto)
        {
            return validarCampo(nombreTipoProducto);
        }
    }
}
