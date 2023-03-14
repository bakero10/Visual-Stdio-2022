using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    internal class cliente
    {
        private int id { get; set; }
        private String nombre { get; set; }
        private String apellidos { get; set; }
        private String dni { get; set; }
        private int telefono { get; set; }

        private String direccion { get; set; }
        private String email { get; set; }

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
        // Método ToString() de la clase
        public override string ToString()
        {
            return id + " " + nombre + " " + apellidos + " " + dni + " " + telefono + " " + direccion + " " + email;
        }
    }
}
