using System;
using Dominio;
using Repositorio;
using Util;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opcao = 0;

                do
                {
                    Console.WriteLine("Digite a opção");
                    Console.WriteLine("1 - Cadastrar Cliente");
                    Console.WriteLine("2 - Cadastrar Produto");
                    Console.WriteLine("3 - Cadastrar Fornecedor");
                    Console.WriteLine("4 - Realizar Pedido");
                    Console.WriteLine("5 - Histórico");
                    Console.WriteLine("9 - Sair");

                    opcao = Int16.Parse(Console.ReadLine());

                    switch (opcao)
                    {

                        case 1:
                            CadastrarCliente();
                            break;
                        case 2:
                            CadastrarProduto();
                            break;
                        case 3:
                            CadastrarFornecedor();
                            break;
                        /*
                         case 4:
                             RealizarPedido();
                             break;
                         case 5:
                             ConsultarHistorico();
                             break; */
                        case 9:
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;

                    }
                }
                while (opcao != 9);

            }
            catch (System.Exception e)
            {
                Console.WriteLine("erro ao tentar ler o arquivo. " + e.Message);
            }

        }

        static void CadastrarProduto()
        {

            Produto p1 = new Produto();

            System.Console.WriteLine("Digite o código do produto: ");
            p1.Cod = Console.ReadLine();

            System.Console.WriteLine("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o preço de compra do produto: ");
            p1.PrecoCompra = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Digite o preço de venda do produto: ");
            p1.PrecoVenda = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Digite a unidade de medidas do produto: ");
            p1.Unidade = Console.ReadLine();

            DateTime utcDate = DateTime.UtcNow;
            p1.Data = utcDate;

            System.Console.WriteLine(new GerenciarProduto().Cadastrar(p1));

            //int id, string razaoSocial, string cnpj, string email, string telefone, DateTime dataCriacao, Endereco endereco
        }
        static void CadastrarFornecedor()
        {

            PJ fornec = new PJ();
            Endereco End = new Endereco();
            System.Console.WriteLine("Digite o código do fornecedor: ");
            fornec.Id = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Digite a razão social: ");

            fornec.RazaoSocial = Console.ReadLine();
            System.Console.WriteLine("Digite o email: ");
            fornec.Email = Console.ReadLine();
            System.Console.WriteLine("Digite o telefone: ");
            fornec.Telefone = Console.ReadLine();
            System.Console.WriteLine("Digite a data de criação da empresa: DD/MM/AAAA");
            fornec.DataCriacao = Convert.ToDateTime(Console.ReadLine());
            DateTime utcDate = DateTime.UtcNow;
            fornec.DataCadastro = utcDate;
            System.Console.WriteLine("Digite o logradouro: ");

                End.Logradouro = Console.ReadLine();
                System.Console.WriteLine("Digite o número: ");
                End.Numero = Console.ReadLine();
                System.Console.WriteLine("Digite o complemento: ");
                End.Complemento = Console.ReadLine();
                System.Console.WriteLine("Digite o Bairro: ");
                End.Bairro = Console.ReadLine();
                System.Console.WriteLine("Digite a Cidade: ");
                End.Cidade = Console.ReadLine();
                System.Console.WriteLine("Digite UF");
                End.Uf = Console.ReadLine();

                fornec.Endereco = End;
            System.Console.WriteLine("Digite a categoria do fornecedor");
            string cat = Console.ReadLine();

            System.Console.WriteLine("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();

            if (!new Validacao().validarCNPJ(cnpj))
            {
                Console.WriteLine("CNPJ inválido");
            }
            else
            {
                fornec.Cnpj = cnpj;
                Fornecedor fornecedor = new Fornecedor(fornec, cat);
                System.Console.WriteLine(new Fornecedor().Cadastrar(fornecedor));


            }
        }

        static void CadastrarCliente()
        {

            Console.WriteLine("1 - Pessoa física\n2 - Pessoa jurídica");
            string i = Console.ReadLine();

            if (i == "1")
            {
                PF cliente = new PF();
                Endereco End = new Endereco();
                System.Console.WriteLine("Digite o código do cliente: ");
                cliente.Id = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine("Digite oNome: ");
                cliente.Nome = Console.ReadLine();
                System.Console.WriteLine("Digite o email: ");
                cliente.Email = Console.ReadLine();
                System.Console.WriteLine("Digite o telefone: ");
                cliente.Telefone = Console.ReadLine();
                System.Console.WriteLine("Digite a data de nascimento DD/MM/AAAA");
                cliente.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                DateTime utcDate = DateTime.UtcNow;
                cliente.DataCadastro = utcDate;
                System.Console.WriteLine("Digite o logradouro: ");

                End.Logradouro = Console.ReadLine();
                System.Console.WriteLine("Digite o número: ");
                End.Numero = Console.ReadLine();
                System.Console.WriteLine("Digite o complemento: ");
                End.Complemento = Console.ReadLine();
                System.Console.WriteLine("Digite o Bairro: ");
                End.Bairro = Console.ReadLine();
                System.Console.WriteLine("Digite a Cidade: ");
                End.Cidade = Console.ReadLine();
                System.Console.WriteLine("Digite UF");
                End.Uf = Console.ReadLine();

                cliente.Endereco = End;

                System.Console.WriteLine("Digite o CPF: ");
                string cpf = Console.ReadLine();

                if (!new Validacao().validarCPF(cpf))
                {
                    Console.WriteLine("CPF inválido");
                }
                else
                {
                    cliente.Cpf = cpf;
                    System.Console.WriteLine(new Cliente().Cadastrar(cliente));
                }
            }
            else
            {

                PJ fornec = new PJ();
                Endereco End = new Endereco();
                System.Console.WriteLine("Digite o código do fornecedor: ");
                fornec.Id = Convert.ToInt16(Console.ReadLine());
                System.Console.WriteLine("Digite a razão social: ");
                fornec.RazaoSocial = Console.ReadLine();
                System.Console.WriteLine("Digite o email: ");
                fornec.Email = Console.ReadLine();
                System.Console.WriteLine("Digite o telefone: ");
                fornec.Telefone = Console.ReadLine();
                System.Console.WriteLine("Digite a data de criação da empresa: DD/MM/AAAA");
                fornec.DataCriacao = Convert.ToDateTime(Console.ReadLine());
                DateTime utcDate = DateTime.UtcNow;
                fornec.DataCadastro = utcDate;
                System.Console.WriteLine("Digite o logradouro: ");

                End.Logradouro = Console.ReadLine();
                System.Console.WriteLine("Digite o número: ");
                End.Numero = Console.ReadLine();
                System.Console.WriteLine("Digite o complemento: ");
                End.Complemento = Console.ReadLine();
                System.Console.WriteLine("Digite o Bairro: ");
                End.Bairro = Console.ReadLine();
                System.Console.WriteLine("Digite a Cidade: ");
                End.Cidade = Console.ReadLine();
                System.Console.WriteLine("Digite UF");
                End.Uf = Console.ReadLine();

                fornec.Endereco = End;

                System.Console.WriteLine("Digite o CNPJ: ");
                string cnpj = Console.ReadLine();

                if (!new Validacao().validarCNPJ(cnpj))
                {
                    Console.WriteLine("CNPJ inválido");
                }
                else
                {
                    fornec.Cnpj = cnpj;
                    System.Console.WriteLine(new Cliente().Cadastrar(fornec));
                }

            }
        }
    }
}


