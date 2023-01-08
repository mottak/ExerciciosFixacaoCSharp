using System;
using SalarioNoMes.Entities;
using SalarioNoMes.Entities.Enums;

namespace SalarioNoMes
{
  internal class Program
  {
    static void Main(string[] args)
    {
     
      System.Console.Write("Enter department's name: ");
      string departmentName = Console.ReadLine();
      System.Console.Write("Enter worker data: ");
      System.Console.Write("Name: ");
      string workerName = Console.ReadLine();
      System.Console.Write("Level (Junior/MidLevel/Senior): ");
      WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
      System.Console.Write("Base salary: ");
      double workerSalary = double.Parse(Console.ReadLine());

      Department dept = new Department(departmentName);
      Worker worker = new Worker(workerName, workerLevel, workerSalary, dept);

      System.Console.Write("How many contracts to this worker? ");
      int qtdContracts = int.Parse(Console.ReadLine());

      for(int i = 1 ; i <= qtdContracts; i++)
      {
        System.Console.WriteLine($"Enter #{i} contract data:");
        System.Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        System.Console.Write("Value per hour: ");
        double hourValue = double.Parse(Console.ReadLine());
        System.Console.Write("Duration (hours): ");
        int qtdHours = int.Parse(Console.ReadLine());
        HourContract contract = new HourContract(date, hourValue, qtdHours);
        worker.AddContract(contract);
      }

      System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
      string incomeDate = Console.ReadLine();
      string month = incomeDate.Substring(0, 2);
      string year = incomeDate.Substring(3, 4);

      System.Console.WriteLine($"Name: {worker.Name}");
      System.Console.WriteLine($"Department: {worker.Department.Name}");
      System.Console.WriteLine($"Income for {incomeDate}: {worker.Income(int.Parse(year), int.Parse(month))}");
    }



  }
}