using System;
using Senai.OO.Exercicio5.classes;

namespace Senai.OO.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicaçao aplicacao = new Aplicaçao();
            //Recebendo Nome
            Console.WriteLine("Digite o Nome da Aplicação: ");
            aplicacao.Nome = Console.ReadLine();

            //Recebendo valor de Aplicação
            Console.WriteLine("Digite o Valor a ser Aplicado: ");
            aplicacao.Valor = float.Parse(Console.ReadLine());
            
            //Recebendo valor do juros
            Console.WriteLine("Digite o valor de juros: ");
            aplicacao.Juros = double.Parse(Console.ReadLine());

            //Recendo o Período de Retanção
            Console.WriteLine("Digite o Período de Retenção");
            aplicacao.retencao = int.Parse(Console.ReadLine());


            Console.WriteLine($"Nome da Aplicação:{aplicacao.Nome}");
            Console.WriteLine($"Valor a ser Aplicado: R$ {aplicacao.Valor}");
            Console.WriteLine($"Valor do juros: {aplicacao.Juros}%");
            Console.WriteLine($"Período de Retenção: {aplicacao.retencao} mes(es)");

            //Calculando a margem de lucro
            double marginLucro = aplicacao.Juros / 100 * aplicacao.Valor;
            DateTime hoje = DateTime.Now;
            DateTime dataRetorno = hoje.AddMonths(aplicacao.retencao);
            Console.WriteLine($"Lucro (Juros):); {marginLucro.ToString("c")}");
            Console.WriteLine($"Total Retorno Financeiro: R$ {aplicacao.Valor + marginLucro}");
            Console.WriteLine($"Data de retirada {dataRetorno.ToShortDateString()}");
        }
    }
}
