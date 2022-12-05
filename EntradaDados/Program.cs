using System;

namespace EntadaDados
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Entre com seu nome completo");
      string fullName = Console.ReadLine();

      Console.WriteLine("Quantos quartos tem na sua casa");
      int rooms = int.Parse(Console.ReadLine());

      Console.WriteLine("Entre com o preço de um produto:");
      string productPrice = Console.ReadLine();

      Console.WriteLine($"Você digitou: {fullName}, {rooms}, {productPrice}");

      Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha):");
      string[] infos = Console.ReadLine().Split(' ');

      string lastName = infos[0];
      int age = int.Parse(infos[1]);
      float height = float.Parse(infos[2]);

      Console.WriteLine($"Você digitou: {lastName}, {age}, {height}");
     
    }
  }
}