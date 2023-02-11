using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Devart.Data.MySql;


namespace TalleresFitipaldi
{

    public partial class Cliente : Window
    {
        private DataGrid dataGrid;
        private AccesoBDatos abd;
        public Cliente()
        {
            InitializeComponent();
            abd= new AccesoBDatos();
            dataGrid = new DataGrid();    

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
            abd.insertarCliente(int.Parse(textBoxId.Text),
                                textBoxNombre.Text,
                                textBoxApellido.Text,
                                textBoxDNI.Text,
                                int.Parse(textBoxTelefono.Text),
                                textBoxDireccion.Text,
                                textBoxCorreo.Text);

            MessageBox.Show("Cliente Insertado correctamente!", "Información");
        }

        private void botonActualizar_Click(object sender, RoutedEventArgs e)
        {
            abd.actualizarCliente(int.Parse(textBoxId.Text),
                                textBoxNombre.Text,
                                textBoxApellido.Text,
                                textBoxDNI.Text,
                                int.Parse(textBoxTelefono.Text),
                                textBoxDireccion.Text,
                                textBoxCorreo.Text);

            MessageBox.Show("Cliente Actualizado correctamente!", "Información");
        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {
          
            abd.borrarCliente(int.Parse(textBoxId.Text));
            MessageBox.Show("Cliente borrado correctamente!","Información");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        public void CargarDatos()
        {
            // Crea una instancia de la clase de conexión y llama al método para obtener los datos
            AccesoBDatos conexion = new AccesoBDatos();
            DataTable data = conexion.rellenarDataGrid();
            if (data.Rows.Count > 0)
            {
                MessageBox.Show(data.ToString());
            }
            else
            {
                // El objeto DataTable está vacío, no se puede asignar como origen de datos
                MessageBox.Show("El objeto DataTable está vacío, no se puede asignar como origen de datos");
            }
        }

        private void botonBuscar_Click(object sender, RoutedEventArgs e)
        {
            CargarDatos();
        }
    }
}
