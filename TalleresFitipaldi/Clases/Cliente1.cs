using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    public class Cliente1 : INotifyPropertyChanged
    {
        private int id;
        private String nombre;
        private String apellidos;
        private String dni;
        private int telefono;
        private String direccion;
        private String email;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Cliente1()
        {
        }

        public Cliente1(int id, string nombre, string apellidos, string dni, int telefono, string direccion, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Apellidos"));
            }
        }

        public string Dni
        {
            get { return dni; }
            set
            {
                dni = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Dni"));
            }
        }

        public int Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefono"));
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                direccion = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Direccion"));
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }


        // Método ToString() de la clase
        public override string ToString()
        {
            return base.ToString() + ": " + Id + " " + Nombre + " " + Apellidos + " " + Dni + " " + Telefono + " " + Direccion + " " + Email;
        }
    }




}


