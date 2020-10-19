using FinalProjectBank;
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
    public partial class CajeroMain : Form
    {
        Form_LogIn login;
        Cajero cajero;
        public CajeroMain(Cajero cajerop, Form_LogIn form)
        {
            InitializeComponent();
            login = form;
            cajero = cajerop;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void CajeroMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarCliente regcliente = new RegistrarCliente(this, cajero);
            this.Hide(); 
            regcliente.Show();

        }
    }
}
