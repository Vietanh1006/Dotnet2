using Microsoft.AspNetCore.Mvc;
using NET2.Models.Process;

namespace NET2.Controllers;

public class Net2Controller : Controller
{
  StringProcess stringProcess = new StringProcess();

  [HttpGet]
  public IActionResult XuLyChuoi()
  {
    return View();
  }
  [HttpPost]
  public IActionResult XuLyChuoi(string str)
  {
    ViewBag.ThongTin = stringProcess.CapitalizeOneFirstCharacter(str);
    return View();
  }
}
