using System;
using Senai.Exercicio1.Classes;

namespace Senai.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            
            System.Console.WriteLine("Digite o valor Do Lado A: ");
            retangulo.LadoA = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor do Lado B: ");
            retangulo.LadoB = float.Parse(Console.ReadLine());

            //Retorna o Método Área
            System.Console.WriteLine($"Área: {retangulo.Area()}cm²");

            //Retorna o Método Perímetro
            System.Console.WriteLine($"Perímetro: {retangulo.Perimetro()}cm");
        }
    }
}
