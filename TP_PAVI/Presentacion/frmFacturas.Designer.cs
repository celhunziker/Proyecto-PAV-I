﻿namespace AppBTS.Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
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
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.cboTipoFact = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNroFact = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoFact = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblCodDescuento = new System.Windows.Forms.Label();
            this.txtCodDescuento = new System.Windows.Forms.TextBox();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(716, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnGrabar.Location = new System.Drawing.Point(95, 496);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 35);
            this.btnGrabar.TabIndex = 29;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AppBTS.Properties.Resources.new_file;
            this.btnNuevo.Location = new System.Drawing.Point(14, 495);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dpbDetalle
            // 
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
            this.dpbDetalle.Location = new System.Drawing.Point(14, 78);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Size = new System.Drawing.Size(777, 412);
            this.dpbDetalle.TabIndex = 27;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(667, 379);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(667, 353);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(667, 327);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(592, 382);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(69, 13);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(585, 356);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 13);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento (%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(614, 330);
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
            this.txtCantidad.ValidatingType = typeof(int);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroItem,
            this.CodArt,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 61);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(754, 252);
            this.dgvDetalle.TabIndex = 7;
            // 
            // NroItem
            // 
            this.NroItem.DataPropertyName = "NroItem";
            this.NroItem.HeaderText = "Nro. Ítem";
            this.NroItem.Name = "NroItem";
            this.NroItem.ReadOnly = true;
            this.NroItem.Width = 70;
            // 
            // CodArt
            // 
            this.CodArt.DataPropertyName = "IdProducto";
            this.CodArt.HeaderText = "Cod. Art.";
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            this.CodArt.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "ProductoDescripcion";
            dataGridViewCellStyle2.NullValue = null;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle3.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle4.Format = "C2";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
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
            // 
            // txtNroFact
            // 
            this.txtNroFact.Location = new System.Drawing.Point(327, 24);
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.ReadOnly = true;
            this.txtNroFact.Size = new System.Drawing.Size(100, 20);
            this.txtNroFact.TabIndex = 18;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(86, 51);
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
            this.cboTipoFact.Location = new System.Drawing.Point(86, 24);
            this.cboTipoFact.Name = "cboTipoFact";
            this.cboTipoFact.Size = new System.Drawing.Size(143, 21);
            this.cboTipoFact.TabIndex = 16;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(628, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.Value = new System.DateTime(2019, 9, 29, 17, 20, 8, 0);
            // 
            // lblNroFact
            // 
            this.lblNroFact.AutoSize = true;
            this.lblNroFact.Location = new System.Drawing.Point(254, 27);
            this.lblNroFact.Name = "lblNroFact";
            this.lblNroFact.Size = new System.Drawing.Size(54, 13);
            this.lblNroFact.TabIndex = 24;
            this.lblNroFact.Text = "Nro. Fact.";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(25, 54);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(564, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoFact
            // 
            this.lblTipoFact.AutoSize = true;
            this.lblTipoFact.Location = new System.Drawing.Point(25, 25);
            this.lblTipoFact.Name = "lblTipoFact";
            this.lblTipoFact.Size = new System.Drawing.Size(55, 13);
            this.lblTipoFact.TabIndex = 17;
            this.lblTipoFact.Text = "Tipo Fact.";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Location = new System.Drawing.Point(327, 54);
            this.txtCUIT.Mask = "00-00000000-0";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtCUIT.TabIndex = 32;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(268, 57);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 34;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblCodDescuento
            // 
            this.lblCodDescuento.AutoSize = true;
            this.lblCodDescuento.Location = new System.Drawing.Point(530, 61);
            this.lblCodDescuento.Name = "lblCodDescuento";
            this.lblCodDescuento.Size = new System.Drawing.Size(95, 13);
            this.lblCodDescuento.TabIndex = 36;
            this.lblCodDescuento.Text = "Codigo Descuento";
            // 
            // txtCodDescuento
            // 
            this.txtCodDescuento.Location = new System.Drawing.Point(628, 61);
            this.txtCodDescuento.Name = "txtCodDescuento";
            this.txtCodDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtCodDescuento.TabIndex = 37;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 550);
            this.Controls.Add(this.txtCodDescuento);
            this.Controls.Add(this.lblCodDescuento);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.txtNroFact);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label _lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtNroFact;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.ComboBox cboTipoFact;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNroFact;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoFact;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblCodDescuento;
        private System.Windows.Forms.TextBox txtCodDescuento;
    }
}