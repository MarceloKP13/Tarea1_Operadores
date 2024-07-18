using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Actividad
{
    internal class Program
    {
        //Desarrollar un programa que realice las operaciones básicas aritméticas
        //(suma, resta, multiplicación y división) con dos números ingresados por el usuario.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2;
            double resta = numero1 - numero2;
            double multiplicacion = numero1 * numero2;
            double division = 0;
            if (numero2 != 0)
            {
                division = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }

            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"la diferencia es: {resta}");
            Console.WriteLine($"El producto es: {multiplicacion}");
            if (numero2 != 0)
            {
                Console.WriteLine($"El cociente es: {division}");
            }
            Console.ReadKey();
        }
    }
}
