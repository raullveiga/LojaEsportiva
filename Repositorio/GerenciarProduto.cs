using System;
using System.IO;
using System.Text;
using Dominio;


namespace Repositorio
{
    public class GerenciarProduto
    {
        public void Cadastrar(Produto produto)
        {
            StreamWriter sv = null;
            try
            {
                sv = new StreamWriter("produtos.csv", true);
                sv.WriteLine(produto.Cod + ";" + produto.Nome + ";" + produto.PrecoVenda + ";" + produto.PrecoCompra + ";" + produto.Data + ";" + produto.Unidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sv.Close();
            }
        }
        public string Consultar(string Texto)
        {
            string resultado = "Produto não encontrado";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("produto.csv", Encoding.Default);
                string linha = "";
                while ((linha = ler.ReadLine()) != null)
                {
                    string[] dados = linha.Split(';');
                    if (dados[0] == Texto)
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

        public string Consultar(DateTime Data)
        {
            throw new NotImplementedException();
        }
    }

}