using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digite o valor em pés: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor {numero} em polegadas é: {numero * 12}.");
            Console.WriteLine($"O valor {numero} em jardas é: {numero / 3}.");
            Console.WriteLine($"O valor {numero} em milhas é: {numero / 3 / 1760}.");

            Console.ReadKey();
        }
    }
}
