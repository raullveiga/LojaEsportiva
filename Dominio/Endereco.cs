namespace Dominio

{
    /// <summary>
    /// Classe para as informações de endereço
    /// </summary>
    public class Endereco
    {   
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }


        /// <summary>
        /// Método vazio
        /// </summary>
        public Endereco()
        {

        }

        /// <summary>
        /// Método Completo para guardar endereço
        /// </summary>
        /// <param name="logradouro"> Rua em texto</param>
        /// <param name="numero"> Número em texto</param>
        /// <param name="complemento">Complemento em texto</param>
        /// <param name="bairro">Bairro em texto</param>
        /// <param name="cidade">Cidade em texto</param>
        /// <param name="uf">Estado em texto</param>
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

