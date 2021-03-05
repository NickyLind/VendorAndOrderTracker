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
  }
}