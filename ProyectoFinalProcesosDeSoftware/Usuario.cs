using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesosDeSoftware
{
    public enum TipoUsuario
    {
        Doctor = 1,
        Cajero = 2
    }
    public class Usuario
    {
        private string correo;
        private string contraseña;
        private TipoUsuario tipoUsuario;


        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public void SetTipoUsuario(TipoUsuario value)
        {
            tipoUsuario = value;
        }
        public TipoUsuario GetTipoUsuario()
        {
            return tipoUsuario;
        }

    }
}
