using System;
using Taxes.Entities;

namespace Taxes {
  internal class Program
  {
    static void Main(string[] args)
    {
      List<TaxPayer> list = new List<TaxPayer>();

      System.Console.Write("Enter the number of tax payers:");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        System.Console.WriteLine($"Tax payer #{i} data:");
        System.Console.Write("Individual or company (i/c)? ");
        char ch = char.Parse(Console.ReadLine());
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Anual income: ");
        double income = double.Parse(Console.ReadLine());
        if(ch == 'i')
        {
          System.Console.Write("Health expenditures: ");
          double health = double.Parse(Console.ReadLine());
          list.Add(new PersonTaxPayer(income, name, health));
        } else {
          System.Console.WriteLine("Number of employees: ");
          int qtdEmployees = int.Parse(Console.ReadLine());
          list.Add(new CompanyTaxPayer(income, name, qtdEmployees));
        }
      }
      System.Console.WriteLine();
      System.Console.WriteLine("TAXES PAID:");
      double totalTaxes = 0;
      foreach(TaxPayer payer in list)
      {
        double tax = payer.TaxPaid();
        totalTaxes += tax;
        System.Console.WriteLine($"{payer}");
      }
      
      System.Console.WriteLine($"TOTAL TAXES: $ {totalTaxes}");
  }
}
}