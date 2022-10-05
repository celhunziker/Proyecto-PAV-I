namespace AppBTS.Presentacion
{
    partial class frmClasesABM
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
            this.cboDisciplinas = new System.Windows.Forms.ComboBox();
            this.cboDiasSemana = new System.Windows.Forms.ComboBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDisciplinas
            // 
            this.cboDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisciplinas.FormattingEnabled = true;
            this.cboDisciplinas.Location = new System.Drawing.Point(314, 70);
            this.cboDisciplinas.Name = "cboDisciplinas";
            this.cboDisciplinas.Size = new System.Drawing.Size(283, 21);
            this.cboDisciplinas.TabIndex = 64;
            // 
            // cboDiasSemana
            // 
            this.cboDiasSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiasSemana.FormattingEnabled = true;
            this.cboDiasSemana.Location = new System.Drawing.Point(315, 142);
            this.cboDiasSemana.Name = "cboDiasSemana";
            this.cboDiasSemana.Size = new System.Drawing.Size(283, 21);
            this.cboDiasSemana.TabIndex = 63;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(205, 145);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(104, 13);
            this.lblDiaSemana.TabIndex = 61;
            this.lblDiaSemana.Text = "Día de la semana (*)";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(223, 68);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(65, 13);
            this.lblDisciplina.TabIndex = 60;
            this.lblDisciplina.Text = "Disciplina (*)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(415, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 45);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(226, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 45);
            this.btnAceptar.TabIndex = 58;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(290, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 52;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(315, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 51;
            // 
            // dtpHorario
            // 
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorario.Location = new System.Drawing.Point(315, 107);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new System.Drawing.Size(200, 20);
            this.dtpHorario.TabIndex = 65;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(223, 107);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(54, 13);
            this.lblHorario.TabIndex = 66;
            this.lblHorario.Text = "Horario (*)";
            // 
            // frmClasesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.cboDisciplinas);
            this.Controls.Add(this.cboDiasSemana);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "frmClasesABM";
            this.Text = "frmClasesABM";
            this.Load += new System.EventHandler(this.frmClasesABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDisciplinas;
        private System.Windows.Forms.ComboBox cboDiasSemana;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.Label lblHorario;
    }
}