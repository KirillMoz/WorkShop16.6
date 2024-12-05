namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustNotNullReturnValue()
        {
            Calculator calc = new Calculator();

            Assert.True(12 == calc.Additional(5, 7));
        }

        [Test]
        public void SubtractionMustNotnullReturnValue()
        {
            Calculator calc = new Calculator();

            Assert.True(6 == calc.Subtraction(10, 4));
        }

        [Test]
        public void MiltiplicationMustNotnullReturnValue()
        {
            Calculator calc = new Calculator();

            Assert.True(24 == calc.Miltiplication(6, 4));
        }

        [Test]
        public void DivisionMustNotnullReturnValue()
        {
            Calculator calc = new Calculator();

            Assert.True(2 == calc.Division(6, 3));
        }
    }
}