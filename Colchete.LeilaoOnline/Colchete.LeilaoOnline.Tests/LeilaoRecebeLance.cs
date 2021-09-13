using System;
using System.Collections.Generic;
using Colchete.LeilaoOnline.Core;
using System.Text;
using System.Linq;
using Xunit;


namespace Colchete.LeilaoOnline.Tests
{
    public class LeilaoRecebeLance
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
        {
            //Arrange
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            leilao.IniciaPregao();
            leilao.RecebeLance(fulano, 800);

            //Act
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var qdeEsperada = 1;
            var qdeObtida = leilao.Lances.Count();
            Assert.Equal(qdeEsperada, qdeObtida);
        }
        [Theory]
        [InlineData(4, new double[] { 1000, 1200,1400,1300 })]
        [InlineData(2, new double[] {800, 900})]
        public void NaoPertmiteNovosLancesDadoLeilaoFinalizado(
            int qdeEsperada, double[] ofertas)
        {
            //Arrange
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i % 2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else 
                {
                    leilao.RecebeLance(maria, valor);
                }
            }

            leilao.TerminaPregao();

            //Act
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var qdeObtida = leilao.Lances.Count();
            Assert.Equal(qdeEsperada, qdeObtida);
        }
    }
}
