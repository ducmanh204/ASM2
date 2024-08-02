namespace B2
{
    public class Calculator
    {
        public int Multiply(int n1, int n2)
        {
            return checked(n1 * n2);  //su dung checked de phat hien so nguen
        }
    }
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int n1 = 5;
            int n2 = 15;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(75, result);
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_ReturnsProduct()
        {
            // Arrange
            int n1 = -5;
            int n2 = -12;

            // Act
            int result = _calculator.Multiply(n1,n2);

            // Assert
            Assert.AreEqual(60, result);
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumber_ReturnsCorrectProduct()
        {
            // Arrange
            int n1 = 5;
            int n2 = -4;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(-20, result);
        }

        [Test]
        public void Multiply_ZeroAndAnyNumber_ReturnsZero()
        {
            // Arrange
            int n1 = 0;
            int n2 = 50;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_TwoZeros_ReturnsZero()
        {
            // Arrange
            int n1 = 0;
            int n2 = 0;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_LargePositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int n1 = 10000;
            int n2 = 20000;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(200000000, result);
        }

        [Test]
        public void Multiply_LargeNegativeNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int n1 = -1000;
            int n2 = -3000;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(3000000, result);
        }

        [Test]
        public void Multiply_LargeNumbers_Overflow_ReturnsException()
        {
            // Arrange
            int n1 = 10000;
            int n2 = 3000;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _calculator.Multiply(n1, n2));
        }

        [Test]
        public void Multiply_NegativeAndLargePositiveNumber_ReturnsCorrectProduct()
        {
            // Arrange
            int n1 = -1000000;
            int n2 = 4000;

            // Act
            int result = _calculator.Multiply(n1, n2);

            // Assert
            Assert.AreEqual(-4000000, result);
        }
    }
}