using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadOrder.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      //Arrange
      //Act
      Bread testOrder = new Bread(5);
      //Assert
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }
    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(amount);
      int result = testOrder.Amount;
      //Assert
      Assert.AreEqual(amount, result);
    }
  }
}