using System;

namespace Senai.Operadores.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Célsius");
            float Célsius = float.Parse(Console.ReadLine());

            float Convesao = (9*Célsius+160) / 5;

            Console.WriteLine($"Temperatura em Célsius: {Célsius}");
            Console.WriteLine($"Fahrenheit= {Convesao}");
        }
    }
}
