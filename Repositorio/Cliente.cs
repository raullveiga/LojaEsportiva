using System;
using System.IO;
using Dominio;

namespace Repositorio {

    /// <summary>
    /// Classe que grava e consulta os clientes PF e PJ
    /// </summary>
    public class Cliente : IDominio {
        public PF PF { get; set; }
        public PJ PJ { get; set; }

        /// <summary>
        /// Método Cadastrar sem parametros;
        /// </summary>
        /// <returns>Retorno nulo</returns>
        public string Cadastrar () {
            return null;
        }

        /// <summary>
        /// Método para cadastrar um cliente.
        /// </summary>
        /// <param name="clientePf">Recebe como parametro as informações do Cliente PF</param>
        /// <returns>Retorna uma mensagem informando se o cliente foi cadastrado ou não</returns>
        public string Cadatrar (PF clientePf) {
            string msg = "";
            StreamWriter sw = null;
            FileInfo fi = new FileInfo ("ClientesPF.csv");

            try {
                if (fi.Length == 0) {
                    sw = new StreamWriter ("ClientesPF.csv");
                    sw.WriteLine ("ID;CPF;NOME;EMAIL;TELEFONE;DATA_NASCIMENTO;LOGRADOURO;NUMERO;COMPLEMENTO;BAIRRO;CIDADE;UF;DATA_CADASTRO");
                    sw.WriteLine (PF.Id + ";" + PF.Cpf + ";" + PF.Nome + ";" + PF.Email + ";" + PF.DataNascimento + ";" +
                        PF.Endereco.Logradouro + ";" + PF.Endereco.Numero + ";" + PF.Endereco.Complemento + ";" + PF.Endereco.Bairro + ";" +
                        PF.Endereco.Cidade + ";" + PF.Endereco.Uf + ";" + DateTime.Now.ToShortDateString ());
                } else {
                    sw.WriteLine (PF.Id + ";" + PF.Cpf + ";" + PF.Nome + ";" + PF.Email + ";" + PF.DataNascimento + ";" +
                        PF.Endereco.Logradouro + ";" + PF.Endereco.Numero + ";" + PF.Endereco.Complemento + ";" + PF.Endereco.Bairro + ";" +
                        PF.Endereco.Cidade + ";" + PF.Endereco.Uf + ";" + DateTime.Now.ToShortDateString ());
                }
                msg = "Cliente cadastrado com sucesso";
            } catch (Exception ex) {
                msg = "Erro ao manipular o arquivo: " + ex.Message;
            } finally {
                sw.Close ();
            }
            return msg;
        }

        /// <summary>
        /// Método para cadastrar um cliente.
        /// </summary>
        /// <param name="clientePj">Recebe como parametro as informações do Cliente PJ</param>
        /// <returns>Retorna uma mensagem informando se o cliente foi cadastrado ou não</returns>
        public string Cadatrar (PJ clientePj) {
            string msg = "";
            StreamWriter sw = null;
            FileInfo fi = new FileInfo ("ClientesPJ.csv");

            try {
                if (fi.Length == 0) {
                    sw = new StreamWriter ("ClientesPJ.csv");
                    sw.WriteLine ("ID;CNPJ;RAZAO_SOCIAL;EMAIL;TELEFONE;DATA_CRIACAO;LOGRADOURO;NUMERO;COMPLEMENTO;BAIRRO;CIDADE;UF;DATA_CADASTRO");
                    sw.WriteLine (PJ.Id + ";" + PJ.Cnpj + ";" + PJ.RazaoSocial + ";" + PJ.Email + ";" + PJ.DataCriacao + ";" +
                        PJ.Endereco.Logradouro + ";" + PJ.Endereco.Numero + ";" + PJ.Endereco.Complemento + ";" + PJ.Endereco.Bairro + ";" +
                        PJ.Endereco.Cidade + ";" + PJ.Endereco.Uf + ";" + DateTime.Now.ToShortDateString ());
                } else {
                    sw.WriteLine (PJ.Id + ";" + PJ.Cnpj + ";" + PJ.RazaoSocial + ";" + PJ.Email + ";" + PJ.DataCriacao + ";" +
                        PJ.Endereco.Logradouro + ";" + PJ.Endereco.Numero + ";" + PJ.Endereco.Complemento + ";" + PJ.Endereco.Bairro + ";" +
                        PJ.Endereco.Cidade + ";" + PJ.Endereco.Uf + ";" + DateTime.Now.ToShortDateString ());
                }
                msg = "Cliente cadastrado com sucesso";
            } catch (Exception ex) {
                msg = "Erro ao manipular o arquivo: " + ex.Message;
            } finally {
                sw.Close ();
            }
            return msg;

        }

        /// <summary>
        /// Método Consultar sem parametros
        /// </summary>
        /// <returns>Retorno nulo</returns>
        public string Consultar () {
            return null;
        }

        /// <summary>
        /// Método para Consultar um cliente.
        /// </summary>
        /// <param name="cpf_cnpj">Recebe como parametro um CPF ou CNPJ</param>
        /// <returns>Retorna as informações do cliente, caso ele esteja cadastrado</returns>
        public string Consultar (string cpf_cnpj) {
            StreamReader srClientesPF = new StreamReader ("ClientesPF.csv");
            StreamReader srClientesPJ = new StreamReader ("ClientesPF.csv");
            string[] dadosCliente;
            String txt = "CPF não encontrado";

            if ((cpf_cnpj.Length) <= 11) {
                try {
                    while ((txt = srClientesPF.ReadLine ()) != null) {
                        dadosCliente = txt.Split (';');
                        if (dadosCliente[1] == cpf_cnpj) {
                            break;
                        }
                    }
                } catch (Exception ex) {
                    txt = "Erro ao manipular o arquivo: " + ex.Message;
                } finally {
                    srClientesPF.Close ();
                }
            } else {
                try {
                    while ((txt = srClientesPJ.ReadLine ()) != null) {
                        dadosCliente = txt.Split (';');
                        if (dadosCliente[1] == cpf_cnpj) {
                            break;
                        }
                    }
                } catch (Exception ex) {
                    txt = "Erro ao manipular o arquivo: " + ex.Message;
                } finally {
                    srClientesPJ.Close ();
                }
            }

            return txt;
        }
    }
}