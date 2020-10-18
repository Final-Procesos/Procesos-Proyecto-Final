using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using ProyectoFinalProcesosDeSoftware;

namespace FinalProjectBank
{
    public partial class Form_LogIn : Form
    {
        LocalMethods localMethods = new LocalMethods();
        public Form_LogIn()
        {
            InitializeComponent();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsuario.Text)|| string.IsNullOrWhiteSpace(txbContrasena.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                Usuario user = new Usuario();
                string username = txbUsuario.Text;
                string contraseña = txbContrasena.Text;
                bool login = true;
                user = localMethods.Login(username, contraseña);

                if (string.IsNullOrWhiteSpace(user.Contraseña))
                {
                    login = false;
                }


                if (login == true)
                {
                    int tipoUsuario = (int)user.GetTipoUsuario();
                    if(tipoUsuario == 1)
                    {
                        MessageBox.Show("Datos Correctos de Doctor");

                    }
                    else if(tipoUsuario == 2)
                    {
                        MessageBox.Show("Datos Correctos de Cajero");
                    }

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

            }


        }


        private void Form_LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    string username = txbUsuario.Text;
        //    string contraseña = Encrypt(txbContrasena.Text);
        //    cmd.Connection = sql;
        //    cmd.CommandText = "Encrypt_Acc";

        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.Parameters.AddWithValue("@contraseña", contraseña);

        //    sql.Open();
        //    cmd.ExecuteNonQuery();
        //    sql.Close();

        //}
    }
}
