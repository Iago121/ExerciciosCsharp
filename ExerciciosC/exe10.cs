using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista01exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int ano = DateTime.Now.Year;
            int idade;

            Console.Write("Digite o ano do seu nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Ano atual: {ano}. \n Ano Nascimento: {anoNascimento}. \n Sua idade atual é: {ano - anoNascimento} anos.");
            idade = 2050 - anoNascimento;
            Console.WriteLine($" Em 2050 você terá: {idade} anos.");


            Console.ReadKey();
        }
    }
}
