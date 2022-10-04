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
            this.cboClase = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblMarcaTarjeta = new System.Windows.Forms.Label();
            this.grdTarjetas = new System.Windows.Forms.DataGridView();
            this.lblNroTarjeta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtFechaVenc = new System.Windows.Forms.MaskedTextBox();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClase
            // 
            this.cboClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClase.FormattingEnabled = true;
            this.cboClase.Location = new System.Drawing.Point(145, 87);
            this.cboClase.Name = "cboClase";
            this.cboClase.Size = new System.Drawing.Size(283, 21);
            this.cboClase.TabIndex = 48;
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
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(145, 56);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(283, 20);
            this.txtNombreProducto.TabIndex = 44;
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
            this.grdTarjetas.Location = new System.Drawing.Point(28, 200);
            this.grdTarjetas.MultiSelect = false;
            this.grdTarjetas.Name = "grdTarjetas";
            this.grdTarjetas.ReadOnly = true;
            this.grdTarjetas.RowHeadersWidth = 51;
            this.grdTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTarjetas.Size = new System.Drawing.Size(400, 122);
            this.grdTarjetas.TabIndex = 38;
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
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AppBTS.Properties.Resources.buscar1;
            this.btnConsultar.Location = new System.Drawing.Point(455, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 47);
            this.btnConsultar.TabIndex = 43;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnBorrar.Location = new System.Drawing.Point(191, 347);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(74, 47);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnEditar.Location = new System.Drawing.Point(111, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 47);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AppBTS.Properties.Resources.new_file;
            this.btnNuevo.Location = new System.Drawing.Point(29, 347);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 47);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
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
            // txtFechaVenc
            // 
            this.txtFechaVenc.Location = new System.Drawing.Point(145, 119);
            this.txtFechaVenc.Mask = "00/00";
            this.txtFechaVenc.Name = "txtFechaVenc";
            this.txtFechaVenc.Size = new System.Drawing.Size(42, 20);
            this.txtFechaVenc.TabIndex = 52;
            this.txtFechaVenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fechaVenc_KeyPress);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "Marca de Tarjeta";
            this.IDProducto.MinimumWidth = 6;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Width = 50;
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
            this.TipoProducto.Width = 125;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(145, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(283, 20);
            this.txtUsuario.TabIndex = 53;
            // 
            // frmTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtFechaVenc);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cboClase);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.lblFechaVenc);
            this.Controls.Add(this.txtNombreProducto);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboClase;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblMarcaTarjeta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdTarjetas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNroTarjeta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MaskedTextBox txtFechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}