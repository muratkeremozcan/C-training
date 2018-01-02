using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var model = new Equipment();
      model.Name = "Shield";
      return View(model);
    }
  }
}
