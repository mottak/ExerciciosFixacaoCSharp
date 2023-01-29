using System;
using AccountBank.Entities;
using AccountBank.Entities.Exception;

namespace AccountBank
{
  internal class Program
  {
    static void Main(string[] args)
    {

      try
      {
        System.Console.WriteLine("Enter account data");
        System.Console.Write("Number: ");
        int accountNumber = int.Parse(System.Console.ReadLine());
        System.Console.Write("Holder: ");
        string holderName = System.Console.ReadLine();
        System.Console.Write("Initial balance: ");
        double balance = double.Parse(System.Console.ReadLine());
        System.Console.Write("Withdraw limit: ");
        double withdrawBalance = double.Parse(System.Console.ReadLine());

        Account account = new Account(accountNumber, holderName, balance, withdrawBalance);

        System.Console.WriteLine();

        System.Console.Write("Enter amount for withdraw: ");
        double withdraw = double.Parse(System.Console.ReadLine());

        account.Withdraw(withdraw);

        System.Console.WriteLine($"{account}");

      }
      catch (DomainException e)
      {
        System.Console.WriteLine("Error: " + e.Message);
      }

    }
  }
}