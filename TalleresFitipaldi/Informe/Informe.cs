using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Data.Helpers;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;
using TalleresFitipaldi.Clases;

namespace TalleresFitipaldi.Informe
{

    public partial class Informe : DevExpress.XtraReports.UI.XtraReport
    {
        ObservableCollection<Cliente1> listaClientes;
        ObservableCollection<Coche1> listaCoche;
        
        public Informe()
        {
            InitializeComponent();
            // Crear la etiqueta y establecer su contenido y tamaño
            XRLabel labelTitulo = new XRLabel();
            labelTitulo.Text = "Factura de Taller Fitipaldis";
            labelTitulo.Font = new Font("Arial", 24, FontStyle.Bold);
            labelTitulo.SizeF = new SizeF(500, 50);
            // Crear una variable de saludo
            string saludo = "¡Hola Mundo!";
            
            // Acceder a la etiqueta y asignarle el valor de la variable de saludo
            XRLabel labelSaludo = new XRLabel();
            labelSaludo.Text = saludo;



        }


    }

}
    