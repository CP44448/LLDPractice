using StrategyPattern;

namespace StrategyPatternTest
{
    public class StrategyServiceTest
    {
        [Fact]
        public void CreditCardPayment_ShouldPrintCorrectMessage()
        {
            // Arrange
            var context = new PaymentContext(new CreditCardPayment());
            var expectedMessage = "CreditCard payment of 100 amount is successfully done!";

            // Redirect the console output
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            context.ProcessPayments(100);

            // Assert
            Assert.Contains(expectedMessage, consoleOutput.ToString());
        }

        [Fact]
        public void PayPalPayment_ShouldPrintCorrectMessage()
        {
            // Arrange
            var context = new PaymentContext(new PayPalPayment());
            var expectedMessage = "PayPal payment of 100 amount is successfully done!";

            // Redirect the console output
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            context.ProcessPayments(100);

            // Assert
            Assert.Contains(expectedMessage, consoleOutput.ToString());
        }

        [Fact]
        public void BankTransferPayment_ShouldPrintCorrectMessage()
        {
            // Arrange
            var context = new PaymentContext(new BankTransferPayment());
            var expectedMessage = "Bank Transfer of 100 amount is successfully done!";

            // Redirect the console output
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            context.ProcessPayments(100);

            // Assert
            Assert.Contains(expectedMessage, consoleOutput.ToString());
        }

        [Fact]
        public void Context_ShouldThrowException_WhenStrategyIsNull()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PaymentContext(null!));
        }
    }

}
