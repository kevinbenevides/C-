using System;
using Senai.Projeto.Classes;

namespace Senai.Projeto {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();

            Financas[] funcionarios = new Financas[1000];

            int cont = 0, escolha;

            Console.WriteLine ("\nOlá, seja Bem Vindo ao Sitema de Finanças");

            do {
                if (cont > 0) {
                    Console.Clear ();
                }
                Console.WriteLine ("\nEscolha uma das opções: ");
                System.Console.WriteLine ("\n1- Cadastrar um Funcionário");
                System.Console.WriteLine ("2- Exibir folha de pagamento");
                System.Console.WriteLine ("3- Exibir total de Custos Bruto da Folha");
                System.Console.WriteLine ("4- Aumentar salário");
                System.Console.WriteLine ("5- Exibir total de custos Líquidos da Folha");
                System.Console.WriteLine ("0- Sair");
                escolha = int.Parse (Console.ReadLine ());

                switch (escolha) {
                    case 1:
                        {
                            Console.Clear ();
                            string escolha1;
                            do {
                                funcionarios[cont] = new Financas ();

                                Console.WriteLine ("Digite o Nome do Funcionário: ");
                                funcionarios[cont].Nome = Console.ReadLine ();

                                Console.WriteLine ("\nDigite o Salário Bruto do Funcionário: ");
                                funcionarios[cont].Salariobruto = double.Parse (Console.ReadLine ());

                                Console.WriteLine ($"\nO indice desse funcionário é: {cont}");

                                System.Console.WriteLine ("\nDeseja continuar cadastrando ?");
                                escolha1 = Console.ReadLine ();

                                Console.Clear ();

                                cont++;
                            } while (escolha1 == "Sim");

                            System.Console.WriteLine ("Obrigado por cadastrar");

                            break;
                        }

                    case 2:
                        {
                            string escolha2;
                            do{
                            
                            System.Console.WriteLine("\nFolha de Pagamento do Funcionário");

                            System.Console.WriteLine("\nDigite o número do indice do funcionário:");
                            int indice = int.Parse(Console.ReadLine());

                            Console.WriteLine($"{funcionarios[indice].Salariobruto}");
                            

                            System.Console.WriteLine("\nDeseja exibir as informarções de outro usuário?(Sim/Nao)");
                            escolha2 = Console.ReadLine();
                            }while(escolha2 == "Sim");

                            Console.Clear();
                            break;
                        }

                    case 0: {
                        System.Console.WriteLine("");
                        break;
                    }
                    default:
                        {
                            Console.WriteLine ("Opção invalida");
                            break;
                        }
                }
            }

            while (escolha != 0);

            System.Console.WriteLine ("Obrigado por usar o nosso Sistema de Finanças");

        }
    }
}