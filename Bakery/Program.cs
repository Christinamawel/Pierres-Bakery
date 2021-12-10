using System;
using BreadOrder.Models;
using PastryOrder.Models;

namespace UI 
{
  public class Program 
  {
    public static Bread breadOrder = new Bread(0);
    public static Pastry pastryOrder = new Pastry(0);

    static void Main()
    {
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Buy 2 loafs of bread get one free!");
      Console.WriteLine("Get 3 pastries for $5!");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Menu:");
      Console.WriteLine("To Order Bread: order bread");
      Console.WriteLine("To Order Pastries: order pastries");
      Console.WriteLine("To View Order Total: view total");
      
      string input = Console.ReadLine();

      if (input == "order bread")
      {
        Console.WriteLine("How Many total loafs of bread would you like?");
        string amount = Console.ReadLine();
        int intAmount = int.Parse(amount);
        breadOrder.Amount = intAmount;
        Console.WriteLine("Ordering " + breadOrder.Amount.ToString() +" Loafs of bread.");
        Console.WriteLine("Bread Order Total: $" + breadOrder.TotalPrice().ToString());
        Main();
      }
      else if (input == "order pastries")
      {
        Console.WriteLine("How Many total Pastries would you like?");
        string amount = Console.ReadLine();
        int intAmount = int.Parse(amount);
        pastryOrder.Amount = intAmount;
        Console.WriteLine("Ordering " + pastryOrder.Amount.ToString() +" pastries.");
        Console.WriteLine("Pastry Order Total: $" + pastryOrder.TotalPrice().ToString());
        Main();
      }
      else if (input == "view total")
      {
        Console.WriteLine("Your Current Total is: $" + (pastryOrder.TotalPrice() + breadOrder.TotalPrice()).ToString());
        Console.WriteLine("Finish Order? type y for yes or n for no");
        string userInput = Console.ReadLine();
        if (userInput == "n") {
          Main();
        }
      }
    }
  }
}