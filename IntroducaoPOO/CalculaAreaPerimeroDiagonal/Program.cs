using System;

namespace CalculaAreaPerimetroDiagonal
{
    internal class Program
        {
        static void Main(string[] args)
    {
      Retangulo retang;
      retang = new Retangulo();
      System.Console.WriteLine("Entre com largura e altura do retângulo");
      retang.altura = double.Parse(Console.ReadLine());
      retang.largura = double.Parse(Console.ReadLine());
      double area = retang.Area();
      double perimetro = retang.Perimetro();
      double diagonal = retang.Diagonal();
      System.Console.WriteLine($"Área {area}\nPERIMETRO: {perimetro}\nDiagonal: {diagonal}");

    }
    

    
    }
}