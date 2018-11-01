using System;
using Senai.Pizzaria.Mvc.ViewsControllers;

namespace Senai.Pizzaria.Mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioViewController = new UsuarioViewController();

            usuarioViewController.CadastroUsuario();

            usuarioViewController.ListarUsuarios();

        }
    }
}
