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
    public partial class frmFacturas : Form
    {
        private readonly BindingList<DetalleFactura> listaFacturaDetalle;
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
            var precio = producto.Precio;
            listaFacturaDetalle.Add(new Detalle_Factura()
            {
                NroItem = listaFacturaDetalle.Count + 1,
                Id_producto = producto,
                Cantidad = cantidad,
                Subtotal = precio
            });

            CalcularTotales();

            InicializarDetalle();
        }
    }
}
