namespace Senai.OO.Exercicio8.classes
{
    public class Funcionarios
    {
        public string Nome;
        public int HorasTrabalhadas;
        public double ValorHora;

        #region Métodos
        
        public double CalcularValorProjeto()
        {
            //Calculando o total atraves dos atributos
            double total = ValorHora * HorasTrabalhadas;
            return total;
        }
        
        
        #endregion
    }
}