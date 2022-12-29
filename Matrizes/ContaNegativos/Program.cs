using System;

namespace ContaNegativos
{
  internal class Program
  {
    static void Main(string[] args)
    {

      System.Console.WriteLine("Informe um número inteiro: ");
      int num = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Informe os elementos da matriz: ");
      int[,] matriz = new int [num, num];

      for (int i = 0; i < num; i++) // percorre as linhas
      {
        string[] numbers = Console.ReadLine().Split(' '); // salva a primeira linha em um vetor r separa cada elemento pelo espaço
        for (int j = 0; j < num; j++) // percorre as colunas da linha em questão
        {
          matriz[i, j] = int.Parse(numbers[j]); // as posições do vetor são iguais a posição das colunas da matriz
        }
      }
     
      System.Console.WriteLine("--------------------------------");
      System.Console.WriteLine("Elementos da diagonal principal da matriz: ");
      for (int i = 0; i < num; i++) 
      {
        System.Console.Write(matriz[i, i] + " ");
      }
        System.Console.WriteLine("");

      System.Console.WriteLine("--------------------------------");
      System.Console.WriteLine("Elementos negativos da matriz: ");
      int countNegatives = 0;

      for (int i = 0; i < num; i++) 
      {
        
        for (int j = 0; j < num; j++) 
        {
          if(matriz[i, j] < 0) {
            countNegatives ++;
          }
        }
      }

      System.Console.WriteLine($"Total de números negativos na matriz: {countNegatives}");

    }
  }
}