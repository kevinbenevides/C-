using Projeto.Web.Mvc.Models;
using System.Collections.Generic;

namespace Projeto.Web.Mvc.Interfaces
{

    /// <summary>
    /// Interface do Usuário
    /// Métodos que a classe 
    /// </summary>
    public interface IUsuario
    {
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna uma lista</returns>
         List<UsuarioModel> Listar();

        /// <summary>
        /// Cadastra os usuários
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
         UsuarioModel Cadastrar(UsuarioModel usuario);

        /// <summary>
        /// Edita os usuários
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
         UsuarioModel Editar(UsuarioModel usuario);

        /// <summary>
        /// Exclui os usuários
        /// </summary>
        /// <param name="id"></param>
         void Excluir(int id);

         UsuarioModel Login(string email, string senha);

    }
}