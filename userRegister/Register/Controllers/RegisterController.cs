using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Register.Models;

namespace Register.Controllers
{
    
    public class RegisterController : Controller
    {
        private readonly AppDbContext db;
        public RegisterController(AppDbContext context){
            this.db = context;
        }


        public IActionResult Index()
        {
            empl = db.Registers;
            return View(empl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}