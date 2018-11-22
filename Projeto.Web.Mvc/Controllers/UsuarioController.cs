using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Web.Mvc.Models;
using Projeto.Web.Mvc.Repositorios;

namespace Projeto.Web.Mvc.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel ();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.TipoCadastro = form["tipocadastro"];
            usuario.DataCriacao = DateTime.Now;

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction("Cadastrar", "Tarefa");
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.Login(form["email"], form["senha"]);

            using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    
                    var linha = sr.ReadLine();

                    if(string.IsNullOrEmpty(linha)){
                        continue;
                    }

                    string[] dados = linha.Split (";");

                    if (dados[2] == usuario.Email && dados[3] == usuario.Senha) {
                        HttpContext.Session.SetString ("emailUsuario", usuario.Email);
                        return RedirectToAction ("Listar", "Usuario");
                    }
                }
            }

            ViewBag.Mensagem = "Usuário inválido";

            return View ();
        }

        //viewdata armazena dados do c#
    //viewbag armazena mensagens
        public IActionResult Listar () {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            ViewData["Usuarios"] = usuarioRepositorio.Listar();

            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Excluir(id);
            
            TempData["Mensagem"] = "Usuário excluído";

            return RedirectToAction("Listar");
        }
        
        [HttpGet]
        public IActionResult Editar(int id) {

            if(id == 0){
                TempData["Mensagem"] = "Informe um usuário para editar";
                return RedirectToAction("Listar");
            }

            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            foreach (var item in linhas)
            {
                string[] dados = item.Split(';');

                if (id.ToString() == dados[0]){
                    UsuarioModel usuario = new UsuarioModel();
                    usuario.Id = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataCriacao = DateTime.Parse(dados[4]);


                    ViewBag.Usuario = usuario;
                    break;
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(IFormCollection form) {
            //Declara um objeto UsuarioModel e atribui os valores do form
            UsuarioModel usuario = new UsuarioModel{
                Id = int.Parse(form["id"]),
                Nome = form["nome"],
                Email = form["email"],
                Senha = form["senha"],
                DataCriacao = DateTime.Parse(form["dataCriacao"])
            };

            //Cria um objeto UsuarioRepositorio e edita
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Editar(usuario);


            TempData["Mensagem"] = "usuário editado";

            return RedirectToAction("Listar");
        }
    }

}