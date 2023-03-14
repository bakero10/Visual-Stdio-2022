using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    internal class Cliente
    {
        public int id;
        public String nombre;
        public String apellidos;
        public String dni;
        public int telefono;
        public String direccion;
        public String email;

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string apellidos, string dni, int telefono, string direccion, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    

    // Método ToString() de la clase
    public override string ToString()
        {
            return base.ToString() + ": " + Id + " " + Nombre + " " + Apellidos + " " + Dni + " " + Telefono + " " + Direccion + " " + Email;
        }
    }




}
