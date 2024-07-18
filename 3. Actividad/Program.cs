using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Actividad
{
    internal class Program
    {
        //Desarrollar un programa que convierta grados Celsius a Fahrenheit y viceversa.
        //El programa debe solicitar al usuario la temperatura en Celsius o Fahrenheit y
        //realizar la conversión correspondiente.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la unidad de medidad que desea:\n" +
                "(C para Celsius y F para Fahrenheit)");
            char unidad = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            float temp, tempConvertida;

            if (unidad == 'C')
            {
                Console.WriteLine("Ingrese la temperatura en Celsius: ");
                temp = float.Parse(Console.ReadLine());

                tempConvertida = (temp * 9 / 5) + 32;
                Console.WriteLine($"La temperatura en Fahrenheir es: {tempConvertida} °F. ");
            }
            else if (unidad == 'F')
            {
                Console.WriteLine("Ingrese la temperatura en Fahrenheit: ");
                temp = float.Parse(Console.ReadLine());

                tempConvertida = (temp - 32) * 5 / 9;
                Console.WriteLine($"La temperatura en Celsius es: {tempConvertida} °C. ");
            }
            else {
                Console.WriteLine($"Unidad {unidad} no valida. Por favor ingrese C o F");
            }
            Console.ReadKey();
        }
    }
}
