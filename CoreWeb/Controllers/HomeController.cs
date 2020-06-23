using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWeb.Models;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            TimeModel time = new TimeModel();

            time.Time = DateTime.Now.ToString();
            return View(time);
        }

    }
}
