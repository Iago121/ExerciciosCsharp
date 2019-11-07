using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe09lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataString;
            DateTime data1, data2;
            int comparacao;

            Console.Write("Digite a primeira data (DD/MM/AAAA): ");
            dataString = Console.ReadLine();
            data1 = Convert.ToDateTime(dataString, System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.Write("Digite a segunda data (DD/MM/AAAA): ");
            dataString = Console.ReadLine();
            data2 = Convert.ToDateTime(dataString, System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR"));

            comparacao = DateTime.Compare(data1, data2);

            if (comparacao < 0)
            {
                Console.Write($"A data maior é " + data2.ToString("dd/MM/yyyy"));
            }
            else if (comparacao == 0)
            {
                Console.WriteLine("As data são iguais!");
            }
            else
            {
                Console.Write($"A data maior é " + data1.ToString("dd/MM/yyyy"));
            }

            Console.ReadLine();
        }
    }
}
