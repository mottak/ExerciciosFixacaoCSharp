using Shapes.Entities;

namespace Shapes.Entities
{

  class Circle : Shape
  {
    public double Radius { get; set; }

    public Circle(Color color, double radius) : base(color)
    {
      Radius = radius;
    }
    public override double Area()
    {
      return 3.14 * Math.Pow(Radius, 2);
    }
  }
}