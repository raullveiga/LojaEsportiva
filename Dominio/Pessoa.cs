using System;

namespace Dominio {
    public class Pessoa {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Pessoa () { }

        public Pessoa (int id, string email, string telefone, Endereco endereco, DateTime dataCadastro) {
            this.Id = id;
            this.Email = email;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.DataCadastro = dataCadastro;
        }
    }
}