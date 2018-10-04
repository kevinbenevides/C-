using System;

namespace Senai.Exercicio.Switch4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do salario mínimo: ");
            double salariomin = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horastrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de dependentes: ");
            int dependentes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a qunatidade de horas extras trabalhadas: ");
            int horasextra = int.Parse(Console.ReadLine());

            double valorhorastrab = salariomin/5;
            double salariodomes = valorhorastrab*horastrab;
            double valordependente = dependentes*64;
            double valorhoraextra = horasextra*(valorhorastrab*0.5 + valorhorastrab);
            double salariobruto = salariodomes + valordependente + valorhoraextra;
            
        }
    }
}
