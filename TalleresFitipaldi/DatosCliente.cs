using System;

public class DatosCliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string DNI { get; set; }
    public int Telefono { get; set; }
    public string Dirección { get; set; }
    public string Correo { get; set; }

    public DatosCliente(int id, string nombre, string apellidos, string dni, int telefono, string dirección, string correo)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Apellidos = apellidos;
        this.DNI = dni;
        this.Telefono = telefono;
        this.Dirección = dirección;
        this.Correo = correo;
    }
}

