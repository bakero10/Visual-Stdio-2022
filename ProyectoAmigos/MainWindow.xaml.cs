using ProyectoAmigos.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoAmigos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        /// <DIFERENCIA>
        /// La diferencia entre list y observable son los cambios dinamicos los cambios se ejecutan automaticos -->
        /// </summary>
        // List<Persona> personas;
        ObservableCollection<Persona> personas;
        public MainWindow()
        {
            InitializeComponent();
           // personas = new List<Persona>();
            personas= new ObservableCollection<Persona>();
            personas.Add(new Persona("Miguel", "Desarrollo"));
            personas.Add(new Persona("Bakero", "Dam2"));
            personas.Add(new Persona("Pepito", "Ternera"));
            personas.Add(new Persona("Roberto", "Depaco"));
            personas.Add(new Persona("Escriba", "Pest"));
            personas.Add(new Persona("Potis", "Potañez"));
            lstPersonas.ItemsSource = personas;
            dgAlumnos.ItemsSource = personas;
        }

        private void btnAnnadir_Click(object sender, RoutedEventArgs e)
        {
            String cadena = "Esta seguro de introducir a "+txtNombre.Text+" - "+txtApellido.Text;
            String caption = "Proceso de validación";

            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debes rellenar los campos", "Error");
            }
            else
            {
                MessageBoxResult dialogResult = MessageBox.Show(cadena, caption, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    Persona p = new Persona(txtNombre.Text, txtApellido.Text);
                    personas.Add(p);
                    txtNombre.Clear();
                    txtApellido.Clear();
                }
                else
                {
                    MessageBox.Show("Arreglalo", "Arreglalo");

                }
            }
        }

        private void btnMejorAmigo_Click(object sender, RoutedEventArgs e)
        {
            object[] itemsToRemove = new object[lstPersonas.SelectedItems.Count];
            lstPersonas.SelectedItems.CopyTo(itemsToRemove, 0);

            foreach (object item in itemsToRemove)
            {
                lstPersonas.Items.Remove(item);
                lstMejoresAmigos.Items.Add(item);
            }

        }

        private void btnQuitarMejor_Click(object sender, RoutedEventArgs e)
        {
            if (lstMejoresAmigos.SelectedItems.Count != 0)
            {
                foreach (Persona p in lstMejoresAmigos.SelectedItems)
                {
                    personas.Remove(p);
                }
                
            }

        }

        private void btnActualiza_Click(object sender, RoutedEventArgs e)
        {
            personas.ElementAt(0).Nombre = "Raúl";
            
        }
    }
}
