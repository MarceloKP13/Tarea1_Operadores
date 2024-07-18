using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tarea.Operadores
{
    internal class Program
    {
        //1. Escribir un programa que declare variables para almacenar el nombre,
        //la edad y la estatura de una persona. Asignar valores a las variables y
        //luego mostrarlos en la consola.

        static void Main(string[] args)
        {
            string nombre = "Marcelo Torres";
            int edad = 22;
            double estatura = 169;

            Console.WriteLine("Un gusto saludarte " + nombre);
            Console.WriteLine("Tienes " + edad + " años, cierto?");
            Console.WriteLine($"Al parecer mides {estatura} centimetros.");
            Console.ReadKey();
        }
    }
}
