using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderCalcTests
  {
    [TestMethod]
    public void CostPush_ReturnNoDeal_OrderCalc()
    {
      OrderSetter testOrder = new OrderSetter();
      testOrder.BreadAmount = 2;
      testOrder.PastryAmount = 2;
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(testOrder.BreadCost, 10);
      Assert.AreEqual(testOrder.PastryCost, 4);
    }

    [TestMethod]
    public void CostPush_ReturnDeal_OrderCalc()
    {
      OrderSetter testOrder = new OrderSetter();
      testOrder.BreadAmount = 6;
      testOrder.PastryAmount = 6;
      testOrder.PushOrder("Bread");
      testOrder.PushOrder("Pastry");
      Assert.AreEqual(testOrder.BreadCost, 20);
      Assert.AreEqual(testOrder.PastryCost, 10);
    }
  }
}
