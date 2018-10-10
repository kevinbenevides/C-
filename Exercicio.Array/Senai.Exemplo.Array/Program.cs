using System;

namespace Senai.Exemplo.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            int contador = 0;

            do{
                System.Console.WriteLine("Informe um números");
                numeros[contador] = int.Parse(Console.ReadLine());
                contador++;
            }while (contador < numeros.Length);

           // System.Console.WriteLine("O numero na posição 2 é:" + numeros[1]);
           
           System.Array.Sort(numeros);

           contador = 0; 
           do{
               System.Console.WriteLine($"Número na posição {contador} é {numeros[contador]}");
               contador++;
           }while (contador < numeros.Length);
        }
    }
}
