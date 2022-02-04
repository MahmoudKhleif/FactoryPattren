// See https://aka.ms/new-console-template for more information
using FactoryPattren;
string CardNumber, BankCode, add;
//an application that uses Factory pattren 
// this app is handeling  which bank that customer is using by first 6 digit 
BankFactory BankFactory = new BankFactory();
do
{
    Console.WriteLine("Enter your Card Number : ");
    CardNumber = Console.ReadLine();
    BankCode = CardNumber.Substring(0, 6);
    IBank bank = BankFactory.GetBank(BankCode);
    Console.WriteLine(bank.Withdraw());
    Console.WriteLine("Write 'a' to try again :");
    add = Console.ReadLine();
} while (add == "a");