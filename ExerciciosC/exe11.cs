using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoFabrica, lucroRevendedor, imposto, valorFinal;

            Console.Write("Digite o preço de fabrica do veículo: ");
            precoFabrica = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de lucro do revendedor: ");
            lucroRevendedor = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o percentual de impostos: ");
            imposto = Convert.ToDouble(Console.ReadLine()) / 100;

            lucroRevendedor = precoFabrica * lucroRevendedor;
            Console.WriteLine($"O lucro do vendedor é de {lucroRevendedor:c}");

            imposto = precoFabrica * imposto;
            Console.WriteLine($"O preço dos impostos é de {imposto:c}");

            valorFinal = precoFabrica + lucroRevendedor + imposto;
            Console.WriteLine($"O preço final do veículo é de {valorFinal:c}");

            Console.ReadLine();

        }
    }
}
