namespace Taxes.Entities
{
  abstract class TaxPayer {
    public double Income { get; set; }
    public string Name { get; set; }

    public TaxPayer(double income, string name)
    {
      Income = income;
      Name = name;
    }
    public abstract double TaxPaid();

    public override string ToString() {
      return $"{Name} $ {TaxPaid().ToString("F2")}";
    }
  }
}