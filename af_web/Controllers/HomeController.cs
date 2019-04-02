using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using af_web.Models;

namespace af_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Redirect("https://github.com/AirFleetTeam");
            return View();
        }

        [HttpGet("{AF-XLiteEx}")]
        public IActionResult AF_XLiteEx()
        {
            return Redirect("https://github.com/AirFleetTeam/AF-XLiteEx");
        }

        [HttpGet("{SG325}")]
        public IActionResult SG325()
        {
            return Redirect("https://github.com/AirFleetTeam/SG325");
        }
    }
}
