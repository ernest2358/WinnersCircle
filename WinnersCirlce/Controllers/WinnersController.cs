using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WinnersCirlce.Controllers
{
    public class WinnersController : Controller
    {
        public IActionResult Index()
        {
            //might want to use the home to handle everything -- might not need identity after all
            return View();
        }
    }
}