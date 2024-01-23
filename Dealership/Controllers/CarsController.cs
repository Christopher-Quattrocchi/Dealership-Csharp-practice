using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allNames = Car.GetAll();
      return View(allNames);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [HttpPost("/cars")]
    public ActionResult Create(string name)
    {
      Car myCar = new Car(name);
      return RedirectToAction("Index");
    }
  }
}