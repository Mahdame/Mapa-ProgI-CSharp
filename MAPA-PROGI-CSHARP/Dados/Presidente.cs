using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public class Presidente : Funcionario
    {
        public List<Presidente> presidentes { get; set; }

        public Presidente()
        {
            presidentes = new List<Presidente>();
            CalculaSalarioAnual(salario);
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
                Console.WriteLine($"Houve um problema com o cadastro do funcionário: {ex.Message}");
            }
        }

        public override void ExibeDados()
        {
            foreach (var linha in presidentes)
            {
                Console.WriteLine("\n==> Presidente <=");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Documento: " + Documento);
            }
        }
    }
}
