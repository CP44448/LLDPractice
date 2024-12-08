namespace StrategyPattern
{ 
    public class BankTransferPayment: IPaymentProcessor
    {
        public void ProcessPayments(double Amount)
        {
            System.Console.WriteLine($"Bank Transfer of {Amount} amount is successfully done!");
        }
    }
}