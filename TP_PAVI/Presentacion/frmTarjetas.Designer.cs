namespace AppBTS.Presentacion
{
    partial class frmTarjetas
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
            this.cboMarcaTarjeta = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblMarcaTarjeta = new System.Windows.Forms.Label();
            this.grdTarjetas = new System.Windows.Forms.DataGridView();
            this.lblNroTarjeta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtFechaVencMes = new System.Windows.Forms.TextBox();
            this.txtFechaVencAnio = new System.Windows.Forms.TextBox();
            this.lblFechaVencDivisor = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarcaTarjeta
            // 
            this.cboMarcaTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaTarjeta.FormattingEnabled = true;
            this.cboMarcaTarjeta.Location = new System.Drawing.Point(145, 87);
            this.cboMarcaTarjeta.Name = "cboMarcaTarjeta";
            this.cboMarcaTarjeta.Size = new System.Drawing.Size(283, 21);
            this.cboMarcaTarjeta.TabIndex = 48;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(145, 168);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 47;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblFechaVenc
            // 
            this.lblFechaVenc.AutoSize = true;
            this.lblFechaVenc.Location = new System.Drawing.Point(26, 122);
            this.lblFechaVenc.Name = "lblFechaVenc";
            this.lblFechaVenc.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVenc.TabIndex = 46;
            this.lblFechaVenc.Text = "Fecha de Vencimiento";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(145, 56);
            this.txtNumeroTarjeta.MaxLength = 16;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(283, 20);
            this.txtNumeroTarjeta.TabIndex = 44;
            this.txtNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // lblMarcaTarjeta
            // 
            this.lblMarcaTarjeta.AutoSize = true;
            this.lblMarcaTarjeta.Location = new System.Drawing.Point(55, 90);
            this.lblMarcaTarjeta.Name = "lblMarcaTarjeta";
            this.lblMarcaTarjeta.Size = new System.Drawing.Size(84, 13);
            this.lblMarcaTarjeta.TabIndex = 45;
            this.lblMarcaTarjeta.Text = "Marca de tarjeta";
            // 
            // grdTarjetas
            // 
            this.grdTarjetas.AllowUserToAddRows = false;
            this.grdTarjetas.AllowUserToDeleteRows = false;
            this.grdTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreProducto,
            this.TipoProducto});
            this.grdTarjetas.Location = new System.Drawing.Point(29, 205);
            this.grdTarjetas.MultiSelect = false;
            this.grdTarjetas.Name = "grdTarjetas";
            this.grdTarjetas.ReadOnly = true;
            this.grdTarjetas.RowHeadersWidth = 51;
            this.grdTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarjetas.Size = new System.Drawing.Size(501, 122);
            this.grdTarjetas.TabIndex = 38;
            this.grdTarjetas.SelectionChanged += new System.EventHandler(this.grdTarjetas_SelectionChanged);
            // 
            // lblNroTarjeta
            // 
            this.lblNroTarjeta.AutoSize = true;
            this.lblNroTarjeta.Location = new System.Drawing.Point(45, 59);
            this.lblNroTarjeta.Name = "lblNroTarjeta";
            this.lblNroTarjeta.Size = new System.Drawing.Size(91, 13);
            this.lblNroTarjeta.TabIndex = 37;
            this.lblNroTarjeta.Text = "Número de tarjeta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::AppBTS.Properties.Resources.actualizar;
            this.btnLimpiar.Location = new System.Drawing.Point(455, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 47);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AppBTS.Properties.Resources.buscar1;
            this.btnConsultar.Location = new System.Drawing.Point(455, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 47);
            this.btnConsultar.TabIndex = 43;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnBorrar.Location = new System.Drawing.Point(191, 347);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(74, 47);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnEditar.Location = new System.Drawing.Point(111, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 47);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AppBTS.Properties.Resources.new_file;
            this.btnNuevo.Location = new System.Drawing.Point(29, 347);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 47);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(93, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 50;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(145, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(283, 20);
            this.txtUsuario.TabIndex = 53;
            // 
            // txtFechaVencMes
            // 
            this.txtFechaVencMes.Location = new System.Drawing.Point(145, 119);
            this.txtFechaVencMes.MaxLength = 2;
            this.txtFechaVencMes.Name = "txtFechaVencMes";
            this.txtFechaVencMes.Size = new System.Drawing.Size(41, 20);
            this.txtFechaVencMes.TabIndex = 54;
            this.txtFechaVencMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // txtFechaVencAnio
            // 
            this.txtFechaVencAnio.Location = new System.Drawing.Point(210, 119);
            this.txtFechaVencAnio.MaxLength = 2;
            this.txtFechaVencAnio.Name = "txtFechaVencAnio";
            this.txtFechaVencAnio.Size = new System.Drawing.Size(41, 20);
            this.txtFechaVencAnio.TabIndex = 55;
            this.txtFechaVencAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly_KeyPress);
            // 
            // lblFechaVencDivisor
            // 
            this.lblFechaVencDivisor.AutoSize = true;
            this.lblFechaVencDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencDivisor.Location = new System.Drawing.Point(189, 115);
            this.lblFechaVencDivisor.Name = "lblFechaVencDivisor";
            this.lblFechaVencDivisor.Size = new System.Drawing.Size(15, 24);
            this.lblFechaVencDivisor.TabIndex = 56;
            this.lblFechaVencDivisor.Text = "/";
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "Marca de Tarjeta";
            this.IDProducto.MinimumWidth = 6;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Número de Tarjeta";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 125;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "Fecha de Vencimiento";
            this.TipoProducto.MinimumWidth = 6;
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(480, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 47);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFechaVencDivisor);
            this.Controls.Add(this.txtFechaVencAnio);
            this.Controls.Add(this.txtFechaVencMes);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cboMarcaTarjeta);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.lblFechaVenc);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblMarcaTarjeta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdTarjetas);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblNroTarjeta);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmTarjetas";
            this.Text = "Tarjetas";
            this.Load += new System.EventHandler(this.frmTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMarcaTarjeta;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblMarcaTarjeta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdTarjetas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNroTarjeta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtFechaVencMes;
        private System.Windows.Forms.TextBox txtFechaVencAnio;
        private System.Windows.Forms.Label lblFechaVencDivisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.Button btnSalir;
    }
}