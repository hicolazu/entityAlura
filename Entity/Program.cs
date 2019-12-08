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
            //ExibirEnderecoDeClientes();

            //ExibeProdutosdaPromocao();

            WherecomJoin();
        }

        public static void ExibeProdutosdaPromocao()
        {
            using (var repo = new LojaRepository())
            {
                //Join para relacionamento N:N
                var promocao = repo.Promocoes
                    .Include(p => p.Produtos) //Lista de PromocaoProduto
                    .ThenInclude(pp => pp.Produto) //Lista de Produto
                    .FirstOrDefault();

                // OU

                var promocao2 = repo.Promocoes
                    .Include("Produtos.Produto")
                    .FirstOrDefault();

                foreach(var item in promocao2.Produtos)
                {
                    Console.WriteLine(item.Produto.Nome);
                }

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public static void WherecomJoin()
        {
            using (var repo = new LojaRepository())
            {
                var produto = repo
                    .Produtos
                    .Where(p => p.Id == 6)
                    .FirstOrDefault();

                //Segundo Select para retornar mais uma cláusula Where
                repo.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Valor > 10)
                    .Load();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");

                foreach(var item in produto.Compras)
                {
                    Console.WriteLine("\t" + item);
                }
            }

            Console.ReadKey();
        }

        public static void ExibirEnderecoDeClientes()
        {
            using (var repo = new LojaRepository())
            {
                //Left Join para relacionamento 1:1
                var cliente = repo.Clientes
                    .Include(c => c.Endereco)
                    .FirstOrDefault();

                Console.WriteLine(cliente.Endereco.Logradouro);

                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
