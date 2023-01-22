using OrderSystem.Entities;

namespace OrderSystem.Entities
{
  class ImportedProduct : Product
  {
    public double CustomFee { get; set; }

    public ImportedProduct()
    {
    }
    public ImportedProduct(string name, double price, double customFee) :base(name, price)
    {
      CustomFee = customFee;
    }

    public string PriceTag()
    {
     
      return $"{base.Name} $ {TotalPrice()} (Customs fee: $ {CustomFee.ToString("F2")})";
    }

    public double TotalPrice()
    {
      return base.Price + CustomFee;
    }
  }
}