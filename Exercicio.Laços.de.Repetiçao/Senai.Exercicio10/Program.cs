using System;

namespace Senai.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario irá inserir um número
            Console.WriteLine("Digite o número: ");
            int digito = int.Parse(Console.ReadLine());
            
            int contador = 0;

            int soma = digito;

            //Se o número digitado for > 0
            //O laço continuará a pedir valores
            
            while (digito > 0)
            {

            //Recebe o segundo valor utilizando a mesma variavel
            //para armazenar os dados
            Console.WriteLine("Digite mais um número ou digite 0 para finalizar: ");
            digito =int.Parse(Console.ReadLine());
            
            //Adiciona +1 ao contador toda vez que se inicia o ciclo 
            contador++;

            //Adiciona o valor de "digito" para o de "soma"
            //Armazena o rezultadp em "soma" e retorna um novo valors
            soma += digito;
            }

            System.Console.WriteLine($"Resultado da soma: {soma}");
            System.Console.WriteLine($"Quantidade de número: {contador}");
            System.Console.WriteLine($"Media dos valores inseridos: {soma/contador}");
            System.Console.WriteLine($"Media dos numeros pares: {soma %2}");


        }
    }
}
