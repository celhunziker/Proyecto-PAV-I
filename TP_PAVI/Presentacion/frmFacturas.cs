using AppBTS.Datos.Interfaces;
using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios;
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
        private readonly BindingList<Detalle_Factura> listaFacturaDetalle = new BindingList<Detalle_Factura>();
        IFacturaService oFacturaService = new FacturaService();
        ITipoFacturaService oTipoFacturaService = new TipoFacturaService();
        ITipoClienteService oTipoClienteService = new TipoClienteService();
        IProductoService oProductoService = new ProductoService();
        IMarcaTarjetaService oMarcaTarjetaService = new MarcaTarjetaService();
        IMedioPagoService oMedioPagoService = new MedioPagoService();
        IMarcaBancoService oMarcaBancoService = new MarcaBancoService();
        IDescuentoService oDescuentoService = new DescuentoService();
        IUsuarioService oUsuarioService = new UsuarioService();
        Usuario usuario_cliente = new Usuario();
        public frmFacturas()
        {

            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            CargarComboTipoFactura(cboTipoFact, oTipoFacturaService.traerTodos());
            CargarComboTipoCliente(cboTipoCliente, oTipoClienteService.traerTodos());
            CargarComboProducto(cboProducto, oProductoService.traerTodos());

            cboTipoFact.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            ;
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
            
            agregarDetalleListaFacturaDetalle();
            CargarGrilla(dgvDetalle, listaFacturaDetalle);

            
            

            //Detalle_Factura df = new Detalle_Factura();

            ////id_factura e id_detalle_factura se ingresan o crean en mappeo
            //df.NroItem = listaFacturaDetalleGrid.Count + 1;
            //df.Id_producto = producto;
            ////df.Descripcion = producto.Descripcion;
            //df.Cantidad = cantidad;
            //df.Subtotal = producto.Precio * cantidad;
            //df.Borrado = false;

            //Object aux = (Object)Activator.CreateInstance(typeof(Object), new object[] { NroItem, Id_producto, Descripcion, Cantidad, Precio, Subtotal }); 

            //listaFacturaDetalleGrid.Add();
            //listaFacturaDetalle.Add(df);

            CalcularTotales();

            InicializarDetalle();
        }

        private void agregarDetalleListaFacturaDetalle()
        {
            int cantidad = 0;
            int.TryParse(txtCantidad.Text, out cantidad);
            Producto producto = (Producto)cboProducto.SelectedItem;
            int idProd = producto.Id_producto;
            listaFacturaDetalle.Add(new Detalle_Factura()
            {
                NroItem = listaFacturaDetalle.Count + 1,
                Id_producto = producto,
                Cantidad = cantidad,
                Subtotal = producto.Precio * cantidad

            });
        }

        private void CargarGrilla(DataGridView grilla, BindingList<Detalle_Factura> lista)
        {
            grilla.Rows.Clear();

            foreach (Detalle_Factura oDetalleFactura in lista)
            {
                grilla.Rows.Add(oDetalleFactura.NroItem,
                                oDetalleFactura.Id_producto.Id_producto,
                                oDetalleFactura.Id_producto.NombreProducto,
                                oDetalleFactura.Id_producto.Descripcion,
                                oDetalleFactura.Cantidad,
                                oDetalleFactura.Id_producto.Precio,
                                oDetalleFactura.Subtotal);
            }
        }

        private void CalcularTotales()
        {
            var subtotal = listaFacturaDetalle.Sum(p => p.Subtotal);
            txtSubtotal.Text = subtotal.ToString();

            float descuento = 0;
            //llamar a función que hace select con el codigo de descuento y si hay que nos devuelva el mensaje
            Descuento oDescuento = oDescuentoService.traerPorCodigo(txtCodDescuento.Text);
            if (oDescuento == null)
            {
                descuento = 0;
            } else
            {
                descuento = oDescuento.Porcentaje;
            }

            var importeTotal = subtotal - subtotal * descuento / 100;
            txtDescuento.Text = descuento.ToString();
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
            // CLEAR ROWS

        }

        private void InicializarDetalle()
        {
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPrecio.Text = 0.ToString("N2");
            txtImporte.Text = 0.ToString("N2");
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                Producto producto = (Producto)cboProducto.SelectedItem;
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

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                int cantidad;
                int.TryParse(txtCantidad.Text, out cantidad);
                Producto producto = (Producto)cboProducto.SelectedItem;
                txtImporte.Text = (producto.Precio * cantidad).ToString("C");
            }
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            CalcularTotales();
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

        private void btnCUIT_Click(object sender, EventArgs e)
        {
            if (validarCampoCUIT())
            {
                Usuario usuario = oUsuarioService.BuscarPorCUIT(txtCUIT.Text);
                if(usuario != null)
                {
                    txtDireccion.Text = usuario.Direccion;
                    usuario_cliente = usuario;
                }
                else
                {
                    MessageBox.Show("No existe un cliente registrado con ese CUIT.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("No ingresó el CUIT.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private bool validarCampoCUIT()
        {
            return (txtCUIT.Text != "");
        }


        //private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboProducto.SelectedIndex!=-1) 
        //    {
        //        Producto producto = (Producto)cboProducto.SelectedItem;
        //        txtPrecio.Text = producto.Precio.ToString();
        //    }
        //}

    }
}
