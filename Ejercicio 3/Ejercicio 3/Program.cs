Cliente cliente1 = new Cliente("Juan", 1141565642, "Calle Falsa 123", "juan@cliente.com", false);
Console.WriteLine(cliente1);

Cliente cliente2 = new Cliente("Mercedez", 1151675837, "Calle Falsa 723", "mercedez@cliente.com", true);
Console.WriteLine("Nombre: " + cliente2.Nombre);
Console.WriteLine("Telefono: " + cliente2.Tel);
Console.WriteLine("Direccion: " + cliente2.Direc);
Console.WriteLine("Email: " + cliente2.Email);
Console.WriteLine("¿Es nuevo cliente? : " + cliente2.Nuevo);

public struct Cliente
{
    public Cliente(string nombre, int tel, string direc, string email, bool nuevo)
    {
        Nombre = nombre;
        Tel = tel;
        Direc = direc;
        Email = email;
        Nuevo = nuevo;
    }
    public string Nombre { get; }
    public int Tel { get; }
    public string Direc { get; }
    public string Email { get; }
    public bool Nuevo { get; }


    public override string ToString() => $"({Nombre}, {Tel}, {Direc}, {Email}, {Nuevo})";
}