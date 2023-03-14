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
    /*
    private MySqlConnectionStringBuilder myCSB;
    private MySqlConnection myConnection;
    private DataGrid myGrid;
    */
    /*
    public AccesoBDatos() {
        myCSB = new MySqlConnectionStringBuilder();
        myCSB.Host = "localhost";
        myCSB.UserId = "root";
        myCSB.Password = "nacarino";
        myCSB.Database = "tallerfitipaldi";
        myConnection = new MySqlConnection(myCSB.ConnectionString);
        myConnection.Open(); 
    }
    */
    /*
    public void insertarCliente(int id, String nombre, String apellidos, String dni, int telefono, String direccion, String correo)
    {
        String sql = "INSERT INTO cliente VALUES(" + id + ",'" + nombre + "','" + apellidos + "','" + dni + "'," + telefono + ",'" + direccion + "','" + correo + "')";
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    */
    /*
    public void borrarCliente(int id)
    {
        String sql = "DELETE FROM cliente WHERE idCliente = " + id;
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    */
    /*
    public void actualizarCliente(int id, String nombre, String apellidos, String dni, int telefono, String direccion, String correo)
    {
       
        String sql = "UPDATE cliente SET Nombre = '"+nombre+"', Apellidos = '"+apellidos+"', DNI = '"+dni+"',Telefono="+telefono+", Direccion='"+direccion+"',Correo='"+correo+"' WHERE idCliente = "+id;
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    */
    /*
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
