using System;

namespace Pensionato
{
  internal class Program
  {
    static void Main(string[] args)
    {
    

      Estudante[] vectEstudantes = new Estudante[10];

      System.Console.Write("Quantos quartos serão alugados? ");
      int qtdQuartos = int.Parse(Console.ReadLine());

      for(int i = 1; i <= qtdQuartos; i++){
        System.Console.WriteLine($"Aluguel #{i}: ");
        System.Console.Write("Nome: ");
        string nome = Console.ReadLine();

        System.Console.Write("Email: ");
        string email = Console.ReadLine();

        System.Console.Write("Quarto: ");
        int quarto = int.Parse(Console.ReadLine());

        vectEstudantes[quarto] = new Estudante(nome, email);

      }

      System.Console.WriteLine("Quartos ocupados:");
      for (int i = 0; i < 10; i++)
      {
        if(vectEstudantes[i] != null){
          System.Console.WriteLine($"{i}: {vectEstudantes[i]}");

        }

      }

    }
  }
}