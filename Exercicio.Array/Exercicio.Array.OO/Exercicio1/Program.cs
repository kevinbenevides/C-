using System;
using Exercicio1.Classes;

namespace Senai.Exdercicio.Arrays {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Tsukamoto AirLines");

            int resposta;
            Passagem[] passagens = new Passagem[3];
            int cont = 0;
            int contExibir = 0;

            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Agendar Viagem");
                Console.WriteLine ("2 - Exibir Viagens");
                Console.WriteLine ("0 - Sair");
                resposta = int.Parse (Console.ReadLine ());
                switch (resposta) {
                    case 1:
                        {
                            if (cont < 3) {
                                //Instanciar um objeto do vetor?
                                passagens[cont] = new Passagem();
                                passagens[cont].Receberdados();
                                cont++;
                            } else {
                                Console.WriteLine ("Limite de passagens Excedida");
                            }
                            break;
                        }
                    case 2:
                        {
                            contExibir = 0;
                            while (contExibir < cont) {
                                Console.WriteLine ($"\nNome: {passagens[contExibir].NomePassagem},\t Nº Passagem: {passagens[contExibir].NumeroPassagem},\t Data: {passagens[contExibir].DataVoo.ToShortDateString()},\t Leva Pet? R:{passagens[contExibir].Pet}");
                                contExibir++;
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Obrigado e Thau.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Valor Inválido");
                            break;
                        }
                }

            } while (resposta != 0);
        }
    }
}