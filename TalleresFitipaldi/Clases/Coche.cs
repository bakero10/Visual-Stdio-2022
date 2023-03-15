using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    internal class Coche : INotifyPropertyChanged
    {
        private String dni;
        private String matricula;
        private String marca;
        private String modelo;
        private String color;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Coche(string dni, string matricula, string marca, string modelo, string color)
        {
            this.dni = dni; 
            this.matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }

        public String Dni
        {
            get { return dni; }
            set
            {
                dni = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Dni"));
            }
        }
        public String Matricula
        {
            get { return matricula; }
            set
            {
                matricula = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Matricula"));
            }
        }
        public String Marca
        {
            get { return marca; }
            set
            {
                marca = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Marca"));
            }
        }
        public String Modelo
        {
            get { return modelo; }
            set
            {
                modelo = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Modelo"));
            }
        }
        public String Color
        {
            get { return color; }
            set
            {
                color = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }


        // Método ToString() de la clase
        public override string ToString()
        {
            return base.ToString() + ": " + Dni + " " + Matricula + " " + Marca + " " + Modelo + " " + Color;
        }
    }
}

