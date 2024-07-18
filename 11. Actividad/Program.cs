using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Actividad
{
    internal class Program
    {
        //Crear un programa que explique la importancia de usar nombres de variables descriptivos en C#.
        static void Main(string[] args)
        {
            // Ejemplo con nombres de variables no descriptivos
            int a = 10;
            int b = 20;
            int c = a + b;

            Console.WriteLine($"El valor de c es: {c}");

            // Ejemplo con nombres de variables descriptivos
            int numeroDeManzanas = 10;
            int numeroDeNaranjas = 20;
            int totalDeFrutas = numeroDeManzanas + numeroDeNaranjas;

            Console.WriteLine($"El total de frutas es: {totalDeFrutas}");

            // Explicación de la importancia de usar nombres de variables descriptivos
            Console.WriteLine("\n\tImportancia de usar nombres de variables descriptivos:");
            Console.WriteLine("1. Claridad: Facilita la comprensión del código.");
            Console.WriteLine("2. Mantenimiento: Hace que el código sea más fácil de mantener y modificar.");
            Console.WriteLine("3. Colaboración: Ayuda a otros desarrolladores a entender el propósito de las variables.");
            Console.WriteLine("4. Depuración: Facilita la localización y corrección de errores.");

            Console.ReadKey();
        }
    }
}
