namespace AppBTS.Presentacion
{
    partial class frmTipoProducto
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
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.txtNombreTipoProducto = new System.Windows.Forms.TextBox();
            this.lblNombreTipoProducto = new System.Windows.Forms.Label();
            this.grdTipoProducto = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(296, 121);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(69, 20);
            this.chkTodos.TabIndex = 48;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // txtNombreTipoProducto
            // 
            this.txtNombreTipoProducto.Location = new System.Drawing.Point(296, 77);
            this.txtNombreTipoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            this.txtNombreTipoProducto.Size = new System.Drawing.Size(376, 22);
            this.txtNombreTipoProducto.TabIndex = 45;
            // 
            // lblNombreTipoProducto
            // 
            this.lblNombreTipoProducto.AutoSize = true;
            this.lblNombreTipoProducto.Location = new System.Drawing.Point(144, 80);
            this.lblNombreTipoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTipoProducto.Name = "lblNombreTipoProducto";
            this.lblNombreTipoProducto.Size = new System.Drawing.Size(144, 16);
            this.lblNombreTipoProducto.TabIndex = 46;
            this.lblNombreTipoProducto.Text = "Nombre Tipo Producto";
            // 
            // grdTipoProducto
            // 
            this.grdTipoProducto.AllowUserToAddRows = false;
            this.grdTipoProducto.AllowUserToDeleteRows = false;
            this.grdTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.NombreTipoProducto,
            this.Descripcion});
            this.grdTipoProducto.Location = new System.Drawing.Point(147, 171);
            this.grdTipoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.grdTipoProducto.MultiSelect = false;
            this.grdTipoProducto.Name = "grdTipoProducto";
            this.grdTipoProducto.ReadOnly = true;
            this.grdTipoProducto.RowHeadersWidth = 51;
            this.grdTipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoProducto.Size = new System.Drawing.Size(526, 150);
            this.grdTipoProducto.TabIndex = 38;
            this.grdTipoProducto.SelectionChanged += new System.EventHandler(this.grdTipoProducto_SelectionChanged);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID";
            this.IDProducto.MinimumWidth = 6;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Width = 50;
            // 
            // NombreTipoProducto
            // 
            this.NombreTipoProducto.HeaderText = "Nombre Tipo Producto";
            this.NombreTipoProducto.MinimumWidth = 6;
            this.NombreTipoProducto.Name = "NombreTipoProducto";
            this.NombreTipoProducto.ReadOnly = true;
            this.NombreTipoProducto.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::AppBTS.Properties.Resources.actualizar;
            this.btnLimpiar.Location = new System.Drawing.Point(786, 136);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 58);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AppBTS.Properties.Resources.buscar1;
            this.btnConsultar.Location = new System.Drawing.Point(786, 71);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 58);
            this.btnConsultar.TabIndex = 43;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::AppBTS.Properties.Resources.logout_door;
            this.btnSalir.Location = new System.Drawing.Point(786, 364);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 58);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::AppBTS.Properties.Resources.delete_exit;
            this.btnBorrar.Location = new System.Drawing.Point(252, 364);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(99, 58);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::AppBTS.Properties.Resources.documentediting;
            this.btnEditar.Location = new System.Drawing.Point(146, 364);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 58);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AppBTS.Properties.Resources.new_file;
            this.btnNuevo.Location = new System.Drawing.Point(36, 364);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 58);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 461);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtNombreTipoProducto);
            this.Controls.Add(this.lblNombreTipoProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdTipoProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmTipoProducto";
            this.Text = "frmTipoProducto";
            this.Load += new System.EventHandler(this.frmTipoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.TextBox txtNombreTipoProducto;
        private System.Windows.Forms.Label lblNombreTipoProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdTipoProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}