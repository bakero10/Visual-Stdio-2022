using System;
using System.Windows;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

public class Conexion
{

    private MySqlConnection myConn;

    public Conexion()
	{

        myConn = new MySqlConnection();
        myConn.ConnectionString = "User Id=root;Password=nacarino;Host=127.0.0.1;";
        myConn.Open();

        MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();
        myCSB.Port = 3306;
        myCSB.UserID = "root"; 
        myCSB.Password = "root"; 
        myCSB.Database = "tallerfitipaldi"; 
        myCSB.ConnectionTimeout = 30;
        MySqlConnection myConnection = new MySqlConnection(myCSB.ConnectionString);
        myConnection.Open();
        MySqlCommand command = myConnection.CreateCommand();
        command.CommandText = "select * from cliente where idCliente=1";
        String cadena = ""; String resultado = "";

        MySqlDataReader reader = command.ExecuteReader();
        for (int i = 0; i < reader.FieldCount; i++)
        {
            cadena += reader.GetName(i).ToString() + "\t";
        }

        while (reader.Read())
        {
            // printing the table content
            for (int i = 0; i < reader.FieldCount; i++)
                resultado += reader.GetValue(i).ToString() + "\t";
        }

        MessageBox.Show(cadena); 
        MessageBox.Show(resultado);

    }

    public void desconectar()
    {
        myConn.Close();
    }
}
