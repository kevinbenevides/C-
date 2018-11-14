using System;

namespace Projeto.Web.Mvc.Models
{
    public class UsuarioModel
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public string TipoCadastro {get; set;}
        public DateTime DataCriacao {get; set;}

    }
}