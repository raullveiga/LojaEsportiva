using Dominio;
using System;
using System.IO;
using System.Text;

namespace Repositorio
{
    public class Fornecedor : IDominio
    {

        public Fornecedor(PJ empresa, string categoria) 
        {
            this.Empresa = empresa;
                this.Categoria = categoria;
               
        }
                public PJ Empresa { get; set; }
        public string Categoria { get; set; }
        


        public Fornecedor(PJ empresa, string categoria, DateTime dataCadastro)
        {
            this.Empresa = empresa;
            this.Categoria = categoria;
            

        }

        public string Cadastrar(PJ empresa)
        {
            string rt = "";

            StreamWriter sv = null;

            try
            {
                sv = new StreamWriter("produtos.csv", true);                
                sv.WriteLine(   empresa.Id+";"+empresa.RazaoSocial+";"+empresa.Email+";"+empresa.Telefone+";"+empresa.DataCriacao+";"+
                                empresa.Endereco.Logradouro+";"+empresa.Endereco.Numero+";"+empresa.Endereco.Complemento+";"+empresa.Endereco.Bairro+";"+
                                empresa.Endereco.Cidade+";"+empresa.Endereco.Uf+";"+DateTime.Now.ToShortDateString());
                rt = "Fornecedor cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
               rt = "Erro ao tentar cadastrar"+ex.Message;
                
            }
            finally{
                sv.Close();
            }
            return rt;
        }

        public string Consultar(string NomeFornecedor)
        {
             string resultado = "Fornecedor não encontrado";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("fornecedor.csv", Encoding.Default);
                string linha = "";
                while ((linha = ler.ReadLine()) != null)
                {
                    string[] dados = linha.Split(';');
                    if (dados[0] == NomeFornecedor)
                    {
                        resultado = linha;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = "erro ao tentar ler o arquivo. " + ex.Message;

            }
            finally
            {
                ler.Close();
            }
            return resultado;
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
