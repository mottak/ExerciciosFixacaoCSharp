using System;
using OrdersSystem.Entities;
using OrdersSystem.Entities.Enum;

namespace OrdersSystem

{
  internal class Program
  {
    static void Main(string[] args)
    {
      System.Console.Write("Enter client data: ");

      System.Console.Write("Name: ");
      string name = Console.ReadLine();

      System.Console.Write("Email: ");
      string email = Console.ReadLine();

      System.Console.Write("Birth date (DD/MM/YYYY): ");
      DateTime birthDate = DateTime.Parse(Console.ReadLine());

      Client client = new Client(name, email, birthDate);
      // ----------------------------------------------------------------

      System.Console.Write("Enter order data: ");

      System.Console.Write("How many items to this order? ");
      int orderItems = int.Parse(Console.ReadLine());


      Order order = new Order(DateTime.Now, Status.PendingPayment, client);
      

      for(int i = 1; i <= orderItems; i++)
      {
        System.Console.WriteLine($"Enter #{i} item data:");
        System.Console.WriteLine("Product name: ");
        string productName = Console.ReadLine();

        System.Console.WriteLine("Product price: ");
        double productPrice = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Product product = new Product(productName, productPrice);

        OrderItem orderItem = new OrderItem(quantity, productPrice, product);

        order.AddItem(orderItem);
        
      }
      System.Console.WriteLine("ORDER SUMMARY:");
      System.Console.WriteLine(order);

    }
  }
}