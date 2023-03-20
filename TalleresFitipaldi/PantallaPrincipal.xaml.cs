using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DevExpress.XtraReports.UI;
using TalleresFitipaldi.Clases;


namespace TalleresFitipaldi
{
    /// <summary>
    /// Lógica de interacción para PantallaPrincipal.xaml
    /// </summary>
    public partial class PantallaPrincipal : Window
    {
        
        PantallaCliente pantallaCliente;
        PaginaReparacion paginaReparacion;
        

        ObservableCollection<Cliente1> observableCliente;
        ObservableCollection<Coche1> observableCoches;

        public PantallaPrincipal()
        {
            InitializeComponent();

            insertarDatos();
            paginaReparacion = new PaginaReparacion();
            pantallaCliente = new PantallaCliente();
           
           
            
            
        }
        public void insertarDatos()
        {
            observableCoches = new ObservableCollection<Coche1>();
            observableCliente = new ObservableCollection<Cliente1>
            {
                new Cliente1(1, "José Miguel", "Andrés Pérez", "18049608J", 699687589, "Julio Alejandro Castro Cardus 12 5A", "bakero__10@hotmail.com"),
                new Cliente1(2, "Raúl", "Solano Berdiel", "18049659R", 699687534, "c/ Teruel 23 1A", "Rasobe@hotmail.com"),
                new Cliente1(3, "Santiago", "Ramirez Arenas", "18049656S", 699687531, "BajoGimanasio 33 12A", "SantiFans@hotmail.com"),
                new Cliente1(4, "Oskaras", "Stankevicius", "180423234t", 699687234, "Carretera Cuarte", "Oskaras@hotmail.com"),
                new Cliente1(5, "Mario Pop", "De popis", "180423243t", 699687234, "Barbastro 4b", "Mario@hotmail.com"),
                new Cliente1(6, "María", "García González", "18987654M", 699654321, "c/ Zaragoza 12 4B", "maria.garcia@gmail.com"),
                new Cliente1(7, "Antonio", "Martínez López", "18543210A", 699987654, "c/ Valencia 8 2A", "antonio.martinez@hotmail.com"),
                new Cliente1(8, "Laura", "Pérez Fernández", "18234567L", 699123456, "c/ Barcelona 33 3C", "laura.perez@gmail.com"),
                new Cliente1(9, "Miguel", "Sánchez García", "18987654M", 699654321, "c/ Huesca 20 1B", "miguel.sanchez@gmail.com"),
                new Cliente1(10, "Ana", "Fernández García", "18234567L", 699123456, "c/ Madrid 45 2C", "ana.fernandez@hotmail.com")
            };

            observableCoches.Add(new Coche1("18049608J", "2670POR", "Renault", "Trafic", "Blanco"));
            observableCoches.Add(new Coche1("18049659R", "3454GYR", "Kia", "Rio", "Rosa"));
            observableCoches.Add(new Coche1("18049656S", "4456GYY", "Ford", "Fiesta", "Rojo"));
            observableCoches.Add(new Coche1("180423243t", "2670POR", "Renault", "Trafic", "Blanco"));
            observableCoches.Add(new Coche1("18234567L", "1234ABC", "Audi", "A3", "Rojo"));
            observableCoches.Add(new Coche1("18049608J", "5678DEF", "Toyota", "Corolla", "Azul"));
            observableCoches.Add(new Coche1("18234567L", "9012GHI", "Ford", "Focus", "Verde"));
            observableCoches.Add(new Coche1("18543210A", "3456JKL", "Volkswagen", "Golf", "Gris"));
            observableCoches.Add(new Coche1("18049659R", "3454GYR", "Kia", "Rio", "Rosa"));
            observableCoches.Add(new Coche1("18987654M", "1111AAA", "Peugeot", "208", "Negro"));
            observableCoches.Add(new Coche1("18987654M", "2222BBB", "Citroen", "C3", "Blanco"));
            observableCoches.Add(new Coche1("18049656S", "4456GYY", "Ford", "Fiesta", "Rojo"));
            observableCoches.Add(new Coche1("18543210A", "3333CCC", "Seat", "Ibiza", "Azul"));
            observableCoches.Add(new Coche1("18049656S", "4444DDD", "Renault", "Clio", "Gris"));
            observableCoches.Add(new Coche1("180423234t", "5555EEE", "Peugeot", "3008", "Negro"));
            observableCoches.Add(new Coche1("180423234t", "6666FFF", "Opel", "Corsa", "Rojo"));

            Listas.listaCoches = observableCoches;
            Listas.listaClientes = observableCliente;
        }

        private void botonClientes_Click(object sender, RoutedEventArgs e)
        {
            
            pantallaCliente.Show();
            
        }

        private void botonReparaciones_Click(object sender, RoutedEventArgs e)
        {
            
            paginaReparacion.Show();
            
        }

    }
}
