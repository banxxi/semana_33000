using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
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
            Console.Write("ingrese el numero decimal:");
            double num = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);
            double redo = Math.Round(num, 2);
            double cubo = Math.Pow(num, 3);
            double cubica = Math.Pow(num, 1 / 3);

            Console.WriteLine("raiz cauadrada: " + raiz);
            Console.WriteLine("redondeado:" + redo);
            Console.WriteLine("elevado a 3:" + cubo); 
            Console.WriteLine("raiz cubica: " +cubica);
        }
        static void ejer5()
        {
            Console.Write("ingrese un numero:");
            string num = Console.ReadLine();
            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("resto: " + (entero % 2));
            Console.WriteLine("decimal: " + (deci/3 ));
        }
        static void ejer6()
        {

        }
    }
}
