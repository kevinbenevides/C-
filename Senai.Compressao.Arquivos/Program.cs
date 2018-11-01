using System;
using System.IO;
using System.IO.Compression;

namespace Senai.Compressao.Arquivos {
    class Program {
        static void Main (string[] args) {
            /// <summary>
            /// Menu do Sistema de Compactação de arquivos
            /// </summary>
            #region Menu
            int escolha;
            Console.Clear();
            System.Console.WriteLine ("Bem-Vindo ao Sistema Zip-Zap");
            System.Console.WriteLine("\nVocê fala que quer um 'Zip' e ele 'Zap'");
            do {
                System.Console.WriteLine ("\nEscolha uma opção: ");
                System.Console.WriteLine ("\n[1] - Compactar uma pasta");
                System.Console.WriteLine ("[2] - Extrair uma pasta compactada");
                System.Console.WriteLine ("[0] - Sair\n");
                escolha = int.Parse (Console.ReadLine ());

                #region Opcoes

                switch (escolha) {
                    case 1:
                        {
                            Console.Clear ();
                            
                            System.Console.WriteLine ("Bem vindo a compactação de Pasta");

                            Console.WriteLine ("\nDigite o diretório de destino que deseja compactar: ");
                            System.Console.WriteLine ("Ex: C:/Exemplo/Pasta_exemplo\n");//Caminho do diretório
                            string diretorio = Console.ReadLine ();

                            Console.WriteLine ("\nDigite o local para onde a pasta será compactada: ");
                            System.Console.WriteLine ("Ex: C:/Exemplo/MeuArquivo.zip\n");//Caminho do arquivo zip a ser criado
                            string arquivo = Console.ReadLine ();

                            ZipFile.CreateFromDirectory (diretorio, arquivo);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear ();
                            
                            System.Console.WriteLine("Bem vindo a extração de arquivo");

                            System.Console.WriteLine ("\nDigite o caminho onde sera criado a extração:");
                            System.Console.WriteLine ("Ex: C:/MinhaPasta\n");
                            string diretorio = Console.ReadLine (); //Caminho do diretório a ser criado

                            System.Console.WriteLine ("\nDigite o caminho do arquivo zip a ser extraido:");
                            System.Console.WriteLine ("EX: C:/MinhaPasta.zip\n");
                            string arquivo = Console.ReadLine (); //Caminho do arquivo zip a ser extraído

                            ZipFile.ExtractToDirectory (arquivo, diretorio);
                            break;
                        }

                    case 0:
                        {
                            Console.Clear ();
                            System.Console.WriteLine ("");
                            break;
                        }

                    default:
                        {
                            Console.Clear ();
                            System.Console.WriteLine ("Opção inválida");
                            break;
                        }
                }

                #endregion

            } while (escolha != 0);
            #endregion

        }
    }
}