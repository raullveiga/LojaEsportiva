using System;

namespace Dominio {
    /// <summary>
    /// Classe que recebe as informações do cliente PF
    /// </summary>
    public class PF : Pessoa {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Método construtor sem parametros;
        /// </summary>
        public PF () { }
        
        /// <summary>
        /// Método construtor que recebe como parametro os dados do Cliente PF;
        /// </summary>
        /// <param name="id">Código do cliente tipo Inteiro</param>
        /// <param name="nome">Nome do cliente tipo String</param>
        /// <param name="cpf">CPF do cliente tipo String</param>
        /// <param name="email">Email do cliente tipo String</param>
        /// <param name="telefone">Telefone do cliente tipo String</param>
        /// <param name="dataNascimento">Data de Nascimento  do cliente tipo DateTime</param>
        /// <param name="endereco">Endereço do cliente tipo Endereco</param>
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