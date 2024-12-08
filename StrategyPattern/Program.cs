// See https://aka.ms/new-console-template for more information
using StrategyPattern;

//Credit Card Payment
var creditCardPayment = new PaymentContext(new CreditCardPayment());
creditCardPayment.ProcessPayments(100);

//PayPal Payment
var paypalPayment = new PaymentContext(new PayPalPayment());
paypalPayment.ProcessPayments(200);

//Bank Transfer
var bankTransferPayment = new PaymentContext(new BankTransferPayment());
bankTransferPayment.ProcessPayments(300);
