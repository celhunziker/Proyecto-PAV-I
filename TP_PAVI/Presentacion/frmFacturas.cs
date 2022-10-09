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
    public partial class frmFacturas : Form
    {
        private readonly BindingList<Detalle_Factura> listaFacturaDetalle;
        IFacturaService oFacturaService = new FacturaService();
        ITipoFacturaService oTipoFacturaService = new TipoFacturaService();
        ITipoClienteService oTipoClienteService = new TipoClienteService();
        IProductoService oProductoService = new ProductoService();
        IMarcaTarjetaService oMarcaTarjetaService = new MarcaTarjetaService();
        IMedioPagoService oMedioPagoService = new MedioPagoService();
        IMarcaBancoService oMarcaBancoService = new MarcaBancoService();
        public frmFacturas()
        {
            dgvDetalle.AutoGenerateColumns = false;
            InitializeComponent();

        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            CargarCombo(cboTipoFact, oTipoFacturaService.ObtenerTodos(), "IdTipoFactura", "IdTipoFactura");
            CargarCombo(cboTipoCliente, oTipoClienteService.ObtenerTodos(), "NombreTipoCliente", "IdTipoCliente");
            CargarCombo(cboProducto, oProductoService.ObtenerTodos(), "Nombre", "IdProducto");

            dgvDetalle.DataSource = listaFacturaDetalle;
            cboTipoFact.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
        }
        private void CargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int.TryParse(txtCantidad.Text, out cantidad);

            var producto = (Producto)cboProducto.SelectedItem;
            listaFacturaDetalle.Add(new Detalle_Factura()
            {
                NroItem = listaFacturaDetalle.Count + 1,
                Id_producto = producto,
                Cantidad = cantidad,
                Subtotal = producto.Precio * cantidad
            });

            CalcularTotales();

            InicializarDetalle();
        }
        private void CalcularTotales()
        {
            var subtotal = listaFacturaDetalle.Sum(p => p.Subtotal);
            txtSubtotal.Text = subtotal.ToString();

            float descuento = 0;
            //llamar a función que hace select con el codigo de descuento y si hay que nos devuelva el mensaje

            if (descuento == null)
            {
                descuento = 0;
            }

            var importeTotal = subtotal - subtotal * descuento / 100;
            txtImporteTotal.Text = importeTotal.ToString("C");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                    Factura factura = new Factura
                {
                    Fecha = dtpFecha.Value,
                    Tipo_cliente = (Tipo_Cliente)cboTipoCliente.SelectedItem,
                    Tipo_factura = (Tipo_Factura)cboTipoFact.SelectedItem,
                    FacturaDetalle = listaFacturaDetalle,
                    Total = float.Parse(txtSubtotal.Text),
                    //Id_Descuento =(Descuento)txtDescuento.Text
                    //falta direccion
                };

                if (FacturaService.ValidarDatos(factura))
                {
                    FacturaService.Crear(factura);

                    MessageBox.Show(string.Concat("La factura nro: ", factura.IdFactura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicializarFormulario();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            //terminaaaaar
            Usuario usuario = new Usuario();
            btnAgregar.Enabled = false;
            txtDescuento.Text = (0).ToString("N2");
            txtNroFact.Text = "1";
            cboTipoFact.SelectedIndex = -1;
            txtNroFact.Text = "";
            txtDireccion.Text = usuario.Direccion;
            cboTipoCliente.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtCUIT.Text = "";

            InicializarDetalle();

            dgvDetalle.DataSource = null;

        }

        private void InicializarDetalle()
        {
            _cboArticulo.SelectedIndex = -1;
            _txtCantidad.Text = "";
            _txtPrecio.Text = 0.ToString("N2");
            _txtImporte.Text = 0.ToString("N2");
        }

        private void _cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cboArticulo.SelectedItem != null)
            {
                var producto = (Producto)_cboArticulo.SelectedItem;
                _txtPrecio.Text = producto.Precio.ToString("C");
                _txtCantidad.Enabled = true;
                int cantidad = 0;
                int.TryParse(_txtCantidad.Text, out cantidad);
                _txtImporte.Text = (producto.Precio * cantidad).ToString("C");
                _btnAgregar.Enabled = true;
            }
            else
            {
                _btnAgregar.Enabled = false;
                _txtCantidad.Enabled = false;
                _txtCantidad.Text = "";
                _txtPrecio.Text = "";
                _txtImporte.Text = "";
            }
        }

        private void _txtCantidad_Leave(object sender, EventArgs e)
        {
            if (_cboArticulo.SelectedItem != null)
            {
                int cantidad = 0;
                int.TryParse(_txtCantidad.Text, out cantidad);
                var producto = (Producto)_cboArticulo.SelectedItem;
                _txtImporte.Text = (producto.Precio * cantidad).ToString("C");
            }
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            CalcularTotales();
            double descuento = 0;
            if (double.TryParse(txtDescuento.Text, out descuento))
            {
                txtDescuento.Text = descuento.ToString("N2");
            }
        }

        private void _btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                var detalleSeleccionado = (FacturaDetalle)dgvDetalle.CurrentRow.DataBoundItem;
                listaFacturaDetalle.Remove(detalleSeleccionado);
            }
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem != null)
            {
                var cliente = (Cliente)cboCliente.SelectedItem;

                txtDireccion.Text = string.Concat(cliente.DomicilioCalle, cliente.DomicilioNumero);
                txtCUIT.Text = cliente.CUIT;
            }
        }

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarDetalle();
        }

    }
}
