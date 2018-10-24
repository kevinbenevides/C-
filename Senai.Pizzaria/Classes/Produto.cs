using System;
namespace Senai.Pizzaria.Classes {
    public class Produto {
        static Produto[] arrayproduto = new Produto[10000];
        static int contador = 0;
        public int Id = 0;
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        #region Métodos
        public static void CadastroProduto () {
            string nome;
            string descriacao;
            double preco;
            string categoria;

            System.Console.WriteLine ("\nDigite o Nome do Produto:");
            nome = Console.ReadLine ();

            System.Console.WriteLine ("\nDigite a Descrição do Produto:");
            descriacao = Console.ReadLine ();

            System.Console.WriteLine ("\nDigite o Preço:");
            preco = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("\nDigite a Categoria:(Pizza/Bebida)");
            categoria = Console.ReadLine ();

            switch (categoria) {
                case "Pizza":
                    {
                        categoria = "Pizza";
                        break;
                    }

                case "Bebida":
                    {
                        categoria = "Bebida";
                        break;
                    }

                default:
                    {
                        System.Console.WriteLine ("Categoria inválida");
                        break;
                    }
            }
            arrayproduto[contador] = new Produto ();
            arrayproduto[contador].Id = contador + 1;
            arrayproduto[contador].Nome = nome;
            arrayproduto[contador].Descricao = descriacao;
            arrayproduto[contador].Preco = preco;
            arrayproduto[contador].Categoria = categoria;
            contador++;

        }
        public static void Listar () {
            int escolhaid = -1;
            do {
                foreach (Produto pro in arrayproduto) {
                    if (pro == null) break;

                    System.Console.WriteLine ($"[{pro.Id}] - Nome:{pro.Nome}; Preço:R${pro.Preco};");
                    contador++;
                }
                System.Console.WriteLine("Digite o ID do produto que deseja exibir ou Digite 0 para sair:");
                escolhaid = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"[{arrayproduto[escolhaid].Id}] - Nome:{arrayproduto[escolhaid].Nome}");
                System.Console.WriteLine($"Preço:R${arrayproduto[escolhaid].Preco}");
                System.Console.WriteLine($"Descrição:{arrayproduto[escolhaid].Descricao}");
                System.Console.WriteLine($"Categoria:{arrayproduto[escolhaid].Categoria}");
                System.Console.WriteLine($"Data de Criação:{arrayproduto[escolhaid].DataCriacao}");

            }while(escolhaid != 0);
        }
        public static void Total(){
            double total = 0;
            foreach(Produto pt in arrayproduto){
            if(pt == null){
                break;}
            total += pt.Preco;
            }
            System.Console.WriteLine ($"Valor total dos Preços dos produtos: R${total}");
        }
        #endregion
    }
}