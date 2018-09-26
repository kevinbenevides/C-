using System;

namespace Senai.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            string Nome;
            sbyte Idade;
            float Altura;
            DateTime dataNascimento;
            char Sexo;

            Console.WriteLine("Informe o seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            Idade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Informe sua altura:");
            Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua data de nascimento:");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo [M/F]:");
            Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + Nome + 
            ", Idade: " + Idade + 
            ", Altura: " + Altura + 
            ", Data de nascimento: " + dataNascimento.ToShortDateString() + 
            ", Sexo:" + Sexo);

        }
    }
}
