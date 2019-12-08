using Entity.models;
using Entity.models.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repo = new LojaRepository())
            {
                var promocao = repo.Promocoes
                    .Include(p => p.Produtos) //Lista de PromocaoProduto
                    .ThenInclude(pp => pp.Produto) //Lista de Produto
                    .FirstOrDefault();

                foreach(var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto.Nome);                
                }

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
            }

        }
    }
}
