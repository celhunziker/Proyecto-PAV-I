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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboTipoFact = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.dgvMedioCobro = new System.Windows.Forms.DataGridView();
            this.MedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblCorroborarMonto = new System.Windows.Forms.Label();
            this.txtCorroborarMonto = new System.Windows.Forms.TextBox();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioCobro)).BeginInit();
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
            this.dpbDetalle.Location = new System.Drawing.Point(24, 108);
            this.dpbDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpbDetalle.Size = new System.Drawing.Size(1036, 517);
            this.dpbDetalle.TabIndex = 27;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // btnPasarMedioPago
            // 
            this.btnPasarMedioPago.Location = new System.Drawing.Point(99, 436);
            this.btnPasarMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarMedioPago.Name = "btnPasarMedioPago";
            this.btnPasarMedioPago.Size = new System.Drawing.Size(183, 28);
            this.btnPasarMedioPago.TabIndex = 31;
            this.btnPasarMedioPago.Text = "Pasar a medio pago";
            this.btnPasarMedioPago.UseVisualStyleBackColor = true;
            this.btnPasarMedioPago.Click += new System.EventHandler(this.btnMedioPago_Click);
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(889, 473);
            this.txtImporteTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(132, 22);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(889, 441);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(132, 22);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(889, 409);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(132, 22);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(789, 476);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(86, 16);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(780, 444);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(95, 16);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento (%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(819, 412);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(56, 16);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(356, 36);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(53, 22);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(683, 34);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(89, 22);
            this.txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(623, 41);
            this.lblImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(52, 16);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AppBTS.Properties.Resources.Cancelar3;
            this.btnCancelar.Location = new System.Drawing.Point(972, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 44);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnQuitar.Location = new System.Drawing.Point(913, 23);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(51, 44);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnAgregar.Location = new System.Drawing.Point(857, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(48, 44);
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
            this.dgvDetalle.Location = new System.Drawing.Point(17, 75);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvDetalle.Size = new System.Drawing.Size(1005, 310);
            this.dgvDetalle.TabIndex = 7;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
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
            this.txtPrecio.Location = new System.Drawing.Point(505, 37);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(89, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(448, 41);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // _lblCantidad
            // 
            this._lblCantidad.AutoSize = true;
            this._lblCantidad.Location = new System.Drawing.Point(283, 41);
            this._lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCantidad.Name = "_lblCantidad";
            this._lblCantidad.Size = new System.Drawing.Size(61, 16);
            this._lblCantidad.TabIndex = 2;
            this._lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(11, 39);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 16);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(77, 34);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(176, 24);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnGrabar.Location = new System.Drawing.Point(156, 866);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 43);
            this.btnGrabar.TabIndex = 29;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(123, 44);
            this.cboTipoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(189, 24);
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
            this.cboTipoFact.Location = new System.Drawing.Point(123, 11);
            this.cboTipoFact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoFact.Name = "cboTipoFact";
            this.cboTipoFact.Size = new System.Drawing.Size(189, 24);
            this.cboTipoFact.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(845, 11);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(132, 22);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2019, 9, 29, 17, 20, 8, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(41, 48);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(760, 15);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoFact
            // 
            this.lblTipoFact.AutoSize = true;
            this.lblTipoFact.Location = new System.Drawing.Point(41, 12);
            this.lblTipoFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoFact.Name = "lblTipoFact";
            this.lblTipoFact.Size = new System.Drawing.Size(67, 16);
            this.lblTipoFact.TabIndex = 17;
            this.lblTipoFact.Text = "Tipo Fact.";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(365, 52);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(38, 16);
            this.lblCUIT.TabIndex = 34;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblCodDescuento
            // 
            this.lblCodDescuento.AutoSize = true;
            this.lblCodDescuento.Location = new System.Drawing.Point(715, 57);
            this.lblCodDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodDescuento.Name = "lblCodDescuento";
            this.lblCodDescuento.Size = new System.Drawing.Size(119, 16);
            this.lblCodDescuento.TabIndex = 36;
            this.lblCodDescuento.Text = "Codigo Descuento";
            // 
            // txtCodDescuento
            // 
            this.txtCodDescuento.Location = new System.Drawing.Point(845, 57);
            this.txtCodDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodDescuento.Name = "txtCodDescuento";
            this.txtCodDescuento.Size = new System.Drawing.Size(132, 22);
            this.txtCodDescuento.TabIndex = 37;
            this.txtCodDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(123, 76);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(453, 22);
            this.txtDireccion.TabIndex = 39;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(41, 76);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnCUIT
            // 
            this.btnCUIT.Location = new System.Drawing.Point(581, 48);
            this.btnCUIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUIT.Name = "btnCUIT";
            this.btnCUIT.Size = new System.Drawing.Size(125, 25);
            this.btnCUIT.TabIndex = 40;
            this.btnCUIT.Text = "Buscar Cliente";
            this.btnCUIT.UseVisualStyleBackColor = true;
            this.btnCUIT.Click += new System.EventHandler(this.btnCUIT_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(444, 48);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(132, 22);
            this.txtCUIT.TabIndex = 41;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(960, 868);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 43);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelarMedioPago
            // 
            this.btnCancelarMedioPago.Image = global::AppBTS.Properties.Resources.Cancelar3;
            this.btnCancelarMedioPago.Location = new System.Drawing.Point(1000, 746);
            this.btnCancelarMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarMedioPago.Name = "btnCancelarMedioPago";
            this.btnCancelarMedioPago.Size = new System.Drawing.Size(51, 44);
            this.btnCancelarMedioPago.TabIndex = 55;
            this.btnCancelarMedioPago.UseVisualStyleBackColor = true;
            this.btnCancelarMedioPago.Click += new System.EventHandler(this.btnCancelarMedioPago_Click);
            // 
            // btnQuitarMedioPago
            // 
            this.btnQuitarMedioPago.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnQuitarMedioPago.Location = new System.Drawing.Point(941, 746);
            this.btnQuitarMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitarMedioPago.Name = "btnQuitarMedioPago";
            this.btnQuitarMedioPago.Size = new System.Drawing.Size(51, 44);
            this.btnQuitarMedioPago.TabIndex = 54;
            this.btnQuitarMedioPago.UseVisualStyleBackColor = true;
            this.btnQuitarMedioPago.Click += new System.EventHandler(this.btnQuitarMedioPago_Click);
            // 
            // btnAgregarMedioPago
            // 
            this.btnAgregarMedioPago.Image = global::AppBTS.Properties.Resources.grabar2;
            this.btnAgregarMedioPago.Location = new System.Drawing.Point(885, 746);
            this.btnAgregarMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarMedioPago.Name = "btnAgregarMedioPago";
            this.btnAgregarMedioPago.Size = new System.Drawing.Size(48, 44);
            this.btnAgregarMedioPago.TabIndex = 53;
            this.btnAgregarMedioPago.UseVisualStyleBackColor = true;
            this.btnAgregarMedioPago.Click += new System.EventHandler(this.btnAgregarMedioPago_Click);
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Location = new System.Drawing.Point(949, 635);
            this.cboCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(109, 24);
            this.cboCuotas.TabIndex = 50;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(888, 639);
            this.lblCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(49, 16);
            this.lblCuotas.TabIndex = 49;
            this.lblCuotas.Text = "Cuotas";
            // 
            // dgvMedioCobro
            // 
            this.dgvMedioCobro.AllowUserToAddRows = false;
            this.dgvMedioCobro.AllowUserToDeleteRows = false;
            this.dgvMedioCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioCobro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedioPago,
            this.MarcaBanco,
            this.MarcaTarjeta,
            this.Cuotas,
            this.ValorCuota,
            this.dataGridViewTextBoxColumn1,
            this.CodigoAutorizacion});
            this.dgvMedioCobro.Location = new System.Drawing.Point(69, 714);
            this.dgvMedioCobro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMedioCobro.Name = "dgvMedioCobro";
            this.dgvMedioCobro.ReadOnly = true;
            this.dgvMedioCobro.RowHeadersWidth = 51;
            this.dgvMedioCobro.Size = new System.Drawing.Size(808, 145);
            this.dgvMedioCobro.TabIndex = 48;
            // 
            // MedioPago
            // 
            this.MedioPago.HeaderText = "Medio Pago";
            this.MedioPago.MinimumWidth = 6;
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.ReadOnly = true;
            this.MedioPago.Width = 125;
            // 
            // MarcaBanco
            // 
            this.MarcaBanco.HeaderText = "Marca Banco";
            this.MarcaBanco.MinimumWidth = 6;
            this.MarcaBanco.Name = "MarcaBanco";
            this.MarcaBanco.ReadOnly = true;
            this.MarcaBanco.Width = 125;
            // 
            // MarcaTarjeta
            // 
            this.MarcaTarjeta.HeaderText = "Marca Tarjeta";
            this.MarcaTarjeta.MinimumWidth = 6;
            this.MarcaTarjeta.Name = "MarcaTarjeta";
            this.MarcaTarjeta.ReadOnly = true;
            this.MarcaTarjeta.Width = 125;
            // 
            // Cuotas
            // 
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.MinimumWidth = 6;
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Width = 125;
            // 
            // ValorCuota
            // 
            this.ValorCuota.HeaderText = "Valor Cuota";
            this.ValorCuota.MinimumWidth = 6;
            this.ValorCuota.Name = "ValorCuota";
            this.ValorCuota.ReadOnly = true;
            this.ValorCuota.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // CodigoAutorizacion
            // 
            this.CodigoAutorizacion.HeaderText = "Código Autorización";
            this.CodigoAutorizacion.MinimumWidth = 6;
            this.CodigoAutorizacion.Name = "CodigoAutorizacion";
            this.CodigoAutorizacion.ReadOnly = true;
            this.CodigoAutorizacion.Width = 125;
            // 
            // cboMarcaTarjeta
            // 
            this.cboMarcaTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaTarjeta.FormattingEnabled = true;
            this.cboMarcaTarjeta.Location = new System.Drawing.Point(707, 635);
            this.cboMarcaTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarcaTarjeta.Name = "cboMarcaTarjeta";
            this.cboMarcaTarjeta.Size = new System.Drawing.Size(160, 24);
            this.cboMarcaTarjeta.TabIndex = 47;
            // 
            // lblMarcaTarjeta
            // 
            this.lblMarcaTarjeta.AutoSize = true;
            this.lblMarcaTarjeta.Location = new System.Drawing.Point(607, 639);
            this.lblMarcaTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaTarjeta.Name = "lblMarcaTarjeta";
            this.lblMarcaTarjeta.Size = new System.Drawing.Size(85, 16);
            this.lblMarcaTarjeta.TabIndex = 46;
            this.lblMarcaTarjeta.Text = "Marca tarjeta";
            // 
            // cboMarcaBanco
            // 
            this.cboMarcaBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaBanco.FormattingEnabled = true;
            this.cboMarcaBanco.Location = new System.Drawing.Point(424, 635);
            this.cboMarcaBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarcaBanco.Name = "cboMarcaBanco";
            this.cboMarcaBanco.Size = new System.Drawing.Size(160, 24);
            this.cboMarcaBanco.TabIndex = 45;
            // 
            // lblMarcaBanco
            // 
            this.lblMarcaBanco.AutoSize = true;
            this.lblMarcaBanco.Location = new System.Drawing.Point(323, 639);
            this.lblMarcaBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaBanco.Name = "lblMarcaBanco";
            this.lblMarcaBanco.Size = new System.Drawing.Size(86, 16);
            this.lblMarcaBanco.TabIndex = 44;
            this.lblMarcaBanco.Text = "Marca banco";
            // 
            // cboMedioPago
            // 
            this.cboMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioPago.FormattingEnabled = true;
            this.cboMedioPago.Location = new System.Drawing.Point(144, 635);
            this.cboMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMedioPago.Name = "cboMedioPago";
            this.cboMedioPago.Size = new System.Drawing.Size(160, 24);
            this.cboMedioPago.TabIndex = 43;
            this.cboMedioPago.SelectionChangeCommitted += new System.EventHandler(this.cboMedioPago_SelectionChangeCommitted);
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(51, 639);
            this.lblMedioPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(81, 16);
            this.lblMedioPago.TabIndex = 42;
            this.lblMedioPago.Text = "Medio Pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(123, 682);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(132, 22);
            this.txtMonto.TabIndex = 56;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(65, 686);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 57;
            this.lblMonto.Text = "Monto";
            // 
            // lblValorCuota
            // 
            this.lblValorCuota.AutoSize = true;
            this.lblValorCuota.Location = new System.Drawing.Point(293, 686);
            this.lblValorCuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorCuota.Name = "lblValorCuota";
            this.lblValorCuota.Size = new System.Drawing.Size(77, 16);
            this.lblValorCuota.TabIndex = 59;
            this.lblValorCuota.Text = "Valor Cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(380, 682);
            this.txtValorCuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(132, 22);
            this.txtValorCuota.TabIndex = 58;
            // 
            // lblCodAutorizacion
            // 
            this.lblCodAutorizacion.AutoSize = true;
            this.lblCodAutorizacion.Location = new System.Drawing.Point(525, 682);
            this.lblCodAutorizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodAutorizacion.Name = "lblCodAutorizacion";
            this.lblCodAutorizacion.Size = new System.Drawing.Size(126, 16);
            this.lblCodAutorizacion.TabIndex = 61;
            this.lblCodAutorizacion.Text = "Código autorización";
            // 
            // txtCodAutorizacion
            // 
            this.txtCodAutorizacion.Location = new System.Drawing.Point(664, 677);
            this.txtCodAutorizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodAutorizacion.Name = "txtCodAutorizacion";
            this.txtCodAutorizacion.Size = new System.Drawing.Size(132, 22);
            this.txtCodAutorizacion.TabIndex = 60;
            // 
            // lblCorroborarMonto
            // 
            this.lblCorroborarMonto.AutoSize = true;
            this.lblCorroborarMonto.Location = new System.Drawing.Point(651, 871);
            this.lblCorroborarMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorroborarMonto.Name = "lblCorroborarMonto";
            this.lblCorroborarMonto.Size = new System.Drawing.Size(78, 16);
            this.lblCorroborarMonto.TabIndex = 64;
            this.lblCorroborarMonto.Text = "Monto Total";
            // 
            // txtCorroborarMonto
            // 
            this.txtCorroborarMonto.Location = new System.Drawing.Point(744, 868);
            this.txtCorroborarMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorroborarMonto.Name = "txtCorroborarMonto";
            this.txtCorroborarMonto.Size = new System.Drawing.Size(132, 22);
            this.txtCorroborarMonto.TabIndex = 63;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1283, 750);
            this.Controls.Add(this.lblCorroborarMonto);
            this.Controls.Add(this.txtCorroborarMonto);
            this.Controls.Add(this.lblCodAutorizacion);
            this.Controls.Add(this.txtCodAutorizacion);
            this.Controls.Add(this.lblValorCuota);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCancelarMedioPago);
            this.Controls.Add(this.btnQuitarMedioPago);
            this.Controls.Add(this.btnAgregarMedioPago);
            this.Controls.Add(this.cboCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.dgvMedioCobro);
            this.Controls.Add(this.cboMarcaTarjeta);
            this.Controls.Add(this.btnGrabar);
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
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.cboTipoFact);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipoFact);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioCobro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
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
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoFact;
        private System.Windows.Forms.DateTimePicker dtpFecha;
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
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.DataGridView dgvMedioCobro;
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
        private System.Windows.Forms.Label lblCorroborarMonto;
        private System.Windows.Forms.TextBox txtCorroborarMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAutorizacion;
    }
}