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
    public enum Modo
    {
        Create,
        Read,
        Update,
        Delete
    }
    //CUIT A USAR 55881111112
    public partial class frmFacturas : Form
    {
        Modo modo = Modo.Create;
        private readonly BindingList<Detalle_Factura> listaFacturaDetalle = new BindingList<Detalle_Factura>();
        private readonly BindingList<Detalle_Cobro> listaDetalleCobro = new BindingList<Detalle_Cobro>();
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
        Factura oFactura = new Factura();
        Tipo_Factura oTipoFactura = new Tipo_Factura();
        Tipo_Cliente oTipoCliente = new Tipo_Cliente();
        Producto oProducto = new Producto();
        Descuento oDescuento = new Descuento();
        Detalle_Factura oDetalleFactura = new Detalle_Factura();
        Usuario usuario_vendedor = new Usuario();
        float importeGeneral = new float();
        List<int> listaCuotas = new List<int>(new int[] { 1,2,3,4,5,6 });
        public frmFacturas(Usuario usuario)
        {
            //ver modos
            InitializeComponent();
            this.usuario_vendedor = usuario;


        }
        void Program_MyEvent(object sender, EventArgs e)
        {
            if (txtCUIT.Text.Length > 0 && /*txtCantidad.Text.Length > 0 &&*/ cboTipoFact.SelectedIndex >= 0 && cboTipoCliente.SelectedIndex >= 0 && dgvDetalle.Rows.Count > 0 /*&& cboProducto.SelectedIndex >= 0*/)
                btnPasarMedioPago.Enabled = true;
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            CargarComboTipoFactura(cboTipoFact, oTipoFacturaService.traerTodos());
            CargarComboTipoCliente(cboTipoCliente, oTipoClienteService.traerTodos());
            CargarComboProducto(cboProducto, oProductoService.traerTodos());
            CargarComboMedioPago(cboMedioPago, oMedioPagoService.traerTodos());
            CargarComboMarcaBanco(cboMarcaBanco, oMarcaBancoService.traerTodos());
            CargarComboMarcaTarjeta(cboMarcaTarjeta, oMarcaTarjetaService.traerTodos());
            CargarComboCuota(cboCuotas);

            cboTipoFact.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            habilitarCamposMedioPago(false);
            habilitarCamposDetalleFactura(true);
            btnPasarMedioPago.Enabled = false;
            txtCUIT.TextChanged += Program_MyEvent;
            cboTipoFact.SelectionChangeCommitted += Program_MyEvent;
            cboTipoCliente.SelectionChangeCommitted += Program_MyEvent;
            dgvDetalle.RowsAdded += Program_MyEvent;
            //cboProducto.SelectionChangeCommitted += Program_MyEvent;
            //txtCantidad.TextChanged += Program_MyEvent;
        }

        private void habilitarCamposMedioPago(bool opcion)
        {
            cboMedioPago.Enabled = opcion;
            cboMarcaTarjeta.Enabled = false;
            cboMarcaBanco.Enabled = false;
            cboCuotas.Enabled = false;
            txtCodAutorizacion.Enabled = false;
            txtMonto.Enabled = false;
            txtValorCuota.Enabled = false;
            btnAgregarMedioPago.Enabled = opcion;
            btnCancelarMedioPago.Enabled = opcion;
            btnQuitarMedioPago.Enabled = opcion;
            dgvMedioCobro.Enabled = opcion;
            btnVolverDetalle.Enabled = opcion;
        }
        private void habilitarCamposDetalleFactura(bool opcion)
        {
            cboTipoFact.Enabled = opcion;
            cboTipoCliente.Enabled = opcion;
            txtNroFact.Enabled = opcion;
            dtpFecha.Enabled = opcion;
            txtCUIT.Enabled = opcion;
            btnCUIT.Enabled = opcion;
            cboProducto.Enabled = opcion;
            txtCantidad.Enabled = opcion;
            btnAgregar.Enabled = opcion;
            btnQuitar.Enabled = opcion;
            btnCancelar.Enabled = opcion;
            dgvDetalle.Enabled = opcion;
        }

        private void CargarComboMedioPago(ComboBox combo, List<Medio_Pago> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreMedioCobro";
            combo.ValueMember = "Id_medio_cobro";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboCuota(ComboBox cboCuotas)
        {
            cboCuotas.DataSource = listaCuotas;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboMarcaTarjeta(ComboBox combo, List<Marca_Tarjeta> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id_marca_tarjeta";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboMarcaBanco(ComboBox combo, List<Marca_Banco> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreMarcaBanco";
            combo.ValueMember = "Id_marca_banco";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            CalcularTotales();

            InicializarDetalle();



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
            if (producto.Stock >= cantidad) {
                int idProd = producto.Id_producto;
                listaFacturaDetalle.Add(new Detalle_Factura()
                {
                    NroItem = listaFacturaDetalle.Count + 1,
                    Id_producto = producto,
                    Cantidad = cantidad,
                    Subtotal = producto.Precio * cantidad

                }
                );
                //ver cómo hacer para que sólo se haga si se crea bien la factura
                //oProductoService.ReducirStock(idProd, cantidad);
            }
            else
            {
                MessageBox.Show("No hay stock disponible");
            }
            
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
            importeGeneral = (float)importeTotal;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //string importe = txtImporteTotal.Text;
            //importe = importe.Replace("$", "");
            //float importeFloat = float.Parse(importe);
            switch (modo)
            {
                case Modo.Create:
                    {
                        Descuento oDescuento = oDescuentoService.traerPorCodigo(txtCodDescuento.Text);

                        oFactura.Id_usuario_vendedor = usuario_vendedor;
                        oFactura.Tipo_factura = (Tipo_Factura)cboTipoFact.SelectedItem;
                        oFactura.Total = importeGeneral;
                        oFactura.Id_descuento = oDescuento;
                        oFactura.Id_cliente = usuario_cliente;
                        oFactura.Fecha = DateTime.Today;
                        oFactura.Borrado = false;

                        // ME PARECE QUE HAY QUE CAMBIAR LA BD, USAR UN STRING PARA NRO FACTURA ASI PODEMOS USAR LA FUNCION PAD LEFT Y
                        // QUE SEA "00000000004" EL NRO FACTURA, SIENDO 4 EL ID_FACTURA (OSEA LO HARIAMOS DEL LADO DEL DAO YA QUE
                        // NECESITAMOS RECUPERAR EL IDENTITY (ID_FACTURA ))

                        oFactura.FacturaDetalle = listaFacturaDetalle;
                        oFactura.DetalleCobro = listaDetalleCobro;
                        //oDetalleFactura.Cantidad = listaFacturaDetalle;
                        //oDetalleFactura.Id_producto = (Producto)cboProducto.SelectedItem;
                        //oDetalleFactura.Subtotal = float.Parse(txtImporte.Text);
                        if (txtCorroborarMonto.Text == txtImporteTotal.Text)
                        {

                            if (oFacturaService.Create(oFactura))
                            {

                                foreach (Detalle_Factura detalle in oFactura.FacturaDetalle)
                                {
                                    oProductoService.ReducirStock(detalle.Id_producto.Id_producto, detalle.Cantidad);
                                    //MessageBox.Show("Se actualizo el producto " + detalle.Id_producto.Id_producto + ", nuevo stock: " + (detalle.Id_producto.Stock-detalle.Cantidad) + " stock anterior: " + detalle.Id_producto.Stock + ", cantidad: " + detalle.Cantidad);
                                }
                                MessageBox.Show("Se creó con éxito una nueva Factura.");
                            }
                            else
                            {
                                MessageBox.Show("Error al crear una nueva Factura.");
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("EL IMPORTE TOTAL NO COINCIDE CON EL MONTO A PAGAR.");
                        }

                            break;
                        
                    }
                case Modo.Read:
                    this.Close();
                    break;
                case Modo.Update:
                    {
                        this.Close();
                        break;
                        
                    }
                case Modo.Delete:
                    this.Close();
                    break;
                    
                default:
                    this.Close();
                    break;
                    
            }
            
            //try
            //{
            //    Factura factura = new Factura
            //    {
            //        Fecha = dtpFecha.Value,
            //        Tipo_cliente = (Tipo_Cliente)cboTipoCliente.SelectedItem,
            //        Tipo_factura = (Tipo_Factura)cboTipoFact.SelectedItem,
            //        FacturaDetalle = listaFacturaDetalle,
            //        Total = float.Parse(txtSubtotal.Text),
            //        //Id_Descuento =(Descuento)txtDescuento.Text
            //        //falta direccion
            //    };

            //    if (oFacturaService.ValidarDatos(factura))
            //    {
            //        oFacturaService.CrearFactura(factura);

            //        MessageBox.Show(string.Concat("La factura nro: ", factura.Id_factura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        InicializarFormulario();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
            txtNroFactMal.Text = "1";
            cboTipoFact.SelectedIndex = -1;
            txtNroFactMal.Text = "";
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

        

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                int nroItem = Convert.ToInt32(dgvDetalle.CurrentRow.Cells[0].Value);
                listaFacturaDetalle.RemoveAt(nroItem-1);
                foreach (Detalle_Factura detalle in listaFacturaDetalle)
                {
                    if (detalle.NroItem > nroItem)
                    {
                        detalle.NroItem = detalle.NroItem-1;
                    }
                }
                dgvDetalle.Rows.RemoveAt(dgvDetalle.SelectedRows[0].Index);
            }
            CargarGrilla(dgvDetalle, listaFacturaDetalle);
            CalcularTotales();
            InicializarDetalle();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listaFacturaDetalle.Clear();
            CargarGrilla(dgvDetalle, listaFacturaDetalle);
            CalcularTotales();
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
                    // ACA AGREGAR LA OPCION DE DAR DE ALTA UN NUEVO USUARIO SI EL CUIT NO EXISTE
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

        private void btnMedioPago_Click(object sender, EventArgs e)
        {
            habilitarCamposMedioPago(true);
            habilitarCamposDetalleFactura(false);
        }



        //COBRO
        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            habilitarCamposMedioPago(false);
            habilitarCamposDetalleFactura(true);
        }

        private void btnQuitarMedioPago_Click(object sender, EventArgs e)
        {
            if (dgvMedioCobro.CurrentRow != null)
            {
                int i = dgvMedioCobro.CurrentRow.Index;
                listaDetalleCobro.RemoveAt(i);
                dgvMedioCobro.Rows.RemoveAt(dgvMedioCobro.CurrentRow.Index);
            }
            CargarGrillaMedioCobro(dgvMedioCobro, listaDetalleCobro);
            CalcularTotalesMedioCobro();
            InicializarDetalleCobro();
        }

        private void btnAgregarMedioPago_Click(object sender, EventArgs e)
        {
            //CalcularValorCuota();
            agregarDetalleCobroListaDetalleCobro();
            CargarGrillaMedioCobro(dgvMedioCobro, listaDetalleCobro);
            CalcularTotalesMedioCobro();
           
            InicializarDetalleCobro();
        }

        private void InicializarDetalleCobro()
        {
            cboMarcaBanco.SelectedIndex = -1;
            cboMarcaTarjeta.SelectedIndex = -1;
            cboCuotas.SelectedIndex = -1;
            cboMedioPago.SelectedIndex = -1;
            txtValorCuota.Text = "";
            txtCodAutorizacion.Text = "";
            txtMonto.Text = "";
        }

        private void CalcularValorCuota()
        {
            var monto = Convert.ToInt32(txtMonto.Text);
            var cantCuotas = Convert.ToInt32(cboCuotas.SelectedItem);
            var valorCuota = monto / cantCuotas;
            txtValorCuota.Text = valorCuota.ToString("C");

        }

        private void CalcularTotalesMedioCobro()
        {
            var monto = listaDetalleCobro.Sum(p => p.Monto);
            txtCorroborarMonto.Text = monto.ToString();

            var importeTotal = monto ;
            txtCorroborarMonto.Text = importeTotal.ToString("C");
        }

        private void CargarGrillaMedioCobro(DataGridView grilla, BindingList<Detalle_Cobro> lista)
        {
            grilla.Rows.Clear();

            foreach (Detalle_Cobro oDetalleCobro in lista)
            {
                if(oDetalleCobro.Medio_pago.Id_medio_cobro == 1 || oDetalleCobro.Medio_pago.Id_medio_cobro == 4)
                {
                    grilla.Rows.Add(oDetalleCobro.Medio_pago.NombreMedioCobro,
                                null,
                                null,
                                null,
                                null,
                                oDetalleCobro.Monto,
                                null);
                }
                else
                {
                    if(oDetalleCobro.Medio_pago.Id_medio_cobro == 2)
                    {
                        grilla.Rows.Add(oDetalleCobro.Medio_pago.NombreMedioCobro,
                                oDetalleCobro.Id_marca_banco.NombreMarcaBanco,
                                oDetalleCobro.Id_marca_tarjeta.Nombre,
                                oDetalleCobro.Cuotas,
                                oDetalleCobro.Valor_couta,
                                oDetalleCobro.Monto,
                                oDetalleCobro.Codigo_confirmacion

                                );
                    }
                    else
                    {
                        if(oDetalleCobro.Medio_pago.Id_medio_cobro == 3)
                        {
                            grilla.Rows.Add(oDetalleCobro.Medio_pago.NombreMedioCobro,
                                oDetalleCobro.Id_marca_banco.NombreMarcaBanco,
                                oDetalleCobro.Id_marca_tarjeta.Nombre,
                                null,
                                null,
                                oDetalleCobro.Monto,
                                oDetalleCobro.Codigo_confirmacion
                                );
                        }
                    }
                }
                
            }
        }

        private void agregarDetalleCobroListaDetalleCobro()
        {
            int monto = 0;
            int.TryParse(txtMonto.Text, out monto);
            //int monto = Convert.ToInt32(txtCorroborarMonto.Text);
            Medio_Pago medio_pago = (Medio_Pago)cboMedioPago.SelectedItem;
            Marca_Tarjeta marca_tarjeta = new Marca_Tarjeta();
            Marca_Banco marca_banco = new Marca_Banco();
            int cuotas = 0;
            float valor_cuota = 0;
            int codigo_confirmacion = 0;
            //HACERLO CON UN SWITCH CASE
            if (medio_pago.Id_medio_cobro == 1 || medio_pago.Id_medio_cobro == 4)
            {
                marca_tarjeta = null;
                marca_banco = null;
                cuotas = 0;
                valor_cuota = 0;
                codigo_confirmacion = 0;
            }
            else
            {
                if (medio_pago.Id_medio_cobro == 2)
                {
                    marca_tarjeta = (Marca_Tarjeta)cboMarcaTarjeta.SelectedItem;
                    marca_banco = (Marca_Banco)cboMarcaBanco.SelectedItem;
                    cuotas = cboCuotas.SelectedIndex;
                    //valor_cuota = Convert.ToInt32(txtValorCuota.Text);
                    float contenido = string.IsNullOrEmpty(txtValorCuota.Text) ? (float)0 : float.Parse(txtValorCuota.Text);
                    //valor_cuota = (float)Convert.ToDouble(txtValorCuota.Text);
                    codigo_confirmacion = Convert.ToInt32(txtCodAutorizacion.Text);
                }
                else
                {
                    if (medio_pago.Id_medio_cobro == 3)
                    {
                        marca_tarjeta = (Marca_Tarjeta)cboMarcaTarjeta.SelectedItem;
                        marca_banco = (Marca_Banco)cboMarcaBanco.SelectedItem;
                        cuotas = 0;
                        valor_cuota = 0;
                        codigo_confirmacion = Convert.ToInt32(txtCodAutorizacion.Text);
                    }
                }
            }
            listaDetalleCobro.Add(new Detalle_Cobro()
            {
                Medio_pago = medio_pago,
                Monto = monto,
                Cuotas = cuotas,
                Valor_couta = valor_cuota,
                Codigo_confirmacion = codigo_confirmacion,
                Id_marca_banco = marca_banco,
                Id_marca_tarjeta = marca_tarjeta

            }
                ); ;
            }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
        

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboProducto.SelectedItem != null)
            {
                int cantidad;
                int.TryParse(txtCantidad.Text, out cantidad);
                Producto producto = (Producto)cboProducto.SelectedItem;
                txtImporte.Text = (producto.Precio * cantidad).ToString("C");
            }
        }

        private void btnCancelarMedioPago_Click(object sender, EventArgs e)
        {
            listaDetalleCobro.Clear();
            CargarGrillaMedioCobro(dgvMedioCobro, listaDetalleCobro);
            CalcularTotalesMedioCobro();

            InicializarDetalleCobro();
        }


        private void cboMedioPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboMedioPago.Text == "Crédito")
            {
                cboMarcaBanco.Enabled = true;
                cboMarcaTarjeta.Enabled = true;
                cboCuotas.Enabled = true;
                txtValorCuota.Enabled = true;
                txtMonto.Enabled = true;
                txtCodAutorizacion.Enabled = true;
            }
            if (cboMedioPago.Text == "Débito")
            {
                cboMarcaBanco.Enabled = true;
                cboMarcaTarjeta.Enabled = true;
                txtCodAutorizacion.Enabled = true;
                txtMonto.Enabled = true;
                cboCuotas.Enabled = false;
                txtValorCuota.Enabled = false;
            }
            if (cboMedioPago.Text == "Transferencia" || cboMedioPago.Text == "Efectivo")
            {
                txtMonto.Enabled = true;
                cboMarcaBanco.Enabled = false;
                cboMarcaTarjeta.Enabled = false;
                cboCuotas.Enabled = false;
                txtValorCuota.Enabled = false;
                txtCodAutorizacion.Enabled = false;
            }
        }

        private void txtValorCuota_Leave(object sender, EventArgs e)
        {
            CalcularValorCuota();
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
