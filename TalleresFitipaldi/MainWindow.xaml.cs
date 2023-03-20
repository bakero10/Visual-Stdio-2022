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


namespace TalleresFitipaldi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PaginaReparacion paginaReparacion;
        PantallaPrincipal pagina;
        public MainWindow()
        {
            InitializeComponent();
            pagina= new PantallaPrincipal();  
            paginaReparacion= new PaginaReparacion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {        
                if (textboxUsuario.Text.Equals("Pepe"))
                {
                    MessageBox.Show("Usuario y contraseña correcto!", "Confirmado!");
                    pagina.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto!", "Error");
                } 
        }
    }
}
