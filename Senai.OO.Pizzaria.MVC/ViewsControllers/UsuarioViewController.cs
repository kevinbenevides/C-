using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers
{
    //Classe responsável por receber e mostrar os dados
    // referente ao Usuário
    public static class UsuarioViewController 
    {
        static UsuarioRepositorio usuarioRep = new UsuarioRepositorio();

        /// <summary>
        /// Método que representa a tela de cadastro de usuario
        /// Obtem nome, email e senha e mandar inserir
        /// </summary>
        public static void CadastrarUsuario(){
            string nome, email, senha;

            do
            {
                System.Console.WriteLine("Informe seu nome");
                nome = Console.ReadLine();

                if(string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Nome inválido");
                }
                
            }while(string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Informe o email com @ e .");
                email = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }

            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Informe a senha");
                senha = Console.ReadLine();

                if (!ValidacaoUtil.ValidarSenha(senha)){
                    System.Console.WriteLine("Senha inválida");
                }
            }while (!ValidacaoUtil.ValidarSenha(senha));

            //Cria um objeto do tipo UsuárioViewModel
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            //Atribui os valores ao objeto
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            //Manda inserir o objeto
            usuarioRep.Inseir(usuarioViewModel);

            //Mostrar mensagem de usuário castrado
            System.Console.WriteLine("Usuário Cadastrado");
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> lsUsuario = usuarioRep.Listar();

            foreach(UsuarioViewModel item in lsUsuario){
                System.Console.WriteLine($"Id[{item.Id}] - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data de Cadastro {item.DataCriacao}");
            }
        }
    }
}