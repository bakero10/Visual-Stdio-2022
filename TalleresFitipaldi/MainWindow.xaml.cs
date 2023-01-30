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
        PaginaPrincipla pagina;
        public MainWindow()
        {
            InitializeComponent();
            pagina= new PaginaPrincipla();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((!textboxUsuario.Text.Equals("")))
            {
                if (textboxUsuario.Text.Equals("Pepe") && textPassword.Equals("pepe"))
                {
                    MessageBox.Show("Usuario y contraseña correcto!");
                    pagina.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto!");
                }
            }
            else
            {
                MessageBox.Show("Debes introducir los campos usuario y contraseña para entrar.", "Error.");
            }

        }
    }
}
