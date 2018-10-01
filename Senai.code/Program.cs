using System;
using Senai.code.classes;

namespace Senai.code
{
    class Program
    {
        static void Main(string[] args)
        {
            aplicacao produto = new aplicacao();

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço real do produto:");
            produto.preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de prestação:");
            produto.qtpres = double.Parse(Console.ReadLine());

            produto.vp = produto.preco/produto.qtpres;
            produto.a = produto.vp*(0.05*(produto.qtpres-1));

            Console.Clear();

            Console.WriteLine($"Nome: {produto.Nome}");

            Console.WriteLine($"Preço real: R${produto.preco}" );

            Console.WriteLine($"Quantidade de prestação(ões): {produto.qtpres}");

            Console.WriteLine($"Valor real para cada prestação: R${produto.vp}");

            Console.WriteLine($"Valor do acrescimo: R${produto.a}");

            Console.WriteLine("");
            
            Console.WriteLine($"Valor para cada mensalidade: R${produto.vp + produto.a}");

            
        }
    }
}
