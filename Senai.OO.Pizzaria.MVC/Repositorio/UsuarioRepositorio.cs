using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    /// <summary>
    /// Classe responsável pela leitura e gravação do Usuário
    /// </summary>
    public class UsuarioRepositorio
    {
        //Criação do Objeto List que esta presente no namespace System.Collections.Generic
        //Responsável por armazenar as informações do Usuário
        List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();  
        
        /// <summary>
        /// Método responsável por armazenar um usuário 
        /// </summary>
        /// <param name="usuario" usuário que será armazenado></param>
        /// <returns>Retorna um Usuário com os dados alterados</returns>
        public UsuarioViewModel Inseir(UsuarioViewModel usuario){
            //Incrementa 1 no Id do objeto
            usuario.Id = lsUsuarios.Count + 1;
            //Define a Data e Hora da inserção do objeto lista
            usuario.DataCriacao = DateTime.Now;
            //Insere o objeto usuario na Lista
            lsUsuarios.Add(usuario);
            //Retorna um usuário
            return usuario;
        }

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna a Lista de Usuários Cadastrados</returns>
        public List<UsuarioViewModel> Listar(){
            //Retorna
            return lsUsuarios;
        }

        /// <summary>
        /// Verifica se um usuário é válido
        /// </summary>
        /// <param name="email">Email do Usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// <returns>Retorna um usuário caso o mesmo seja encontrado ou null caso não exista</returns>
        public UsuarioViewModel EfetuarLogin(string email, string senha){
            foreach (UsuarioViewModel item in lsUsuarios)
            {
                if(item.Email == email && item.Senha == senha){
                    return item;
                }
            }

            //Usuário não válido retorna null
            return null;
        }
    }
}