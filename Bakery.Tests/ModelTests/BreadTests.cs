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
      Bread testOrder = new Bread(5);
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }
  }
}