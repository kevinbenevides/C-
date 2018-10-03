using System;

namespace Senai.Exercicio.Swirch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do dia da semana: ");
            int diaSemana = int.Parse(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:{
                    Console.WriteLine("Domingo");
                    break;
                }

                case 2:{
                    Console.WriteLine("Segunda");
                    break;
                }
                case 3:{
                    Console.WriteLine("Terça");
                    break;
                }
                case 4:{
                    Console.WriteLine("Quarta");
                    break;
                }
                case 5:{
                    Console.WriteLine("Quinta");
                    break;
                }
                case 6:{
                    Console.WriteLine("Sexta");
                    break;
                }
                case 7:{
                    Console.WriteLine("Sabado");
                    break;
                }
                default:{
                    Console.WriteLine("Dia inválido");
                    break;
                }
            }
        }
    }
}
