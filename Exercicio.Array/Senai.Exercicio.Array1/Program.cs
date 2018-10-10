using System;

namespace Senai.Exercicio.Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, posicao = 0;
            string[] nome = new string[4];
            int[] numero = new int[4];
            DateTime[] data = new DateTime[4];


            do{
                System.Console.WriteLine("Escolha um opção: ");
                System.Console.WriteLine("1 - Agendar Viagem ");
                System.Console.WriteLine("2 - Exibir Viagem");
                System.Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1: {

                            if( posicao < 3){
                            Console.WriteLine("Bem Vindo ao agendamento de sua Viagem!"); 
                            
                            Console.WriteLine("\nPor favor insira seu nome: ");
                            nome[posicao] = Console.ReadLine();

                            Console.WriteLine("\nInsira o numero da passagem: ");
                            numero[posicao] = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nInsira a data do voo: ");
                            data[posicao] = DateTime.Parse(Console.ReadLine());

                            posicao++;
                            }
                            else{
                                Console.WriteLine("Deu erro!");
                            }
                            break;
                        }

                    case 2:{
                        do{
                            Console.Clear();
                            Console.WriteLine("Aqui estão os agendamentos feitos: ");
                            Console.WriteLine($"Nome do Passageiro: {nome[posicao]}");
                            Console.WriteLine($"Número da Passagem: {numero[posicao]}");
                            Console.WriteLine($"Data do voo: {data[posicao]}");
                            posicao++;
                        }
                        while(posicao <= 2);{
                        Console.WriteLine("Registre todas as informações");
                        break;
                        }

                    }

                    case 0:{
                        Console.WriteLine("Obrigado por usar nosso sistema de agendamento!");
                        break;
                    }
                    default: {
                        System.Console.WriteLine("Opção inválida");
                        break;
                    }
                }
            }
            while(opcao != 0);
        }
    }
}
