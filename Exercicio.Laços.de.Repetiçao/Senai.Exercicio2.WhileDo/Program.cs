using System;

namespace Senai.Exercicio2.WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int cont = 0;
            //int contador = 0;
           
            do{    
               cont +=2;
               Console.WriteLine(cont);
               //contador++;
            }

            while (cont < numero);

            Console.WriteLine($"Quantidade: {numero/2 -1}");
        }
    }
}
