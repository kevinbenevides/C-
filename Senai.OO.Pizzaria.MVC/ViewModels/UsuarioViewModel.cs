namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe responsável pelos dados do Usuário
    /// Herda da classe Base
    /// Para herdar utilizar : e o nome da classe que deseja herdar
    /// </summary>
    public class UsuarioViewModel : BaseViewModel
    {
        /// <summary>
        /// Email Usuário
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        ///  Senha Usuário
        /// </summary>
        public string Senha { get; set; }
    }
}