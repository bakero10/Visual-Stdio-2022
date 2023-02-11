using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Windows.Documents;


public class AccesoBDatos
{

    private MySqlConnectionStringBuilder myCSB;
    private MySqlConnection myConnection;

    public AccesoBDatos() {
        myCSB = new MySqlConnectionStringBuilder();
        myCSB.Host = "localhost";
        myCSB.UserId = "root";
        myCSB.Password = "nacarino";
        myCSB.Database = "tallerfitipaldi";
        myConnection = new MySqlConnection(myCSB.ConnectionString);
        myConnection.Open(); 
    }

    public void insertarCliente(int id, String nombre, String apellidos, String dni, int telefono, String direccion, String correo)
    {
        String sql = "INSERT INTO cliente VALUES(" + id + ",'" + nombre + "','" + apellidos + "','" + dni + "'," + telefono + ",'" + direccion + "','" + correo + "')";
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    public void borrarCliente(int id)
    {
        String sql = "DELETE FROM cliente WHERE idCliente = " + id;
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }

    public void actualizarCliente(int id, String nombre, String apellidos, String dni, int telefono, String direccion, String correo)
    {
       
        String sql = "UPDATE cliente SET Nombre = '"+nombre+"', Apellidos = '"+apellidos+"', DNI = '"+dni+"',Telefono="+telefono+", Direccion='"+direccion+"',Correo='"+correo+"' WHERE idCliente = "+id;
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    public DataTable rellenarDataGrid()
    {
        String sql = "SELECT * FROM cliente";
        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, myConnection))
        {
            // Crea un objeto DataTable y llena los datos utilizando el objeto SqlDataAdapter
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
    }

}
