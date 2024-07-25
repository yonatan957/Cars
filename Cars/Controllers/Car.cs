using Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    public class Car : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Model(string year, string name, string color)
        {
            CarModel model = new CarModel()
            {
                name = name ?? "error",
                year = year ?? "error",
                color = color ?? "white"
            };

            return View(model);
        }
    }
}
