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
    public partial class ConsultarResultados : Form
    {
        LocalMethods localMethods = new LocalMethods();
        DoctorMain main;
        public ConsultarResultados(DoctorMain form)
        {
            InitializeComponent();
            main = form;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

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

            Cliente cliente = localMethods.GetClienteoData(txtCedula.Text);

            if (cliente.Nombre == null)
            {
                MessageBox.Show("No se ha encontrado a un paciente con esta cedula");
            }
            else
            {
                List<Dictionary<string, string>> info = localMethods.GetDataGridInformation(cliente.Cedula);

                foreach (Dictionary<string,string> item in info)
                {
                    dataGrid.Rows.Add(item["Doctor"],item["Paciente"], item["TipoMuestra"], item["Resultado"]);
                }
            }
        }

        private void ConsultarResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
