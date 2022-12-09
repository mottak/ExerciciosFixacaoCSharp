using System;

namespace ConversorMoeda
{
  internal class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Qual a cotação do dolar? ");
      double cotacao = double.Parse(System.Console.ReadLine());
      System.Console.WriteLine("Qual a dolares serão comprados? ");
      double qtdDolar = double.Parse(System.Console.ReadLine());
      

      System.Console.WriteLine($"Valor a ser pago em reais = {ConverteMoeda.ConversaoReal(cotacao, qtdDolar)} ");
    }
  }
}