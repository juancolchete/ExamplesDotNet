using System;
using System.Collections.Generic;
using System.Text;
using Colchete.LeilaoOnline.Core;
using Xunit;

namespace Colchete.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arrange
            var valorNegativo = -100;

            //Assert
            Assert.Throws<ArgumentException>(
                    //Act
                    () => new Lance(null, valorNegativo)
                );
        }
    }
}
