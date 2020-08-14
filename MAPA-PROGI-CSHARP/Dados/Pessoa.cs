using System;
using System.Collections.Generic;

namespace MAPA_PROGI_CSHARP.Dados
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        public abstract void ExibeDados();
    }
}
