namespace ProyectoFinalProcesosDeSoftware
{
    partial class RegistrarCliente
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Seguro = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btn_RegistrarCliente = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Nombre.Location = new System.Drawing.Point(23, 60);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(81, 25);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Apellido.Location = new System.Drawing.Point(23, 115);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(82, 25);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Cedula.Location = new System.Drawing.Point(23, 217);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(75, 25);
            this.lbl_Cedula.TabIndex = 2;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // lbl_Seguro
            // 
            this.lbl_Seguro.AutoSize = true;
            this.lbl_Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Seguro.Location = new System.Drawing.Point(23, 264);
            this.lbl_Seguro.Name = "lbl_Seguro";
            this.lbl_Seguro.Size = new System.Drawing.Size(173, 25);
            this.lbl_Seguro.TabIndex = 3;
            this.lbl_Seguro.Text = "Seguro (Opcional)";
            this.lbl_Seguro.Click += new System.EventHandler(this.lbl_Seguro_Click);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Telefono.Location = new System.Drawing.Point(23, 310);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(190, 25);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Numero de Telefono";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Correo.Location = new System.Drawing.Point(23, 168);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(72, 25);
            this.lbl_Correo.TabIndex = 5;
            this.lbl_Correo.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(219, 62);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtApellido.Location = new System.Drawing.Point(219, 117);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(368, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(219, 170);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(368, 23);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCedula.Location = new System.Drawing.Point(219, 219);
            this.txtCedula.MaxLength = 11;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(368, 23);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSeguro.Location = new System.Drawing.Point(219, 266);
            this.txtSeguro.MaxLength = 10;
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(368, 23);
            this.txtSeguro.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(219, 312);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(368, 23);
            this.txtTelefono.TabIndex = 11;
            // 
            // btn_RegistrarCliente
            // 
            this.btn_RegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RegistrarCliente.Location = new System.Drawing.Point(67, 449);
            this.btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            this.btn_RegistrarCliente.Size = new System.Drawing.Size(191, 58);
            this.btn_RegistrarCliente.TabIndex = 12;
            this.btn_RegistrarCliente.Text = "Registrar Cliente";
            this.btn_RegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Cancelar.Location = new System.Drawing.Point(345, 449);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(191, 58);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 554);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Seguro);
            this.Controls.Add(this.lbl_Cedula);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.MaximizeBox = false;
            this.Name = "RegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarCliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Seguro;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btn_RegistrarCliente;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}