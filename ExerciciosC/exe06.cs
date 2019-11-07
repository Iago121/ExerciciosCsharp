using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, baze, area;

            Console.Write("Informe o valor da Altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor da Base: ");
            baze = Convert.ToInt32(Console.ReadLine());

            area = baze * altura / 2;
            Console.WriteLine("O tamanho da área é: " + area);
            Console.ReadLine();
        }
    }
}
