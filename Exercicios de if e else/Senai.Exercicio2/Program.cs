using System;

namespace Sena.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de seu nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            if ( ano <= 2000)
            {
                Console.WriteLine("Pode votar");
            }
            else {
                Console.WriteLine("Ainda não pode votar");
            }
        }
    }
}
