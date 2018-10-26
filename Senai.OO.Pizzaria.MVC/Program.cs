using System;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewsControllers;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaoLogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:{
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }
                    case 2:{
                        //Chama a página Login e aguarda o retorno
                        UsuarioViewModel usuarioViewModel = UsuarioViewController.EfetuarLogin();

                        //Usuário é válido
                        if (usuarioViewModel != null){
                            //Mensagem de boas vindas
                            System.Console.WriteLine("Seja Bem vindo" + usuarioViewModel.Nome);

                            //Laço menu logado
                            do
                            {
                                //Mostra menu logado
                                MenuUtil.MenuLogado();

                                //Obtém opção do menu
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado)
                                {
                                    case 0:{
                                        System.Console.WriteLine("Tchau");
                                        break;
                                    }
                                    default:{
                                        System.Console.WriteLine("Opção invalida");
                                        break;
                                    }
                                }
                            }while(opcaoLogado != 0);
                        }
                        break;
                    }
                    case 3:{
                        UsuarioViewController.ListarUsuario();
                        break;
                    }
                    case 0:{
                        System.Console.WriteLine("Tchau");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Opção Inválida");
                        break;
                    }
                }
            }while(opcaoDeslogado != 0);
        }
    }
}
