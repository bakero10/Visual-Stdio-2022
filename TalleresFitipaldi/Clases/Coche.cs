using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TalleresFitipaldi.Clases
{
    internal class Coche
    {
        private String matricula;
        private String marca;
        private String modelo;
        private String color;

        public Coche(string matricula, string marca, string modelo, string color)
        {
            this.matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }


        // Método ToString() de la clase
        public override string ToString()
        {
            return base.ToString() + ": " + Matricula + " " + Marca + " " + Modelo + " " + Color;
        }
    }
}

