using System;

namespace Senai.Exercicio.WhileDo.EX
{
    class Program
    {
        static void Main(string[] args)
        {

            string email;

            do{
                Console.WriteLine("Digite seu E-Mail: ");
                email = Console.ReadLine();

            }while (string.IsNullOrEmpty(email) || email.Contains("@") == false);
            {
                Console.WriteLine("O Email é válido");
            }
        }
    }
}
