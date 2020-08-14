using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public class Cliente : Pessoa
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }        

        public Cliente()
        {
        }

        public void CadastrarCliente()
        {
            try
            {
                Console.Write("Nome: ");
                Nome = Console.ReadLine();

                Console.Write("Senha: ");
                Senha = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Houve um problema com o cadastro do cliente: {ex.Message}");
            }
        }

        public bool VerificarSenha(string s)
        {
            return s == Senha ? true : false;
        }

        public override void ExibeDados()
        {     
        }
    }
}
