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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace TalleresFitipaldi
{
    
    public partial class Cliente : Window
    {
        static MySqlConnection myConn;
        public Cliente()
        {
            InitializeComponent();
            myConn = new MySqlConnection();
        }
        private void conectar()
        {

            myConn.ConnectionString = "User Id=root;Password=nacarino;Host=127.0.0.1;";
            myConn.Open();
            MessageBox.Show(myConn.ServerVersion);

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
           
        }

        private void botonActualizar_Click(object sender, RoutedEventArgs e)
        {   
            conectar();

        }
    }
}
