using System;
using   Senai.OO.Exercicio8.classes;

namespace Senai.OO.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Funcionario 1
            Funcionarios f1 = new Funcionarios();

            // Recebendo nome
            Console.WriteLine("Insira o nome do funcionario");
            f1.Nome = Console.ReadLine();

            // Recebendo o valor da hora
            Console.WriteLine("Insira o valor/hora");
            f1.ValorHora = Double.Parse(Console.ReadLine());

            // Recebendo o numero de horas
            Console.WriteLine("Insira a quantidade de horas trabalhadas");
            f1.HorasTrabalhadas = int.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"Valor a ser pago: {f1.CalcularValorProjeto()}");

             #region Funcionario 2
            Funcionarios f2 = new Funcionarios();

            //Recebendo nome
            Console.WriteLine("Insira o nome fo funcionario");
            f2.Nome = Console.ReadLine();

            //Recebendo o valor da hora
            Console.WriteLine("Insira o valor/hora");
            f2.ValorHora = double.Parse(Console.ReadLine());

            //Recebendo o numero da horas trabalhadas
            Console.WriteLine("Insira a quantidade de horas trabbalhadas");
            f2.HorasTrabalhadas = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"Valor a ser pago: {f2.CalcularValorProjeto()}"); 
            #endregion
        }
    }
}
