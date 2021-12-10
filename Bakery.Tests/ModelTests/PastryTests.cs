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
  }
}