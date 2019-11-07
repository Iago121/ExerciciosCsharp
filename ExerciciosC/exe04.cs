using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento, calculo;

            Console.Write("Informe o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do aumento: ");
            aumento = Convert.ToDouble(Console.ReadLine());

            calculo = salario * aumento / 100;
            Console.WriteLine($"O aumento será de: {calculo} e o total do seu salario é: {calculo + salario}");
            Console.ReadKey();
        }
    }
}
