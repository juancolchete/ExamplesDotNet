using System;
using System.Collections.Generic;
using System.Text;

namespace Colchete.LeilaoOnline.Core
{
    public interface IModalidadeAvaliacao
    {
        Lance Avalia(Leilao leilao);
    }
}
