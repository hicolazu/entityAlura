using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.models
{
    class ProdutoDAO : IDisposable
    {
        //CRUD

        private LojaRepository repo; 

        public ProdutoDAO()
        {
            this.repo = new LojaRepository();
        }

        public void adicionar()
        {
            int count = 0;

            Console.Write("Deseja adicionar quantos produtos? ");
            int vezes = int.Parse(Console.ReadLine());

            do {
                Produto produto = new Produto();
                Console.Write("Informe o nome do {0}º produto: ", (count + 1));
                produto.Nome = Console.ReadLine();
                Console.Write("\nInforme o valor do {0}º produto: ", (count + 1));
                produto.Valor = double.Parse(Console.ReadLine());

                try
                {
                    repo.Produtos.Add(produto);
                    repo.SaveChanges();
                    Console.WriteLine("Produto Adicionado!\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro!\n{0}\n", e);
                }
            count++;
            }
            while (count < vezes);

            Console.WriteLine("Digite qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public void remover(Produto p)
        {
            repo.Produtos.Remove(p);
            repo.SaveChanges();

            Console.WriteLine("Digite qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public void atualizar(Produto p)
        {
            repo.Produtos.Update(p);
            repo.SaveChanges();

            Console.WriteLine("Digite qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public void listar()
        {
            int count = 0;
            IList<Produto> listaProdutos =  repo.Produtos.ToList();
            foreach(var item in listaProdutos)
            {
                Console.Write("{0} produto(s) encontrado(s)!   ", (count+1));
                Console.WriteLine(item.Nome);
                count++;
            }
            Console.WriteLine("Digite qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public IList<Produto> listarPorCategoria(string categoria)
        {
            IList<Produto> Produtos = repo.Produtos.Where(p => p.Categoria == categoria).ToList();
            return Produtos;
        }

        public void listarPorNome(string nome)
        {
            var Produtos = repo.Produtos.Where(p => p.Nome == nome).OrderBy(p => p.Id);

            Console.WriteLine(" Id  ---  Nome  ---  Valor\n");
            
            foreach (var p in Produtos)
            {
                Console.WriteLine(p.Id + "   " + p.Nome + "   " + p.Valor);
            }

            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void Dispose()
        {
        }
    }
}
