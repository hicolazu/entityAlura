using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class Produto
    {

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public double Valor { get; internal set; }

        public IList<PromocaoProduto> Promocoes { get; set; }

    }
}
