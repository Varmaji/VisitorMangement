using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Models
{
    public class githubController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string githubApi()
        {

            return "";
        }
    }
}