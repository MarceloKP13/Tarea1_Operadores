using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Actividad
{
    internal class Program
    {
        //Desarrollar un programa que muestre un ejemplo de cómo se puede declarar
        //una variable con un tipo de dato específico en C#.
        static void Main(string[] args)
        {
            // Declarar una variable de tipo entero (int)
            int edad = 22;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"La edad es: {edad}");

            // Declarar una variable de tipo double para almacenar un número con decimales
            double estatura = 1.69;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"La altura es: {estatura} metros");

            // Declarar una variable de tipo cadena (string)
            string nombre = "MARCELO";

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"Mi nombre es: {nombre}");

            // Declarar una variable booleana (bool)
            bool Trabajador = true;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"¿Trabaja? {Trabajador}");

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
