using Projeto.Checkpoint.Models;
using System.Collections.Generic;

namespace Projeto.Checkpoint.Interfaces
{
    public interface IUsuario
    {
          /// <summary>
        /// Cadastra os usuários
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
         UsuarioModel Cadastrar(UsuarioModel usuario);
    }
}