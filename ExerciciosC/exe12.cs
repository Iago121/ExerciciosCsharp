using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrau, alturaDesejada, numeroDegraus;

            Console.Write("Digite o tamanho do degrau (em cm): ");
            degrau = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura que deseja alcançar (em cm): ");
            alturaDesejada = Convert.ToDouble(Console.ReadLine());

            numeroDegraus = alturaDesejada / degrau;
            Console.WriteLine("Você terá que subir aproximadamente {0} degraus", numeroDegraus.ToString("F0"));

            Console.ReadLine();
        }
    }
}
