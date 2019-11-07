using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;

            Console.Write("Primeira Nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Terceira Nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Total da nota é: {nota1 + nota2 + nota3 / 3}", ("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
