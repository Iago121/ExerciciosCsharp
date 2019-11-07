using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4;

            Console.Write("Digite o Primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Qaurto número: ");
            numero4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" A soma de todos os números é: {numero1 + numero2 + numero3 + numero4}.");
            Console.ReadLine();
        }
    }
}
