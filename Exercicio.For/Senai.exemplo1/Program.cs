using System;

namespace Senai.exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo o x
            Console.WriteLine("Insira um número: ");
            int x = int.Parse(Console.ReadLine());

            //Recebendo o limite
            Console.WriteLine("Insira o limite: ");
            int limite = int.Parse(Console.ReadLine());

            //Laço de tabuada
            for(int cont = 0; cont <= limite; cont++)
            {
                Console.WriteLine($"{x} x {cont} = {x * cont}");
            }
        }
    }
}
