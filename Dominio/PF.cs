using System;

namespace Dominio {
    public class PF : Pessoa {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa Pessoa { get; set; }


    }
}