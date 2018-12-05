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
            return View();
        }
    }
}