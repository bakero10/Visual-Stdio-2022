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
using MetroFramework.Forms;
using TalleresFitipaldi.Clases;

namespace TalleresFitipaldi
{
    /// <summary>
    /// Lógica de interacción para PantallaCliente.xaml
    /// </summary>
    public partial class PantallaCliente : Window
    {
        ObservableCollection<Cliente1> listaClientes;
        ObservableCollection<Coche1> listaCoches;
        
        public PantallaCliente()
        {
            InitializeComponent();
            // abd = new AccesoBDatos();
            // listaClientes = new List<Clases.Cliente>();
           

            // el segundo listaClientes hace referencia a la clase lista creada
            listaClientes = Listas.listaClientes;
            listaCoches = Listas.listaCoches;

            dataGridPanel.ItemsSource = listaClientes;

        }
 
        public int ObtenerPrimerIdDisponible()
        {
            int idDisponible = 1;
            foreach (Cliente1 cliente in listaClientes)
            {
                if (cliente.Id == idDisponible)
                {
                    idDisponible++;
                }
                else
                {
                    break;
                }
            }
            return idDisponible;
        }
        private void botonInsertar_Click(object sender, RoutedEventArgs e)
        {   
            int idNuevoCliente = int.Parse(textBoxId.Text);
            bool idExiste = false;
            foreach (Cliente1 cliente in listaClientes)
            {

                if (cliente.Id == idNuevoCliente)
                {
                    idExiste = true;

                    _ = MessageBox.Show(messageBoxText: "Este id ya esta usado.\rEl siguiente Id en estar disponible es: " + ObtenerPrimerIdDisponible());
                    textBoxId.Text = ObtenerPrimerIdDisponible().ToString();
                    break;
                }
            }

            if (!idExiste)
            {
                listaClientes.Add(new Cliente1(idNuevoCliente,
                                                         textBoxNombre.Text,
                                                         textBoxApellido.Text,
                                                         textBoxDNI.Text,
                                                         int.Parse(textBoxTelefono.Text),
                                                         textBoxDireccion.Text,
                                                         textBoxCorreo.Text));

                listaClientes = new ObservableCollection<Cliente1>(listaClientes.OrderBy(c => c.Id)); // Ordenar por ID
                dataGridPanel.ItemsSource = listaClientes; // Asignar la colección ordenada al ItemsSource del DataGrid
                MessageBox.Show("Cliente Insertado correctamente!", "Información");

             // Limpiar los campos de texto
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";
            textBoxCorreo.Text = "";
            }

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
            foreach (Cliente1 cliente in listaClientes)
            {
                if (cliente.Id == idClienteAActualizar)
                {
                    // Verificar si se han realizado cambios en los campos
                    bool cambiosRealizados = false;
                    if (cliente.Nombre != textBoxNombre.Text)
                    {
                        cliente.Nombre = textBoxNombre.Text;
                        cambiosRealizados = true;
                    }
                    if (cliente.Apellidos != textBoxApellido.Text)
                    {
                        cliente.Apellidos = textBoxApellido.Text;
                        cambiosRealizados = true;
                    }
                    if (cliente.Dni != textBoxDNI.Text)
                    {
                        cliente.Dni = textBoxDNI.Text;
                        cambiosRealizados = true;
                    }
                    if (cliente.Telefono != int.Parse(textBoxTelefono.Text))
                    {
                        cliente.Telefono = int.Parse(textBoxTelefono.Text);
                        cambiosRealizados = true;
                    }
                    if (cliente.Direccion != textBoxDireccion.Text)
                    {
                        cliente.Direccion = textBoxDireccion.Text;
                        cambiosRealizados = true;
                    }
                    if (cliente.Email != textBoxCorreo.Text)
                    {
                        cliente.Email = textBoxCorreo.Text;
                        cambiosRealizados = true;
                    }

                    if (cambiosRealizados)
                    {
                        clienteEncontrado = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se puede modificar porque todos los campos son iguales.", "Información");
                        return;
                    }
                }
            }

            if (clienteEncontrado)
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Información");
                dataGridPanel.ItemsSource = listaClientes;
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
            foreach (Cliente1 cliente in listaClientes)
            {
                if (cliente.Id == idClienteABorrar)
                {
                    listaClientes.Remove(cliente);
                    clienteEncontrado = true;
                    break;
                }
            }

            if (clienteEncontrado)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Información");
                dataGridPanel.ItemsSource = listaClientes;
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


            //abd.borrarCliente(int.Parse(textBoxId.Text));
            //MessageBox.Show("Cliente borrado correctamente!", "Información");

        }

        // Método para verificar si el DNI del cliente es válido y existe en la lista de clientes
        private bool verificarCliente(string dni)
        {
            foreach (Cliente1 cliente in listaClientes)
            {
                if (cliente.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }
        private void botonInsertar_Coche_Click(object sender, RoutedEventArgs e)
        {
            // Crear un nuevo objeto Coche con los valores de los campos de texto
            Coche1 nuevoCoche = new Coche1(textBoxDniCoche.Text, textBoxMatricula.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxColor.Text);

            // Verificar si la matrícula ya existe en la lista de coches
            bool existeMatricula = false;
            foreach (Coche1 coche in listaCoches)
            {
                if (coche.Matricula == nuevoCoche.Matricula)
                {
                    existeMatricula = true;
                    MessageBox.Show("La matrícula " + coche.Matricula + " ya existe. Introduce otra matrícula.","Error");
                    break;
                }
            }

            // Verificar si el DNI del cliente es válido y existe en la lista de clientes
            bool existeCliente = verificarCliente(nuevoCoche.Dni);
            if (!existeCliente)
            {
                MessageBox.Show("El DNI " + nuevoCoche.Dni + " no es válido o no pertenece a ningún cliente registrado.","Error");
            }

            // Si la matrícula y el DNI del cliente son válidos, agregar el nuevo coche a la lista de coches y mostrar mensaje de éxito
            if (!existeMatricula && existeCliente)
            {
                listaCoches.Add(nuevoCoche);
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
        Coche1 cocheActualizar = null;
        foreach (Coche1 coche in listaCoches)
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
            MessageBox.Show("La matrícula " + matriculaActualizar + " no existe en la lista de coches.","Error");
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
           Coche1 cocheExistente = listaCoches.FirstOrDefault(c => c.Matricula == matricula);

            if (cocheExistente == null)
            {
                MessageBox.Show("El coche no existe. Por favor, introduce una matrícula válida.", "Error");
                return;
            }

            // Borrar el coche de la colección
            listaCoches.Remove(cocheExistente);

            

            MessageBox.Show("Coche borrado correctamente.", "Información");
        }

        private void dataGridPanel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cliente1 cliente= (Cliente1)dataGridPanel.SelectedItem;
            textBoxId.Text = cliente.Id.ToString();
            textBoxNombre.Text = cliente.Nombre;
            textBoxApellido.Text = cliente.Apellidos;
            textBoxDNI.Text = cliente.Dni;
            textBoxTelefono.Text = cliente.Telefono.ToString();
            textBoxDireccion.Text = cliente.Direccion;
            textBoxCorreo.Text = cliente.Email;
        }

        private void textBoxIntroduceMatricula_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxIntroduceId.IsEnabled = false;
        }

        private void textBoxIntroduceDNI_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxIntroduceMatricula.IsEnabled = false;
        }

        private void botonBuscar_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxIntroduceMatricula.IsEnabled)
            {
                int contador = 0;
                foreach(Coche1 c in listaCoches)
                {
                    if(c.Matricula.Equals(textBoxIntroduceMatricula.Text))
                    {
                        contador++;
                        textBoxDniCoche.Text = c.Dni;
                        textBoxModelo.Text = c.Modelo;
                        textBoxMarca.Text = c.Marca;
                        textBoxMatricula.Text = c.Matricula;
                        textBoxColor.Text = c.Color;
                        break;
                    }
                    
                }
                if(contador== 0)
                {
                MessageBox.Show("No se encontro ningun coche en la base de datos con esa matricula.","Error");
                }
            }
            else
            {
                int contador = 0;
                foreach(Cliente1 cliente in listaClientes) 
                { 
                    if(cliente.Id.ToString().Equals(textBoxIntroduceId.Text.ToString()))
                    {
                        contador++;
                        textBoxId.Text = cliente.Id.ToString();
                        textBoxNombre.Text = cliente.Nombre;
                        textBoxApellido.Text = cliente.Apellidos;
                        textBoxDNI.Text = cliente.Dni;
                        textBoxTelefono.Text = cliente.Telefono.ToString();
                        textBoxDireccion.Text = cliente.Direccion;
                        textBoxCorreo.Text = cliente.Email;
                    }
                }
                if (contador == 0)
                {
                    MessageBox.Show("No se encontro ningun cliente en la base de datos con ese Id.", "Error");
                }
            }

            textBoxIntroduceMatricula.IsEnabled = true;
            textBoxIntroduceMatricula.Text = "";
            textBoxIntroduceId.IsEnabled = true;
            textBoxIntroduceId.Text = "";
        }
    }
}
