using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public abstract class Funcionario : Pessoa
    {
        protected double salario;
        protected int ramal;

        public Funcionario()
        {
        }

        public abstract void CadastrarFuncionario();

        public double CalculaSalarioAnual(double salario)
        {
            return salario * 13;
        }
    }
}
