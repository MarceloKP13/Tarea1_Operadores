using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Actividad
{
    internal class Program
    {
        //Escribir un programa que muestre un ejemplo de cómo se puede modificar el valor de una variable en C#.
        static void Main(string[] args)
        {
            // Declarar una variable normal
            int variable = 15;

            // Mostrar el valor inicial de la variable
            Console.WriteLine($"El valor inicial de la variable número es: {variable}\n");

            // Modificar el valor de la variable
            variable = 35;

            // Mostrar el valor modificado de la variable
            Console.WriteLine($"El valor modificado de la variable número es: {variable}\n");

            // Modificar el valor de la variable de nuevo
            variable = variable + 100;

            // Mostrar el valor nuevamente modificado de la variable
            Console.WriteLine($"El valor nuevamente modificado de la variable número es: {variable}");

            Console.ReadKey();
        }
    }
}
