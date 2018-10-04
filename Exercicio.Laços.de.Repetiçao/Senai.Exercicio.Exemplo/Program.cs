using System;

namespace Senai.Exercicio.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a tabuada que deseja calcular: ");
            int tabuada = int.Parse(Console.ReadLine());
            
            Console.Clear();
            
            Console.WriteLine($"Tabuada do {tabuada}");
            
            int contador = 0 ;

            //Criando o laço while
            while (contador < 10)
            {   
                int valor = tabuada * contador;
                Console.WriteLine($"{tabuada} x {contador} = {valor}");
                
                //Incrementa (pega o valor atual e adiciona + 1)
                contador++;
            }
        } 
    }
}
