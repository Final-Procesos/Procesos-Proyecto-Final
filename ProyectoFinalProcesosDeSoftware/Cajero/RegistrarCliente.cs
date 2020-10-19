using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProcesosDeSoftware
{
    public partial class RegistrarCliente : Form
    {
        CajeroMain main;
        Cajero cajero;
        public RegistrarCliente(CajeroMain form, Cajero cajerop)
        {
            InitializeComponent();
            main = form;
            cajero = cajerop;
        }

        private void lbl_Seguro_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }

        private void btn_RegistrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text)) { 
            
                MessageBox.Show("Debe llenar todos los campos que no sean opcionales");
            }

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Cedula = txtCedula.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Seguro = txtSeguro.Text;

            MessageBox.Show(cajero.RegistrarCliente(cliente));
            this.Close();
        }
    }
}
