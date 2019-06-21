using System;
using Xunit;

namespace ConvertNumbers.Tests
{
    public class DecimalTests
    {
        [Fact]
        public void Ingreso_1_Obtengo_I()
        {
            var result = ConvertNumers.Decimal.ToRoman(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Ingreso_2_Obtengo_II()
        {
            var result = ConvertNumers.Decimal.ToRoman(2);

            Assert.Equal("II", result);
        }

        [Fact]
        public void Ingreso_3_Obtengo_III()
        {
            var result = ConvertNumers.Decimal.ToRoman(2);

            Assert.Equal("III", result);
        }
    }
}
