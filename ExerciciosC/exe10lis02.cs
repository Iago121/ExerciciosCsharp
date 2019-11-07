using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe10lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int escrituario, secretario, caixa, gerente, opcao;
            int salaEscri = 1000, salaSecre = 1200, salaCai = 1100, salaGere = 10000;

            Console.WriteLine("Digite o cargo:\n 1 \n 2 \n 3 \n 4 \n 5");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Escriturário - Salário atual $1.000,00");

                    escrituario = salaEscri * 50 / 100;
                    Console.WriteLine($"O aumento será de: {escrituario}.\n O valor total será: {escrituario + salaEscri} Reais");

                    break;

                case 2:
                    Console.WriteLine("Secretário - Salário atual $1.200,00");

                    secretario = salaSecre * 35 / 100;
                    Console.WriteLine($"O aumento será de: {secretario}.\n O valor total será: {secretario + salaSecre} Reais");

                    break;

                case 3:
                    Console.WriteLine("Caixa - Salário atual $1.100,00");

                    caixa = salaCai * 20 / 100;
                    Console.WriteLine($"O aumento será de: {caixa}.\n O valor total será: {caixa + salaCai} Reais");

                    break;

                case 4:
                    Console.WriteLine("Gerente - Salário atual $10.000,00");

                    gerente = salaGere * 10 / 100;
                    Console.WriteLine($"O aumento será de: {gerente}.\n O valor total será: {gerente + salaGere} Reais");

                    break;

                case 5:
                    Console.WriteLine("Diretor - Salário atual $20.000,00");

                    break;

                default:

                    Console.WriteLine("Entrada Inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
