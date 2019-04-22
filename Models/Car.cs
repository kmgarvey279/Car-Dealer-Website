using System;

namespace CarsRUs
{

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool CheckMaxPrice(int maxPrice)
  {
    return (Price < maxPrice);
  }

  public bool CheckMaxMiles(int maxMiles)
  {
    return (Miles < maxMiles);
  }
}
}
