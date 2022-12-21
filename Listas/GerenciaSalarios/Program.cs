using System;
using System.Collections.Generic;

namespace GerenciaSalario
{
  internal class Program
  {
    static void Main(string[] args)
    {


      List<Employee> employeesList = new List<Employee>();

      System.Console.Write("How many employees will be registered? ");
      int funcNumber = int.Parse(Console.ReadLine());

      for (int i = 1; i <= funcNumber; i++)
      {
        System.Console.WriteLine($"Emplyoee #{i}: ");
        System.Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        System.Console.Write("Name: ");
        string name = Console.ReadLine();

        System.Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        employeesList.Add(new Employee(id, name, salary));

      }

      System.Console.Write("Enter the employee id that will have salary increase:");
      int employeeId = int.Parse(Console.ReadLine());
      // busca pelo employee através do Id em toda a lista de employees, logo dentro da variavél employee está contido o employee encontrado - expressão lambda
      Employee employee = employeesList.Find(x => x.Id == employeeId);

      if (employee != null){
        System.Console.Write("Enter the percentage: ");
        double persent = double.Parse(Console.ReadLine());
        employee.IncreaseSalary(persent);
      } else {
        System.Console.WriteLine("This id does not exist!");
      }

      System.Console.WriteLine("Updated list of employees:");
      foreach (Employee obj in employeesList)
      {
        System.Console.WriteLine(obj);
      }

    }
  }
}