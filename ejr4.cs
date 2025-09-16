using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_4
{
    internal class ejr4
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenidos al calculo de areas");
            Console.WriteLine("1. Cuadrdo");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo");
            Console.WriteLine("\nIngrese una opcion:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("?n ingrese lado:");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea: "+ (lado * lado));
                    break;
                case 2:
                    Console.WriteLine("\nIngrese la base:");
                    int bse = int.Parse(Console.ReadLine());
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea: " + (bse * alt));
                    break;
                case 3:
                    Console.WriteLine("\nIngrese la base:");
                    int bse2 = int.Parse(Console.ReadLine());
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea: " + ((bse2 * alt2)/2));
                    break;
                case 4:
                    Console.WriteLine("\nIngrese la base:");
                    double radio = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine ("\nArea:" + Math.Round(Math.PI * (radio*radio),2));
                    break;
                default:
                    Console.WriteLine("\nOpcion Incorrecta");
                    break;
                    
            }
        }
    }
}
