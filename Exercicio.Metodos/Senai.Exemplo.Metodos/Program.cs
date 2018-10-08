using System;
using Senai.Exemplo.Metodos.Classes;

namespace Senai.Exemplo.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.NivelTanque = 50;
            carro1.Ligar();
            carro1.Andar(125);
            carro1.Andar(200);
            carro1.Andar(125);
            Console.WriteLine("Nivel do Tanque = " + carro1.NivelTanque);
            Console.WriteLine("Total km = " + carro1.Odometro);

            Carro corsa = new Carro();
            corsa.Ligar();
            
            
            float Nivel = corsa.Abastecer(20);
            Nivel = corsa.Abastecer(25);
            System.Console.WriteLine("Tanque" + Nivel );
            
            
            
            
            //corsa.NivelTanque = 45;
            corsa.CapacidadeTanque = 45;
            corsa.PotenciaDoMotor = 1.0f;
            corsa.KilometroPorLitro = 15;
            corsa.Andar(100);
            Console.WriteLine("Nivel do Tanque = " + corsa.NivelTanque);
            Console.WriteLine("Total km = " + corsa.Odometro);

        }
    }
}
