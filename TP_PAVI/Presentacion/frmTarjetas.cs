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
    public partial class frmTarjetas : Form
    {
        private Usuario usuarioActivo;
        public frmTarjetas(Usuario usuario)
        {
            this.usuarioActivo = usuario;
            InitializeComponent();
        }

        enum Acciones //enumeración, similar a una bandera
        {
            Alta,
            Modificacion,
            Consulta,
            Baja
        }
        Acciones miAccion;
        IMarcaTarjetaService oMarcaTarjeta = new MarcaTarjetaService();
        ITarjetaService oTarjeta = new TarjetaService();


        private void LimpiarGrilla()
        {
            grdTarjetas.Rows.Clear();
            habilitarEdicionYBorrado(false);
        }

        private void CargarGrilla(DataGridView grilla, List<Tarjeta> lista)
        {
            grilla.Rows.Clear();

            foreach (Tarjeta oTarjeta in lista)
            {
                grilla.Rows.Add(oTarjeta.Id_marca_tarjeta.Nombre, oTarjeta.Nro_tarjeta, oTarjeta.Fecha_venc.ToString("MM/yy"));
            }
        }

        private void frmTarjetas_Load(object sender, EventArgs e)
        {
            CargarComboMarcaTarjeta(cboMarcaTarjeta, oMarcaTarjeta.traerTodos());
            miAccion = Acciones.Modificacion;
            grdTarjetas.Enabled = true;
            habilitarEdicionYBorrado(false);
        }

        private void habilitarEdicionYBorrado(bool opcion)
        {
            btnEditar.Enabled = opcion;
            btnBorrar.Enabled = opcion;
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

        private void habilitarCampos(bool opcion)
        {
            txtFechaVencAnio.Enabled = opcion;
            txtFechaVencMes.Enabled = opcion;
            txtNumeroTarjeta.Enabled = opcion;
            cboMarcaTarjeta.Enabled = opcion;

        }

        private void LimpiarCampos()
        {
            txtFechaVencAnio.Text = String.Empty;
            txtFechaVencMes.Text = String.Empty;
            cboMarcaTarjeta.SelectedIndex = -1;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarComboMarcaTarjeta(ComboBox combo, List<Marca_tarjeta> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_marca_tarjeta";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void grdTarjetas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTarjetas.SelectedCells.Count > 0)
            {
                habilitarEdicionYBorrado(true);
            }
        }

        private void numberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarConConsulta();
        }

        private void cargarConConsulta()

        {
            long nro_tarjeta = string.IsNullOrEmpty(txtNumeroTarjeta.Text) ? (long)-1 : long.Parse(txtNumeroTarjeta.Text);
            if (cboMarcaTarjeta.SelectedValue != null)
            {
                List<Tarjeta> lista = oTarjeta.traerFiltrados(usuarioActivo.Id_usuario, (int)cboMarcaTarjeta.SelectedValue, nro_tarjeta, txtFechaVencMes.Text, txtFechaVencAnio.Text);
                CargarGrilla(grdTarjetas, lista);
            }
            else
            {
                if (validarCamposTarjeta(txtNumeroTarjeta.Text, txtFechaVencMes.Text, txtFechaVencAnio.Text) || (chkTodos.Checked))
                {
                    List<Tarjeta> lista = oTarjeta.traerFiltrados(usuarioActivo.Id_usuario, null, nro_tarjeta, txtFechaVencMes.Text, txtFechaVencAnio.Text);
                    CargarGrilla(grdTarjetas, lista);
                }
                else
                {
                    MessageBox.Show("No está filtrando por ninguna opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
        private bool validarCampo(string campo)
        {
            return campo != "";
        }
        private bool validarCamposTarjeta(string nro_tarjeta, string fecha_venc_mes, string fecha_venc_anio)
        {
            return ((validarCampo(nro_tarjeta) || validarCampo(fecha_venc_mes)
                || validarCampo(fecha_venc_anio)));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarGrilla();
            chkTodos.Checked = false;
         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmTarjetasABM fabm = new frmTarjetasABM(miAccion.ToString(), null, usuarioActivo);
            fabm.ShowDialog();
            if (grdTarjetas.Rows.Count != 0)
            {
                cargarConConsulta();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Modificacion;
            frmTarjetasABM fabm = new frmTarjetasABM(miAccion.ToString(), (long)grdTarjetas.CurrentRow.Cells[1].Value, usuarioActivo);
            fabm.ShowDialog();
            cargarConConsulta();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar esta tarjeta?", "Eliminación de Tarjeta",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                oTarjeta.Eliminar((long)grdTarjetas.CurrentRow.Cells[1].Value);
                MessageBox.Show("Tarjeta eliminada.", "Baja de Tarjeta en el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla(grdTarjetas, oTarjeta.traerTodos(usuarioActivo.Id_usuario));
            }
        }
    }
}
