using System;

namespace SalarioMedio
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Funcionario func1, func2;
      func1 = new Funcionario();
      func2 = new Funcionario();

      System.Console.WriteLine("Informe o nome e salário da primeira funcionario:");
      func1.nome = Console.ReadLine();
      func1.salario = double.Parse(Console.ReadLine());

      System.Console.WriteLine("Informe o nome e salário da segunda funcionario:");
      func2.nome = Console.ReadLine();
      func2.salario = double.Parse(Console.ReadLine());

     double media = (func1.salario + func2.salario)/2;
      System.Console.WriteLine($"Salario médio: {media.ToString("F2")}");
    }
  }
}