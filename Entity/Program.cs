using Entity.models;
using System;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var repoProduto = new ProdutoDAO();
            var repoCompra = new CompraDAO();

            repoProduto.adicionar();
            repoProduto.listar();

            repoCompra.adicionar();
            
        }
    }
}
