using System;
using Dominio;
using Repositorio;

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

                        /* case 1:
                            CadastrarCliente();
                            break; */
                        case 2:
                            CadastrarProduto();
                            break;
                       /*  case 3:
                            CadastrarFornecedor();
                            break;
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
        static void CadastrarProduto(){
            
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
            p1.Data   =  utcDate;
            
            System.Console.WriteLine(new GerenciarProduto().Cadastrar(p1)); 


        
        }





            }
        }
   
