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
      Bread testOrder = new Bread(5, 0, 0);
      //Assert
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }
    [TestMethod]
    public void GetWhiteBread_ReturnsAmountForWhiteBread_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.WhiteBread;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceforAmountOfBread_Int()
    {
      //Arrange
      int amount = 2;
      int totalPrice = 2 * 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void TotalPrice_ReturnsTotalPriceAccountingForBuyTwoGetOneSale_Int()
    {
      //Arrange
      int amount = 4;
      int totalPrice = 4 * 5 - 5;
      //Act
      Bread testOrder = new Bread(amount, 0, 0);
      int result = testOrder.TotalPrice();
      //Assert
      Assert.AreEqual(totalPrice, result);
    }
    [TestMethod]
    public void GetWheatBread_ReturnsAmountForWheatBread_Int()
    {
      //Arrange
      int amount = 5;
      //Act
      Bread testOrder = new Bread(0, amount, 0);
      int result = testOrder.WheatBread;
      //Assert
      Assert.AreEqual(amount, result);
    }
  }
}