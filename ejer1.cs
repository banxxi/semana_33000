using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_4
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese una edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("eres negro "); 
            }
            else
            {
                if (edad <=64)
                {
                    Console.WriteLine("eres negro");
                }
                else
                {
                    Console.WriteLine("pinga ");
                }
            }
            Console.ReadKey();

        }
    }
}
