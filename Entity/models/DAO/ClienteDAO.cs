using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models.DAO
{
    public class ClienteDAO
    {
        private LojaRepository repo;

        public ClienteDAO()
        {
            this.repo = new LojaRepository();
        }

        public void adicionar()
        {
            var cliente = new Cliente();
            cliente.Nome = "Janna";
            cliente.Endereco = new Endereco()
            {
                Numero = 12,
                Logradouro = "Alameda das Américas",
                Bairro = "Guilhermina",
            };


            try
            {
                repo.Clientes.Add(cliente);
                repo.SaveChanges();
                Console.WriteLine("Cliente adicionado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
