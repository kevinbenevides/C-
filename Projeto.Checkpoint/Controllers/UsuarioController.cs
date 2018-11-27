using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Checkpoint.Controllers
{
    public class UsuarioController
    {
        [HttpGet]
        public ActionResult Cadastrar(){
            return View();
        }

    }
}