using System;

namespace Senai.Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o dia do nascimento: ");
            int diaNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o mês do nascimento: ");
            int mesNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano do nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            //Verifica se o dia de nascimento está entre 0 e 31
            if(diaNascimento <= 0 || diaNascimento > 31){
                Console.WriteLine("Dia de nascimento é inválido");
            //Verifica se o mês de nascimento está entre 0 e 12
            }else if (mesNascimento <= 0 || mesNascimento > 12)
            {
                Console.WriteLine("Mês de Nascimento inválido");
            //Verifica se o ano de nascimento está entre 0 e 2013
            }else if(anoNascimento <= 0 || anoNascimento > 2013){
                Console.WriteLine("Ano de Nascimento inválido");
            }
            else {
                Console.WriteLine($"Sua Data de nascimento é: {diaNascimento}/{mesNascimento}/{anoNascimento}");
            }
        }
    }
}
