namespace Taxes.Entities
{
  class CompanyTaxPayer : TaxPayer
  {
    public int EmployeesQuantity { get; set; }
    public CompanyTaxPayer(double income, string name, int employeesQuantity) : base(income, name)
    {
      EmployeesQuantity = employeesQuantity;
    }
    public override double TaxPaid()
    {
      if(EmployeesQuantity > 10)
      {
        return base.Income * 0.14;
      }
      return base.Income * 0.16;
    }
  }
}