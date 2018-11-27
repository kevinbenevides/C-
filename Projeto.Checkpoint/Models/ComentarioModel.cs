using System;
namespace Projeto.Checkpoint.Models
{
    public class ComentarioModel
    {
        public string Nome {get; set;}
        public string Texto {get; set;}
        public DateTime DataCriacao {get; set;}
        public int Id {get; set;}
        public string Status {get; set;} 
    }
}