using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2.Models;

namespace NET2.Controllers;

public class UserController : Controller
{
  public IActionResult Index()
  {

    ViewData["name"] = "John Doe";
    return View();
  }
}