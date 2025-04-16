using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese sus 4 notas para generar su promedio");
            float n1, n2, n3, n4;
            Console.WriteLine("Ingrese la primera nota(10%): ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota(20%): ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota(30%): ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota(40%): ");
            n4 = float.Parse(Console.ReadLine());

            double promedio;

            promedio = ((n1*0.10) + (n2*0.20) + (n3*0.30) + (n4*0.40));
            Console.WriteLine("Promedio: " + promedio);

            if (promedio >= 11.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Estás aprobado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Estás reprobado"); 
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
