using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            ViewBag.error = false;
            return View();
        }

        [HttpPost("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.user = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.date = newUser.Date.ToLongDateString();
            if (newUser.Password == verify)
            {
                ViewBag.error = false;
                return View("Index");
            }
            else
            {
                ViewBag.error = true;
                return View("Add");
            }


        }
    }
}
