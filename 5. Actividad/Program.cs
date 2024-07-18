using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Actividad
{
    internal class Program
    {
        //Crear un programa que calcule el área y el volumen de una esfera.
        //El programa debe solicitar al usuario el radio de la esfera.
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Ingrese el radio de la esfera (en cm): ");
            double radio = double.Parse(Console.ReadLine());

            double area = 4 * pi * Math.Pow(radio, 2);
            double volumen = (4.0 / 3.0) * pi * Math.Pow(radio, 3);

            Console.WriteLine($"El área de la esfera es: {area}cm²");
            Console.WriteLine($"El volumen de la esfera es: {volumen}cm³");

            Console.ReadKey();
        }
    }
}