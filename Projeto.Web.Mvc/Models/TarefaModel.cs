using System;

namespace Projeto.Web.Mvc.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
    }
}