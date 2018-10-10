namespace Senai.Exercicio3.Classes
{
    public class Porta
    {
        public bool Aberta {get; private set; } = false;

        public void Abrir(){
            Aberta = true;
        }

        public void Fechar(){
            Aberta = false;
        }
    }
}