using System;

namespace Senai.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de maçãs: ");
            int maça = int.Parse(Console.ReadLine());
            double valor1 = maça*0.30;
            double valor2 = maça*0.25;

            if (maça < 12)
            {
                Console.WriteLine("Valor De Cada Maçã: R$0,30");
                Console.WriteLine($"Valor total: R${valor1}");
            }
            else if(maça >= 12)
            {
                Console.WriteLine("Valor De Cada Maçã: R$0,25");
                Console.WriteLine($"Valor total: R${valor2}");
            }
        }
    }
}
