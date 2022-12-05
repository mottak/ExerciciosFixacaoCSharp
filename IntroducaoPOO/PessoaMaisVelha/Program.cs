using System;

namespace PessoaMaisVelha
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Pessoa p1, p2;
      p1 = new Pessoa();
      p2 = new Pessoa();

    System.Console.WriteLine("Informe o nome e idade da primeira pessoa:");
    p1.nome = Console.ReadLine();
    p1.idade = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Informe o nome e idade da segunda pessoa:");
      p2.nome = Console.ReadLine();
      p2.idade = int.Parse(Console.ReadLine());

      if(p1.idade > p2.idade){
        System.Console.WriteLine($"{p1.nome}, a primeira pessoa informada é mais velha");
      } else {
        System.Console.WriteLine($"{p2.nome}, a segunda pessoa informada é mais velha");
      }
    }
  }
}