using System;

namespace Dominio
{
    public class PJ : Pessoa
    {
        
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCriacao { get; set; }

        public PJ()
        {

        }
        public PJ(int id, string razaoSocial, string cnpj, string email, string telefone, DateTime dataCriacao, Endereco endereco)
        {
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