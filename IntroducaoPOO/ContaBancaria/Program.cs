using System;

namespace ContaBancaria
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Conta contaBancaria;

      System.Console.WriteLine("Informe o número da conta:");
      int numConta = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Informe o titular da conta:");
      string nomeTitular = Console.ReadLine();

      System.Console.WriteLine("Haverá deposito inicial? (s/n)");
      string respostaDeposito = Console.ReadLine();

      double valorDepositoInicial;


      if(respostaDeposito == "s") {
        System.Console.WriteLine("Entre o valor de depósito inicial:");
        valorDepositoInicial = double.Parse(Console.ReadLine());
        contaBancaria = new Conta(numConta, nomeTitular, valorDepositoInicial);
      }
      contaBancaria = new Conta(numConta, nomeTitular);

      System.Console.WriteLine($"{contaBancaria}");
      System.Console.WriteLine("");

      System.Console.WriteLine("Entre um valor para depósito:");
       double valor = double.Parse(Console.ReadLine());
      contaBancaria.Deposito(valor);
      System.Console.WriteLine($"{contaBancaria}");
      System.Console.WriteLine("");

      System.Console.WriteLine("Entre um valor para saque:");
      valor = double.Parse(Console.ReadLine());
      contaBancaria.Saque(valor);
      System.Console.WriteLine($"{contaBancaria}");
      System.Console.WriteLine("");

      
    }



  }
}