using System;

namespace Senai.Exercicio2 {
    class Program {
        static void Main (string[] args) {
            //Recebendo o número de inicio
            Console.WriteLine ("Digite o número de início: ");
            int prinumero = int.Parse (Console.ReadLine ());

            //Recebendo o número de chegada
            Console.WriteLine ("Digite o número final: ");
            int ultnumero = int.Parse (Console.ReadLine ());

            int cont = prinumero;

            Console.Clear ();

            if (prinumero < ultnumero) {
                while (cont < ultnumero - 1) {
                    Console.WriteLine (cont);
                    cont++;
                }
            }
            else{
                while (cont > ultnumero + 1)
                {
                    cont--;
                    Console.WriteLine(cont);
                }
            }

        }
    }
}