using Devart.Data.MySql;
using System;
using System.Windows;

public class AccesoBDatos
{
    private MySqlConnection myConn;
	public AccesoBDatos()
	{        
            myConn = new MySqlConnection();
            myConn.ConnectionString = "User Id=root;Password=root;Host=127.0.0.1;";
            myConn.Open();
            MessageBox.Show("Conexion realizada con exito!");
    }

     
        public void desconectar()
        {
            myConn.Close();
        
    }
}
