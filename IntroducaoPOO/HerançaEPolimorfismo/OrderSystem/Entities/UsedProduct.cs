using OrderSystem.Entities;

namespace OrderSystem.Entities
{
  class UsedProduct : Product
  {
    public DateTime ManifactureDate { get; set; }

    public UsedProduct()
    {
    }
    public UsedProduct(string name, double price, DateTime manifactureDate) : base(name, price)
    {
      ManifactureDate = manifactureDate;
    }

    public string PriceTag()
    {
     return $"{base.Name} (used) $ {base.Price} (Manufacture date: {ManifactureDate})";
    }
  }
}