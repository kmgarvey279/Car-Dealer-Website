using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }

    [HttpGet("/cars/{id}")]
    public ActionResult Show(int id)
    {
      Car car = Car.Find(id);
      return View(car);
    }
    
  }
}
