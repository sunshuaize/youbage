using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using youbage.Entities;
using youbage.Entities.Entities;
using youbage.Interface;

namespace youbage.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUser _user;

        public AccountController(IUser user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            //查出来了
            user user = _user.Find("3adb9230-a87e-4209-b7e4-4abb874d50e9");


            return View();
        }
    }
}