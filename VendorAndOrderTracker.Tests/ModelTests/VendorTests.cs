using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor ("testname", "testdescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "testName";
      Vendor newVendor = new Vendor(name, "testDescription");
      string result = newVendor.Name;
      Assert.AreEqual(result, name);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      string description = "testDescription";
      Vendor newVendor = new Vendor("testName", description);
      string result = newVendor.Description;
      Assert.AreEqual(result, description);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test Vendor";
      string description = "test Vendor";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "test1";
      string description01 = "test1";
      Vendor newVendor1 = new Vendor(name01, description01);
      string name02 = "test2";
      string description02 = "test2";
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "test1";
      string description01 = "test1";
      Vendor newVendor1 = new Vendor(name01, description01);
      string name02 = "test2";
      string description02 = "test2";
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_PlacesOrderInVendorObject_OrderList()
    {
      string name = "test Order";
      string description = "test Order";
      int price = 15;
      string date = "test Order";
      Order newOrder = new Order(name, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "test1";
      string vendorDescription = "test1";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}