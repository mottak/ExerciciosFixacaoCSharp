namespace CalculaAreaPerimetroDiagonal
{
  class Retangulo {
    public double largura;
    public double altura;

    public double Area(){
      return this.largura * this.altura;
    }
    public double Perimetro()
    {
      return (this.largura * 2) + (this.altura * 2);
    }
    public double Diagonal()
    {
      
      return Math.Sqrt(Math.Pow(this.largura, 2) + Math.Pow(this.altura, 2));
    }
  }
}