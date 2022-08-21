using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Library.Models;

namespace Library.Controllers
{
  public class BestSellersController : Controller
  {
    public ActionResult Index()
    {
      List<BestSeller> allBestSellers = BestSeller.GetBestSellers(EnvironmentalVariables.ApiKey);
      return View(allBestSellers);
    }
  }
}