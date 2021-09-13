using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Colchete.LeilaoOnline.Core
{
    public class MaiorValor : IModalidadeAvaliacao
    {
        public Lance Avalia(Leilao leilao)
        {
           return leilao.Lances.DefaultIfEmpty(new Lance(null, 0))
                    .OrderBy(l => l.Valor)
                    .LastOrDefault(); ;
        }
    }
}
