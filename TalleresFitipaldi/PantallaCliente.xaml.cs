using System;
using System.Collections;
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
using TalleresFitipaldi.Clases;

namespace TalleresFitipaldi
{
    /// <summary>
    /// Lógica de interacción para PantallaCliente.xaml
    /// </summary>
    public partial class PantallaCliente : Window
    {
      //  List<Clases.Cliente> listaClientes;


        public PantallaCliente()
        {
            InitializeComponent();
            // abd = new AccesoBDatos();
           // listaClientes = new List<Clases.Cliente>();
            
            /*
            Clases.Cliente c1 = new Clases.Cliente(1, "José Miguel", "Andrés Pérez", "18049608J", 699687589, "Julio Alejandro Castro Cardus 12 5A", "bakero__10@hotmail.com");
            Clases.Cliente c2 = new Clases.Cliente(2, "Raúl", "Solano Berdiel", "18049659R", 699687534, "c/ Teruel 23 1A", "Rasobe@hotmail.com");
            Clases.Cliente c3 = new Clases.Cliente(3, "Santiago", "Ramirez Arenas", "18049656S", 699687531, "BajoGimanasio 33 12A", "SantiFans@hotmail.com");

            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            */
            dataGridPanel.ItemsSource = LoadCollectionData();

        }

        private static List<Cliente> LoadCollectionData()
        {
           
            List<Cliente> listaDeClientes = new List<Cliente>();
            listaDeClientes.Add(new Cliente()
            {
               Id = 1, 
               Nombre= "José Miguel", 
               Apellidos= "Andrés Pérez", 
               Dni= "18049608J", 
               Telefono= 699687589, 
               Direccion= "Julio Alejandro Castro Cardus 12 5A", 
               Email= "bakero__10@hotmail.com"
            });

            listaDeClientes.Add(new Cliente()
            {
                Id = 2,
                Nombre = "Raúl",
                Apellidos = "Solano Berdiel",
                Dni = "18049659R",
                Telefono = 699687534,
                Direccion = "c/ Teruel 23 1A",
                Email = "Rasobe@hotmail.com"
            });

            listaDeClientes.Add(new Cliente()
            {
                Id = 3,
                Nombre = "Santiago",
                Apellidos = "Ramirez Arenas",
                Dni = "18049656S",
                Telefono = 699687531,
                Direccion = "BajoGimanasio 33 12A",
                Email = "SantiFans@hotmail.com"
            });

            listaDeClientes.Add(new Cliente()
            {
                Id = 4,
                Nombre = "Oskaras",
                Apellidos = "Stankevicius",
                Dni = "180423234t",
                Telefono = 699687234,
                Direccion = "Carretera Cuarte",
                Email = "Oskaras@hotmail.com"
            });

            listaDeClientes.Add(new Cliente()
            {
                Id = 5,
                Nombre = "Mario Pop",
                Apellidos = "De popis",
                Dni = "180423243t",
                Telefono = 699687234,
                Direccion = "Barbastro 4b",
                Email = "Mario@hotmail.com"
            });
            return listaDeClientes;
        }

        private void dataGridPanel_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridTextColumn idColumn = new DataGridTextColumn();
            idColumn.Header = "ID";
            idColumn.Binding = new Binding("Id");

            DataGridTextColumn nombreColumn = new DataGridTextColumn();
            nombreColumn.Header = "Nombre";
            nombreColumn.Binding = new Binding("Nombre");

            DataGridTextColumn apellidosColumn = new DataGridTextColumn();
            apellidosColumn.Header = "Apellidos";
            apellidosColumn.Binding = new Binding("Apellidos");

            DataGridTextColumn dniColumn = new DataGridTextColumn();
            dniColumn.Header = "DNI";
            dniColumn.Binding = new Binding("Dni");

            DataGridTextColumn telefonoColumn = new DataGridTextColumn();
            telefonoColumn.Header = "Teléfono";
            telefonoColumn.Binding = new Binding("Telefono");

            DataGridTextColumn direccionColumn = new DataGridTextColumn();
            direccionColumn.Header = "Dirección";
            direccionColumn.Binding = new Binding("Direccion");

            DataGridTextColumn emailColumn = new DataGridTextColumn();
            emailColumn.Header = "Email";
            emailColumn.Binding = new Binding("Email");

            dataGridPanel.Columns.Add(idColumn);
            dataGridPanel.Columns.Add(nombreColumn);
            dataGridPanel.Columns.Add(apellidosColumn);
            dataGridPanel.Columns.Add(dniColumn);
            dataGridPanel.Columns.Add(telefonoColumn);
            dataGridPanel.Columns.Add(direccionColumn);
            dataGridPanel.Columns.Add(emailColumn);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_Expanded(object sender, RoutedEventArgs e)
        {

        }

        private void botonInsertar_Click(object sender, RoutedEventArgs e)
        {
            /*
            abd.insertarCliente(int.Parse(textBoxId.Text),
                                textBoxNombre.Text,
                                textBoxApellido.Text,
                                textBoxDNI.Text,
                                int.Parse(textBoxTelefono.Text),
                                textBoxDireccion.Text,
                                textBoxCorreo.Text);

            MessageBox.Show("Cliente Insertado correctamente!", "Información");
            */
        }

        private void botonActualizar_Click(object sender, RoutedEventArgs e)
        {
            /*
            abd.actualizarCliente(int.Parse(textBoxId.Text),
                                textBoxNombre.Text,
                                textBoxApellido.Text,
                                textBoxDNI.Text,
                                int.Parse(textBoxTelefono.Text),
                                textBoxDireccion.Text,
                                textBoxCorreo.Text);

            MessageBox.Show("Cliente Actualizado correctamente!", "Información");
            */
        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {

            //abd.borrarCliente(int.Parse(textBoxId.Text));
            MessageBox.Show("Cliente borrado correctamente!", "Información");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void CargarDatos()
        {
            // Crea una instancia de la clase de conexión y llama al método para obtener los datos
            AccesoBDatos conexion = new AccesoBDatos();


        }

        private void botonBuscar_Click(object sender, RoutedEventArgs e)
        {
            CargarDatos();
            //abd.Rellenar();
        }
    }
}
