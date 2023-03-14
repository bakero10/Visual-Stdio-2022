using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TalleresFitipaldi
{
    /// <summary>
    /// Lógica de interacción para PantallaPrincipal.xaml
    /// </summary>
    public partial class PantallaPrincipal : Window
    {
        
        PantallaCliente pantallaCliente;
        PaginaReparacion paginaReparacion;
        
        List<Clases.Coche> listaCoches;

        public PantallaPrincipal()
        {
            InitializeComponent();
            
            listaCoches = new List<Clases.Coche>();
            paginaReparacion = new PaginaReparacion();
            pantallaCliente= new PantallaCliente();
           

            

            Clases.Coche co1 = new Clases.Coche("2670POR","Renault","Trafic","Blanco");
            Clases.Coche co2 = new Clases.Coche("3454GYR","Kia","Rio","Rosa");
            Clases.Coche co3 = new Clases.Coche("4456GYY","Ford","Fiesta","Rojo");

            

           listaCoches.Add(co1);
           listaCoches.Add(co2);   
           listaCoches.Add(co3);   
            
           


        }

        private void botonClientes_Click(object sender, RoutedEventArgs e)
        {
            pantallaCliente.Show();
            this.Close();
        }

        private void botonReparaciones_Click(object sender, RoutedEventArgs e)
        {
            paginaReparacion.Show();
            this.Close();
        }
    }
}
