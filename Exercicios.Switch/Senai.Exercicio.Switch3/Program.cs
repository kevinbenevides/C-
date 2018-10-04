using System;

namespace Senai.Exercicio.Swich3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu salário: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu código: ");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1: {
                    Console.WriteLine("Seu Cargo é : Escriturário");
                    Console.WriteLine("Seu Percentual de almento é: 50%");
                    Console.WriteLine($"O seu aumento salarial é de: R${valor*0.50 + valor}");
                    break;
                }
                case 2: {
                    Console.WriteLine("Seu Cargo é : Secretário");
                    Console.WriteLine("Seu Percentual de almento é: 35%");
                    Console.WriteLine($"O seu aumento salarial é de: R${valor*0.35 + valor}");
                    break;
                }
                case 3: {
                    Console.WriteLine("Seu Cargo é : Caixa");
                    Console.WriteLine("Seu Percentual de almento é: 20%");
                    Console.WriteLine($"O seu aumento salarial é de: R${valor*0.20 + valor}");
                    break;
                }
                case 4: {
                    Console.WriteLine("Seu Cargo é : Gerente");
                    Console.WriteLine("Seu Percentual de almento é: 10%");
                    Console.WriteLine($"O seu aumento salarial é de: R${valor*0.10 + valor}");
                    break;
                }
                case 5: {
                    Console.WriteLine("Seu Cargo é : Diretor");
                    Console.WriteLine("Seu Percentual de almento é: Nenhum");
                    Console.WriteLine($"O seu aumento salarial é de: R${valor}");
                    break;
                }
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}
