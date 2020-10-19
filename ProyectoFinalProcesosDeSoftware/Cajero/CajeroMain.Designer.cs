namespace ProyectoFinalProcesosDeSoftware
{
    partial class CajeroMain
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
            this.label_CajeroMain = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CajeroMain
            // 
            this.label_CajeroMain.AutoSize = true;
            this.label_CajeroMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label_CajeroMain.Location = new System.Drawing.Point(189, 37);
            this.label_CajeroMain.Name = "label_CajeroMain";
            this.label_CajeroMain.Size = new System.Drawing.Size(236, 46);
            this.label_CajeroMain.TabIndex = 0;
            this.label_CajeroMain.Text = "Cajero Main";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Logout.Location = new System.Drawing.Point(531, 53);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(123, 30);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(176, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CajeroMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.label_CajeroMain);
            this.Name = "CajeroMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CajeroMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CajeroMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CajeroMain;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button button1;
    }
}