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
        myCSB.Password = "root";
        myCSB.Database = "WORLD";
        myConnection = new MySqlConnection(myCSB.ConnectionString);
        myConnection.Open(); 
    }

    public void insertarCliente(int id,String name,String country,String district,int population)
        {
        String sql ="INSERT INTO city VALUES("+id+","+name+","+country+","+district+","+population)"
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
    public void borrarCliente(int id)
    {
        String sql = "DELETE FROM city WHERE id = " + id;
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = sql;
        MessageBox.Show(sql);
        command.ExecuteNonQuery();
        myConnection.Close();
    }
}
