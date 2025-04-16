using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 3 valores para desarrollar la ecuación cuadrática ax^2 + bx + c");
            int a, b, c;
            Console.WriteLine("Ingrese el valor del primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer número: ");
            c = int.Parse(Console.ReadLine());

            double x1;
            double x2;
            int discriminante;
            discriminante = (b * b) - (4 * a * c);

            if (discriminante>0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / 2 * a;
                x2 = (-b - Math.Sqrt(discriminante)) / 2 * a;

                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
            } else
            {
                if (discriminante==0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("x1: " + x1);
                } else
                {
                    Console.WriteLine("No tiene soluciones");
                }
            }
                Console.ReadKey();
        }
    }
}
