using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, elevado1, elevado2;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > 0 && numero2 > 0)
            {


                elevado1 = Math.Pow(numero1, numero2);
                Console.WriteLine($"O número {numero1} elevado ao número {numero2} é: " + elevado1.ToString("F2"));

                elevado2 = Math.Pow(numero2, numero1);
                Console.WriteLine($"O número {numero2} elevado ao número {numero1} é: " + elevado2.ToString("F2"));
            }
            else
            {
                Console.WriteLine("O número devera ser maior que 0.");
            }
            Console.ReadKey();
        }
    }
}
