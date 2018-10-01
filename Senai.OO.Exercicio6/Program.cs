using System;
using Senai.OO.Exercicio6.classes;

namespace Senai.OO.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprecao = new Imprimir();
            //recebendo nome
            Console.WriteLine("Digite seu nome: ");
            imprecao.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Nome: {imprecao.Nome}");
            Console.WriteLine($"Primeira Letra do Nome: {imprecao.Nome.Substring(0, 1)}");
            //Calculando o comprimento da string
            int tamanho = imprecao.Nome.Length;
            Console.WriteLine($"Última Letra do Nome: {imprecao.Nome[tamanho -1]}");
            Console.WriteLine($"Três Primeiras Letras do Nome: {imprecao.Nome.Substring(0 ,3)}");
            Console.WriteLine($"Quarta Letra do Nome: {imprecao.Nome[3]}");
            Console.WriteLine($"Todas Letras do Nome menos a Primeira: {imprecao.Nome.Substring (1, tamanho -1)}");
            Console.WriteLine($"Duas Últimas Letras do Nome: {imprecao.Nome.Substring(tamanho -2, 2)}");

        }
    }
}
