using System;

namespace Dominio {
    /// <summary>
    /// Classe que recebe os dados do cliente PJ
    /// </summary>
    public class PJ : Pessoa {

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// Método construtor sem parametros;
        /// </summary>
        public PJ () { }

        /// <summary>
        /// Método construtor que recebe como parametro os dados do Cliente PJ;
        /// </summary>
        /// <param name="id">Código do cliente tipo Inteiro</param>
        /// <param name="razaoSocial">Razão social do cliente tipo String</param>
        /// <param name="cnpj">CNPJ do cliente tipo String</param>
        /// <param name="email">Email do cliente tipo String</param>
        /// <param name="telefone">Telefone do cliente tipo String</param>
        /// <param name="dataCriacao">Data de Criação  do cliente tipo DateTime</param>
        /// <param name="endereco">Endereço do cliente tipo Endereco</param>
        public PJ (int id, string razaoSocial, string cnpj, string email, string telefone, DateTime dataCriacao, Endereco endereco) {
            this.Id = id;
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Email = email;
            this.Telefone = telefone;
            this.DataCriacao = dataCriacao;
            this.Endereco = endereco;

        }
    }
}