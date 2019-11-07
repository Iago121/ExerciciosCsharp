using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorExe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[5];
            string nome;
            int soma = 0, media = 0;

            Console.Write("Digite o nome do aluno: ");
            nome = Convert.ToString(Console.ReadLine());

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Notas: ");
                notas[i] = int.Parse(Console.ReadLine());
                

                soma += notas[i];

            }
            media = soma / 5;


            Console.WriteLine($"{nome} o seu resultado é: {media} pontos.");
            Console.ReadLine();
        }
    }
}
