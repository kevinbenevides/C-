using System;
using System.Collections.Generic;
using System.IO;
using Projeto.Checkpoint.Interfaces;
using Projeto.Checkpoint.Models;

namespace Projeto.Checkpoint.Repositorios
{
    public class UsuarioRepositorio : IUsuario
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            if(File.Exists("usuarios.csv")){
                usuario.Id = File.ReadAllLines("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.TipoUsuario}");
            }

            return usuario;
        }
    }
}