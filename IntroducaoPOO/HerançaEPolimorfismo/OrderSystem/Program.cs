using System;
using System.Globalization;
using OrderSystem.Entities;

namespace OrderSystem
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Product> list = new List<Product>();
      System.Console.WriteLine("Enter the number of products:");
      int qtd = int.Parse(Console.ReadLine());

      for (int i = 1; i <= qtd; i++)
      {
        System.Console.WriteLine($"Product #{i} data: ");
        System.Console.Write("Common, used or imported (c/u/i)? ");
        char ch = char.Parse(Console.ReadLine());
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Price: ");
        int price = int.Parse(Console.ReadLine());

        if (ch == 'u')
        {
          System.Console.Write("Manufacture date (DD/MM/YYYY): ");
          DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
          list.Add(new UsedProduct(name, price, manufactureDate));
        }
        else if (ch == 'i')
        {
          System.Console.Write("Customs fee: ");
          double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          list.Add(new ImportedProduct(name, price, customFee));
        } else {
          list.Add(new Product(name, price));
        }
      }
      System.Console.WriteLine();
      System.Console.WriteLine("PRICE TAGS:");
      foreach (Product product in list)
      {
        System.Console.WriteLine($"{product.PriceTag()}");
      }

    }
  }
}