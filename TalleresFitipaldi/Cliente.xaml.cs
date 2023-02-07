using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
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
using Devart.Data.MySql;


namespace TalleresFitipaldi
{

    public partial class Cliente : Window
    {
        private AccesoBDatos abd;
        public Cliente()
        {
            InitializeComponent();
            abd= new AccesoBDatos();
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
            abd.insertarCliente(int.Parse(textBoxId.Text)
                                tex);
        }

        private void botonActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {
          
            abd.borrarCliente(int.Parse(textBoxId.Text));
            MessageBox.Show("Cliente borrado correctament!","Información");
        }
    }
}
