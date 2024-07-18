using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Actividad
{
    internal class Program
    {
        //Crear un programa que muestre un ejemplo de cómo se puede inicializar
        //una variable con un valor predeterminado en C#.
        static void Main(string[] args)
        {
            // Declarar e inicializar una variable entera (int) con valor predeterminado
            int numero = 85;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"El valor de la variable numero es: {numero}");

            // Declarar e inicializar una variable double con valor predeterminado
            double precio = 19.99;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"El precio del reloj: ${precio}");

            // Declarar e inicializar una variable string con valor predeterminado
            string nombre = "Marcelo";

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"Hola, soy {nombre}");

            // Declarar e inicializar una variable booleana con valor predeterminado
            bool esEstudiante = true;

            // Mostrar el valor de la variable en la consola
            Console.WriteLine($"¿Estudia? {esEstudiante}");

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
