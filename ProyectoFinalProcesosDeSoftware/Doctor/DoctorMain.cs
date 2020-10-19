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
    public partial class DoctorMain : Form
    {
        Form_LogIn login;
        Doctor doctor;
        public DoctorMain(Doctor doctor_p, Form_LogIn form)
        {
            InitializeComponent();
            login = form;
            doctor = doctor_p;

        }

        private void DoctorMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void btn_RegistrarResultados_Click(object sender, EventArgs e)
        {
            RegistrarResultados registrarResultados = new RegistrarResultados(this, doctor);
            this.Hide();
            registrarResultados.Show();
        }
    }
}
