using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe13
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaParede, resposta, angulo, radianos;

            Console.Write("Digite o valor do ângulo: ");
            angulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura da parede: ");
            alturaParede = Convert.ToDouble(Console.ReadLine());

            radianos = angulo * (Math.PI / 180);
            angulo = Math.Sin(radianos);
            resposta = alturaParede / angulo;

            Console.WriteLine("O tamanho da escada é aproximadamente " + resposta.ToString("F2"));
            Console.ReadLine();
        }
    }
}
