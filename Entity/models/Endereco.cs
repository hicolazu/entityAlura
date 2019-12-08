using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
    }
}
