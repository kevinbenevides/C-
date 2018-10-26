namespace Senai.OO.Pizzaria.MVC.Util
{
    /// <summary>
    /// Classe responsável pelas validações de campos do sistema
    /// </summary>
    public static class ValidacaoUtil
    {
        /// <summary>
        /// Valida email do usuário, verifica se o mesmo possui @ e .
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Retorna true caso o email possua @ e . e false se não possuir</returns>
        public static bool ValidarEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se a senha informada possui mais que 6 caracteres
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>Retorna true caso a senha possua mais que 6 caracters e false se não possuir</returns>
        public static bool ValidarSenha(string senha){
            if(senha.Length >= 6){
                return true;
            }

            return false;
        }

        /// <summary>
        /// Validar a Categoria do Produto
        /// </summary>
        /// <param name="categoria">Categoria do produto(pizza/bebida)</param>
        /// <returns>Retorna true se categoria for pizza/bebida ou false caso contrario</returns>
        public static bool ValidarCategoria(string categoria){
            if(categoria.ToLower() == "pizza" || categoria.ToLower() == "bebida"){
                return true;
            }

            return false;
        }
    }
}