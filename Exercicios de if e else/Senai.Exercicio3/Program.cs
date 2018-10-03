using System;

namespace Sena.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            
            if (senha != 1234)
            {
                Console.WriteLine("Acesso Negado");
            }
            else {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
