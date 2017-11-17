using System;
using System.IO;
using System.Text;
using Dominio;


namespace Repositorio 
{
    public class GerenciarPedidos : IDominio
    {
        public string Cadastrar(Produto produto, Fornecedor fornecedor, Cliente cliente)
        {
            StreamWriter sv = null;
            string retorno; 
            try
            {
                sv = new StreamWriter("pedidos.csv", true);
                sv.WriteLine(produto.Cod + ";" + produto.Nome + ";" + produto.PrecoVenda + ";" 
                + produto.Data + ";" + produto.Unidade + ";"+ cliente.PF.Cpf+ ";" + cliente.PF.Nome+ ";" + DateTime.Now.ToLongDateString());
                retorno = "Cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao cadastrar : "+ ex.Message;
            }
            finally
            {
                sv.Close();
            }
            return retorno;
        }

        public string Cadastrar()
        {
            throw new NotImplementedException();
        }

        public string Consultar(string Texto)
        {
            string resultado = "Produto não encontrado";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("pedidos.csv", Encoding.Default);
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

        public string Consultar()
        {
            throw new NotImplementedException();
        }
    }

}