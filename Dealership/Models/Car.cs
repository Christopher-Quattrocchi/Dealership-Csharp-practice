using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car 
    {
      public string Name { get; set ;}
      private static List<Car> _instances = new List<Car> { };

      public Car(string name)
      {
        Name = name;
        _instances.Add(this);
      }

      public static List<Car> GetAll()
      {
        return _instances;
      }

      public static void ClearAll()
      {
        _instances.Clear();
      }
    }
  }

