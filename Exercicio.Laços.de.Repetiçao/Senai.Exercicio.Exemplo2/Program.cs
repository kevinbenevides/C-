using System;
using Senai.Exercicio.Exemplo2.classes;

namespace Senai.Exercicio.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o objeto calculadora
            Calculadora calculadora = new Calculadora();
            char resposta = 'S';

            while(resposta == 'S'){
                
                Console.WriteLine("Qual a tabuada que deseja calcular: ");
                calculadora.Fator = int.Parse(Console.ReadLine());
                calculadora.contador = 0 ;
                
                Console.Clear();
                
                Console.WriteLine($"Tabuada do {calculadora.Fator}");
                

                //Criando o laço while
                while (calculadora.contador <= 10)
                {   
                    calculadora.Valor = calculadora.Fator * calculadora.contador;
                    Console.WriteLine($"{calculadora.Fator} x {calculadora.contador} = {calculadora.Valor}");
                    
                    //Incrementa (pega o valor atual e adiciona + 1)
                    calculadora.contador++;
                }

                //Perguntar se o usuário deseja calcular outra tabuada
                Console.WriteLine("Deseja criar um outra tabuada? [S/N]");
                resposta = char.Parse(Console.ReadLine());

                //Converter o caractere para sempre ser Maiusculo
                resposta = char.ToUpper(resposta);
            }
        } 
    }
}
