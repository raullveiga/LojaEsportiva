using System;

namespace Dominio {
    public class PF : Pessoa {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public PF () { }

        public PF (int id, string nome, string cpf, string email, string telefone, DateTime dataNascimento, Endereco endereco) {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
            this.Endereco = endereco;

        }

    }
}