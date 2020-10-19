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
            this.SuspendLayout();
            // 
            // label_DoctorMain
            // 
            this.label_DoctorMain.AutoSize = true;
            this.label_DoctorMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label_DoctorMain.Location = new System.Drawing.Point(144, 27);
            this.label_DoctorMain.Name = "label_DoctorMain";
            this.label_DoctorMain.Size = new System.Drawing.Size(237, 46);
            this.label_DoctorMain.TabIndex = 1;
            this.label_DoctorMain.Text = "Doctor Main";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(481, 23);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(141, 50);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // DoctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 554);
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
    }
}