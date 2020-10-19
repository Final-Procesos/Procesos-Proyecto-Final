using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProyectoFinalProcesosDeSoftware
{
    public class LocalMethods
    {
        public static string Cn = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        SqlConnection sql = new SqlConnection(Cn);

        public Usuario Login(string correo, string contraseña)
        {
            Usuario user = new Usuario();

            SqlCommand cmd = new SqlCommand("Verify_Account", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Correo", correo);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return user;
            }

            if (reader.Read())
            {
                if (contraseña == reader["Contraseña"].ToString())
                {
                    user.Correo = correo;
                    user.Contraseña = contraseña;
                    if((int) reader["idTipousuario"] == 1)
                    {
                        user.SetTipoUsuario(TipoUsuario.Doctor);
                    }
                    else
                    {
                        user.SetTipoUsuario(TipoUsuario.Cajero);
                    }

                    sql.Close();
                    return user;
                }

            }
            else
            {
                sql.Close();
                return user;
            }

            return user;
        }

        public Doctor GetDoctorData(Usuario user)
        {
            Doctor doctor = new Doctor();

            SqlCommand cmd = new SqlCommand("GetDoctorData", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Correo", user.Correo);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return doctor;
            }

            if (reader.Read())
            {
                doctor.Nombre = reader["Nombre"].ToString();
                doctor.Apellido = reader["Apellido"].ToString();


                sql.Close();
                return doctor;
            }
            return doctor;
        }

        public Cajero GetCajeroData(Usuario user)
        {
            Cajero cajero = new Cajero();

            SqlCommand cmd = new SqlCommand("GetCajeroData", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Correo", user.Correo);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return cajero;
            }

            if (reader.Read())
            {
                cajero.Nombre = reader["Nombre"].ToString();
                cajero.Apellido = reader["Apellido"].ToString();


                sql.Close();
                return cajero;
            }
            return cajero;
        }

        public Cliente GetClienteoData(string cedula)
        {
            Cliente cliente = new Cliente();

            SqlCommand cmd = new SqlCommand("GetClienteData", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", cedula);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return cliente;
            }

            if (reader.Read())
            {
                cliente.Nombre = reader["Nombre"].ToString();
                cliente.Apellido = reader["Apellido"].ToString();
                cliente.Cedula = reader["Cedula"].ToString();

                sql.Close();
                return cliente;
            }
            return cliente;
        }

        public List<Dictionary<string,string>> GetDataGridInformation(string cedula)
        {
            List<Dictionary<string,string>> info = new List<Dictionary<string,string>>();

            SqlCommand cmd = new SqlCommand("GetDataGridInformation", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", cedula);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return info;
            }

            while(reader.Read())
            {
                Dictionary<string, string> tempdic = new Dictionary<string, string>
                {
                    {"Doctor", reader["NombreDoctor"].ToString() + " " + reader["ApellidoDoctor"].ToString()},
                    {"Paciente",reader["NombreCliente"].ToString() + " " + reader["ApellidoCliente"].ToString() },
                    {"TipoMuestra", reader["TipoMuestra"].ToString() },
                    {"Resultado", reader["Resultados"].ToString() }
                };
                info.Add(tempdic);
            }
            sql.Close();

            return info;

        }
    }

    



}
