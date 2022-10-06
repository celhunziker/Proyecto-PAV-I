namespace AppBTS.Presentacion
{
    partial class frmProductosABM
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblUnidadDeMedida = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cboUnidadDeMedida = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(194, 129);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 13);
            this.lblMarca.TabIndex = 45;
            this.lblMarca.Text = "Marca (*)";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(160, 91);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(86, 13);
            this.lblTipoProducto.TabIndex = 43;
            this.lblTipoProducto.Text = "Tipo producto (*)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(377, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 45);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(184, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 45);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(250, 167);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(100, 20);
            this.txtContenido.TabIndex = 33;
            this.txtContenido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContenido_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(250, 57);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(283, 20);
            this.txtNombreProducto.TabIndex = 32;
            // 
            // lblUnidadDeMedida
            // 
            this.lblUnidadDeMedida.AutoSize = true;
            this.lblUnidadDeMedida.Location = new System.Drawing.Point(139, 203);
            this.lblUnidadDeMedida.Name = "lblUnidadDeMedida";
            this.lblUnidadDeMedida.Size = new System.Drawing.Size(106, 13);
            this.lblUnidadDeMedida.TabIndex = 38;
            this.lblUnidadDeMedida.Text = "Unidad de medida (*)";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(177, 165);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(68, 13);
            this.lblContenido.TabIndex = 37;
            this.lblContenido.Text = "Contenido (*)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(143, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 13);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre Producto (*)";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(251, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 30;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(226, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "Id";
            // 
            // cboUnidadDeMedida
            // 
            this.cboUnidadDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadDeMedida.FormattingEnabled = true;
            this.cboUnidadDeMedida.Location = new System.Drawing.Point(251, 203);
            this.cboUnidadDeMedida.Name = "cboUnidadDeMedida";
            this.cboUnidadDeMedida.Size = new System.Drawing.Size(283, 21);
            this.cboUnidadDeMedida.TabIndex = 46;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(251, 130);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(283, 21);
            this.cboMarca.TabIndex = 47;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(251, 93);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(283, 21);
            this.cboTipoProducto.TabIndex = 48;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(180, 336);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(250, 318);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 100);
            this.txtDescripcion.TabIndex = 50;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(250, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 51;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(175, 250);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 13);
            this.lblPrecio.TabIndex = 52;
            this.lblPrecio.Text = "Precio (*)    $";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(251, 283);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 53;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(178, 281);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 13);
            this.lblStock.TabIndex = 54;
            this.lblStock.Text = "Stock (*)";
            // 
            // frmProductosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboUnidadDeMedida);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblUnidadDeMedida);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "frmProductosABM";
            this.Text = "ABM de producto";
            this.Load += new System.EventHandler(this.frmProductosABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblUnidadDeMedida;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboUnidadDeMedida;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
    }
}