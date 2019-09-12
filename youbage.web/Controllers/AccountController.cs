using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace youbage.web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine();
            return View();
        }
    }
}