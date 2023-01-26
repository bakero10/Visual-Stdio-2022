using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace holaMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblHolaMundo.Content = "Hola Mundo";
            lblHolaMundo.Visibility = Visibility.Hidden;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            
            if(lblHolaMundo.Visibility == Visibility.Visible)
            {
                btnMostrar.Content = "Mostrar";
                lblHolaMundo.Visibility = Visibility.Hidden;
            }
            else
            {
                btnMostrar.Content = "Ocultar";
                btnMostrar.Visibility = Visibility.Visible;
            }
        }
    }
}
