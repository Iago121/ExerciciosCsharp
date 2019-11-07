using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, peso1, nota2, peso2, nota3, peso3, calculo;

            Console.Write("Informe a nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o Peso: ");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o Peso: ");
            peso2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o Peso: ");
            peso3 = Convert.ToDouble(Console.ReadLine());

            calculo = peso1 * nota1 + peso2 * nota2 + peso3 + nota3 / nota1 + nota2 + nota3;
            Console.WriteLine("Sua média ponderada é: " + calculo, ("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
