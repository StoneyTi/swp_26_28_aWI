using FirstOOP;

namespace KuhTestProjekt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KuhConstructor_IsCalled_SetsValuesCorrect()
        {
            Kuh myKuh = new Kuh("Paula", "Schwarz");
            Assert.That(myKuh.Name, Is.EqualTo("Paula"));
            Assert.That(myKuh.Colour, Is.EqualTo("Schwarz"));
        }
        [Test]

        public void KuhConstructor_EmptyName_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Kuh("", "Schwarz"));
        }
        [Test]
        public void KuhConstructor_EmptyColour_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Kuh("Paula", ""));
        }
    }
}