namespace Dominio.classes
{
    public class Endereco
    {   
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }


        public Endereco()
        {

        }

        public Endereco(string logradouro, string numero, string complemento, string bairro, string cidade, string uf)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Uf = uf;
        }



    }
}

