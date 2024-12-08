namespace StrategyPattern
{
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayments(double Amount)
        {
            System.Console.WriteLine($"PayPal payment of {Amount} amount is successfully done!");
        }
    }
}