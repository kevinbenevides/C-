using System;

namespace Senai.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digte o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2){
                Console.WriteLine($"O maior Valor é: {valor1}");
            }
            else if (valor1<valor2){
                Console.WriteLine($"O maior Valor é: {valor2}");
            }
            else {
                Console.WriteLine("Digite valores que sejam diferentes entre si");
            }
        }
        
    }
}
