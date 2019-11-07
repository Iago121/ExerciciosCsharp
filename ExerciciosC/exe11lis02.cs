using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe11lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("Entre com o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de C: ");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine($"Não existem raizes reais para delta {delta}");
            }
            else
            {
                x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                Console.WriteLine($"X'(aproximado) = {x1.ToString("F4")}");
                x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                Console.WriteLine($"X''(aproximado) = {x2.ToString("F4")}");
            }
            Console.ReadKey();
        }
    }
}
