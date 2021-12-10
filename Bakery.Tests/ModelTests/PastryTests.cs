using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryOrder.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      //Arrange
      //Act
      Pastry testOrder = new Pastry(5);
      //Assert
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }
    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Pastry testOrder = new Pastry(amount);
      int result = testOrder.Amount;
      //Assert
      Assert.AreEqual(amount, result);
    }
  }
}