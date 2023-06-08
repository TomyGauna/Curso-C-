#region Ejercicio 1
Console.WriteLine("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su email: ");
string email = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cupon: ");
string cupon = Console.ReadLine();
cupon = cupon.ToLower();

float precio = 3000;
float precioFinal;

if (cupon == "descuento")
{
    precioFinal = precio * 0.75f;
    Console.WriteLine($"El precio original es de ${precio}");
    Console.WriteLine($"El precio con el descuento del 25% es de ${precioFinal}");
}
else
{
    precioFinal = precio;
    Console.WriteLine("Usted no ingreso un cupon valido");
    Console.WriteLine($"El precio es de ${precio}");
}
#endregion

#region Ejercicio 2
Console.WriteLine("0. C#");
Console.WriteLine("1. Java");
Console.WriteLine("2. C++");
Console.WriteLine("3. ASM");
Console.WriteLine("4. Python");
int leng = int.Parse(Console.ReadLine());

switch (leng)
{
    case 0:
        Console.WriteLine("El lenguaje que usted desea ustilizar es C#");
        break;
    case 1:
        Console.WriteLine("El lenguaje que usted desea ustilizar es Java");
        break;
    case 2:
        Console.WriteLine("El lenguaje que usted desea ustilizar es C++");
        break;
    case 3:
        Console.WriteLine("El lenguaje que usted desea ustilizar es ASM");
        break;
    case 4:
        Console.WriteLine("El lenguaje que usted desea ustilizar es Python");
        break;
    default:
        Console.WriteLine("No ingresaste ningun numero valido");
        break; 
}
#endregion