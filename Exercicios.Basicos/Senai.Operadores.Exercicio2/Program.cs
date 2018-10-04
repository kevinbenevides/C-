using System;

namespace Senai.Operadores.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            float alturaRetangulo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da base do retângulo: ");
            float baseRetangulo = float.Parse(Console.ReadLine());

            float areaRetangulo = baseRetangulo * alturaRetangulo;

            Console.WriteLine($"Altura : {alturaRetangulo}, Base : {baseRetangulo}, Área= {areaRetangulo} ");
        }
    }
}
