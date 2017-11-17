using System;

namespace Dominio {
    public class PF {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa Pessoa { get; set; }
        public PF () { }

        public PF (string cpf, string nome, DateTime dataNascimento, Pessoa pessoa) {
            this.Cpf = cpf;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Pessoa = pessoa;

        }

    }
}