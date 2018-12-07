using System;
using System.Collections.Generic;
using System.IO;
using Projeto.Checkpoint.Interfaces;
using Projeto.Checkpoint.Models;

namespace Projeto.Checkpoint.Repositorios
{
    public class ComentarioRepositorio : IComentario
    {
        public ComentarioModel Comentar(ComentarioModel comentario)
        {

            using(StreamWriter sw = new StreamWriter("comentarios.csv", true)){
                sw.WriteLine($"{comentario.Usuario.Id};{comentario.Usuario.Nome};{comentario.Id};{comentario.Texto};{comentario.DataCriacao.ToShortDateString()}");
            }

            return comentario;
        }

        public List<ComentarioModel> Listar(){

            List<ComentarioModel> lsUsuarios = new List<ComentarioModel> ();

            if(File.Exists("comentarios.csv")){
                return lsUsuarios;
            }

            string[] linhas = System.IO.File.ReadAllLines ("comentarios.csv");

            ComentarioModel comentario ;

             foreach (var item in linhas) {

                //Verifica se a linha é vazia
                if (string.IsNullOrEmpty (item)) {
                    //Retorna para o foreach
                    continue;
                }

                string[] linha = item.Split (';');

                comentario = new ComentarioModel(
                    idUsuario: int.Parse(linha[0]),
                    nome: linha[1],
                    idComentario: int.Parse(linha[2]),
                    texto: linha[3],
                    datacriacao: DateTime.Parse(linha[4])
                );

               lsUsuarios.Add (comentario);
            }

            return lsUsuarios;

        }
    }
}