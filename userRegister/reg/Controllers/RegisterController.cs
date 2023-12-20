using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using reg.Models;

namespace reg.Controllers
{
    
    public class RegisterController : Controller
    {
        private readonly AppDbContext db;
        public RegisterController(AppDbContext context){
            this.db = context;
        }


        public IActionResult Index()
        {
           var empl = db.Registers;
            return View(empl);
        }


        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Register register){
            db.Registers.Add(register);
            db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}