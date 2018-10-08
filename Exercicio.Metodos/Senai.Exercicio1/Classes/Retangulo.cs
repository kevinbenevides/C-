using System;
namespace Senai.Exercicio1.Classes
{
    public class Retangulo
    {   
        #region Atributos
        public float LadoA;
        public float LadoB;

        #endregion

        #region Métodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A area do retangulo </returns>
        public float Area(){
            return LadoA*LadoB;
        }

        public float Perimetro(){
            return (LadoA + LadoB)*2;
        }

        #endregion
    }
}