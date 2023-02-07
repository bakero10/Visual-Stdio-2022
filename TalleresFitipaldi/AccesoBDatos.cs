using Devart.Data.MySql;
using System;
using System.Windows;

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
}
