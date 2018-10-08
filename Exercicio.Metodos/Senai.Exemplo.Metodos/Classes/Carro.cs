using System;

namespace Senai.Exemplo.Metodos.Classes
{
    public class Carro
    {   
        #region Atributos
        //Declaração de Variaveis da Classe Carro
        public float PotenciaDoMotor = 1.0f;
        public float KilometroPorLitro = 10;
        public float NivelTanque = 0;
        public float CapacidadeTanque = 40;
        public bool Ligado = false;
        public float Odometro;
        #endregion

        #region Métodos
        /// <summary>
        /// Liga o carro
        /// </summary>
            public void Ligar(){
                Console.WriteLine("Carro Ligado");
                Ligado = true;
            }

        /// <summary>
        /// Faz o carro andar
        /// </summary>
        /// <param></param>
        public void Andar(float kilometragem){
            if (Ligado){
                
                //Calculando o consumo de litros por km
                float consumo = kilometragem/KilometroPorLitro;
                
                if (NivelTanque >= consumo){
                
                //Retira o consumo do nivel do tanque
                NivelTanque -= consumo;
                
                //Acrescenta a kilometragem informada
                Odometro += kilometragem;
                Console.WriteLine($"Andou e consumiu {consumo}L");
                } else {
                    System.Console.WriteLine("Carro sem combustível, abasteça.");
                }
            }
            else {
                Console.WriteLine("Ligue o Carro");
            }
        }

        /// <summary>
        /// Abastece o carro
        /// </summary>
        /// <param name="quantidade">Informe a quantidade de litro</param>
        /// <returns>Retorna o nivel do tanque</returns>
        public float Abastecer(float quantidade){
            NivelTanque = quantidade;
            return NivelTanque;
        }
        #endregion
    }
}