using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public class Vendedor : Funcionario
    {
        public double Comissao { get; set; }
        public List<Vendedor> vendedores { get; set; }
        public Vendedor vendedor { get; set; }

        public Vendedor()
        {
            vendedores = new List<Vendedor>();
        }

        public override void CadastrarFuncionario()
        {
            try
            {
                Console.Write("Nome: ");
                Nome = Console.ReadLine();

                Console.Write("Documento: ");
                Documento = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Houve um problema com o cadastro do vendedor: {ex.Message}");
            }
        }

        public override void ExibeDados()
        {
            foreach (var vendedor in vendedores)
            {
                Console.WriteLine("\n==> Vendedores <==");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Documento: " + Documento);
            }
        }

        public double SalarioMesComComissao()
        {
            double totalVendas = 10000;
            double salario = 1200;
            double comissao = totalVendas * 0.08;

            Console.WriteLine("Comissao + Salario = " + (salario + comissao));

            return salario + comissao;
        }
    }
}
