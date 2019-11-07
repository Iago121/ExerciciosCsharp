using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioBase,salarioImposto, salarioGratificaçao, calcular;
            double imposto = 0.07;
            double gratificaçao = 0.05;

            Console.Write("Salário Funcionário: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());

            salarioGratificaçao = salarioBase * gratificaçao;
            Console.WriteLine("Salário com gratificação é {0:C}", salarioGratificaçao);

            salarioImposto = salarioBase * imposto;
            Console.WriteLine("Salário com Imposto é: {0:c}", salarioImposto);


            calcular = salarioBase + salarioImposto + salarioGratificaçao ;
            Console.WriteLine("Sua remunersção é: {0:c}", calcular);

            Console.ReadLine();
        }
    }
}
