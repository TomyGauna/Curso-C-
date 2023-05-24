//Ejercicio 1

/*
Console.WriteLine("Por favor escribi tu nombre.");
string nombre = Console.ReadLine();
while (string.IsNullOrWhiteSpace(nombre) == true)
{
Console.WriteLine("Por favor ingresa un nombre valido.");
nombre = Console.ReadLine();
}

Console.WriteLine("Por favor escribi tu apellido.");
string apellido = Console.ReadLine();
while (string.IsNullOrWhiteSpace(apellido) == true)
{
Console.WriteLine("Por favor ingresa un apellido valido.");
apellido = Console.ReadLine();
}

Console.WriteLine("Por favor escribi tu edad.");
int edad = Convert.ToInt32(Console.ReadLine());
while (edad <= 3 || edad > 150)
{
Console.WriteLine("Por favor ingresa una edad valida.");
edad = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Sabes programar? (Y/N)");
bool sabeProgramar = false;
char c = Console.ReadKey().KeyChar;
while (c != 'y' && c != 'Y' && c != 'n' && c != 'N')
{
Console.WriteLine("Por favor ingrese una tecla valida");
c = Console.ReadKey().KeyChar;
}
if (c == 'y' || c == 'Y')
{
sabeProgramar = true;
}
else if (c == 'n' || c == 'N')
{
sabeProgramar = false;
}
*/

//Ejercicio 2

/*
public class coche
{
    public int Puertas;
    public int Ruedas;
    public string Marca;
    public bool ITV_vigente;
    public coche(int puertas, int ruedas, string marca, bool itv)
    {
        Puertas = puertas;
        Ruedas = ruedas;
        Marca = marca;
        ITV_vigente = itv;
    }
}

public class mesa
{
    public int Peso;
    public float Largo;
    public string Material;
    public string Color;
    public mesa(int peso, float largo, string material, string color)
    {
        Peso = peso;
        Largo = largo;
        Material = material;
        Color = color;
    }
}

class program
{
    static void Main()
    {
        coche coche1 = new coche(3, 4, "Mazda", true);
        Console.WriteLine(" Coche 1: \n   Puertas = {0}\n   Ruedas = {1}\n   Marca = {2}\n   ITV Vigente = {3}", coche1.Puertas, coche1.Ruedas, coche1.Marca, coche1.ITV_vigente);
        mesa mesa1 = new mesa(30, 10, "Roble", "Madera");
        Console.WriteLine("");
        Console.WriteLine(" Mesa 1: \n   Peso = {0}\n   Largo = {1}\n   Material = {2}\n   Color = {3}", mesa1.Peso, mesa1.Largo, mesa1.Material, mesa1.Color);
    }
}
*/

//Ejercicio 3

/*
int i = Convert.ToInt32(Console.ReadLine());
int k = 18;
char c = Console.ReadKey().KeyChar;
char a = 'a';
if (i >= k) {
    Console.WriteLine("es mayor o igual a 18"); 
} else if (c == a) {
    Console.WriteLine("el char es A");
} else if (i >= k && c == a) {
    Console.WriteLine("ambas condiciones son verdaderas");
} else if (i >= k || c == a) {
    Console.WriteLine("solo una de las condiciones son verdaderas");
}
*/