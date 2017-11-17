using System;

namespace Dominio
{
    /// <summary>
    /// Classe para guardar produtos
    /// </summary>
    public class Produto
    {

        public string Cod { get; set; }
        public string Nome { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }

        /// <summary>
        /// Método vazio
        /// </summary>
        public Produto()
        {
        }

        /// <summary>
        /// Método com parâmetros para guardar o produto
        /// </summary>
        /// <param name="cod">Código do produto em texto</param>
        /// <param name="nome">Nome do produto em texto</param>
        /// <param name="precoVenda">Preço de venda em double</param>
        /// <param name="precoCompra">Preço de compra em double</param>
        /// <param name="unidade">Unidade de medidas</param>
        /// <param name="data">Data de Cadastro</param>
        public Produto(string cod , string nome, double precoVenda, double precoCompra, string unidade, DateTime data)
        {   
            this.Cod = cod;
            this.Nome = nome;
            this.PrecoVenda = precoVenda;
            this.PrecoCompra = precoCompra;
            this.Unidade = unidade;
            this.Data = data;

        }
        



    }
}