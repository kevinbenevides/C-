using System;

namespace Senai.Exercicio.Swirch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu - Escolha uma das opções: ");
            Console.WriteLine("1- Quadrado");
            Console.WriteLine("2- Triângulo");
            Console.WriteLine("3- Circulo");
            int forma = int.Parse(Console.ReadLine());

            switch (forma)
            {
                case 1:{
                    Console.WriteLine("Digite o Tamanho do Lado do Quadrado: ");
                    double lado = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Área do Quadrado: {lado*lado}");
                    break;
                }
                case 2:{
                    Console.WriteLine("Digite o Tamanho da Base do Triângulo: ");
                    double basetri = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a Altura do Triângulo: ");
                    double Alturatri = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Área do Triângulo: {(basetri*Alturatri)/2}");
                    break;
                }
                case 3:{
                    Console.WriteLine("Digite o Tamanho do Raio do Circulo: ");
                    double raio = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Área do Circulo {Math.PI*raio*raio}");
                    break;
                }
                default:{
                    Console.WriteLine("Opção inválida");
                    break;
                }
            }
        }
    }
}
