using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
