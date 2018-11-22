using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Web.Mvc.Models;

namespace Projeto.Web.Mvc.Controllers
{
    public class TarefaController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar(){

            if(string.IsNullOrEmpty(HttpContext.Session.GetString("emailUsuario"))){
                return RedirectToAction("Login", "Usuario");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel();
            TarefaModel transacao = new TarefaModel();
            transacao.Id = 1;
            transacao.Descricao = form["descricao"];
            transacao.Tipo = form["tipo"];
            transacao.Data = DateTime.Now;            

            using(StreamWriter sw = new StreamWriter("tarefas.csv", true)){
                sw.WriteLine($"{transacao.Id};{usuario.Nome};{usuario.Id};{transacao.Descricao};{transacao.Tipo};{transacao.Data}");
            }

            ViewBag.Mensagem = "Transação cadastrada";
            
            return RedirectToAction("Cadastrar", "Usuário");
        }

    }
}