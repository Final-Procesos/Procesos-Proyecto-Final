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

    public partial class RegistrarResultados : Form
    {
        LocalMethods localMethods = new LocalMethods();
        DoctorMain main;
        Doctor doctor;
        Cliente cliente;
        public RegistrarResultados(DoctorMain form, Doctor doctorp)
        {
            InitializeComponent();
            main = form;
            doctor = doctorp;
        }

        private void btn_RegistrarResultado_Click(object sender, EventArgs e)
        {
            int tipoMuestra = cmbox_TipoMuestra.SelectedIndex + 1;
            MessageBox.Show(doctor.RegistrarResultado(cliente, txtResultado.Text, tipoMuestra));
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_BuscarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("No ha ingresado una cedula valida");
                return;
            }

            cliente = localMethods.GetClienteoData(txtCedula.Text);

            if (cliente.Nombre == null)
            {
                MessageBox.Show("No se ha encontrado a un paciente con esta cedula");
            }
            else
            {
                lbl_Nombre_Txt.Text = cliente.Nombre;
                lbl_Apellido_Txt.Text = cliente.Apellido;
                lbl_PacienteEncontrado.Show();
                lblApellido.Show();
                lbl_NombrePaciente.Show();
                lbl_Nombre_Txt.Show();
                lbl_Apellido_Txt.Show();
                txtResultado.Enabled = true;
                btn_RegistrarResultado.Enabled = true;
                cmbox_TipoMuestra.Enabled = true;
            }


        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            btn_RegistrarResultado.Enabled = false;
            txtResultado.Enabled = false;
            cmbox_TipoMuestra.Enabled = false;
            lbl_PacienteEncontrado.Hide();
            lblApellido.Hide();
            lbl_NombrePaciente.Hide();
            lbl_Nombre_Txt.Hide();
            lbl_Apellido_Txt.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
