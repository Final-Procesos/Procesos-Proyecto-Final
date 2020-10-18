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
            this.Close();
            login.Show();
        }
    }
}
