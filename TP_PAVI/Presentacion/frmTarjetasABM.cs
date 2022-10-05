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
    public partial class frmTarjetasABM : Form
    {
        private Usuario usuarioActivo;
        private string accion;
        private long? nro_tarjeta;
        IMarcaTarjetaService oMarcaTarjeta = new MarcaTarjetaService();
        ITarjetaService oTarjeta = new TarjetaService();
        public frmTarjetasABM(string accion, long? nro_tarjeta, Usuario usuario)
        {
            InitializeComponent();
            this.Text = accion + " de Tarjeta";
            this.accion = accion;
            this.nro_tarjeta = nro_tarjeta;
            this.usuarioActivo = usuario;
        }

        private void frmTarjetasABM_Load(object sender, EventArgs e)
        {
            CargarComboMarcaTarjeta(cboMarcaTarjeta, oMarcaTarjeta.traerTodos());
            if (nro_tarjeta != null)
            {
                CargarCampos((long)nro_tarjeta);
            }
        }

        private void CargarCampos(long nro_tarjeta)
        {
            Tarjeta tarjeta = oTarjeta.RecuperarPorNro(nro_tarjeta);
            txtNumeroTarjeta.Text = tarjeta.Nro_tarjeta.ToString();
            txtFechaVencAnio.Text = tarjeta.Fecha_venc.ToString("yy");
            txtFechaVencMes.Text = tarjeta.Fecha_venc.ToString("MM");
            cboMarcaTarjeta.SelectedValue = tarjeta.Id_marca_tarjeta.Nombre;

        }

        private void CargarComboMarcaTarjeta(ComboBox combo, List<Marca_tarjeta> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_marca_tarjeta";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void numberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.Id_usuario = usuarioActivo;
            if (validarCamposTarjeta(txtNumeroTarjeta.Text, txtFechaVencMes.Text, txtFechaVencAnio.Text,
                (int)cboMarcaTarjeta.SelectedIndex))
            {
                tarjeta.Nro_tarjeta = long.Parse(txtNumeroTarjeta.Text);
                tarjeta.Fecha_venc = new DateTime(Convert.ToInt32(txtFechaVencAnio.Text)+2000, Convert.ToInt32(txtFechaVencMes.Text), 1).AddMonths(1).AddDays(-1);
                tarjeta.Id_marca_tarjeta = new Marca_tarjeta();
                tarjeta.Id_marca_tarjeta.Id_marca_tarjeta = (int)cboMarcaTarjeta.SelectedValue;
                if (accion == "Alta")
                {
                    if (oTarjeta.ExisteTarjeta(tarjeta.Nro_tarjeta))
                    {
                        MessageBox.Show("YA EXISTE UNA TARJETA CON ESE NÚMERO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumeroTarjeta.Clear();
                        txtNumeroTarjeta.Focus();
                    }
                    else
                    {
                        oTarjeta.Crear(tarjeta);
                        MessageBox.Show("Tarjeta creada.", "Alta de Tarjeta en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    //COMO CORROBORAMOS LA DUPLICACION?
                    if (oTarjeta.ExisteTarjeta(tarjeta.Nro_tarjeta))
                    {
                        MessageBox.Show("YA EXISTE OTRA TARJETA CON ESE NOMBRE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumeroTarjeta.Clear();
                        txtNumeroTarjeta.Focus();
                    }
                    else
                    {
                        oTarjeta.Modificar(tarjeta);
                        MessageBox.Show("Tarjeta modificada.", "Modificación de Tarjeta en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marcarNoEscritoTarjeta(txtNumeroTarjeta, txtFechaVencMes, txtFechaVencAnio, cboMarcaTarjeta);
            }
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
        private void marcarNoEscritoTarjeta(TextBox txtNumeroTarjeta, TextBox txtFechaVencMes, TextBox txtFechaVencAnio, ComboBox cboMarcaTarjetas)
        {
            marcarNoEscritoCampo(txtNumeroTarjeta); marcarNoEscritoCampo(txtFechaVencMes); marcarNoEscritoCampo(txtFechaVencAnio); marcarNoEscritoCampo(cboMarcaTarjetas);
        }


        private bool validarCampo(string campo)
        {
            return campo != "";
        }
        private bool validarCampo(int campo)
        {
            return campo != -1;
        }
        private bool validarCamposTarjeta(string nro_tarjeta, string fecha_venc_mes, string fecha_venc_anio, int id_marca_tarjeta)
        {
            return ((validarCampo(nro_tarjeta) && validarCampo(fecha_venc_mes)
                && validarCampo(fecha_venc_anio) && validarCampo(id_marca_tarjeta)));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            txtNumeroTarjeta.BackColor = Color.White;
        }

        private void cboMarcaTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMarcaTarjeta.BackColor = Color.White;
        }

        private void txtFechaVencMes_TextChanged(object sender, EventArgs e)
        {
            txtFechaVencMes.BackColor = Color.White;
        }

        private void txtFechaVencAnio_TextChanged(object sender, EventArgs e)
        {
            txtFechaVencAnio.BackColor = Color.White;
        }
    }
}
