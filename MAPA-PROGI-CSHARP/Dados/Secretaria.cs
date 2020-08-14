using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public class Secretaria : Funcionario
    {
        public List<Secretaria> secretarias;
        public Secretaria secretaria;

        public Secretaria()
        {
            secretarias = new List<Secretaria>();
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
                Console.WriteLine($"Houve um problema com o cadastro do funcionario: {ex.Message}");
            }
        }

        public override void ExibeDados()
        {
            foreach (var secretaria in secretarias)
            {
                Console.WriteLine("\n==> Secretarias <==");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Documento: " + Documento);
            }
        }
    }
}
