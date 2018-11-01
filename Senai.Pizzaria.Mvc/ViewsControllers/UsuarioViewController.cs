using System;
using System.IO;
using Senai.Pizzaria.Mvc.Models;
using System.Collections.Generic;

namespace Senai.Pizzaria.Mvc.ViewsControllers
{
    public class UsuarioViewController
    {
        public void CadastroUsuario(){
            #region View
                System.Console.WriteLine("Informe o seu nome:");
                string nome = Console.ReadLine();

                System.Console.WriteLine("Informe o seu email:");
                string email = Console.ReadLine();
                
                System.Console.WriteLine("Infome a sua senha:");
                string senha = Console.ReadLine();
            #endregion

            #region Controller
                int contador = 0;
                List<UsuarioViewModel> lsUsuarios = Listar();

                if(lsUsuarios != null)
                    contador = lsUsuarios.Count;

                StreamWriter sw = new StreamWriter("usuario.csv",true);

                UsuarioViewModel usuario = new UsuarioViewModel();
                usuario.Id = contador + 1;
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.Senha = senha;
                usuario.DataCriacao = DateTime.Now;

                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao};");

                sw.Close();
            #endregion
        }

        public void Login(){
            
            #region View
            System.Console.WriteLine("Informe o seu email");
            string email = Console.ReadLine();
            
            System.Console.WriteLine("Informe sua senha");
            string senha = Console.ReadLine();
            #endregion
            
            #region Controller
             List<UsuarioViewModel> lsUsuarios = Listar();

            foreach(UsuarioViewModel item in lsUsuarios)
            {

                if(item.Email == email && item.Senha == senha){
                    System.Console.WriteLine("Usuário Logado");
                    break;
                }              
            }
            #endregion
        }

        public void ListarUsuarios(){
            #region Controller
               List<UsuarioViewModel> lsUsuarios = Listar();
            #endregion

            #region View
                foreach(UsuarioViewModel item in lsUsuarios)
                {
                    System.Console.WriteLine($"{item.Id}\t{item.Nome}\t{item.Email}\t{item.DataCriacao}");
                }
            #endregion
        }

        private List<UsuarioViewModel> Listar(){
                
                List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();
                
                UsuarioViewModel usuario;

                if(!File.Exists("usuario.csv"))
                return null;

                string[] usuarios = File.ReadAllLines("usuario.csv");

                foreach (string item in usuarios)
                {
                    string[] dados = item.Split(';');

                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataCriacao = DateTime.Parse(dados[4]);
                    lsUsuarios.Add(usuario);
                }

            return lsUsuarios;
        }
    }
}