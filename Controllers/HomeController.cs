using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StringMod msg = new StringMod()
            {
                Message = "A message is here"
            };
            return View(msg);
        }

        public IActionResult numbers()
        {
            Numbers myNums = new Numbers()
            {
                Nums = new int[] {1, 2, 3, 4, 5}
            };
            return View(myNums);
        }

        public IActionResult user()
        {
            User myUser = new User
            {
                FirstName = "Eddie",
                LastName = "Torres"
            };
            return View(myUser);
        }

        public IActionResult users()
        {
            User myUserOne = new User
            {
                FirstName = "Eddie",
                LastName = "Torres"
            };
            User myUserTwo = new User
            {
                FirstName = "Billy",
                LastName = "Bob"
            };
            User myUserThree = new User
            {
                FirstName = "Jane",
                LastName = "Doe"
            };

            List<User> myUsers = new List<User>
            {
                myUserOne,
                myUserTwo,
                myUserThree
            };
            return View(myUsers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
