using Dominio;
using System;
using System.IO;
using System.Text;

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
        }
    }
