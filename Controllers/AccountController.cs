using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTest.Models;

namespace MvcTest.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            return View("Index", new Account());
        }

        [HttpPost]
        public IActionResult Save(Account account)
        {
            if (ModelState.IsValid)
            {
                ViewBag.account = account;
                return View("Success");
            } else {
                return View("Index");
            }
        }
    }
}
