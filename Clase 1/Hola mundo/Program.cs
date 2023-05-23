// Forma vieja de hacerlo (.NET 5.0)
/*
using System;

namespace ConsoleApp2 {
    internal class Program{
        static void Main (string[] args){
            Console.WriteLine("Hola, mundo");
        }
    }
} 
*/

// Forma acutal de hacerlo (.NET 6.0 en adelante)
Console.WriteLine("Hola, mundo");


string nombre = "Tomy";
Console.WriteLine("Hola, " + nombre);

Console.WriteLine("Hola como te llamas?");
string nombre2 = Console.ReadLine();
Console.WriteLine("Hola, " + nombre2);