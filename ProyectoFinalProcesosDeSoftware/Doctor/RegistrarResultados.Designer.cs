namespace ProyectoFinalProcesosDeSoftware
{
    partial class RegistrarResultados
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
            this.components = new System.ComponentModel.Container();
            this.lbl_RegistrarResultados = new System.Windows.Forms.Label();
            this.btn_RegistrarResultado = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.lbl_PacienteEncontrado = new System.Windows.Forms.Label();
            this.lbl_NombrePaciente = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lbl_Apellido_Txt = new System.Windows.Forms.Label();
            this.lbl_Nombre_Txt = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoMuestra = new System.Windows.Forms.Label();
            this.cmbox_TipoMuestra = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbl_RegistrarResultados
            // 
            this.lbl_RegistrarResultados.AutoSize = true;
            this.lbl_RegistrarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_RegistrarResultados.Location = new System.Drawing.Point(211, 24);
            this.lbl_RegistrarResultados.Name = "lbl_RegistrarResultados";
            this.lbl_RegistrarResultados.Size = new System.Drawing.Size(191, 25);
            this.lbl_RegistrarResultados.TabIndex = 0;
            this.lbl_RegistrarResultados.Text = "Registrar Resultados";
            // 
            // btn_RegistrarResultado
            // 
            this.btn_RegistrarResultado.Enabled = false;
            this.btn_RegistrarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RegistrarResultado.Location = new System.Drawing.Point(29, 453);
            this.btn_RegistrarResultado.Name = "btn_RegistrarResultado";
            this.btn_RegistrarResultado.Size = new System.Drawing.Size(234, 46);
            this.btn_RegistrarResultado.TabIndex = 1;
            this.btn_RegistrarResultado.Text = "Registrar Resultado";
            this.btn_RegistrarResultado.UseVisualStyleBackColor = true;
            this.btn_RegistrarResultado.Click += new System.EventHandler(this.btn_RegistrarResultado_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Cancelar.Location = new System.Drawing.Point(341, 453);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(234, 46);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula del Paciente";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCedula.Location = new System.Drawing.Point(205, 112);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(299, 23);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(510, 110);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(129, 25);
            this.btn_BuscarPaciente.TabIndex = 5;
            this.btn_BuscarPaciente.Text = "Buscar Paciente";
            this.btn_BuscarPaciente.UseVisualStyleBackColor = true;
            this.btn_BuscarPaciente.Click += new System.EventHandler(this.btn_BuscarPaciente_Click);
            // 
            // lbl_PacienteEncontrado
            // 
            this.lbl_PacienteEncontrado.AutoSize = true;
            this.lbl_PacienteEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_PacienteEncontrado.Location = new System.Drawing.Point(13, 148);
            this.lbl_PacienteEncontrado.Name = "lbl_PacienteEncontrado";
            this.lbl_PacienteEncontrado.Size = new System.Drawing.Size(160, 20);
            this.lbl_PacienteEncontrado.TabIndex = 6;
            this.lbl_PacienteEncontrado.Text = "Paciente encontrado:";
            this.lbl_PacienteEncontrado.Visible = false;
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(179, 148);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(69, 20);
            this.lbl_NombrePaciente.TabIndex = 7;
            this.lbl_NombrePaciente.Text = "Nombre:";
            this.lbl_NombrePaciente.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblApellido.Location = new System.Drawing.Point(416, 148);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Visible = false;
            // 
            // lbl_Apellido_Txt
            // 
            this.lbl_Apellido_Txt.AutoSize = true;
            this.lbl_Apellido_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Apellido_Txt.Location = new System.Drawing.Point(483, 148);
            this.lbl_Apellido_Txt.Name = "lbl_Apellido_Txt";
            this.lbl_Apellido_Txt.Size = new System.Drawing.Size(156, 20);
            this.lbl_Apellido_Txt.TabIndex = 9;
            this.lbl_Apellido_Txt.Text = "Apellido del Paciente";
            this.lbl_Apellido_Txt.Visible = false;
            // 
            // lbl_Nombre_Txt
            // 
            this.lbl_Nombre_Txt.AutoSize = true;
            this.lbl_Nombre_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Nombre_Txt.Location = new System.Drawing.Point(254, 148);
            this.lbl_Nombre_Txt.Name = "lbl_Nombre_Txt";
            this.lbl_Nombre_Txt.Size = new System.Drawing.Size(156, 20);
            this.lbl_Nombre_Txt.TabIndex = 10;
            this.lbl_Nombre_Txt.Text = "Nombre del Paciente";
            this.lbl_Nombre_Txt.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtResultado.Location = new System.Drawing.Point(163, 257);
            this.txtResultado.MaxLength = 300;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(476, 171);
            this.txtResultado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resultado:";
            // 
            // lblTipoMuestra
            // 
            this.lblTipoMuestra.AutoSize = true;
            this.lblTipoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTipoMuestra.Location = new System.Drawing.Point(13, 198);
            this.lblTipoMuestra.Name = "lblTipoMuestra";
            this.lblTipoMuestra.Size = new System.Drawing.Size(153, 25);
            this.lblTipoMuestra.TabIndex = 13;
            this.lblTipoMuestra.Text = "Tipo de muestra";
            this.lblTipoMuestra.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbox_TipoMuestra
            // 
            this.cmbox_TipoMuestra.Enabled = false;
            this.cmbox_TipoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbox_TipoMuestra.FormattingEnabled = true;
            this.cmbox_TipoMuestra.Items.AddRange(new object[] {
            "Sangre",
            "Saliva",
            "Orina",
            "Heces Fecales"});
            this.cmbox_TipoMuestra.Location = new System.Drawing.Point(205, 202);
            this.cmbox_TipoMuestra.Name = "cmbox_TipoMuestra";
            this.cmbox_TipoMuestra.Size = new System.Drawing.Size(299, 24);
            this.cmbox_TipoMuestra.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RegistrarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 554);
            this.Controls.Add(this.cmbox_TipoMuestra);
            this.Controls.Add(this.lblTipoMuestra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbl_Nombre_Txt);
            this.Controls.Add(this.lbl_Apellido_Txt);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lbl_NombrePaciente);
            this.Controls.Add(this.lbl_PacienteEncontrado);
            this.Controls.Add(this.btn_BuscarPaciente);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarResultado);
            this.Controls.Add(this.lbl_RegistrarResultados);
            this.Name = "RegistrarResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarResultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarResultados_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistrarResultados;
        private System.Windows.Forms.Button btn_RegistrarResultado;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private System.Windows.Forms.Label lbl_PacienteEncontrado;
        private System.Windows.Forms.Label lbl_NombrePaciente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lbl_Apellido_Txt;
        private System.Windows.Forms.Label lbl_Nombre_Txt;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoMuestra;
        private System.Windows.Forms.ComboBox cmbox_TipoMuestra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}