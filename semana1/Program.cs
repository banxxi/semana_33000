using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera;//detenimiento de consola
            Console.Write("ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("ingrese su carrera:");
            carrera = Console.ReadLine();
            Console.WriteLine($"\n{nombre},bienvenido al curso"+ $"de fundamentos de algoritmo {carrera}");
        }
        static void ejer2()
        {
            Console.WriteLine("\"hellen\"");
        }
        static void ejer3()
        {
            Console.Write("ingrese numero 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese numero 1:");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("suma: " + (num1 + num2));
            Console.WriteLine("resta: " + (num1 - num2));
            Console.WriteLine("multiplicacion: " + (num1 * num2));
            Console.WriteLine("division: " + divi);
        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }
    }
}
