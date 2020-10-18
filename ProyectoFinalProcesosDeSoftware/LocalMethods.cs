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

        public bool Login(string username, string contraseña)
        {
            bool login_correcto = false;
            string contraseña2 = null;

            SqlCommand cmd = new SqlCommand("Verify_Account", sql);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Correo", username);

            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            bool rows = reader.HasRows;
            if (!rows)
            {
                sql.Close();
                return login_correcto;
            }

            if (reader.Read())
            {
                contraseña2 = reader["Contraseña"].ToString();
            }


            if (contraseña == contraseña2)
            {
                login_correcto = true;
                sql.Close();
                return login_correcto;
            }
            else
            {
                sql.Close();
                return login_correcto;
            }
        }

    }



}
