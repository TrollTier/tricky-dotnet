using System;
using Xunit;

namespace TrickyDotNet
{
    public class WhyArithmetics
    {
        [Fact]
        public void Gimme_Euros_As_Cents()
        {
            var euros = 230.12;
            int cents = (int) euros * 100;

            Assert.Equal(23012, cents); // Seems like the cents get cut :(
        }

        // Has no solution, is just for understanding
        [Fact]
        public void Why_No_Exception()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var value = 2;
                var divisor = 0;

                var result = value / divisor;
            });

            Assert.Throws<DivideByZeroException>(() =>
            {
                var value = 2.0;
                var divisor = 0.0;

                var result = value / divisor;
            }); // :(
        }

        [Fact]
        public void Why_Negative()
        {
            int value1 = 2_000_000_000;
            int value2 = 2_000_000_000;

            var result = value1 + value2;

            Assert.True(result > 0, result.ToString());
        }

        [Fact]
        public void Why_Isnt_This_Bigger()
        {
            float var1 = 0.9f * 100f;
            float var2 = 0.9f * 99.99999999f;

            Assert.True(var1 > var2);
        }
    }
}
