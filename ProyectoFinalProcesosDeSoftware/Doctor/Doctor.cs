using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesosDeSoftware
{
    public class Doctor
    {
        public static string Cn = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        SqlConnection sql = new SqlConnection(Cn);

        private string nombre;
        private string apellido;



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

        public string RegistrarResultado(Cliente cliente, string resultado)
        {
            SqlCommand cmd = new SqlCommand("RegistrarCliente", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            cmd.Parameters.AddWithValue("@Resultado", resultado);
            cmd.Parameters.AddWithValue("@NombreDoctor", this.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoDoctor", this.Apellido);


            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                string resultado = reader["Resultado"].ToString();
                sql.Close();
                return resultado;

            }
            reader.Close();
            cmd.ExecuteNonQuery();
            sql.Close();

            return "Cliente creado con exito";
            return "El resultado de la muestra ha sido registrado correctamente";

        }

    }
}
