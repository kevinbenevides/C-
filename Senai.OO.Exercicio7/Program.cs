using System;
using Senai.OO.Exercicio7.classes;

namespace Senai.OO.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            #region Vendedor 1
            Cadastro vendedores = new Cadastro();

            Console.WriteLine("Digite seu número de cadastro: ");
            vendedores.Numero = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor do seu Salario Fixo: ");
            vendedores.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de vedas reaizadas no mês: ");
            vendedores.vendas = byte.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto: ");
            vendedores.produto = float.Parse(Console.ReadLine());

            vendedores.comissao = ((vendedores.produto*vendedores.vendas)*15)/100;
            vendedores.salariot = vendedores.comissao + vendedores.Salario;

            Console.WriteLine();

            Console.WriteLine($"Número de Cadastro: {vendedores.Numero}");
            Console.WriteLine($"Salário: R${vendedores.salariot}");
            #endregion

            Console.Clear();

            #region Vendedor 2
            Cadastro vendedor2 = new Cadastro();

            Console.WriteLine("Digite seu número de cadastro: ");
            vendedor2.Numero = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor do seu Salario Fixo: ");
            vendedor2.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de vedas reaizadas no mês: ");
            vendedor2.vendas = byte.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto: ");
            vendedor2.produto = float.Parse(Console.ReadLine());

            vendedor2.comissao = ((vendedor2.produto*vendedor2.vendas)*15)/100;
            vendedor2.salariot = vendedor2.comissao + vendedor2.Salario;

            Console.WriteLine();
            
            Console.WriteLine($"Número de Cadastro: {vendedor2.Numero}");
            Console.WriteLine($"Salário: R${vendedor2.salariot}");
            #endregion

        }
    }
}
