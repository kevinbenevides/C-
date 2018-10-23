using System;
using Senai.Pizzaria.Classes;
namespace Senai.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Login[] usuario = new Login[10000];
            
            int cont=0;
            usuario[cont] = new Login();

            string email = usuario[cont].Email;
            string senha = usuario[cont].Senha;
            #region Menu Inicial
            int escolha;
            Console.WriteLine("Bem vindo ao Sistema da Pizzaria Quadradão de 12!");
            do{
                System.Console.WriteLine("\nMenu Inicial");
                System.Console.WriteLine("\nEscolha uma opção:");
                System.Console.WriteLine("[1]-Cadastra-se");
                System.Console.WriteLine("[2]-Login");
                System.Console.WriteLine("[3]-Listar Usuário");
                System.Console.WriteLine("\n[9]-Sair");
                System.Console.WriteLine("------------------------");
                escolha = int.Parse(Console.ReadLine());
            #endregion
                switch (escolha)
                {
                    case 1 :{
                        Console.Clear();
                        do{
                            System.Console.WriteLine("Digite o E-mail que deseja cadastrar:");
                            email = Console.ReadLine();

                            if (email.Contains("@") == false || email.Contains(".") == false)
                            {
                                Console.WriteLine("Email inválido. ");
                            }

                        }while(email.Contains("@") == false || email.Contains(".") == false);


                        do{
                            System.Console.WriteLine("\nDigite a Senha que deseja cadastrar:");
                            senha = Console.ReadLine();

                            if (senha.Length < 6 )
                            {
                                Console.WriteLine("Senha inválida.");
                            }

                        }while(senha.Length < 6 );

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
