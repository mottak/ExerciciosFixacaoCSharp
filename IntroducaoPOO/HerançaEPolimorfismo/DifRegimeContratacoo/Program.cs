using System;
using System.Globalization;
using DifRegimeContratacao.Entities;

namespace DifRegimeContratacao
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Employee> list = new List<Employee>();
      System.Console.WriteLine("Enter the number of employees: ");
      int employeesNumber = int.Parse(Console.ReadLine());

      for(int i = 1; i <= employeesNumber; i++)
      {
        System.Console.WriteLine($"Employee #{i} data: ");
        System.Console.Write("Outsourced (y/n)? ");
        char ch = char.Parse(Console.ReadLine());
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Value per hour: ");
        double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (ch == 'y')
        {
          System.Console.Write("Addicional charge: ");
          double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          list.Add(new OutSourcedEmployee(name, hours, hourValue, addicionalCharge));
        } else {
          list.Add(new Employee(name, hours, hourValue));
        }
}
        System.Console.WriteLine();
        System.Console.WriteLine("PAYMENTS:");
        foreach (Employee employee in list)
        {
          System.Console.WriteLine($"{employee.Name} - $ {employee.Payment()}");
        }
      
    }
  }
}