using MAPA_PROGI_CSHARP.Dados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MAPA_PROGI_CSHARP

    //Autora: Maira Moura Barbosa
    //Matricula: 1906020-5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criando os objetos a serem utilizados
            Presidente presidente = new Presidente();
            Secretaria secretaria = new Secretaria();
            Vendedor vendedor = new Vendedor();
            Cliente cliente;

            //Criando as listas a serem utilizadas
            List<Presidente> presidentes = new List<Presidente>();
            List<Secretaria> secretarias = new List<Secretaria>();
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Cliente> clientes = new List<Cliente>();

            int opcao = 9;

            while (opcao != 0)
            {
                Console.WriteLine("\nDigite a opcao desejada: ");
                Console.WriteLine("1 - Cadastrar presidente");
                Console.WriteLine("2 - Cadastrar secretaria");
                Console.WriteLine("3 - Cadastrar vendedor");
                Console.WriteLine("4 - Cadastrar clientes");
                Console.WriteLine("5 - Cadastrar comissoes dos vendedores");
                Console.WriteLine("6 - Calcular salario");
                Console.WriteLine("7 - Verificar senha");
                Console.WriteLine("8 - Listar pessoas");
                Console.WriteLine("0 - Sair\n");

                var input = Console.ReadLine();
                opcao = Convert.ToInt32(input);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n*** Cadastrar Presidente ***");
                        presidente.CadastrarFuncionario();

                        if (presidente.Nome == "" || presidente.Documento == "")
                        {
                            Console.WriteLine("O cadastro não pode ser vazio.");
                        }
                        else
                        {
                            presidentes.Add(presidente);
                        }

                        break;
                    case 2:
                        Console.WriteLine("\n*** Cadastrar Secretaria ***");
                        secretaria.CadastrarFuncionario();

                        if (secretaria.Nome == "" || secretaria.Documento == "")
                        {
                            Console.WriteLine("O cadastro não pode ser vazio.");
                        }
                        else
                        {
                            secretarias.Add(secretaria);
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n*** Cadastrar Vendedor ***");
                        vendedor.CadastrarFuncionario();

                        if (vendedor.Nome == "" || vendedor.Documento == "")
                        {
                            Console.WriteLine("O cadastro não pode ser vazio.");
                        }
                        else
                        {
                            vendedores.Add(vendedor); ;
                        }

                        break;
                    case 4:
                        Console.WriteLine("\n*** Cadastrar Cliente ***");
                        cliente = new Cliente();
                        cliente.CadastrarCliente();

                        if (cliente.Nome == "" || cliente.Documento == "")
                        {
                            Console.WriteLine("O cadastro não pode ser vazio.");
                        }
                        else
                        {
                            clientes.Add(cliente);
                        }

                        break;
                    case 5:
                        Console.WriteLine("\n*** Comissao dos Vendedores ***");
                        string comissao = Console.ReadLine();
                        vendedor.Comissao = Convert.ToDouble(comissao);
                        Console.WriteLine($"Comissao definida: R$ {comissao}.");

                        break;
                    case 6:
                        Console.WriteLine("\n*** Calcula Salario Anual ***");
                        Console.WriteLine("Escolha o cargo do funcionario: ");
                        Console.WriteLine("1 - Presidente");
                        Console.WriteLine("2 - Secretaria");
                        Console.WriteLine("3 - Vendedor");
                        string input2 = Console.ReadLine();

                        int opcao2 = 9;
                        opcao2 = Convert.ToInt32(input2);
                        string nomeFuncionario;
                        string salario;

                        switch (opcao2)
                        {
                            case 1:
                                Console.Write("Nome: ");
                                nomeFuncionario = Console.ReadLine();

                                //Pesquisa o nome na lista de presidentes
                                var pesquisaPresidente = presidentes.Where(x => x.Nome == nomeFuncionario).FirstOrDefault();

                                if (pesquisaPresidente == null)
                                {
                                    Console.WriteLine("===> ERRO: Nao ha cliente cadastrado com esse nome. <===");
                                    break;
                                }

                                Console.Write("Salario Mensal: ");
                                salario = Console.ReadLine();
                                var anualPres = presidente.CalculaSalarioAnual(Convert.ToDouble(salario));
                                Console.WriteLine($"Salario Anual: R$ " + anualPres.ToString());

                                break;
                            case 2:
                                Console.Write("Nome: ");
                                nomeFuncionario = Console.ReadLine();

                                //Pesquisa o nome na lista de secretarias
                                var pesquisaSecretaria = secretarias.Where(x => x.Nome == nomeFuncionario).FirstOrDefault();

                                if (pesquisaSecretaria == null)
                                {
                                    Console.WriteLine("===> ERRO: Nao ha cliente cadastrado com esse nome. <===");
                                    break;
                                }

                                Console.Write("Salario Mensal: ");
                                salario = Console.ReadLine();
                                var anualSec = presidente.CalculaSalarioAnual(Convert.ToDouble(salario));
                                Console.WriteLine($"Salario Anual: R$ " + anualSec.ToString());

                                break;
                            case 3:
                                Console.Write("Nome: ");
                                nomeFuncionario = Console.ReadLine();

                                //Pesquisa o nome na lista de vendedores
                                var pesquisaVendedor = vendedores.Where(x => x.Nome == nomeFuncionario).FirstOrDefault();

                                if (pesquisaVendedor == null)
                                {
                                    Console.WriteLine("===> ERRO: Nao ha cliente cadastrado com esse nome. <===");
                                    break;
                                }

                                Console.Write("Salario Mensal: ");
                                salario = Console.ReadLine();
                                var anualVend = presidente.CalculaSalarioAnual(Convert.ToDouble(salario));
                                Console.WriteLine($"Salario Anual: R$ " + anualVend.ToString());

                                break;

                            default:
                                Console.WriteLine("Opcao invalida!");
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine("*** Verificar Senha ***");
                        Console.WriteLine($"Verificar se a senha do cliente e 123456, segredo ou teste.\n");
                        Console.Write("Digite o nome do usuario: ");
                        var nome = Console.ReadLine();

                        //Pesquisa o nome na lista de clientes
                        var pesquisaCliente = clientes.Where(x => x.Nome == nome).FirstOrDefault();

                        if (pesquisaCliente == null)
                        {
                            Console.WriteLine("===> ERRO: Nao ha cliente cadastrado com esse nome. <===");
                        }
                        else if (pesquisaCliente.VerificarSenha("123456") || pesquisaCliente.VerificarSenha("segredo") || pesquisaCliente.VerificarSenha("teste"))
                        {
                            Console.WriteLine("A senha corresponde a: " + pesquisaCliente.Senha);
                        }
                        else
                        {
                            Console.WriteLine("A senha nao corresponde.");
                        }

                        break;
                    case 8:
                        Console.WriteLine("\n*** Lista de Pessoas Cadastradas ***");                        

                        if (presidente.Nome == null || secretaria.Nome == null || vendedor.Nome == null)
                        {
                            Console.WriteLine("===> ERRO: Nao ha registros. <==="); ;
                        }

                        presidentes.ForEach(x => Console.WriteLine("\n==> Presidentes <==\n" + "Nome: " + x.Nome + "\n" + "Documento: " + x.Documento + "\n"));
                        presidente.ExibeDados();

                        secretarias.ForEach(y => Console.WriteLine("==> Secretarias <==\n" + "Nome: " + y.Nome + "\n" + "Documento: " + y.Documento + "\n"));
                        secretaria.ExibeDados();

                        vendedores.ForEach(w => Console.WriteLine("==> Vendedores <==\n" + "Nome: " + w.Nome + "\n" + "Documento: " + w.Documento + "\n"));
                        vendedor.ExibeDados();

                        clientes.ForEach(z => Console.WriteLine("==> Clientes <==\n" + "Nome: " + z.Nome + "\n" + "Documento: " + "\n"));

                        break;
                    case 0:
                        Console.WriteLine("Saindo...");

                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");

                        break;
                }
            }
        }
    }
}
