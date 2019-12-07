using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models.DAO
{
    public class PromocaoDAO
    {
        private LojaRepository repo;

        public PromocaoDAO()
        {
            this.repo = new LojaRepository();
        }

        public void adicionar(Promocao promocao)
        {
            try
            {
                repo.Promocoes.Add(promocao);
                repo.SaveChanges();
                Console.WriteLine("Promoção criada!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nDigite qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
