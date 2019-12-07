using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; } 

    }
}
