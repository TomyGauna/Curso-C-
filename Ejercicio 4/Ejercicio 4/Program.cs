#region Ejercicio 1
Console.WriteLine("Por favor ingrese el numero que desea multiplicar (recuerde que el punto no es equivalente a la coma y por lo tanto no se registrara)");
float numIngresado1;
float resultado1;

if (!float.TryParse(Console.ReadLine(), out numIngresado1))
{
    Console.WriteLine("Ingrese un caracter valido.");
}
else
{
    int i = 1;
    while (i <= 10)
    {
        resultado1 = i * numIngresado1;
        Console.WriteLine($"{i} * {numIngresado1} = {resultado1}");
        i++;
    }
}
#endregion

#region Ejercicio 2
float numIngresado2;
int cantPositivos = 0;
int cantNegativos = 0;
int cantCeros = 0;
char salida;

do
{
    Console.WriteLine("\nPor favor ingrese un número:");
    if (!float.TryParse(Console.ReadLine(), out numIngresado2))
    {
        Console.WriteLine("Ingrese un número válido.");
    }
    else
    {
        if (numIngresado2 == 0)
        {
            cantCeros++;
        }
        else if (numIngresado2 > 0)
        {
            cantPositivos++;
        }
        else
        {
            cantNegativos++;
        }
    }

    Console.WriteLine("¿Desea terminar la cuenta? (Y/N)");
    salida = Console.ReadKey().KeyChar;
    salida = Char.ToUpper(salida);

} while (salida != 'Y');

Console.WriteLine("Cantidad de números positivos: " + cantPositivos);
Console.WriteLine("Cantidad de números negativos: " + cantNegativos);
Console.WriteLine("Cantidad de ceros: " + cantCeros);
#endregion

#region Ejercicio 3
int alto;
int ancho;
int relleno;
int cantidad;

Console.WriteLine("Por favor ingrese el alto:");
alto = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor ingrese el ancho:");
ancho = int.Parse(Console.ReadLine());
Console.WriteLine("Tiene relleno? (1 = si)(0 = no):");
relleno = int.Parse(Console.ReadLine());
Console.WriteLine("¿Qué cantidad de '*' tendrá en cada punto?:");
cantidad = int.Parse(Console.ReadLine());


for (int i = 0; i < alto; i++)
{
    for (int j = 0; j < ancho; j++)
    {
        if (relleno == 1 || i == 0 || i == (alto - 1))
        {
            for (int k = 0; k < cantidad; k++)
            {
                Console.Write("*");
            }
        }
        else if (relleno == 0)
        {
            if (j == 0 || j == (ancho - 1))
            {
                for (int k = 0; k < cantidad; k++)
                {
                    Console.Write("*");
                }
            }
            else if (j > 0 && j < (ancho - 1))
            {
                for (int k = 0; k < cantidad; k++)
                {
                    Console.Write(" ");
                }
            }
        }

    }
    Console.WriteLine();
}
#endregion