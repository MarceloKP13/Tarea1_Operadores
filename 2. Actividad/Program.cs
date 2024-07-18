using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Actividad
{
    internal class Program
    {
        //2. Crear un programa que solicite al usuario dos números enteros y
        //luego muestre el mayor y el menor de los dos números.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
                Console.WriteLine($"El número menor es: {numero2}");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
                Console.WriteLine($"El número menor es: {numero1}");
            }
            else
            {
                Console.WriteLine("Ambos numero son iguales:");
                Console.WriteLine($"{numero1} = {numero2}");
            }

            Console.ReadKey();
        }
    }
}
