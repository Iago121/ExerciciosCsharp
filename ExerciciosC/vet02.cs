using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vet01exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] vet3 = new int[10];

            for(int i =0; i<5; i++)
            {
                Console.WriteLine("Número, Armazenado [" + i +"]: ");
                vet1[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Segundo Vetor..");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Número, Armazenado [" + i + "]: ");
                vet2[i] = int.Parse(Console.ReadLine());

            }

            //vetor1
            int posicao = 0;

            for (int i = 0; i < 5; i++)
            {
                vet3[posicao] = vet1[i];
                posicao = posicao + 2;

            }

            //vetor2
            int posicao1 = 1;

            for (int i = 0; i < 5; i++)
            {
                vet3[posicao1] = vet2[i];
                posicao1 = posicao1 + 2;

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vetor intercalado é: " + vet3[i]);
            }

            Console.ReadLine();

        }
    }
}
