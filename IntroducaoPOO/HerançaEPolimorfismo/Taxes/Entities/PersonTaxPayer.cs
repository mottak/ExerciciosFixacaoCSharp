namespace Taxes.Entities
{
  class PersonTaxPayer : TaxPayer
  {
    public double HealthExpenditures { get; set; }
    public PersonTaxPayer(double income, string name, double healthExpenditures) : base(income, name)
    {
      HealthExpenditures = healthExpenditures;
    }
    public override double TaxPaid()
    {
      if(base.Income < 20000){
        return (base.Income * 0.15) - (HealthExpenditures * 0.5);
      }
      return (base.Income * 0.25) - (HealthExpenditures * 0.5);
    }
  }
}