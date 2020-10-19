using System;
using System.Collections.Generic;
using System.Configuration;
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

        public string RegistrarResultado(Cliente cliente, string resultado_Muestra, int tipoMuestra)
        {
            SqlCommand cmd = new SqlCommand("RegistrarResultado", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@Resultado", resultado_Muestra);
            cmd.Parameters.AddWithValue("@idTipoMuestra", tipoMuestra);
            cmd.Parameters.AddWithValue("@NombreDoctor", this.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoDoctor", this.Apellido);


            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();

            return "El resultado de la muestra ha sido registrado correctamente";

        }

    }
}
