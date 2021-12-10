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
      Console.WriteLine("  ___ _                 _    ");
      Console.WriteLine(" | _ (_)___ _ _ _ _ ___( )___");
      Console.WriteLine(" |  _/ / -_) '_| '_/ -_)/(_-<");
      Console.WriteLine(" |_| |_\\___|_| |_| \\___| /__/");
      Console.WriteLine("                             ");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Buy 2 loafs of bread get one free!");
      Console.WriteLine("Get 3 pastries for $5!");
      Console.WriteLine("---------------------------------------");
      Menu();

      // Main Menu
      static void Menu()
      {
        Console.WriteLine("---Options---");
        Console.WriteLine("To Order Bread: order bread");
        Console.WriteLine("To Order Pastries: order pastries");
        Console.WriteLine("To View Order Total: view total");
        Console.WriteLine("---------------------------------------");

        string input = Console.ReadLine();

        if (input == "order bread")
        {
          orderBread();
        }
        else if (input == "order pastries")
        {
          orderPastry();
        }
        else if (input == "view total")
        {
          Console.WriteLine("---------------------------------------");
          Console.WriteLine("Your Current Total is: $" + (pastryOrder.TotalPrice() + breadOrder.TotalPrice()).ToString());
          Console.WriteLine("---------------------------------------");
          orderFinish();
        } 
        else 
        {
          Console.WriteLine("Sorry that was not a valid input.");
          Menu();
        }
      }

      // Order Bread
      static void orderBread()
      {
        Console.WriteLine("How Many total loafs of bread would you like?");
        string amount = Console.ReadLine();
        int intAmount = int.Parse(amount);
        breadOrder.Amount = intAmount;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Ordering " + breadOrder.Amount.ToString() +" Loafs of bread.");
        Console.WriteLine("Bread Order Total: $" + breadOrder.TotalPrice().ToString());
        Console.WriteLine("---------------------------------------");
        breadConfirm();
      }

      static void breadConfirm()
      {
        Console.WriteLine("Is This Correct? type y for yes or n for no");
        string input = Console.ReadLine();
        if (input == "y")
        {
          Menu();
        }
        else if (input == "n")
        {
          orderBread();
        }
        else
        {
          Console.WriteLine("Sorry that was not a vaild input.");
          breadConfirm();
        }
      }

      //order pastry
      static void orderPastry()
      {
        Console.WriteLine("How Many total Pastries would you like?");
        string amount = Console.ReadLine();
        int intAmount = int.Parse(amount);
        pastryOrder.Amount = intAmount;
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Ordering " + pastryOrder.Amount.ToString() +" pastries.");
        Console.WriteLine("Pastry Order Total: $" + pastryOrder.TotalPrice().ToString());
        Console.WriteLine("---------------------------------------");
        pastryConfirm();
      }

      static void pastryConfirm()
      {
        Console.WriteLine("Is This Correct? type y for yes or n for no");
        string input = Console.ReadLine();
        if (input == "y")
        {
          Menu();
        }
        else if (input == "n")
        {
          orderPastry();
        }
        else
        {
          Console.WriteLine("Sorry that was not a vaild input.");
          pastryConfirm();
        }
      }

      // finish order
      static void orderFinish()
      {
        Console.WriteLine("Finish Order? type y for yes or n for no");
        string userInput = Console.ReadLine();
        if (userInput == "n") 
        {
          Menu();
        }
        else if (userInput != "y")
        {
          Console.WriteLine("Sorry that was not a valid input.");
          orderFinish();
        }
      }
    }
  }
}