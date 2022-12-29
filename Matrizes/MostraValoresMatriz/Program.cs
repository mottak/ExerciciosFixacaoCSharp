using System;

namespace MostraValoresMatriz
{
  internal class Program
  {
    static void Main(string[] args)
    {

      System.Console.WriteLine("Informe dois números inteiros, que serão as dimenções da matriz: ");
      string[] dimencao = Console.ReadLine().Split(' ');

      int m = int.Parse(dimencao[0]);
      int n = int.Parse(dimencao[1]);

      System.Console.WriteLine("Informe os elementos da matriz: ");
      int[,] matriz = new int[m, n];

      for (int i = 0; i < m; i++)
      {
        string[] numbers = Console.ReadLine().Split(' '); 
        for (int j = 0; j < n; j++) 
        {
          matriz[i, j] = int.Parse(numbers[j]); 
        }
      }
      System.Console.WriteLine("--------------------------------");
      System.Console.WriteLine("Elementos da matriz: ");
      for (int i = 0; i < matriz.GetLength(0); i++)
      {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
          System.Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
      }
      System.Console.WriteLine("--------------------------------");
      System.Console.WriteLine("Informe posição: ");
      string[] position = Console.ReadLine().Split(',');
      int row = int.Parse(position[0]);
      int column = int.Parse(position[1]);
      if (row == 0 && column == 0)
      {
        System.Console.WriteLine($"Direita: {matriz[row, column + 1]}");
        System.Console.WriteLine($"Abaixo: {matriz[row + 1, column]}");
      } else if(row == 0){
        System.Console.WriteLine($"Esquerda: {matriz[row, column -1]}");
        System.Console.WriteLine($"Direita: {matriz[row, column + 1]}");
        System.Console.WriteLine($"Abaixo: {matriz[row + 1, column]}");
      } else if (column == 0)
      {
        System.Console.WriteLine($"Acima: {matriz[row - 1, column]}");
        System.Console.WriteLine($"Direita: {matriz[row, column + 1]}");
        System.Console.WriteLine($"Abaixo: {matriz[row + 1, column]}");
      } else {
        System.Console.WriteLine($"Esquerda: {matriz[row, column - 1]}");
        System.Console.WriteLine($"Direita: {matriz[row, column + 1]}");
        System.Console.WriteLine($"Abaixo: {matriz[row + 1, column]}");
        System.Console.WriteLine($"Acima: {matriz[row - 1, column]}");

      }

    }
  }
}