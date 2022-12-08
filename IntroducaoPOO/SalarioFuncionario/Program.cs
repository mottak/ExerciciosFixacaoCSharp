using System;

namespace SalarioFuncionario
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Funcionario func;
      func = new Funcionario();
      

      System.Console.WriteLine("Informe o nome, salário bruto e imposto referente ao sálario do funcionario:");
      func.Nome = Console.ReadLine();
      func.SalarioBruto = double.Parse(Console.ReadLine());     
      func.Imposto = double.Parse(Console.ReadLine());

      //double salarioLiq = func.SalarioLiquido();

      System.Console.WriteLine($"Funcionário: {func.Nome}, $ {(func.SalarioLiquido()).ToString("F2")}");

      System.Console.WriteLine("Digite a porcentagem para aumentar o salário:");
      double porcentagem = double.Parse(Console.ReadLine());
      func.AumentarSalario(porcentagem);
      System.Console.WriteLine($"Funcionário: {func.Nome}, $ {(func.SalarioLiquido()).ToString("F2")}");
    }
  }
}