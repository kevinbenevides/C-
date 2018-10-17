using System;
namespace Exercicio1.Classes {
    public class Passagem {
        public int NumeroPassagem { get; set; }
        public string NomePassagem { get; set; }
        public DateTime DataVoo { get; set; }
        public Boolean Pet { get; set; }

        #region Métodos

        public void Receberdados () {
            Console.WriteLine ("Digite o Número da Passagem");
            NumeroPassagem = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o nome do passageiro");
            NomePassagem = Console.ReadLine ();
            Console.WriteLine ("Digite a data do Voo");
            DataVoo = DateTime.Parse (Console.ReadLine ());
            Console.WriteLine ("Leva Pet?");
            Pet = Boolean.Parse (Console.ReadLine ());
        }
        #endregion
    }
}