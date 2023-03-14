using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Windows.Documents;

namespace TalleresFitipaldi.MyConexion
{
    public class AccesoBDatos
    {

        private MySqlConnectionStringBuilder myCSB;
        private MySqlConnection myConnection;




        public AccesoBDatos()
        {
            /*
            myCSB = new MySqlConnectionStringBuilder();
            myCSB.Host = "localhost";
            myCSB.UserId = "root";
            myCSB.Password = "nacarino";
            myCSB.Database = "tallerfitipaldi";
            myConnection = new MySqlConnection(myCSB.ConnectionString);
            myConnection.Open(); 
            */
        }

        public void insertarCliente(int id, string name, string country, string district, int population)
        {
            /*
            String sql ="INSERT INTO city VALUES("+id+","+name+","+country+","+district+","+population)"
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = sql;
            MessageBox.Show(sql);
            command.ExecuteNonQuery();
            myConnection.Close();
            */

        }

        public void borrarCliente(int id)
        {
            /*
            String sql = "DELETE FROM city WHERE id = " + id;
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = sql;
            MessageBox.Show(sql);
            command.ExecuteNonQuery();
            myConnection.Close();
            */
        }
        public void actualizarCliente(int id)
        {

        }

        /*
        public DataTable rellenarDataGrid()
        {
            String sql = "SELECT * FROM cliente";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, myConnection))
            {
                // Crea un objeto DataTable y llena los datos utilizando el objeto SqlDataAdapter
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;

        public List<DatosCliente> Rellenar(){

           List<DatosCliente> lista = new List<DatosCliente>();


            DatosCliente dc = new DatosCliente(1,"José Miguel","Andrés Pérez","18049608j",699687316,"Julio Alejandro Castro Cardus Nº12","bakero__10@hotmail.com");
            DatosCliente dc1 = new DatosCliente(1, "María", "Castro Bolea", "18053265l", 666333222, "Julio Alejandro Castro Cardus Nº12", "mariacb01@hotmail.com");
            lista.Add(dc);lista.Add(dc1);
            myGrid.ItemsSource = Rellenar();
            return lista;
        }
        */

    }
}