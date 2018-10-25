namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe responsável pelas informações do Produto
    /// Herda da classe BaseViewModel
    /// </summary>
    public class ProdutoViewModel : BaseViewModel
    {
        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preço do Produto
        /// </summary>
        public decimal Preco { get; set; } 
        /// <summary>
        /// Categoria do Produto
        /// </summary>
        public string Categoria { get; set; }       
    }
}