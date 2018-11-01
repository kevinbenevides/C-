using System;

namespace Senai.Pizzaria.Mvc.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
    }
    
}