using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public IList<PromocaoProduto> Produtos { get; set; }

        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public void IncluiProduto(Produto p1)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = p1} );
        }
    }
}
