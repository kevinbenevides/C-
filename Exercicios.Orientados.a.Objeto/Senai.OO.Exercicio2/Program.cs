using System;
using Senai.OO.Exercicio2.classes;

namespace Senai.OO.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region conta 1
            Conta conta1 = new Conta();

            Console.WriteLine("Digite seu Nome: ");
            conta1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o número da conta: ");
            conta1.Nconta = Console.ReadLine();

            Console.WriteLine("Digite o valor do saldo: ");
            conta1.Saldo = decimal.Parse(Console.ReadLine());

            #endregion
            
            Console.WriteLine();

            #region conta 2
            Conta conta2 = new Conta();

            Console.WriteLine("Digite seu Nome: ");
            conta2.Nome = Console.ReadLine();

            Console.WriteLine("Digite o número da conta: ");
            conta2.Nconta = Console.ReadLine();

            Console.WriteLine("Digite o valor do saldo: ");
            conta2.Saldo = decimal.Parse(Console.ReadLine());

            #endregion

            Console.WriteLine();

            #region  conta 3
            Conta conta3 = new Conta();

            Console.WriteLine("Digite seu Nome: ");
            conta3.Nome = Console.ReadLine();

            Console.WriteLine("Digite o número da conta: ");
            conta3.Nconta = Console.ReadLine();

            Console.WriteLine("Digite o valor do saldo: ");
            conta3.Saldo = decimal.Parse(Console.ReadLine());

            #endregion

            Console.WriteLine();

            Console.WriteLine($"Conta 1:");
            Console.WriteLine($"Nome da Conta: {conta1.Nome}");
            Console.WriteLine($"N° da Conta: {conta1.Nconta}");
            Console.WriteLine($"Valor da Conta: R${conta1.Saldo}");

            Console.WriteLine();

            Console.WriteLine($"Conta 2:");
            Console.WriteLine($"Nome da Conta: {conta2.Nome}");
            Console.WriteLine($"N° da Conta: {conta2.Nconta}");
            Console.WriteLine($"Valor da Conta: R${conta2.Saldo}");
            
            Console.WriteLine();    

            Console.WriteLine("Conta 3:");
            Console.WriteLine($"Nome da Conta: {conta3.Nome}");
            Console.WriteLine($"N° da Conta: {conta3.Nconta}");
            Console.WriteLine($"Valor da Conta: R${conta3.Saldo}");
        }
    }
}
