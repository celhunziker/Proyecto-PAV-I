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
            
            InitializeComponent();
            dgvDetalle.AutoGenerateColumns = false;
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            CargarComboTipoFactura(cboTipoFact, oTipoFacturaService.traerTodos());
            CargarComboTipoCliente(cboTipoCliente, oTipoClienteService.traerTodos());
            CargarComboProducto(cboProducto, oProductoService.traerTodos());

            dgvDetalle.DataSource = listaFacturaDetalle;
            cboTipoFact.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
        }
        private void CargarComboTipoFactura(ComboBox combo, List<Tipo_Factura> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_tipo_factura";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboTipoCliente(ComboBox combo, List<Tipo_Cliente> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_tipo_cliente";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarComboProducto(ComboBox combo, List<Producto> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProducto";
            combo.ValueMember = "Id_producto";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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

                if (oFacturaService.ValidarDatos(factura))
                {
                    oFacturaService.CrearFactura(factura);

                    MessageBox.Show(string.Concat("La factura nro: ", factura.Id_factura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicializarFormulario();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPrecio.Text = 0.ToString("N2");
            txtImporte.Text = 0.ToString("N2");
        }

        private void _cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                var producto = (Producto)cboProducto.SelectedItem;
                txtPrecio.Text = producto.Precio.ToString("C");
                txtCantidad.Enabled = true;
                int cantidad = 0;
                int.TryParse(txtCantidad.Text, out cantidad);
                txtImporte.Text = (producto.Precio * cantidad).ToString("C");
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                txtCantidad.Enabled = false;
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                txtImporte.Text = "";
            }
        }

        private void _txtCantidad_Leave(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                int cantidad = 0;
                int.TryParse(txtCantidad.Text, out cantidad);
                var producto = (Producto)cboProducto.SelectedItem;
                txtImporte.Text = (producto.Precio * cantidad).ToString("C");
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
                var detalleSeleccionado = (Detalle_Factura)dgvDetalle.CurrentRow.DataBoundItem;
                listaFacturaDetalle.Remove(detalleSeleccionado);
            }
        }

        //este esta mal porque no lo hacemos así (para mí hay que hacerlo así pero con usuarios, soy vale)
        //private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboTipoCliente.SelectedItem != null)
        //    {
        //        var cliente = (Cliente)cboTipoCliente.SelectedItem;

        //        txtDireccion.Text = string.Concat(cliente.DomicilioCalle, cliente.DomicilioNumero);
        //        txtCUIT.Text = cliente.CUIT;
        //    }
        //}

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarDetalle();
        }

    }
}
