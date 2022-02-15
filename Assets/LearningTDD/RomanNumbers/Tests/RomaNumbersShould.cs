using NUnit.Framework;

namespace LearningTDD.RomanNumbers.Tests
{
    public class RomaNumbersShould
    {
        /*Write a method String convert(int) that takes a number and converts it to the according String representation.
        Examples
           1 ➔ I
           2 ➔ II
           3 ➔ III
           4 ➔ IV
           5 ➔ V
           9 ➔ IX
          21 ➔ XXI
          50 ➔ L
         100 ➔ C
         500 ➔ D
         */

        private RomanNumber _converter;

        [SetUp]
        public void SetUp()
        {
            _converter = new RomanNumber();
        }

        [Test]
        public void ShouldConvertNumberInRomanString()
        {
            // When
            var result= _converter.Convert(8);
            // Assert
            Assert.IsNotNull("IX", result);
        }
    }

    public enum RomaNumbersMask
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
        IX = 9,
        XXI = 21,
        L = 50,
        C = 100,
        D = 500
    }
}