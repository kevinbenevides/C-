using System;

namespace Senai.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cartela = new int[6]{22, 33, 29, 12, 75, 17};
            int acertos = 0, posicao, numero;

            do{
                System.Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());

                posicao = Array.IndexOf(cartela, numero);

                if (posicao >= 0)
                {
                    acertos++;
                    System.Console.WriteLine($"Acertou {acertos}, falta {6 - acertos}");
                }


            }while (acertos < 6);

            System.Console.WriteLine("Parabens. Você ganhou!!");
        }
    }
}
