using FirstOOP;

namespace CowTestProjekt
{
    public class Tests
    {
        private readonly DateTime _birthdate = new DateTime(2020, 1, 1);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CowConstructor_IsCalled_SetsValuesCorrect()
        {
            Cow myCow = new Cow("Paula", "Schwarz", _birthdate);

            Assert.That(myCow.Name, Is.EqualTo("Paula"));
            Assert.That(myCow.Color, Is.EqualTo("Schwarz"));
            Assert.That(myCow.Birthdate, Is.EqualTo(_birthdate));
        }

        [Test]
        public void CowConstructor_EmptyName_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cow("", "Schwarz", _birthdate));
        }

        [Test]
        public void CowConstructor_EmptyColor_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cow("Paula", "", _birthdate));
        }

        [Test]
        public void MakeSound_Cow_ReturnsMoo()
        {
            Cow myCow = new Cow("Paula", "Schwarz", _birthdate);
            Assert.That(myCow.MakeSound(), Is.EqualTo("Moo"));
        }

        [Test]
        public void MakeSound_Cat_ReturnsMeow()
        {
            Cat myCat = new Cat("Whiskers", "Grau", _birthdate);
            Assert.That(myCat.MakeSound(), Is.EqualTo("Meow"));
        }

        [Test]
        public void Age_BornThreeYearsAgo_ReturnsThree()
        {
            Cow myCow = new Cow("Paula", "Schwarz", DateTime.Today.AddYears(-3));
            Assert.That(myCow.Age, Is.EqualTo(3));
        }
    }
}