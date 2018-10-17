using System;

namespace Senai.Exercicio.ArrayMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabela = new int[5, 5];
            Random rand = new Random();
            bool encontrado = false;


            for(int linha = 0; linha < 5; linha++){
                for(int coluna = 0; coluna < 5; coluna++)
                {
                    tabela[linha,coluna] = rand.Next(51);
                    Console.Write($"{tabela[linha,coluna]}\t");
                }
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if(numero == tabela[linha,coluna]){
                        Console.WriteLine($"Número encontrado na linha {linha} e coluna {coluna}");
                        encontrado = true;
                        break;
                    }
                }
            if(encontrado){
                break;}
            }

        if(!encontrado){
            System.Console.WriteLine("Número não encontrado.");
        }
        }
    }
}
