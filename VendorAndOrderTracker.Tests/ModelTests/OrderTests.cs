using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("pancakes", "pancakes", 15, "march 15");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionOfOrder_String()
    {
      string description = "pineapple";
      Order newOrder = new Order("pancakes", description, 15, "march 15");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "wedding order";
      Order newOrder = new Order(title, "cake", 15, "march 15");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Int()
    {
      int price = 25;
      Order newOrder = new Order("title", "description", price, "date");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOfOrder_String()
    {
      string date = "march 25";
      Order newOrder = new Order("title", "description", 15, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }   
  }
}