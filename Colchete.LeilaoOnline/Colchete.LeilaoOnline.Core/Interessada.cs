using System;
using System.Collections.Generic;
using System.Text;

namespace Colchete.LeilaoOnline.Core
{
    public class Interessada
    {
        public string Nome { get; }
        public Leilao Leilao { get; }

        public Interessada(string nome, Leilao leilao)
        {
            Nome = nome;
            Leilao = leilao;
        }
    }
}
