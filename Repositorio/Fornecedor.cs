using Dominio;
using System;
using System.IO;

namespace Repositorio
{
    public class Fornecedor : IDominio
    {

        public PJ Empresa { get; set; }
        public string Categoria { get; set; }
        


        public Fornecedor(PJ empresa, string categoria, DateTime dataCadastro)
        {
            this.Empresa = empresa;
            this.Categoria = categoria;
            

        }

        public string Cadastrar()
        {
            throw new NotImplementedException();
        }

        public string Consultar()
        {
            throw new NotImplementedException();
        }
    }
}