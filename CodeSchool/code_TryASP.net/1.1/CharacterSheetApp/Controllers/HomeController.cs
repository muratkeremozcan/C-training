using Microsoft.AspNet.Mvc;
using System;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      //create the string we want to return to our view
      var name = "Shield";
      //pass the name of the Index view and the string as a parameter
      return View("Index", name);
    }
  }
}
