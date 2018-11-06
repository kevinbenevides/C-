using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewsControllers;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers
{
    /// <summary>
    /// Classe responsável pela visualização e controle dos dados
    /// </summary>
    public class ProdutoViewController
    {
        #region View
        //Objeto responsável pela gravação e leitura dos dados
        static ProdutoRepositorio produtoRep = new ProdutoRepositorio();
        public static void CadastrarProduto(){
            string nome, descricao, categoria, preco;

            do{
                System.Console.WriteLine("Informe o nome do produto");
                nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome do produto inválido");
                }

            }while (string.IsNullOrEmpty(nome));

            do{
                System.Console.WriteLine("Informe o nome do descrição");
                descricao = Console.ReadLine();
                
                if(string.IsNullOrEmpty(descricao)){
                    System.Console.WriteLine("descricao do produto inválido");
                }
                
            }while (string.IsNullOrEmpty(descricao));

            do{
                System.Console.WriteLine("Informe o preco do produto");
                preco = Console.ReadLine();
                
                if(string.IsNullOrEmpty(preco)){
                    System.Console.WriteLine("Preco do produto inválido");
                }
                
            }while (string.IsNullOrEmpty(preco));

            do{
                System.Console.WriteLine("Informe a categoria(pizza ou bebida)");
                categoria = Console.ReadLine();
                
                if(string.IsNullOrEmpty(categoria)){
                    System.Console.WriteLine("Categoria inválida");
                }
                
            }while (string.IsNullOrEmpty(categoria));
            #endregion
            
            #region Controller
            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = decimal.Parse(preco);
            produtoViewModel.Categoria = categoria;

            produtoRep.Inserir(produtoViewModel);

            System.Console.WriteLine("Produto Cadastrado");
            #endregion
        }
            public static void ListarProdutos(){
                List<ProdutoViewModel> lsProduto = produtoRep.Listar();
                int idProduto = 0;
                do{
                    foreach (ProdutoViewModel item in lsProduto){
                        System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");
                    }

                System.Console.WriteLine("Informe o ID do produto para mais informações ou 0 para sair:");
                idProduto = int.Parse(Console.ReadLine());

                if(idProduto == 0){
                    break;
                }

                ProdutoViewModel produtoViewModel = produtoRep.Inserir();
                
                }while(idProduto != 0);
            }
    }
}