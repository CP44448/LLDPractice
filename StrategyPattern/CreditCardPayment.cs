namespace StrategyPattern
{
    public class CreditCardPayment: IPaymentProcessor
    {
        public void ProcessPayments(double Amount)
        {
            System.Console.WriteLine($"CreditCard payment of {Amount} amount is successfully done!");
        }
    }
}