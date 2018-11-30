using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Checkpoint.Models;
using Projeto.Checkpoint.Repositorios;

namespace Projeto.Checkpoint.Controllers 
{
    public class UsuarioController : Controller 
    {
        [HttpGet]
        public ActionResult Index(){
            return View ();
        }

        [HttpGet]
        public ActionResult Cadastrar(){
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.TipoUsuario = form["tipousuario"];

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction("Cadastrar", "Tarefa");
        }
    }
}