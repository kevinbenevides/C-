using System;
using Senai.Exercicio3.Classes;

namespace Senai.Exerciocio._3 {
    class Program {
        static void Main (string[] args) {
            int opcao;
            Porta porta1 = new Porta ();

            do {

                Console.WriteLine ("Escolha a opção");
                System.Console.WriteLine ("1 = Abrir");
                System.Console.WriteLine ("2 = Fechar");
                System.Console.WriteLine ("0 = Sair");

                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        {
                            if (porta1.Aberta) {
                                System.Console.WriteLine ("Não precisa se esforçar para nada");
                            } else {
                                System.Console.WriteLine ("A porta Abriu");
                                porta1.Abrir ();
                            }
                            break;
                        }
                    case 2:
                        {
                            //!porta1.Aberta e o mesmo que porta1.Aberta == false
                            if (porta1.Aberta) {
                                System.Console.WriteLine ("A porta fechou");
                                porta1.Fechar ();
                            } else {
                                System.Console.WriteLine ("Porta já esta fechada");
                            }
                            break;
                        }
                    case 0:
                        {
                            System.Console.WriteLine ("Obrigado pela visita!!!");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Opção Inválida");
                            break;
                        }
                }

            } while (opcao != 0);

        }
    }
}