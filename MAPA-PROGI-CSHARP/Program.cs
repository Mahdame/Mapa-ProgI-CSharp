using MAPA_PROGI_CSHARP.Dados;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MAPA_PROGI_CSHARP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Presidente presidente = new Presidente();
            Secretaria secretaria = new Secretaria();
            Vendedor vendedor = new Vendedor();
            Cliente cliente;
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
                        presidentes.Add(presidente);
                        break;
                    case 2:
                        Console.WriteLine("\n*** Cadastrar Secretaria ***");
                        secretaria.CadastrarFuncionario();
                        secretarias.Add(secretaria);
                        break;
                    case 3:
                        Console.WriteLine("\n*** Cadastrar Vendedor ***");
                        vendedor.CadastrarFuncionario();
                        vendedores.Add(vendedor);
                        break;
                    case 4:
                        Console.WriteLine("\n*** Cadastrar Cliente ***");
                        cliente = new Cliente();
                        cliente.CadastrarCliente();
                        clientes.Add(cliente);
                        break;
                    case 5:
                        Console.WriteLine("\n*** Comissao dos Vendedores ***");
                        string comissao = Console.ReadLine();
                        vendedor.Comissao = Convert.ToDouble(comissao);
                        Console.WriteLine($"Comissao definida: {comissao}.");
                        break;
                    case 6:
                        Console.WriteLine("\n*** Calcula Salario Anual ***");
                        Console.WriteLine($"Calcular Salario Anual de {presidente.Nome = "Asdrubal"}");
                        Console.Write($"Salario: ");
                        string salarioPresidente = Console.ReadLine();
                        var anualPres = presidente.CalculaSalarioAnual(Convert.ToDouble(salarioPresidente));
                        Console.WriteLine($"Salario Anual: " + anualPres.ToString());

                        Console.WriteLine($"Calcular Salario Anual de {secretaria.Nome = "Ana"}");
                        Console.WriteLine($"Salario: ");
                        string salarioSecretaria = Console.ReadLine();
                        var anualSec = secretaria.CalculaSalarioAnual(Convert.ToDouble(salarioSecretaria));
                        Console.WriteLine($"Salario Anual: " + anualSec.ToString());
                        break;
                    case 7:
                        Console.WriteLine("*** Verificar Senha ***");
                        Console.WriteLine($"Verificar se a senha do cliente e 123456, segredo ou teste.\n");
                        Console.Write("Digite o nome do usuario: ");
                        var nome = Console.ReadLine();
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
                        presidente.presidentes = presidentes;
                        presidente.ExibeDados();

                        secretaria.secretarias = secretarias;
                        secretaria.ExibeDados();

                        vendedor.vendedores = vendedores;
                        vendedor.ExibeDados();

                        clientes.ForEach(x => Console.WriteLine("\n==> Clientes <==\n" + "Nome: " + x.Nome));
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
