using System;
using System.Collections.Generic;

namespace CarDealer.Models
{

    public class Car
    {
      private string _MakeModel;
      private int _Price;
      private int _Miles;
      private int _id;
      private static List<Car> _instances = new List<Car>{};

      public Car(string makeModel, int price, int miles)
      {
        _MakeModel = makeModel;
        _Price = price;
        _Miles = miles;
        _instances.Add(this);
        _id = _instances.Count;
      }

      public string GetMakeModel()
      {
          return _MakeModel;
      }

      public int GetPrice()
      {
          return _Price;
      }

      public int GetMiles()
      {
          return _Miles;
      }

      public static List<Car> GetAll()
      {
          return _instances;
      }

      public static void ClearAll()
      {
        _instances.Clear();
      }

      public int GetId()
      {
        return _id;
      }

      public static Car Find(int searchId)
      {
        return _instances[searchId-1];
      }

      public bool CheckMaxPrice(int maxPrice)
      {
        return (_Price < maxPrice);
      }

      public bool CheckMaxMiles(int maxMiles)
      {
        return (_Miles < maxMiles);
      }
    }
}
