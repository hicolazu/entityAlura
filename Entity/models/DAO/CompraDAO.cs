using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class CompraDAO : IDisposable
    {
        private LojaRepository repo; 

        public CompraDAO()
        {
            this.repo = new LojaRepository();
        }

        public void adicionar()
        {
            Produto p = new Produto();
            p.Nome = "pao";
            p.Valor = 1.22;

            Compra c = new Compra();
            c.Produto = p;
            c.Quantidade = 6;
            c.Valor = (p.Valor * c.Quantidade);

            try
            {
                repo.Compras.Add(c);
                repo.SaveChanges();
                Console.WriteLine("Compra adicionada com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void Dispose()
        {
        }
    }
}
