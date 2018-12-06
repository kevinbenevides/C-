using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Checkpoint.Models;
using Projeto.Checkpoint.Repositorios;

namespace Projeto.Checkpoint_Copia.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpGet]
        public ActionResult ComentarioUsuario(){

            if(string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario"))){
                return RedirectToAction("Login", "Usuario");
            }

            return View();
        }

        // [HttpPost]
        // public ActionResult ComentarioUsuario(IFormCollection form){
        //     UsuarioModel usuario = new UsuarioModel(
        //        nome: form["nome"]
        //     );
        //     ComentarioModel comentario = new ComentarioModel();
        //     usuario.Nome = 
        //     comentario.Texto = form["texto"];
        //     comentario.DataCriacao = DateTime.Now;

        //     return View();
        // }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                 nome: HttpContext.Session.GetString("nomeUsuario")
            );
            ComentarioModel comentario = new ComentarioModel();
            comentario.Id = 1;
            comentario.Texto = form["texto"];
            comentario.DataCriacao = DateTime.Now;            

            using(StreamWriter sw = new StreamWriter("comentario.csv", true)){
                sw.WriteLine($"{usuario.Nome};{comentario.Id};{comentario.Texto};{comentario.DataCriacao}");
            }

            ViewBag.Mensagem = "Transação cadastrada";

            return RedirectToAction("ComentarioUsuario", "Comentario");
        }
    }
}