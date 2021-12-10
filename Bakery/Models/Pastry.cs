namespace PastryOrder.Models
{
  public class Pastry
  {
    public int Amount { get; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int TotalPrice()
    {
      return Amount * 2;
    }
  }
}