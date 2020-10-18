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
            bool login_correcto = false;
            string contraseña2 = null;

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
                    login_correcto = true;
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

    }



}
