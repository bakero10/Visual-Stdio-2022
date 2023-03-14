using System;
using System.Collections;
using System.Collections.Generic;
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

        public PaginaPrincipal()
        {
            InitializeComponent();
            listaClientes = new 
                List<cliente>();
        }

        private void botonClientes_Click(object sender, RoutedEventArgs e)
        {
            cliente.Show();
            this.Close();
        }
    }
}
