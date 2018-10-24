using System;
using Senai.Pizzaria.Classes;
namespace Senai.Pizzaria
{
    class Program
    {
        static int cont=0;
        static void Main(string[] args)
        {
            Console.Clear();

            #region Menu Inicial

            int escolha;
            Console.WriteLine("Bem vindo ao Sistema da Pizzaria Quadradão de 12!");
            do{
                Console.WriteLine("\nMenu Inicial");
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("[1]-Cadastra-se");
                Console.WriteLine("[2]-Login");
                Console.WriteLine("[3]-Listar Usuários");
                Console.WriteLine("\n[9]-Sair");
                Console.WriteLine("------------------------");
                escolha = int.Parse(Console.ReadLine());
            #endregion
                switch (escolha)
                {
                    //Opção de Cadastro
                    case 1 :{
                        Console.Clear();
                        Usuario.Inserir();
                        cont ++;
                        break;
                    }

                    //Opção de Login
                    case 2:{
                        Console.Clear();
                        Usuario.EfetuarLogin();
                        int escolha1 = 0;

                            Console.Clear();
                        do {
                            Console.WriteLine ("Bem vindo ao Menu da Pizzaria");
                            Console.WriteLine ("\nEscolha uma opção:");
                            Console.WriteLine ("[1]-Cadastro de Produto");
                            Console.WriteLine ("[2]-Listar todos os produtos");
                            Console.WriteLine ("[3]-Exibir Total");
                            Console.WriteLine ("\n[9]-Sair");
                            Console.WriteLine ("------------------------");
                            escolha1 = int.Parse (Console.ReadLine ());

                            switch (escolha1)
                            {
                                case 1:{
                                    Console.Clear();
                                    Produto.CadastroProduto();
                                    break;
                                }

                                case 2:{
                                    Console.Clear();
                                    Produto.Listar();
                                    break;
                                }
                                case 3:{
                                    Produto.Total();
                                    break;
                                }
                                case 9:{
                                    System.Console.WriteLine();
                                    break;
                                }
                                default:{
                                    System.Console.WriteLine("Opção inválida");
                                    break;
                                }
                            }

                        } while (escolha1 != 9);
                        break;
                    }

                    case 3:{
                        Console.Clear();
                        Usuario.Listar();
                        break;
                        }

                    //Opção de Sair
                    case 9:{
                        Console.WriteLine("\nObrigado por usar o Sistema");
                        break;
                    }
                    default:{
                        Console.WriteLine("Opção inválida");
                        break;
                    }
                }
            }while(escolha != 9);
        }
    }
}
