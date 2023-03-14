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

namespace TalleresFitipaldi
{
  
    public partial class PaginaPrincipal : Window
    {
        List<cliente> listaClientes;
        cliente paginaCliente;

        public PaginaPrincipal()
        {
            InitializeComponent();
            paginaCliente= new cliente();
            
        }
        
        private void botonClientes_Click(object sender, RoutedEventArgs e)
        {
            listaClientes = new List<cliente>();
            cliente c1 = new cliente(1, "José Miguel", "Andrés Pérez", "18049608j", 699687316, "Julio Alejandro Castro Cardus 12 5A", "bakero__10@hotmail.com");
            cliente c2 = new cliente(2, "Raúl", "Solano Berdiel", "18049609R", 699687314, "Tenerias 12", "Rasobe@hotmail.com");
            cliente c3 = new cliente(3, "Santiago", "Ramirez Arenas", "18049621j", 699687333, "Pasaje Burgos 23 5E", "SantiFans@hotmail.com");
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);

            foreach (cliente cliente2 in listaClientes)
            {
                
                Debug.WriteLine(cliente2.ToString());
            }
            paginaCliente.Show();
            this.Close();
        }

        private void botonReparaciones_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
