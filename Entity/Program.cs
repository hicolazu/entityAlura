using Entity.models;
using Entity.models.DAO;
using System;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            //var repoProduto = new ProdutoDAO();
            //var repoCompra = new CompraDAO();
            //var repoPromocao = new PromocaoDAO();
            var repoCliente = new ClienteDAO();

            //repoProduto.adicionar();

            //repoCompra.adicionar();

            //var p1 = new Produto();
            //p1.Nome = "pao frances";
            //p1.Valor = 2;

            //var p2 = new Produto();
            //p2.Nome = "pao italiano";
            //p2.Valor = 3;


            //var promocaoDePascoa = new Promocao();
            //promocaoDePascoa.Descricao = "Promoção Páscoa Feliz";
            //promocaoDePascoa.DataInicio = DateTime.Now;
            //promocaoDePascoa.DataFim = DateTime.Now.AddMonths(3);

            //promocaoDePascoa.IncluiProduto(p1);
            //promocaoDePascoa.IncluiProduto(p2);

            //repoPromocao.adicionar(promocaoDePascoa);

            //repoProduto.listarPorNome("Teste");

            repoCliente.adicionar();

        }

    }
}
