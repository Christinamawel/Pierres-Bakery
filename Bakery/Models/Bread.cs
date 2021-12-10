namespace BreadOrder.Models
{
  public class Bread
  {
    public int Amount { get; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public int TotalPrice()
    {
      return Amount * 5;
    }

  }
}