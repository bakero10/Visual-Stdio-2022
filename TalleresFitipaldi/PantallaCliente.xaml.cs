using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
        ObservableCollection<Clases.Cliente> observableCliente;
        ObservableCollection<Coche> observableCoches;
        public PantallaCliente()
        {
            InitializeComponent();
            // abd = new AccesoBDatos();
            // listaClientes = new List<Clases.Cliente>();
            actualizarLista();
            observableCoches = new ObservableCollection<Coche>();
            observableCliente = new ObservableCollection<Clases.Cliente>();
        }

        public void actualizarLista()
        {

            observableCliente.Add(new Clases.Cliente(1, "José Miguel", "Andrés Pérez", "18049608J", 699687589, "Julio Alejandro Castro Cardus 12 5A", "bakero__10@hotmail.com"));
            observableCliente.Add(new Clases.Cliente(2, "Raúl", "Solano Berdiel", "18049659R", 699687534, "c/ Teruel 23 1A", "Rasobe@hotmail.com"));
            observableCliente.Add(new Clases.Cliente(3, "Santiago", "Ramirez Arenas", "18049656S", 699687531, "BajoGimanasio 33 12A", "SantiFans@hotmail.com"));
            observableCliente.Add(new Clases.Cliente(4, "Oskaras", "Stankevicius", "180423234t", 699687234, "Carretera Cuarte", "Oskaras@hotmail.com"));
            observableCliente.Add(new Clases.Cliente(5, "Mario Pop", "De popis", "180423243t", 699687234, "Barbastro 4b", "Mario@hotmail.com"));

            observableCoches.Add(new Clases.Coche("18049608J", "2670POR", "Renault", "Trafic", "Blanco"));
            observableCoches.Add(new Clases.Coche("18049659R", "3454GYR", "Kia", "Rio", "Rosa"));
            observableCoches.Add(new Clases.Coche("18049656S", "4456GYY", "Ford", "Fiesta", "Rojo"));

            dataGridPanel.ItemsSource = observableCliente;
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
            int idNuevoCliente = int.Parse(textBoxId.Text);
            bool idExiste = false;
            int proxId = (observableCliente.Count + 1);
            foreach (Clases.Cliente cliente in observableCliente)
            {
                
                if (cliente.Id == idNuevoCliente)
                {
                    idExiste = true;
                    
                    MessageBox.Show("Este id ya esta usado. Por favor introduce otro id.El siguiente en estar disponible es: "+proxId);
                    break;
                    
                }
            }

            if (!idExiste)
            {
                observableCliente.Add(new Clases.Cliente(idNuevoCliente,
                                                         textBoxNombre.Text,
                                                         textBoxApellido.Text,
                                                         textBoxDNI.Text,
                                                         int.Parse(textBoxTelefono.Text),
                                                         textBoxDireccion.Text,
                                                         textBoxCorreo.Text));
                dataGridPanel.ItemsSource = observableCliente;
                MessageBox.Show("Cliente Insertado correctamente!", "Información");
            }
            // Limpiar los campos de texto
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";
            textBoxCorreo.Text = "";

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
            int idClienteAActualizar = int.Parse(textBoxId.Text);
            bool clienteEncontrado = false;
            foreach (Clases.Cliente cliente in observableCliente)
            {
                if (cliente.Id == idClienteAActualizar)
                {
                    cliente.Nombre = textBoxNombre.Text;
                    cliente.Apellidos = textBoxApellido.Text;
                    cliente.Dni = textBoxDNI.Text;
                    cliente.Telefono = int.Parse(textBoxTelefono.Text);
                    cliente.Direccion = textBoxDireccion.Text;
                    cliente.Email = textBoxCorreo.Text;
                    clienteEncontrado = true;
                    break;
                }
            }

            if (clienteEncontrado)
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Información");
                dataGridPanel.ItemsSource = observableCliente;
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con el ID especificado.", "Error");
            }

            // Limpiar los campos de texto
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";
            textBoxCorreo.Text = "";
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
            int idClienteABorrar = int.Parse(textBoxId.Text);
            bool clienteEncontrado = false;
            foreach (Clases.Cliente cliente in observableCliente)
            {
                if (cliente.Id == idClienteABorrar)
                {
                    observableCliente.Remove(cliente);
                    clienteEncontrado = true;
                    break;
                }
            }

            if (clienteEncontrado)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Información");
                dataGridPanel.ItemsSource = observableCliente;
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con el ID especificado.", "Error");
            }
            //abd.borrarCliente(int.Parse(textBoxId.Text));
            //MessageBox.Show("Cliente borrado correctamente!", "Información");
        }

        // Método para verificar si el DNI del cliente es válido y existe en la lista de clientes
        private bool verificarCliente(string dni)
        {
            foreach (Cliente cliente in observableCliente)
            {
                if (cliente.Dni == dni)
                {
                    return true;
                }
            }
            return false;
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

        private void botonInsertar_Coche_Click(object sender, RoutedEventArgs e)
        {
            // Crear un nuevo objeto Coche con los valores de los campos de texto
            Coche nuevoCoche = new Coche(textBoxDniCoche.Text, textBoxMatricula.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxColor.Text);

            // Verificar si la matrícula ya existe en la lista de coches
            bool existeMatricula = false;
            foreach (Coche coche in observableCoches)
            {
                if (coche.Matricula == nuevoCoche.Matricula)
                {
                    existeMatricula = true;
                    MessageBox.Show("La matrícula " + coche.Matricula + " ya existe. Introduce otra matrícula.");
                    break;
                }
            }

            // Verificar si el DNI del cliente es válido y existe en la lista de clientes
            bool existeCliente = verificarCliente(nuevoCoche.Dni);
            if (!existeCliente)
            {
                MessageBox.Show("El DNI " + nuevoCoche.Dni + " no es válido o no pertenece a ningún cliente registrado.");
            }

            // Si la matrícula y el DNI del cliente son válidos, agregar el nuevo coche a la lista de coches y mostrar mensaje de éxito
            if (!existeMatricula && existeCliente)
            {
                observableCoches.Add(nuevoCoche);
                MessageBox.Show("Coche insertado correctamente.", "Información");
            }

            // Limpiar los campos de texto
            textBoxMatricula.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxColor.Text = "";
        }

        
    
            

    private void botonActualizar_Coche_Click(object sender, RoutedEventArgs e)
        {
        // Obtener la matrícula del coche a actualizar
        string matriculaActualizar = textBoxMatricula.Text;

        // Buscar el coche correspondiente en la lista de coches
        Coche cocheActualizar = null;
        foreach (Coche coche in observableCoches)
        {
            if (coche.Matricula == matriculaActualizar)
            {
                cocheActualizar = coche;
                break;
            }
        }

        // Si la matrícula no existe, mostrar mensaje de error y salir del método
        if (cocheActualizar == null)
        {
            MessageBox.Show("La matrícula " + matriculaActualizar + " no existe en la lista de coches.");
            return;
        }

        // Actualizar los valores del coche
        cocheActualizar.Marca = textBoxMatricula.Text;
    }

        private void botonBorrar_Coche_Click(object sender, RoutedEventArgs e)
        {
            // Obtener la matrícula del coche a borrar
            string matricula = textBoxMatricula.Text;

            // Buscar el coche con la matrícula especificada en la colección
            Clases.Coche cocheExistente = observableCoches.FirstOrDefault(c => c.Matricula == matricula);

            if (cocheExistente == null)
            {
                MessageBox.Show("El coche no existe. Por favor, introduce una matrícula válida.", "Error");
                return;
            }

            // Borrar el coche de la colección
            observableCoches.Remove(cocheExistente);

            

            MessageBox.Show("Coche borrado correctamente.", "Información");
        }

      
    }
}
