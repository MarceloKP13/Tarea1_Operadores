using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Actividad
{
    internal class Program
    {
        //Escribir un programa que calcule el área y el perímetro de un cuadrado.
        //El programa debe solicitar al usuario la longitud de un lado del cuadrado.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud de un lado del cuadrado (en cm): ");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * lado;
            double perimetro = 4* lado;

            Console.WriteLine($"El área del cuadrado es: {area}cm");
            Console.WriteLine($"El perimetro del cuadrado es: {perimetro}cm");

            Console.ReadKey();
        }
    }
}
