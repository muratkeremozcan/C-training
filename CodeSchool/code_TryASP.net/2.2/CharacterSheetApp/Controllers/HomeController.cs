using Microsoft.AspNet.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
  public class HomeController : Controller
  {

    public IActionResult Index()
    {
      var model = new CharacterSheetApp.Models.Equipment();
      model.Name = "Shield";
      return View(model);
    }

    public IActionResult Create(string EquipmentName)
    {
      var model = new Equipment();
      model.Name = EquipmentName;
      return View("Index",model);
    }
  } 
}
