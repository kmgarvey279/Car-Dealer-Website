using System;
using System.Collections.Generic;

namespace CarsRUs
{
public class Program
 {
   public static void Main()
  {
     Car porsche= new Car( "2014 Porsche 911",114991, 7864);

     Car ford = new Car("2011 Ford F450", 55995, 14241);

     Car lexus = new Car("2013 Lexus RX 350",44700, 20000);

    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars= new List<Car>() { porsche, ford, lexus, mercedes };

    foreach(Car automobile in Cars)
    {
      Console.WriteLine("The car is a  " + automobile.MakeModel + ", it has " + automobile.Miles + ", the price is $" + automobile.Price + ".");
    }

    Console.WriteLine("What is your maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("What is your desired maximum mileage: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);


    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.CheckMaxPrice(maxPrice)&&(automobile.CheckMaxMiles(maxMiles)))
       {
        CarsMatchingSearch.Add(automobile);
       }
    }
         if (CarsMatchingSearch.Count==0)
           {
            Console.WriteLine("No cars match your criteria.");
           }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }

  }
 }
}
