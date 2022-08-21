using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Library.Models;

namespace Library.Controllers
{
  public class BestSellersController : Controller
  {
    public IActionResult Index()
    {
      var allBestSellers = BestSeller.GetBestSellers(EnvironmentVariables.ApiKey);
      return View(allBestSellers);
    }
  }
}