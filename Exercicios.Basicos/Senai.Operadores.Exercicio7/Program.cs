using System;

namespace Senai.Operadores.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite o valor do dolar: ");
            decimal dolar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em real: ");
            decimal real = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine($"Valor do Dolar: US${dolar}");
            Console.WriteLine($"Valor do Real: R${real}");
            Console.WriteLine($"Valor do Conversão: R${dolar * real}");
        }
    }
}
