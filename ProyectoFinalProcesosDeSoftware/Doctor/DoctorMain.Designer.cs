namespace ProyectoFinalProcesosDeSoftware
{
    partial class DoctorMain
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
            this.label_DoctorMain = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_RegistrarResultados = new System.Windows.Forms.Button();
            this.btn_ConsultarResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DoctorMain
            // 
            this.label_DoctorMain.AutoSize = true;
            this.label_DoctorMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label_DoctorMain.Location = new System.Drawing.Point(193, 27);
            this.label_DoctorMain.Name = "label_DoctorMain";
            this.label_DoctorMain.Size = new System.Drawing.Size(237, 46);
            this.label_DoctorMain.TabIndex = 1;
            this.label_DoctorMain.Text = "Doctor Main";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(490, 39);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(140, 34);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_RegistrarResultados
            // 
            this.btn_RegistrarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RegistrarResultados.Location = new System.Drawing.Point(201, 190);
            this.btn_RegistrarResultados.Name = "btn_RegistrarResultados";
            this.btn_RegistrarResultados.Size = new System.Drawing.Size(229, 57);
            this.btn_RegistrarResultados.TabIndex = 3;
            this.btn_RegistrarResultados.Text = "Registrar Resultados";
            this.btn_RegistrarResultados.UseVisualStyleBackColor = true;
            this.btn_RegistrarResultados.Click += new System.EventHandler(this.btn_RegistrarResultados_Click);
            // 
            // btn_ConsultarResultados
            // 
            this.btn_ConsultarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ConsultarResultados.Location = new System.Drawing.Point(201, 309);
            this.btn_ConsultarResultados.Name = "btn_ConsultarResultados";
            this.btn_ConsultarResultados.Size = new System.Drawing.Size(229, 57);
            this.btn_ConsultarResultados.TabIndex = 4;
            this.btn_ConsultarResultados.Text = "Consultar Resultados";
            this.btn_ConsultarResultados.UseVisualStyleBackColor = true;
            // 
            // DoctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 554);
            this.Controls.Add(this.btn_ConsultarResultados);
            this.Controls.Add(this.btn_RegistrarResultados);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.label_DoctorMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoctorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DoctorMain;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_RegistrarResultados;
        private System.Windows.Forms.Button btn_ConsultarResultados;
    }
}