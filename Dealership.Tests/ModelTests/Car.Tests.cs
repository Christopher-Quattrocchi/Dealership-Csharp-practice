using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Dealership.Models;
using System;
using System.Data;
using System.ComponentModel;

namespace Dealership.Tests
{
  [TestClass]
  public class UnitTest1 : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }
    
    [TestMethod]
    public void ConstructorCheck_CheckIfConstructorWorks_Bool()
    {
      Car newCar = new Car("honda");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "honda";
      Car newCar = new Car(name);
      string result = newCar.Name;
      Assert.AreEqual(name, result);

    }
    [TestMethod]
    public void SetName_SetsValueOfName_Void()
    {
      string name = "honda";
      Car newCar = new Car(name);
      string updatedName = "Tesla";
      newCar.Name = updatedName;
      string result = newCar.Name;
      Assert.AreEqual(updatedName, result);

    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
      List<Car> newList = new List<Car> { };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);

    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string name1 = "Honda";
      string name2 = "Mercedes";
      Car newName1 = new Car(name1);
      Car newName2 = new Car(name2);
      List<Car> newList = new List<Car> { newName1, newName2 };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}