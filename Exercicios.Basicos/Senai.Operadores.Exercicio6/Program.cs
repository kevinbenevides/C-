using System;

namespace Senai.Operadores.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nomeproduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            ushort precoproduto = ushort.Parse(Console.ReadLine());

            float porcento = (precoproduto * 10) /100;

            float desconto = (precoproduto - porcento) ;

            Console.WriteLine($"Preço= {precoproduto}");
            Console.WriteLine($"Preço com 10% de desconto= {desconto}");
        }
    }
}
