using System;

namespace Senai.Exercicio.Exemplo.ArrayMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de cadastro");
            int quantCadastro = int.Parse(Console.ReadLine());

            string[,] dadosPessoais = new string[quantCadastro, 3];

            for(int i = 0; i < quantCadastro;i++){
                System.Console.WriteLine("Informe o nome do usuário: ");
                dadosPessoais[i,0] = Console.ReadLine();

                System.Console.WriteLine("Informe o CPF do usuário: ");
                dadosPessoais[i,1] = Console.ReadLine();

                System.Console.WriteLine("Informe o telefone do usuario: ");
                dadosPessoais[i,2] = Console.ReadLine();
            }

            for (int i = 0; i < quantCadastro; i++)
            {
            System.Console.WriteLine($"| {dadosPessoais[i,0]}\t| {dadosPessoais[i,1]}\t| {dadosPessoais[i,2]}|");
            }
        }
    }
}
