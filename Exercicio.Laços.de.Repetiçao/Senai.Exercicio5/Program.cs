using System;

namespace Senai.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("\nDigite o primeiro valor: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o segundo valor: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a opção que você deseja: ");
                
                System.Console.WriteLine("\n1- Soma");
                System.Console.WriteLine("\n2- Subtração");
                System.Console.WriteLine("\n3- Multiplicação");
                System.Console.WriteLine("\n4- Divisão");
                System.Console.WriteLine("\n5- Potencia");
                System.Console.WriteLine("\n0- Sair");

                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:{
                        Console.WriteLine($"\nResultado= {numero1 + numero2}");
                        break;
                    }

                    case 2:{
                        Console.WriteLine($"\nResultado= {numero1 - numero2}");
                        break;
                    }

                    case 3:{
                        Console.WriteLine($"\nResultado= {numero1 * numero2}");
                        break;
                    }

                    case 4:{
                        Console.WriteLine($"\nResultado= {numero1/numero2}");
                        break;
                    }

                    case 5:{
                        Console.WriteLine($"\nResultado= {Math.Pow(numero1, numero2)}");
                        break;
                    }

                    case 0:{
                        Console.WriteLine("\nObrigado por usar a Calculadora do Kevinho");
                        break;
                    }

                    default:{
                        Console.WriteLine("\nOpção invalida");
                        break;
                    }

                }
                    Console.WriteLine("\nDeseja continuar?[0-Não/1-Sim]");
                    opcao = int.Parse(Console.ReadLine());
                    

            }
             while (opcao != 0 );
        }
    }
}