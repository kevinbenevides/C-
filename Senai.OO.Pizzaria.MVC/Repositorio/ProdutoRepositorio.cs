using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        static List<ProdutoViewModel> lsProduto = new List<ProdutoViewModel>();

        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            //Incrementa 1 no Id do objeto
            produto.Id = lsProduto.Count + 1;
            //Define a Data e Hora da inserção do objeto lista
            produto.DataCriacao = DateTime.Now;
            //Adiciona o produto a lista
            lsProduto.Add(produto);
            //Retorna um produto
            return produto;
        }

        public static List<ProdutoViewModel> Listar(){
            return lsProduto;
        }

        public static ProdutoViewModel BuscarPorId(int id){
            foreach (ProdutoViewModel item in lsProduto)
            {
                if(item.Id == id){
                    return item;
                }
            }
            return null;
        }
    }
}