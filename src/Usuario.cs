namespace src;

public class Usuario
{
    public Usuario(long cedula, string nombre)
    {
        Cedula = cedula;
        Nombre = nombre;
    }

    public long Cedula { get; set; }

    public string Nombre { get; set; }

}
