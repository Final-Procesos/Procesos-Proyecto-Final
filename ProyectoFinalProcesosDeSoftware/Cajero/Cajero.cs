﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProcesosDeSoftware
{
    public class Cajero
    {
        public static string Cn = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        SqlConnection sql = new SqlConnection(Cn);

        private string nombre;
        private string apellido;
        private object user;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string RegistrarCliente(Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand("RegistrarCliente", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@Seguro", cliente.Seguro);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();

            return "Cliente creado con exito";
        }
    }
}
