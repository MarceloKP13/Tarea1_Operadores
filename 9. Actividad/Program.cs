using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Actividad
{
    //Crear un programa que declare una variable constante y una variable normal.
    //Asignar valores a ambas variables y mostrarlas en la consola.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilizar la constante PI de la clase Math
            const double PI = Math.PI;

            // Declarar una variable normal
            double radio = 5.0;

            // Mostrar los valores en la consola
            Console.WriteLine($"El valor de la constante PI es: {PI}\n");
            Console.WriteLine($"El valor de la variable radio es: {radio}");

            Console.ReadKey();
        }
    }
}
