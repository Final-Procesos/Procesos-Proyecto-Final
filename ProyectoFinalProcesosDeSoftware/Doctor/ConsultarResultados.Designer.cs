namespace ProyectoFinalProcesosDeSoftware
{
    partial class ConsultarResultados
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor,
            this.Paciente,
            this.TipoMuestra,
            this.Resultado});
            this.dataGrid.Location = new System.Drawing.Point(4, 94);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(852, 536);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(104, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula del Paciente:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCedula.Location = new System.Drawing.Point(297, 43);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(299, 23);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(602, 42);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(129, 25);
            this.btn_BuscarPaciente.TabIndex = 6;
            this.btn_BuscarPaciente.Text = "Buscar Paciente";
            this.btn_BuscarPaciente.UseVisualStyleBackColor = true;
            this.btn_BuscarPaciente.Click += new System.EventHandler(this.btn_BuscarPaciente_Click);
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MaxInputLength = 100;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MaxInputLength = 100;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // TipoMuestra
            // 
            this.TipoMuestra.HeaderText = "TipoMuestra";
            this.TipoMuestra.MaxInputLength = 50;
            this.TipoMuestra.Name = "TipoMuestra";
            this.TipoMuestra.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.MaxInputLength = 300;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // ConsultarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 634);
            this.Controls.Add(this.btn_BuscarPaciente);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "ConsultarResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarResultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarResultados_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}