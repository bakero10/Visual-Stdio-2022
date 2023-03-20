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
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

using DevExpress.XtraPrinting;
using System.Data;
using DevExpress.DataAccess.ObjectBinding;

namespace TalleresFitipaldi
{
    /// <summary>
    /// Lógica de interacción para PaginaReparacion.xaml
    /// </summary>
    public partial class PaginaReparacion : Window
    {

        ObservableCollection<Cliente1> listClientes;
        ObservableCollection<Coche1> listCoches;
        public PaginaReparacion()
        {
            InitializeComponent();
            
            listCoches = Listas.listaCoches;
            listClientes= Listas.listaClientes;

            cochesListView.ItemsSource = listCoches;


        }

        private void cochesListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ObjetosVer.cocheVisto = (Coche1)cochesListView.SelectedItem;
            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.DataSource = cochesListView.SelectedItem;
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1, 21);
            Coche1 cocheSeleccionado = (Coche1)cochesListView.SelectedItem;
            foreach (Cliente1 cliente in listClientes)
            {
                if (cliente.Dni.Equals(cocheSeleccionado.Dni))
                {
                    ObjetosVer.clienteVisto = cliente;
                    objectDataSource.DataSource = cliente;
                    textBoxVehiculoCliente.Text = ("El cliente: " + cliente.Nombre + " " + cliente.Apellidos + "\rCon el Vehiculo: " + cocheSeleccionado.Marca + " - " + cocheSeleccionado.Modelo + " - " + cocheSeleccionado.Matricula + " - " + cocheSeleccionado.Color+
                        "\rEl total de horas realizadas en la reparacion es de: "+numeroAleatorio);
                   
                }
            }
        }

        private void botonInforme_Click(object sender, RoutedEventArgs e)
        {

            // Crea una instancia del objeto ReportPrintTool
           // ReportPrintTool printTool = new ReportPrintTool(myReport);


        }
    }
}
