using System;

namespace Senai.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            
            Console.WriteLine();

            Console.WriteLine("Confirme sua senha: ");
            string senha1 = Console.ReadLine();

            Console.Clear();

            while (senha == senha1 )
            {
                Console.WriteLine("Senha Correta. Acesso garantido");
                break;
            }

            while(senha != senha1){
                Console.WriteLine("Senha Incorreta. Acesso Negado");
                Console.Clear();
                System.Console.WriteLine("Digite a senha novamente: ");
                senha1 = Console.ReadLine();
                
            }
            Console.Clear();
            Console.WriteLine("Senha Correta. Acesso garantido");
            Console.WriteLine();
        }

    }
}
