using System;

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
      int freeBread = Amount / 3;
      return Amount * 5 - freeBread * 5;
    }

  }
}