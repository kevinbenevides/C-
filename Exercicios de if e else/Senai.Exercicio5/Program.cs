using System;

namespace Senai.Exercicio5 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o 1º Valor: ");
            int valor1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o 2º Valor: ");
            int valor2 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o 3º Valor: ");
            int valor3 = int.Parse (Console.ReadLine ());

            //Verifica se o valor1 é maior que Valor 2 "E"
            //Valor1 é maior que Valor3, neste caso
            //Valor1 é maior que todos

            if (valor1 > valor2 && valor1 > valor3) {
                 if (valor2 > valor3){
                    Console.WriteLine ($"{valor3}, {valor2}, {valor1}");
                }
                else {
                    Console.WriteLine($"{valor2}, {valor3}, {valor1}");
                }
            }
            else if (valor2 > valor1 && valor2 > valor3) {
                if (valor3 > valor1){
                    Console.WriteLine($"{valor1}, {valor3}, {valor2}");
                }else{
                    Console.WriteLine ($"{valor3}, {valor1}, {valor2}");}
            }
            else {
                if (valor1 > valor2){
                    Console.WriteLine($"{valor2}, {valor1}, {valor3}");
                }
                else{
                    Console.WriteLine($"{valor1}, {valor2}, {valor3}");    
                }
            }
        }
    }
}