using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public RegistrarCliente(CajeroMain form)
        {
            InitializeComponent();
            main = form;
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
            this.Hide();
            main.Show();

        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
