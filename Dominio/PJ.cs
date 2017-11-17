using System;

namespace Dominio.classes
{
    public class PJ 
    {
        
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCriacao { get; set; }
        public Endereco endereco { get; set; }

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
            this.endereco = endereco;

        }
    }
}