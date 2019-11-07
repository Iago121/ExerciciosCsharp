using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcao, numero1, numero2, soma, raiz;

            Console.Write("1 - somar \n 2 - raíz quadrada \nDigite: ");
            opcao = Convert.ToDouble(Console.ReadLine());

            switch (opcao)
            { 
                case 1:
                    Console.Write("Digite o primeiro numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    soma = numero1 + numero2;
                    Console.WriteLine($"O resultado da soma é " + soma);
                    break;

                case 2:
                    Console.Write("Digite o número: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    raiz = Math.Sqrt(numero1);

                    Console.WriteLine($"A raíz quadrada de {numero1} é aproximadamente {raiz.ToString("F2")}");
                    break;
                default:
                    Console.WriteLine("Entrada inválida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
