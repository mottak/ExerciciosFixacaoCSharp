
using System;
using Shapes.Entities;

namespace Shapes
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Shape> list = new List<Shape>();
      System.Console.WriteLine("Enter the number of shapes: ");
      int qtd = int.Parse(Console.ReadLine());

      for (int i = 1; i <= qtd; i++)
      {
        System.Console.WriteLine($"Shape #{i} data: ");
        System.Console.Write("Rectangle or Circle (r/c)? ");
        char ch = char.Parse(Console.ReadLine());
        System.Console.Write("Color (Black/Blue/Red): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        if (ch == 'r')
        {
          System.Console.Write("Width: ");
          double width = double.Parse(Console.ReadLine());
          System.Console.Write("Height: ");
          double height = double.Parse(Console.ReadLine());
          list.Add(new Rectangle(color, width, height));
        } else {
          System.Console.Write("Radius: ");
          double radius = double.Parse(Console.ReadLine());
          list.Add(new Circle(color, radius));
        }
      }
      System.Console.WriteLine();
      System.Console.WriteLine("SHAPE AREAS:");
      foreach (Shape shape in list) {
      {
        System.Console.WriteLine($"{shape.Area()}");
      }
    }
  }
}
}