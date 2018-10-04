using System;

namespace Senai.Operadores.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto: ");
            float produto = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade mínima: ");
            sbyte qmin = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima: ");
            sbyte qmax = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Digite a quantidade atual do estoque: ");
            sbyte qat = Convert.ToSByte(Console.ReadLine()); 

            int em = (qmin + qmax) /2 ;
            float custoem = produto*em;
            float custoet = produto*qat;

            Console.WriteLine($"Estoque Médio= {em}");
            Console.WriteLine($"Custo total do Estoque Médio= {custoem}");
            Console.WriteLine($"Custo total do Estoque Atual= {custoet}");
        }
    }
}
