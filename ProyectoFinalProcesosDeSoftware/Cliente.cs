using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesosDeSoftware
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string telefono;
        private string seguro;
        private string correo;

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
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Seguro
        {
            get { return seguro; }
            set { seguro = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

    }
}
