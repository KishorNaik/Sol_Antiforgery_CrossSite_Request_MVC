using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_AntiForfgery.Models;

namespace Sol_AntiForfgery.Controllers
{
    
    public class DemoController : Controller
    {
      
        [BindProperty]
        public UserModel Users { get; set; }

        [IgnoreAntiforgeryToken]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AutoValidateAntiforgeryToken]
        public IActionResult OnSubmit()
        {
            return View("Index", Users);
        }
    }
}