using System.Numerics;

namespace FactorialTestProjekt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Factorial_Calculate_ReturnsCorrectResult()
        {
            Assert.That(Factorial.Calculate(5), Is.EqualTo(new BigInteger(120)));
        }
        [Test]
        public void Factorial_Calculate_ReturnsNullForNegativeInput()
        {
            Assert.That(Factorial.Calculate(-1), Is.Null);
        }
    }
}
