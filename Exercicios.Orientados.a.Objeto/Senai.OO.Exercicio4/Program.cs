using System;
using Senai.OO.Exercicio4.classes;

namespace Senai.OO.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cartão 1
            Cartao cartao1 = new Cartao();

            Console.WriteLine("Digite o número do cartão: ");
            cartao1.Ncartao = Console.ReadLine();

            Console.WriteLine("Digite a data de Validade do cartão: ");
            cartao1.datavalidade = DateTime.Parse(Console.ReadLine());
            #endregion

            #region Cartão 2
            Cartao cartao2 = new Cartao();

            Console.WriteLine("/n Digite o número do cartão: ");
            cartao2.Ncartao = Console.ReadLine();

            Console.WriteLine("Digite a data de Validade do cartão");
            cartao2.datavalidade = DateTime.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine();

            Console.WriteLine("Cartão 1 ");
            Console.WriteLine($"Número do Cartão: {cartao1.Ncartao}");
            Console.WriteLine($"Data de Validade: {cartao1.datavalidade.ToString("dd/MM/yyyy")}");

            Console.WriteLine();

             Console.WriteLine("Cartão 2 ");
            Console.WriteLine($"Número do Cartão: {cartao2.Ncartao}");
            Console.WriteLine($"Data de Validade: {cartao2.datavalidade.ToString("dd/MM/yyyy")}");
        }
    }
}
