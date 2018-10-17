using System;

namespace Exercicio2.Classes
{
    public class Cadastro
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Endereco {get; set;}
        public int qtdcadastro;

        #region Métodos
        public void Dados(){
            for(int i = 0; i == qtdcadastro; i++  ){
                System.Console.WriteLine("Digite seu Nome: ");
                Nome = Console.ReadLine();
            }
        }

        #endregion
    }
}