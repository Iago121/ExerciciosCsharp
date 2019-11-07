using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, quadrado, cubo;
            double raizQuadrada, raizCubica;

            Console.Write("Digite um Número maior que 0: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                quadrado = numero * numero;
                Console.WriteLine("O número ao quadrado é: " + quadrado);

                cubo =  Convert.ToInt32(Math.Pow(numero, 3));
                Console.WriteLine("O número ao cubo é: " + cubo);

                raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrada é: " + raizQuadrada.ToString("F3"));

                raizCubica = Math.Pow(numero, 0.3333333333);
                Console.WriteLine("A raiz cúbica é: " + raizCubica.ToString("F3"));

            }
            else
            {
                Console.WriteLine("O valor devera ser maior que 0.");
                
            }
            Console.ReadKey();
        }
    }
}
