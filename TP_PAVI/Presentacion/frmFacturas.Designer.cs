namespace AppBTS.Presentacion
{
    partial class frmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this.btnPasarMedioPago = new System.Windows.Forms.Button();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.NroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNroFactMal = new System.Windows.Forms.TextBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboTipoFact = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNroFact = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoFact = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblCodDescuento = new System.Windows.Forms.Label();
            this.txtCodDescuento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnCUIT = new System.Windows.Forms.Button();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelarMedioPago = new System.Windows.Forms.Button();
            this.btnQuitarMedioPago = new System.Windows.Forms.Button();
            this.btnAgregarMedioPago = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.dvgMedioPago = new System.Windows.Forms.DataGridView();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMarcaTarjeta = new System.Windows.Forms.ComboBox();
            this.lblMarcaTarjeta = new System.Windows.Forms.Label();
            this.cboMarcaBanco = new System.Windows.Forms.ComboBox();
            this.lblMarcaBanco = new System.Windows.Forms.Label();
            this.cboMedioPago = new System.Windows.Forms.ComboBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblValorCuota = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.lblCodAutorizacion = new System.Windows.Forms.Label();
            this.txtCodAutorizacion = new System.Windows.Forms.TextBox();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.btnVolverDetalle = new System.Windows.Forms.Button();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedioPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.Controls.Add(this.btnPasarMedioPago);
            this.dpbDetalle.Controls.Add(this.txtImporteTotal);
            this.dpbDetalle.Controls.Add(this.txtDescuento);
            this.dpbDetalle.Controls.Add(this.txtSubtotal);
            this.dpbDetalle.Controls.Add(this.lblImporteTotal);
            this.dpbDetalle.Controls.Add(this.lblDescuento);
            this.dpbDetalle.Controls.Add(this.lblSubtotal);
            this.dpbDetalle.Controls.Add(this.txtCantidad);
            this.dpbDetalle.Controls.Add(this.txtImporte);
            this.dpbDetalle.Controls.Add(this.lblImporte);
            this.dpbDetalle.Controls.Add(this.btnCancelar);
            this.dpbDetalle.Controls.Add(this.btnQuitar);
            this.dpbDetalle.Controls.Add(this.btnAgregar);
            this.dpbDetalle.Controls.Add(this.dgvDetalle);
            this.dpbDetalle.Controls.Add(this.txtPrecio);
            this.dpbDetalle.Controls.Add(this.lblPrecio);
            this.dpbDetalle.Controls.Add(this._lblCantidad);
            this.dpbDetalle.Controls.Add(this.lblProducto);
            this.dpbDetalle.Controls.Add(this.cboProducto);
            this.dpbDetalle.Controls.Add(this.btnNuevo);
            this.dpbDetalle.Controls.Add(this.btnGrabar);
            this.dpbDetalle.Location = new System.Drawing.Point(18, 88);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Size = new System.Drawing.Size(777, 420);
            this.dpbDetalle.TabIndex = 27;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // btnPasarMedioPago
            // 
            this.btnPasarMedioPago.Location = new System.Drawing.Point(74, 354);
            this.btnPasarMedioPago.Name = "btnPasarMedioPago";
            this.btnPasarMedioPago.Size = new System.Drawing.Size(137, 23);
            this.btnPasarMedioPago.TabIndex = 31;
            this.btnPasarMedioPago.Text = "Pasar a medio pago";
            this.btnPasarMedioPago.UseVisualStyleBackColor = true;
            this.btnPasarMedioPago.Click += new System.EventHandler(this.btnMedioPago_Click);
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(667, 384);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(667, 358);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(667, 332);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(592, 387);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(69, 13);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(585, 361);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 13);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento (%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(614, 335);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(267, 29);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(41, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(512, 28);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(68, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(467, 33);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AppBTS.Properties.Resources.Cancelar3;
            this.btnCancelar.Location = new System.Drawing.Point(729, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(38, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnQuitar.Location = new System.Drawing.Point(685, 19);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(38, 36);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnAgregar.Location = new System.Drawing.Point(643, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(36, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroItem,
            this.Id_producto,
            this.Nombre,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 61);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(754, 252);
            this.dgvDetalle.TabIndex = 7;
            // 
            // NroItem
            // 
            this.NroItem.HeaderText = "Nro. Ítem";
            this.NroItem.MinimumWidth = 6;
            this.NroItem.Name = "NroItem";
            this.NroItem.ReadOnly = true;
            this.NroItem.Width = 70;
            // 
            // Id_producto
            // 
            this.Id_producto.HeaderText = "Cod. Prod.";
            this.Id_producto.MinimumWidth = 6;
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.ReadOnly = true;
            this.Id_producto.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            dataGridViewCellStyle9.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle9;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle10.Format = "C2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.Subtotal.HeaderText = "Importe";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 150;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(379, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(68, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(336, 33);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // _lblCantidad
            // 
            this._lblCantidad.AutoSize = true;
            this._lblCantidad.Location = new System.Drawing.Point(212, 33);
            this._lblCantidad.Name = "_lblCantidad";
            this._lblCantidad.Size = new System.Drawing.Size(49, 13);
            this._lblCantidad.TabIndex = 2;
            this._lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(8, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(58, 28);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(133, 21);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AppBTS.Properties.Resources.new_file;
            this.btnNuevo.Location = new System.Drawing.Point(227, 368);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnGrabar.Location = new System.Drawing.Point(308, 369);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 35);
            this.btnGrabar.TabIndex = 29;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNroFactMal
            // 
            this.txtNroFactMal.Location = new System.Drawing.Point(333, 9);
            this.txtNroFactMal.Name = "txtNroFactMal";
            this.txtNroFactMal.ReadOnly = true;
            this.txtNroFactMal.Size = new System.Drawing.Size(100, 20);
            this.txtNroFactMal.TabIndex = 18;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(92, 36);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(143, 21);
            this.cboTipoCliente.TabIndex = 21;
            // 
            // cboTipoFact
            // 
            this.cboTipoFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFact.FormattingEnabled = true;
            this.cboTipoFact.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoFact.Location = new System.Drawing.Point(92, 9);
            this.cboTipoFact.Name = "cboTipoFact";
            this.cboTipoFact.Size = new System.Drawing.Size(143, 21);
            this.cboTipoFact.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(634, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2019, 9, 29, 17, 20, 8, 0);
            // 
            // lblNroFact
            // 
            this.lblNroFact.AutoSize = true;
            this.lblNroFact.Location = new System.Drawing.Point(260, 12);
            this.lblNroFact.Name = "lblNroFact";
            this.lblNroFact.Size = new System.Drawing.Size(54, 13);
            this.lblNroFact.TabIndex = 24;
            this.lblNroFact.Text = "Nro. Fact.";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(31, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(570, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoFact
            // 
            this.lblTipoFact.AutoSize = true;
            this.lblTipoFact.Location = new System.Drawing.Point(31, 10);
            this.lblTipoFact.Name = "lblTipoFact";
            this.lblTipoFact.Size = new System.Drawing.Size(55, 13);
            this.lblTipoFact.TabIndex = 17;
            this.lblTipoFact.Text = "Tipo Fact.";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(274, 42);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 34;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblCodDescuento
            // 
            this.lblCodDescuento.AutoSize = true;
            this.lblCodDescuento.Location = new System.Drawing.Point(536, 46);
            this.lblCodDescuento.Name = "lblCodDescuento";
            this.lblCodDescuento.Size = new System.Drawing.Size(95, 13);
            this.lblCodDescuento.TabIndex = 36;
            this.lblCodDescuento.Text = "Codigo Descuento";
            // 
            // txtCodDescuento
            // 
            this.txtCodDescuento.Location = new System.Drawing.Point(634, 46);
            this.txtCodDescuento.Name = "txtCodDescuento";
            this.txtCodDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtCodDescuento.TabIndex = 37;
            this.txtCodDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(92, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(341, 20);
            this.txtDireccion.TabIndex = 39;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnCUIT
            // 
            this.btnCUIT.Location = new System.Drawing.Point(436, 39);
            this.btnCUIT.Name = "btnCUIT";
            this.btnCUIT.Size = new System.Drawing.Size(94, 20);
            this.btnCUIT.TabIndex = 40;
            this.btnCUIT.Text = "Buscar Cliente";
            this.btnCUIT.UseVisualStyleBackColor = true;
            this.btnCUIT.Click += new System.EventHandler(this.btnCUIT_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(333, 39);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtCUIT.TabIndex = 41;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(720, 705);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelarMedioPago
            // 
            this.btnCancelarMedioPago.Image = global::AppBTS.Properties.Resources.Cancelar3;
            this.btnCancelarMedioPago.Location = new System.Drawing.Point(750, 606);
            this.btnCancelarMedioPago.Name = "btnCancelarMedioPago";
            this.btnCancelarMedioPago.Size = new System.Drawing.Size(38, 36);
            this.btnCancelarMedioPago.TabIndex = 55;
            this.btnCancelarMedioPago.UseVisualStyleBackColor = true;
            // 
            // btnQuitarMedioPago
            // 
            this.btnQuitarMedioPago.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnQuitarMedioPago.Location = new System.Drawing.Point(706, 606);
            this.btnQuitarMedioPago.Name = "btnQuitarMedioPago";
            this.btnQuitarMedioPago.Size = new System.Drawing.Size(38, 36);
            this.btnQuitarMedioPago.TabIndex = 54;
            this.btnQuitarMedioPago.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMedioPago
            // 
            this.btnAgregarMedioPago.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnAgregarMedioPago.Location = new System.Drawing.Point(664, 606);
            this.btnAgregarMedioPago.Name = "btnAgregarMedioPago";
            this.btnAgregarMedioPago.Size = new System.Drawing.Size(36, 36);
            this.btnAgregarMedioPago.TabIndex = 53;
            this.btnAgregarMedioPago.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(461, 832);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 52;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(498, 829);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 51;
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Location = new System.Drawing.Point(712, 516);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(83, 21);
            this.cboCuotas.TabIndex = 50;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(666, 519);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(40, 13);
            this.lblCuotas.TabIndex = 49;
            this.lblCuotas.Text = "Cuotas";
            // 
            // dvgMedioPago
            // 
            this.dvgMedioPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMedioPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedioPago,
            this.MarcaBanco,
            this.MarcaTarjeta,
            this.Cuotas,
            this.ValorCuota,
            this.dataGridViewTextBoxColumn1});
            this.dvgMedioPago.Location = new System.Drawing.Point(52, 580);
            this.dvgMedioPago.Name = "dvgMedioPago";
            this.dvgMedioPago.Size = new System.Drawing.Size(606, 118);
            this.dvgMedioPago.TabIndex = 48;
            // 
            // MedioPago
            // 
            this.MedioPago.HeaderText = "Medio Pago";
            this.MedioPago.Name = "MedioPago";
            // 
            // MarcaBanco
            // 
            this.MarcaBanco.HeaderText = "Marca Banco";
            this.MarcaBanco.Name = "MarcaBanco";
            // 
            // MarcaTarjeta
            // 
            this.MarcaTarjeta.HeaderText = "Marca Tarjeta";
            this.MarcaTarjeta.Name = "MarcaTarjeta";
            // 
            // Cuotas
            // 
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            // 
            // ValorCuota
            // 
            this.ValorCuota.HeaderText = "Valor Cuota";
            this.ValorCuota.Name = "ValorCuota";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cboMarcaTarjeta
            // 
            this.cboMarcaTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaTarjeta.FormattingEnabled = true;
            this.cboMarcaTarjeta.Location = new System.Drawing.Point(530, 516);
            this.cboMarcaTarjeta.Name = "cboMarcaTarjeta";
            this.cboMarcaTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cboMarcaTarjeta.TabIndex = 47;
            // 
            // lblMarcaTarjeta
            // 
            this.lblMarcaTarjeta.AutoSize = true;
            this.lblMarcaTarjeta.Location = new System.Drawing.Point(455, 519);
            this.lblMarcaTarjeta.Name = "lblMarcaTarjeta";
            this.lblMarcaTarjeta.Size = new System.Drawing.Size(69, 13);
            this.lblMarcaTarjeta.TabIndex = 46;
            this.lblMarcaTarjeta.Text = "Marca tarjeta";
            // 
            // cboMarcaBanco
            // 
            this.cboMarcaBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaBanco.FormattingEnabled = true;
            this.cboMarcaBanco.Location = new System.Drawing.Point(318, 516);
            this.cboMarcaBanco.Name = "cboMarcaBanco";
            this.cboMarcaBanco.Size = new System.Drawing.Size(121, 21);
            this.cboMarcaBanco.TabIndex = 45;
            // 
            // lblMarcaBanco
            // 
            this.lblMarcaBanco.AutoSize = true;
            this.lblMarcaBanco.Location = new System.Drawing.Point(242, 519);
            this.lblMarcaBanco.Name = "lblMarcaBanco";
            this.lblMarcaBanco.Size = new System.Drawing.Size(70, 13);
            this.lblMarcaBanco.TabIndex = 44;
            this.lblMarcaBanco.Text = "Marca banco";
            // 
            // cboMedioPago
            // 
            this.cboMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioPago.FormattingEnabled = true;
            this.cboMedioPago.Location = new System.Drawing.Point(108, 516);
            this.cboMedioPago.Name = "cboMedioPago";
            this.cboMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cboMedioPago.TabIndex = 43;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(38, 519);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(64, 13);
            this.lblMedioPago.TabIndex = 42;
            this.lblMedioPago.Text = "Medio Pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(92, 554);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 56;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(49, 557);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 57;
            this.lblMonto.Text = "Monto";
            // 
            // lblValorCuota
            // 
            this.lblValorCuota.AutoSize = true;
            this.lblValorCuota.Location = new System.Drawing.Point(220, 557);
            this.lblValorCuota.Name = "lblValorCuota";
            this.lblValorCuota.Size = new System.Drawing.Size(62, 13);
            this.lblValorCuota.TabIndex = 59;
            this.lblValorCuota.Text = "Valor Cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(285, 554);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(100, 20);
            this.txtValorCuota.TabIndex = 58;
            // 
            // lblCodAutorizacion
            // 
            this.lblCodAutorizacion.AutoSize = true;
            this.lblCodAutorizacion.Location = new System.Drawing.Point(394, 554);
            this.lblCodAutorizacion.Name = "lblCodAutorizacion";
            this.lblCodAutorizacion.Size = new System.Drawing.Size(100, 13);
            this.lblCodAutorizacion.TabIndex = 61;
            this.lblCodAutorizacion.Text = "Código autorización";
            // 
            // txtCodAutorizacion
            // 
            this.txtCodAutorizacion.Location = new System.Drawing.Point(498, 550);
            this.txtCodAutorizacion.Name = "txtCodAutorizacion";
            this.txtCodAutorizacion.Size = new System.Drawing.Size(100, 20);
            this.txtCodAutorizacion.TabIndex = 60;
            // 
            // txtNroFact
            // 
            this.txtNroFact.Location = new System.Drawing.Point(357, 10);
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.Size = new System.Drawing.Size(100, 20);
            this.txtNroFact.TabIndex = 62;
            // 
            // btnVolverDetalle
            // 
            this.btnVolverDetalle.Location = new System.Drawing.Point(648, 550);
            this.btnVolverDetalle.Name = "btnVolverDetalle";
            this.btnVolverDetalle.Size = new System.Drawing.Size(137, 23);
            this.btnVolverDetalle.TabIndex = 32;
            this.btnVolverDetalle.Text = "Volver a detalle";
            this.btnVolverDetalle.UseVisualStyleBackColor = true;
            this.btnVolverDetalle.Click += new System.EventHandler(this.btnVolverDetalle_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 749);
            this.Controls.Add(this.btnVolverDetalle);
            this.Controls.Add(this.txtNroFact);
            this.Controls.Add(this.lblCodAutorizacion);
            this.Controls.Add(this.txtCodAutorizacion);
            this.Controls.Add(this.lblValorCuota);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCancelarMedioPago);
            this.Controls.Add(this.btnQuitarMedioPago);
            this.Controls.Add(this.btnAgregarMedioPago);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cboCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.dvgMedioPago);
            this.Controls.Add(this.cboMarcaTarjeta);
            this.Controls.Add(this.lblMarcaTarjeta);
            this.Controls.Add(this.cboMarcaBanco);
            this.Controls.Add(this.lblMarcaBanco);
            this.Controls.Add(this.cboMedioPago);
            this.Controls.Add(this.lblMedioPago);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.btnCUIT);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCodDescuento);
            this.Controls.Add(this.lblCodDescuento);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.txtNroFactMal);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.cboTipoFact);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNroFact);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipoFact);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedioPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label _lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtNroFactMal;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoFact;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNroFact;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoFact;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblCodDescuento;
        private System.Windows.Forms.TextBox txtCodDescuento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnPasarMedioPago;
        private System.Windows.Forms.Button btnCancelarMedioPago;
        private System.Windows.Forms.Button btnQuitarMedioPago;
        private System.Windows.Forms.Button btnAgregarMedioPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.DataGridView dvgMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cboMarcaTarjeta;
        private System.Windows.Forms.Label lblMarcaTarjeta;
        private System.Windows.Forms.ComboBox cboMarcaBanco;
        private System.Windows.Forms.Label lblMarcaBanco;
        private System.Windows.Forms.ComboBox cboMedioPago;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblValorCuota;
        private System.Windows.Forms.TextBox txtValorCuota;
        private System.Windows.Forms.Label lblCodAutorizacion;
        private System.Windows.Forms.TextBox txtCodAutorizacion;
        private System.Windows.Forms.TextBox txtNroFact;
        private System.Windows.Forms.Button btnVolverDetalle;
    }
}