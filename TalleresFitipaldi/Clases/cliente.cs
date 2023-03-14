using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    internal class cliente
    {
        private int id;
        private String nombre;
        private String apellidos;
        private String dni;
        private int telefono;
        private String direccion;
        private String email;

        public cliente(int id, string nombre, string apellidos, string dni, int telefono, string direccion, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
    }
}
