using System.Text;
using OrdersSystem.Entities;
using OrdersSystem.Entities.Enum;

namespace OrdersSystem.Entities
{
  class Order
  {
    public DateTime Moment { get; set; }
    public Status OrderStatus { get; set; }
    public Client Client { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Order()
    {
    }
    public Order(DateTime moment, Status status, Client client)
    {
      Moment = moment;
      OrderStatus = status;
      Client = client;
    }

    public void AddItem(OrderItem item){
      OrderItems.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
      OrderItems.Remove(item);
    }

    public double Total()
    {
      double sum = 0;
      foreach(OrderItem item in OrderItems)
      {
        sum += item.SubTotal();
      }
      return sum;
    }

    public override string ToString()
    {
     StringBuilder sb = new StringBuilder();
 
     sb.AppendLine($"Order moment: {Moment.ToString()}");
     sb.AppendLine($"Order status: {OrderStatus}");
     sb.AppendLine($"Client: {Client}");
     sb.AppendLine("Order items:");
     foreach(OrderItem item in OrderItems)
     {
      sb.AppendLine(item.ToString());
     }
     sb.AppendLine($"Total Price: {Total()}");
     return sb.ToString();
    }
  }
}