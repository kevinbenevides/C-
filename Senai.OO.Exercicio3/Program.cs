using System;
using Senai.OO.Exercicio3.classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto1 = new Produtos();

            Console.WriteLine ("Informe o nome do produto 1: ");
            produto1.Nome = Console.ReadLine();

            Console.WriteLine ("Informe o Preço do produto 1: ");
            produto1.Preço = float.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a quantidade do produto 1: ");
            produto1.Quantidade = byte.Parse(Console.ReadLine());

            Console.WriteLine ($"Nome do produto 1= {P} ");

        }
    }
}
