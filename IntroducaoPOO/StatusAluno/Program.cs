using System;

namespace StatusAluno
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Aluno aluno;
      aluno = new Aluno();

      System.Console.WriteLine("Informe o nome do aluno, e suas 3 notas:");
      aluno.nome = Console.ReadLine();
      aluno.nota1 = double.Parse(Console.ReadLine());
      aluno.nota2 = double.Parse(Console.ReadLine());
      aluno.nota3 = double.Parse(Console.ReadLine());

      double notaFinal = aluno.NotaFinal();
      System.Console.WriteLine($"NOTA FINAL: {notaFinal}");
      if (notaFinal < 60)
      {
        System.Console.WriteLine($"REPROVADO\nFALTARAM {aluno.NotaRestante()} PONTOS");
      }
      else
      {
        System.Console.WriteLine("APROVADO");
      }
    
    }
  }
}