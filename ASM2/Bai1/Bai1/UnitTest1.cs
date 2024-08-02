 namespace Bai1
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
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
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            // Arrange
            int num1 = -5;
            int num2 = -10;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 15;
            int num2 = -9;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 0;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_LargePositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 1000000;
            int num2 = 56000000;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(57000000, result);
        }

        [Test]
        public void Add_LargeNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = -1000000;
            int num2 = -5000000;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(-000000, result);
        }

        [Test]
        public void Add_LargeNumbers_Overflow_ReturnsException()
        {
            // Arrange
            int num1 = 214547; // Max value for int
            int num2 = 1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _calculator.Add(num1, num2));
        }

        [Test]
        public void Add_NegativeAndLargePositiveNumber_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = -1000000;
            int num2 = 2147448947; // Max value for int

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(2146483647, result); // 2147483647 - 1000000
        }

        [Test]
        public void Add_TwoLargeNegativeNumbers_Overflow_ReturnsException()
        {
            
            int num1 = -5449847; 
            int num2 = -1;

            
            Assert.Throws<OverflowException>(() => _calculator.Add(num1, num2));
        }
    }
}