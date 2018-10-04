using System;
using Senai.OO.Exercicio3.classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dados do Produto 1
            Produtos produto1 = new Produtos();

            Console.WriteLine ("Informe o nome do produto 1: ");
            produto1.Nome = Console.ReadLine();

            Console.WriteLine ("Informe o Preço do produto 1: ");
            produto1.Preço = float.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a quantidade do produto 1: ");
            produto1.Quantidade = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine ($"Nome do produto 1= {produto1.Nome} ");
            Console.WriteLine ($"Preço do produto 1= R${produto1.Preço}");
            Console.WriteLine ($"Quantidade do produto 1= {produto1.Quantidade}");
            #endregion

            Console.WriteLine();
            #region Dados do Produto 2
            Produtos produto2 = new Produtos ();
            
            Console.WriteLine ("Informe o nome do produto 2: ");
            produto2.Nome = Console.ReadLine();
            
            Console.WriteLine ("Informe o preço do produto 2: ");
            produto2.Preço = float.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a quantidade do produto: ");
            produto2.Quantidade = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine ($"Nome do produto 2= {produto2.Nome}");
            Console.WriteLine ($"Preço do produto 2= R${produto2.Preço}");
            Console.WriteLine ($"Quantidade do produto 2= {produto2.Quantidade}");
            #endregion

            Console.WriteLine();
            #region Dados do Produto 3
            Produtos produto3 = new Produtos ();
        
            Console.WriteLine ("Informe o nome do produto 3: ");
            produto3.Nome = Console.ReadLine();

            Console.WriteLine ("Informe o preço do produto 3: ");
            produto3.Preço = float.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a quantidade do produto 3: ");
            produto3.Quantidade = byte.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine ($"Nome do produto 3= {produto3.Nome}");
            Console.WriteLine ($"Preço do produto 3= R${produto3.Preço}");
            Console.WriteLine ($"Quantidade do produto 3= {produto3.Quantidade}");
            #endregion

            Console.WriteLine ();
            Console.WriteLine ($"Média do preço dos produtos= R${produto1.Preço + produto2.Preço + produto3.Preço / produto1.Quantidade + produto2.Quantidade + produto3.Quantidade}");


        }
    }
}